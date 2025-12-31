using GVC.BLL;
using GVC.MODEL;
using GVC.MUI;
using GVC.UTIL;
using iText.StyledXmlParser.Jsoup.Nodes;
using Krypton.Toolkit;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GVC.UTIL.BrasilApiCepResponse;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GVC.View
{
    public partial class FrmCadEmpresa : KryptonForm
    {
        public bool CarregandoDados { get; set; }
        private readonly EmpresaBll _empresaBll = new EmpresaBll();
        private readonly string QueryMaxId = "SELECT MAX(EmpresaID) FROM Empresa";
        public string StatusOperacao { get; set; } // "NOVO", "ALTERAR", "EXCLUSAO"
        public int EmpresaID { get; set; }
        public int CidadeID { get; set; } // usado internamente na busca de cidade
        private bool bloqueiaPesquisa = false;

        public FrmCadEmpresa()
        {
            InitializeComponent();
            ConfigurarEventosCep();
            ConfigurarMascaras();
        }

        private void ConfigurarMascaras()
        {
            //Configura eventos de máscara diretamente
            txtCnpj.KeyPress += txtCnpj_KeyPress;
            txtCep.KeyPress += txtCep_KeyPress;
            txtTelefone.KeyPress += txtTelefone_KeyPress;

            // Eventos de validação ao sair do campo
            txtCnpj.Leave += txtCnpj_Leave;
            txtCep.Leave += txtCep_Leave;
            txtTelefone.Leave += txtTelefone_Leave;
        }

        private void ConfigurarEventosCep()
        {
            txtCep.AcceptsReturn = false;
            txtCep.Multiline = false;
            toolTip.SetToolTip(txtCep, "Digite o CEP e pressione ENTER para buscar");
        }
        private bool ValidarCNPJ(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14)
                return false;

            // Remove caracteres não numéricos
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            // Verifica se todos os dígitos são iguais
            if (cnpj.All(char.IsDigit) && cnpj.Distinct().Count() == 1)
                return false;

            try
            {
                // Algoritmo de validação do CNPJ
                int[] multiplicadores1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicadores2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                // Primeiro dígito verificador
                int soma = 0;
                for (int i = 0; i < 12; i++)
                    soma += int.Parse(cnpj[i].ToString()) * multiplicadores1[i];

                int resto = soma % 11;
                int digito1 = (resto < 2) ? 0 : 11 - resto;
                if (int.Parse(cnpj[12].ToString()) != digito1)
                    return false;

                // Segundo dígito verificador
                soma = 0;
                for (int i = 0; i < 13; i++)
                    soma += int.Parse(cnpj[i].ToString()) * multiplicadores2[i];

                resto = soma % 11;
                int digito2 = (resto < 2) ? 0 : 11 - resto;
                if (int.Parse(cnpj[13].ToString()) != digito2)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }

        // =============================================
        // BUSCA POR CEP (igual ao cliente, adaptado)
        // =============================================
        private async void btnBuscarEnderecoPorCep_Click(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }

        private async Task BuscarEnderecoPorCep()
        {
            if (!ValidarCepParaBusca())
                return;

            ConfigurarInterfaceBusca(true);
            try
            {
                //txtNomeCidade.TextChanged -= txtNomeCidade_TextChanged;

                var endereco = await ExecutarBuscaCep();
                if (endereco == null) return;

                PreencherCamposEndereco(endereco);
                ProcessarSucessoBusca();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Aviso($"Erro ao buscar CEP: {ex.Message}");
            }
            finally
            {
                ConfigurarInterfaceBusca(false);
                //txtNomeCidade.TextChanged += txtNomeCidade_TextChanged;
            }
        }

        private bool ValidarCepParaBusca()
        {
            string cepDigitado = txtCep.Text?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(cepDigitado) || cepDigitado.Replace("_", "").Replace("-", "").Length == 0)
                return false;

            string cepLimpo = new string(cepDigitado.Where(char.IsDigit).ToArray());
            if (cepLimpo.Length != 8)
            {
                Utilitario.Mensagens.Aviso("CEP inválido. Digite 8 dígitos numéricos.");
                txtCep.Focus();
                txtCep.SelectAll();
                return false;
            }
            return true;
        }

        private void ConfigurarInterfaceBusca(bool emAndamento)
        {
            this.Cursor = emAndamento ? Cursors.WaitCursor : Cursors.Default;
            btnBuscarEnderecoPorCep.Enabled = !emAndamento;
        }

        private async Task<BrasilApiResponse> ExecutarBuscaCep()
        {
            string cepLimpo = new string(txtCep.Text.Where(char.IsDigit).ToArray());
            var endereco = await CepService.BuscarEnderecoPorCepAsync(cepLimpo);
            if (endereco == null || !endereco.EhValido)
            {
                Utilitario.Mensagens.Aviso($"CEP {txtCep.Text} não encontrado.");
                return null;
            }
            return endereco;
        }

        private void PreencherCamposEndereco(BrasilApiResponse endereco)
        {

            // Preenche campos básicos
            txtLogradouro.Text = endereco.Logradouro ?? "";
            txtBairro.Text = endereco.Bairro ?? "";
            txtNomeCidade.Text = endereco.Cidade ?? "";

            string nomeCidade = endereco.Cidade ?? "";
            string query = $"SELECT CidadeID FROM Cidade WHERE Nome = @NomeCidade";
            //string query, string nomeParametro, object parametro
            string cidadeIdStr = Utilitario.PesquisarPorCodigoRetornarNome(query, "NomeCidade", nomeCidade);

            if (int.TryParse(cidadeIdStr, out int cidadeId))
            {
                CidadeID = cidadeId;
            }
            else
            {
                CidadeID = 0; // ou outro valor padrão apropriado
            }

            // Preenche UF com garantia de atualização visual
            txtUF.Text = endereco.SiglaEstado ?? "";
            txtUF.Refresh();
            Application.DoEvents();

            Debug.WriteLine($"✅ UF definido: '{txtUF.Text}'");

            // Formata o CEP para exibição
            txtCep.Text = CepService.FormatarCep(endereco.Cep);
        }

        private void MostrarFeedbackSilencioso()
        {
            Color corOriginal = txtCep.ForeColor;
            txtCep.ForeColor = Color.Green;
            var timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, e) =>
            {
                txtCep.ForeColor = corOriginal;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        private void ProcessarSucessoBusca()
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text))
                txtNumero.Focus();
            else
                txtRazaoSocial.Focus();
        }

        // =============================================
        // CARREGAR DADOS (de uma linha do grid)
        // =============================================
        public void CarregarCampos(DataGridViewRow row)
        {
            if (row == null) return;

            CarregandoDados = true;
            try
            {
                txtEmpresaID.Text = row.Cells["EmpresaID"].Value?.ToString() ?? "";
                EmpresaID = Convert.ToInt32(row.Cells["EmpresaID"].Value);

                txtRazaoSocial.Text = row.Cells["RazaoSocial"].Value?.ToString() ?? "";
                txtNomeFantasia.Text = row.Cells["NomeFantasia"].Value?.ToString() ?? "";

                string cnpj = row.Cells["CNPJ"].Value?.ToString() ?? "";
                txtCnpj.Text = !string.IsNullOrWhiteSpace(cnpj) && cnpj.Length >= 14
                    ? new string(cnpj.Take(14).Where(char.IsDigit).ToArray()) // Pega apenas 14 primeiros dígitos
                    : cnpj;

                txtInscricaoEstadual.Text = row.Cells["InscricaoEstadual"].Value?.ToString() ?? "";
                txtInscricaoMunicipal.Text = row.Cells["InscricaoMunicipal"].Value?.ToString() ?? "";
                txtCnae.Text = row.Cells["CNAE"].Value?.ToString() ?? "";

                txtLogradouro.Text = row.Cells["Logradouro"].Value?.ToString() ?? "";
                txtNumero.Text = row.Cells["Numero"].Value?.ToString() ?? "";
                txtBairro.Text = row.Cells["Bairro"].Value?.ToString() ?? "";

                string cep = row.Cells["Cep"].Value?.ToString() ?? "";
                txtCep.Text = !string.IsNullOrWhiteSpace(cep) && cep.Length >= 8
                    ? $"{new string(cep.Take(8).Where(char.IsDigit).ToArray()).Insert(5, "-")}"
                    : cep;

                txtNomeCidade.Text = row.Cells["Cidade"].Value?.ToString() ?? "";
                txtUF.Text = row.Cells["UF"].Value?.ToString() ?? "";

                string telefone = row.Cells["Telefone"].Value?.ToString() ?? "";
                txtTelefone.Text = !string.IsNullOrWhiteSpace(telefone) && telefone.Length >= 10
                    ? FormatTelefone(telefone)
                    : telefone;

                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtSite.Text = row.Cells["Site"].Value?.ToString() ?? "";
                txtResponsavel.Text = row.Cells["Responsavel"].Value?.ToString() ?? "";
                txtCertificadoDigital.Text = row.Cells["CertificadoDigital"].Value?.ToString() ?? "";

                // Logo
                if (row.Cells["Logo"].Value != DBNull.Value && row.Cells["Logo"].Value is byte[] bytes && bytes.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(bytes))
                        {
                            ptbLogo.Image = Image.FromStream(ms);
                        }
                        txtImagem.Text = "Logo carregada";
                    }
                    catch
                    {
                        ptbLogo.Image = null;
                        txtImagem.Text = "Erro ao carregar imagem";
                    }
                }
                else
                {
                    ptbLogo.Image = null;
                    txtImagem.Text = "Nenhuma imagem";
                }

                // Status (se você tiver um combo)
                // cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString() == "1" ? "Ativo" : "Inativo";
            }
            finally
            {
                CarregandoDados = false;
            }
        }

        private string FormatTelefone(string telefone)
        {
            string apenasNumeros = new string(telefone.Where(char.IsDigit).ToArray());
            if (apenasNumeros.Length == 10)
                return $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 4)}-{apenasNumeros.Substring(6, 4)}";
            else if (apenasNumeros.Length == 11)
                return $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 5)}-{apenasNumeros.Substring(7, 4)}";
            return telefone;
        }

        // =============================================
        // EVENTOS DOS BOTÕES
        // =============================================
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtRazaoSocial.Focus();
        }

        private void GerarNovoCodigo()
        {
            try
            {
                int novoId = Utilitario.ProximoId(QueryMaxId);
                EmpresaID = novoId;
                txtEmpresaID.Text = Utilitario.ZerosEsquerda(novoId, 6);
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro($"Erro ao gerar código: {ex.Message}");
                EmpresaID = 0;
                txtEmpresaID.Text = "000000";
            }
        }

        private void LimparCampos()
        {
            Utilitario.LimparCampos(this);
            ptbLogo.Image?.Dispose();
            ptbLogo.Image = null;
            txtImagem.Text = "";

            // Configura status padrão se existir
            // cmbStatus.SelectedIndex = 0; // Ativo

            GerarNovoCodigo();
        }

        private void SalvarRegistro()
        {
            try
            {
                // Validação básica
                if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtRazaoSocial.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCnpj.Text))
                {
                    Utilitario.Mensagens.Aviso("CNPJ é obrigatório!");
                    txtCnpj.Focus();
                    return;
                }

                var empresa = MontarObjetoEmpresa();
                _empresaBll.Inserir(empresa);
                Utilitario.Mensagens.Aviso("Empresa cadastrada com sucesso!");

                // Atualiza o formulário de manutenção se existir
                AtualizarManutencao();

                // Opção 1: Fechar formulário
                // this.Close();

                // Opção 2: Limpar para novo cadastro
                LimparCampos();
                txtRazaoSocial.Focus();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void AlterarRegistro()
        {
            try
            {
                if (EmpresaID <= 0)
                {
                    Utilitario.Mensagens.Aviso("ID da empresa inválido!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
                {
                    Utilitario.Mensagens.Aviso("Razão Social é obrigatória!");
                    txtRazaoSocial.Focus();
                    return;
                }

                var empresa = MontarObjetoEmpresa();
                empresa.DataAtualizacao = DateTime.Now;
                empresa.UsuarioAtualizacao = FrmLogin.UsuarioConectado;
                _empresaBll.Atualizar(empresa);
                Utilitario.Mensagens.Info("Empresa alterada com sucesso!");

                AtualizarManutencao();
                this.Close();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro(ex.Message);
            }
        }

        private void ExcluirRegistro()
        {
            if (EmpresaID <= 0)
            {
                Utilitario.Mensagens.Aviso("Nenhuma empresa selecionada para exclusão!");
                return;
            }

            if (MessageBox.Show($"Deseja realmente excluir a empresa:\n\n{txtRazaoSocial.Text}?\n\nEsta ação não pode ser desfeita!",
                "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    _empresaBll.Excluir(EmpresaID);
                    Utilitario.Mensagens.Aviso("Empresa excluída com sucesso!");
                    AtualizarManutencao();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro($"Erro ao excluir empresa: {ex.Message}");
                }
            }
        }

        private EmpresaModel MontarObjetoEmpresa()
        {
            var empresa = new EmpresaModel
            {
                EmpresaID = EmpresaID,
                RazaoSocial = txtRazaoSocial.Text?.Trim(),
                NomeFantasia = txtNomeFantasia.Text?.Trim(),
                CNPJ = new string(txtCnpj.Text.Where(char.IsDigit).ToArray()), // Apenas números
                InscricaoEstadual = txtInscricaoEstadual.Text?.Trim(),
                InscricaoMunicipal = txtInscricaoMunicipal.Text?.Trim(),
                CNAE = txtCnae.Text?.Trim(),
                Logradouro = txtLogradouro.Text?.Trim(),
                Numero = txtNumero.Text?.Trim(),
                Bairro = txtBairro.Text?.Trim(),
                Cep = new string(txtCep.Text.Where(char.IsDigit).ToArray()), // Apenas números
                Cidade = txtNomeCidade.Text?.Trim(),
                UF = txtUF.Text?.Trim().ToUpper(),
                Telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray()), // Apenas números
                Email = txtEmail.Text?.Trim(),
                Site = txtSite.Text?.Trim(),
                Responsavel = txtResponsavel.Text?.Trim(),
                CertificadoDigital = txtCertificadoDigital.Text?.Trim(),
                DataCriacao = DateTime.Now,
                DataAtualizacao = null,
                UsuarioCriacao = FrmLogin.UsuarioConectado ?? "Sistema",
                UsuarioAtualizacao = null,
                Logo = ptbLogo.Image != null ? ImageToByteArray(ptbLogo.Image) : null
            };

            if (StatusOperacao == "NOVO")
            {
                empresa.DataCriacao = DateTime.Now;
                empresa.UsuarioCriacao = FrmLogin.UsuarioConectado ?? "Sistema";
            }

            return empresa;
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void AtualizarManutencao()
        {
            try
            {
                var frmManutEmpresa = Application.OpenForms.OfType<FrmManutEmpresa>().FirstOrDefault();
                frmManutEmpresa?.HabilitarTimer(true);
            }
            catch
            {
                // Ignora
            }
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            KryptonTextBox txt = (KryptonTextBox)sender;

            // Aplica a formatação usando seu método utilitário
            string textoFormatado = Utilitario.FormatarCNPJ(txt.Text);

            // Atualiza o texto somente se necessário (evita loop infinito)
            if (txt.Text != textoFormatado)
            {
                int posicao = txt.SelectionStart;
                txt.Text = textoFormatado;

                // Mantém o cursor no final ou na posição correta
                txt.SelectionStart = posicao < txt.Text.Length ? posicao : txt.Text.Length;
            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            string cnpj = new string(txtCnpj.Text.Where(char.IsDigit).ToArray());
            if (cnpj.Length == 14)
            {
                txtCnpj.Text = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

                // Valida CNPJ
                if (!ValidarCNPJ(cnpj))
                {
                    Utilitario.Mensagens.Aviso("CNPJ inválido!");
                    txtCnpj.Focus();
                    txtCnpj.StateCommon.Border.Color1 = Color.Crimson;
                    return;
                }
            }
            else if (!string.IsNullOrWhiteSpace(cnpj))
            {
                Utilitario.Mensagens.Aviso("CNPJ deve conter 14 dígitos!");
                txtCnpj.Focus();
                txtCnpj.StateCommon.Border.Color1 = Color.Crimson;
                return;
            }

            txtCnpj.StateCommon.Border.Color1 = Color.MediumSeaGreen;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string telefone = new string(txtTelefone.Text.Where(char.IsDigit).ToArray());
            if (telefone.Length == 10)
            {
                txtTelefone.Text = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 4)}-{telefone.Substring(6, 4)}";
            }
            else if (telefone.Length == 11)
            {
                txtTelefone.Text = $"({telefone.Substring(0, 2)}) {telefone.Substring(2, 5)}-{telefone.Substring(7, 4)}";
            }
            else if (!string.IsNullOrEmpty(telefone))
            {
                Utilitario.Mensagens.Aviso("Telefone deve conter 10 ou 11 dígitos!");
                txtTelefone.Focus();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            // Auto-formata ao sair do campo
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                string cepLimpo = new string(txtCep.Text.Where(char.IsDigit).ToArray());
                if (cepLimpo.Length == 8)
                {
                    txtCep.Text = $"{cepLimpo.Substring(0, 5)}-{cepLimpo.Substring(5, 3)}";
                }
            }
        }

        private async void btnBuscarEnderecoPorCep_Click_1(object sender, EventArgs e)
        {
            await BuscarEnderecoPorCep();
        }

        private void btnLocalizarLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os arquivos (*.*)|*.*";
                ofd.Title = "Selecionar Logo da Empresa";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ptbLogo.Image?.Dispose(); // Libera imagem anterior
                        ptbLogo.Image = Image.FromFile(ofd.FileName);
                        txtImagem.Text = Path.GetFileName(ofd.FileName);
                        ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        Utilitario.Mensagens.Erro($"Erro ao carregar imagem: {ex.Message}");
                    }
                }
            }
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
            GerarNovoCodigo();
            txtRazaoSocial.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (StatusOperacao == "NOVO")
                SalvarRegistro();
            else if (StatusOperacao == "ALTERAR")
                AlterarRegistro();
            else if (StatusOperacao == "EXCLUSAO")
                ExcluirRegistro(); btnSalvar.Enabled = true;
        }

        private void FrmCadEmpresa_Load(object sender, EventArgs e)
        {
            // ================================
            // 👍 SE MODO NOVO → Gerar código
            // ================================
            if (StatusOperacao == "NOVO")
            {
                GerarNovoCodigo();   // <-- AQUI FUNCIONA!

                var frmManutEmpresa = Application.OpenForms["FrmManutEmpresa"] as FrmManutEmpresa;
                frmManutEmpresa?.HabilitarTimer(true);

                toolStripStatusLabelUsuarioCriacao.Text = FrmLogin.UsuarioConectado;
                ToolStripLabelDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                // Como é novo, não existe atualização ainda:
                toolStripStatusLabelUsuarioAtualizacao.Text = "-";
                ToolStripLabelDataUtimaCompra.Text = "-";
            }
            CarregandoDados = false;
        }

        private void FrmCadEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Limpa memória da imagem
            ptbLogo.Image?.Dispose();
            ptbLogo.Image = null;
        }

        private void FrmCadEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Control && !e.Alt && !e.Shift)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnSalvar_Click(null, null);
                e.Handled = true;
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                btnNovo_Click(null, null);
                e.Handled = true;
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Utilitario.MascaraCNPJ(sender, e);
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            // Permite ENTER para buscar CEP
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnderecoPorCep();
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permite apenas números e backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            KryptonTextBox txt = (KryptonTextBox)sender;
            string textoAtual = txt.Text;
            int posicao = txt.SelectionStart;

            // Remove tudo que não é número
            string apenasNumeros = new string(textoAtual.Where(char.IsDigit).ToArray());

            // Aplica máscara telefone: (00) 00000-0000 ou (00) 0000-0000
            string textoFormatado = "";
            if (apenasNumeros.Length <= 2)
                textoFormatado = $"({apenasNumeros}";
            else if (apenasNumeros.Length <= 6)
                textoFormatado = $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2)}";
            else if (apenasNumeros.Length <= 10)
            {
                textoFormatado = $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 4)}-{apenasNumeros.Substring(6)}";
            }
            else if (apenasNumeros.Length <= 11)
            {
                textoFormatado = $"({apenasNumeros.Substring(0, 2)}) {apenasNumeros.Substring(2, 5)}-{apenasNumeros.Substring(7)}";
            }
            else
            {
                textoFormatado = textoAtual; // Mantém como está se já está completo
            }

            txt.Text = textoFormatado;
            txt.SelectionStart = Math.Min(posicao, textoFormatado.Length);
            e.Handled = true;
        }

        private void FrmCadEmpresa_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void txtCnpj_KeyUp(object sender, KeyEventArgs e)
        {
            Utilitario.MascaraCNPJ(sender, new KeyPressEventArgs((char)Keys.None));
        }
    }
}