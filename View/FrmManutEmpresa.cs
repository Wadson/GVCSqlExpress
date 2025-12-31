using GVC.BLL;
using GVC.DALL;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GVC.View
{
    public partial class FrmManutEmpresa : KryptonForm
    {
        private string StatusOperacao;

        public FrmManutEmpresa(string statusOperacao)
        {
            this.StatusOperacao = statusOperacao;
            InitializeComponent();

            // Personalização do título
            this.Text = "Manutenção de Empresas";            
            this.StateCommon.Header.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            this.StateCommon.Header.Content.ShortText.Color2 = Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 12);
        }
        public void ListarEmpresa()
        {
            EmpresaBll objetoBll = new EmpresaBll();
            dgvEmpresa.DataSource = objetoBll.Listar();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvEmpresa);
        }
        public void HabilitarTimer(bool habilitar)
        {
            timer1.Enabled = habilitar;
        }
        public void PersonalizarDataGridView()
        {
            dgvEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Cabeçalhos bonitos conforme EmpresaModel
            if (dgvEmpresa.Columns["EmpresaID"] != null) dgvEmpresa.Columns["EmpresaID"].HeaderText = "Código";
            if (dgvEmpresa.Columns["RazaoSocial"] != null) dgvEmpresa.Columns["RazaoSocial"].HeaderText = "Razão Social";
            if (dgvEmpresa.Columns["NomeFantasia"] != null) dgvEmpresa.Columns["NomeFantasia"].HeaderText = "Nome Fantasia";
            if (dgvEmpresa.Columns["CNPJ"] != null) dgvEmpresa.Columns["CNPJ"].HeaderText = "CNPJ";
            if (dgvEmpresa.Columns["InscricaoEstadual"] != null) dgvEmpresa.Columns["InscricaoEstadual"].HeaderText = "Inscrição Estadual";
            if (dgvEmpresa.Columns["InscricaoMunicipal"] != null) dgvEmpresa.Columns["InscricaoMunicipal"].HeaderText = "Inscrição Municipal";
            if (dgvEmpresa.Columns["CNAE"] != null) dgvEmpresa.Columns["CNAE"].HeaderText = "CNAE";           
            if (dgvEmpresa.Columns["Logradouro"] != null) dgvEmpresa.Columns["Logradouro"].HeaderText = "Endereço";
            if (dgvEmpresa.Columns["Numero"] != null) dgvEmpresa.Columns["Numero"].HeaderText = "Número";
            if (dgvEmpresa.Columns["Bairro"] != null) dgvEmpresa.Columns["Bairro"].HeaderText = "Bairro";
            if (dgvEmpresa.Columns["Cep"] != null) dgvEmpresa.Columns["Cep"].HeaderText = "CEP";
            if (dgvEmpresa.Columns["Cidade"] != null) dgvEmpresa.Columns["Cidade"].HeaderText = "Cidade";
            if (dgvEmpresa.Columns["UF"] != null) dgvEmpresa.Columns["UF"].HeaderText = "UF";
            if (dgvEmpresa.Columns["Telefone"] != null) dgvEmpresa.Columns["Telefone"].HeaderText = "Telefone";
            if (dgvEmpresa.Columns["Email"] != null) dgvEmpresa.Columns["Email"].HeaderText = "E-mail";
            if (dgvEmpresa.Columns["Site"] != null) dgvEmpresa.Columns["Site"].HeaderText = "Site";
            if (dgvEmpresa.Columns["Responsavel"] != null) dgvEmpresa.Columns["Responsavel"].HeaderText = "Responsável";
            if (dgvEmpresa.Columns["CertificadoDigital"] != null) dgvEmpresa.Columns["CertificadoDigital"].HeaderText = "Certificado Digital";
            if (dgvEmpresa.Columns["DataCriacao"] != null) dgvEmpresa.Columns["DataCriacao"].HeaderText = "Criação";
            if (dgvEmpresa.Columns["DataAtualizacao"] != null) dgvEmpresa.Columns["DataAtualizacao"].HeaderText = "Atualização";
            if (dgvEmpresa.Columns["UsuarioCriacao"] != null) dgvEmpresa.Columns["UsuarioCriacao"].HeaderText = "Usuário Criação";
            if (dgvEmpresa.Columns["UsuarioAtualizacao"] != null) dgvEmpresa.Columns["UsuarioAtualizacao"].HeaderText = "Usuário Atualização";
            if (dgvEmpresa.Columns["Logo"] != null) dgvEmpresa.Columns["Logo"].HeaderText = "Logo";

            // Larguras fixas
            var largurasFixas = new (string nome, int largura)[]
            {
        ("EmpresaID",        80),
        ("RazaoSocial",     250),
        ("NomeFantasia",    200),
        ("CNPJ",            160),
        ("InscricaoEstadual",140),
        ("InscricaoMunicipal",140),
        ("CNAE",            120),       
        ("Logradouro",      250),
        ("Numero",           80),
        ("Bairro",          180),
        ("Cep",              90),
        ("Cidade",          200),
        ("UF",               60),
        ("Telefone",        140),
        ("Email",           240),
        ("Site",            200),
        ("Responsavel",     200),
        ("CertificadoDigital",200),
        ("DataCriacao",     130),
        ("DataAtualizacao", 130),
        ("UsuarioCriacao",  150),
        ("UsuarioAtualizacao",150),
        ("Logo",            100)
            };

            foreach (var (nome, largura) in largurasFixas)
            {
                if (dgvEmpresa.Columns[nome] != null)
                {
                    dgvEmpresa.Columns[nome].Width = largura;
                    dgvEmpresa.Columns[nome].Resizable = DataGridViewTriState.False;
                }
            }

            // Colunas fixas
            if (dgvEmpresa.Columns["EmpresaID"] != null) dgvEmpresa.Columns["EmpresaID"].Frozen = true;
            if (dgvEmpresa.Columns["RazaoSocial"] != null) dgvEmpresa.Columns["RazaoSocial"].Frozen = true;
            if (dgvEmpresa.Columns["CNPJ"] != null) dgvEmpresa.Columns["CNPJ"].Frozen = true;

            // Estilo do cabeçalho
            dgvEmpresa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpresa.ColumnHeadersHeight = 35;
            dgvEmpresa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dgvEmpresa.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvEmpresa.RowHeadersWidth = 28;

            dgvEmpresa.PerformLayout();
        }


        private void CarregaDados(FrmCadEmpresa frmcadEmpresa)
        {
            // Blindagem de estado
            if (string.IsNullOrWhiteSpace(StatusOperacao))
                throw new InvalidOperationException("StatusOperacao não definido.");

            frmcadEmpresa.StatusOperacao = StatusOperacao;

            // MODO NOVO
            if (StatusOperacao == "NOVO")
            {

               frmcadEmpresa.Text = "Novo Empresa";
               frmcadEmpresa.StateCommon.Header.Content.ShortText.Color1 = Color.Green;
               frmcadEmpresa.StateCommon.Header.Content.ShortText.Color2 = Color.White;
               frmcadEmpresa.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                
                frmcadEmpresa.ShowDialog();
                return;
            }

            DataGridViewRow row = dgvEmpresa.CurrentRow;

            if (row == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um empresa na lista!");
                return;
            }

            frmcadEmpresa.CarregandoDados = true;
            frmcadEmpresa.CarregarCampos(row);
            frmcadEmpresa.CarregandoDados = false;

            if (StatusOperacao == "ALTERAR")
            {
                frmcadEmpresa.Text = "Alterar Empresa";
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Color1 = Color.Orange;
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                //frmcadEmpresa.btnSalvar.Text = "Alterar";
                //frmcadEmpresa.btnNovo.Enabled = false;                
            }
            else if (StatusOperacao == "EXCLUSAO")
            {
                frmcadEmpresa.Text = "Excluir Empresa";
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Color1 = Color.Red;
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Color2 = Color.White;
                frmcadEmpresa.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12);
                frmcadEmpresa.btnSalvar.Text = "Excluir";
                frmcadEmpresa.btnNovo.Enabled = false;                

                // 🔒 BLOQUEIO ESPECÍFICO DOS TEXTBOX
                foreach (Control ctrl in frmcadEmpresa.Controls)
                {
                    BloquearTextBoxRecursivo(ctrl);
                }
            }
            frmcadEmpresa.ShowDialog();
        }
        private void BloquearTextBoxRecursivo(Control controle)
        {
            if (controle is TextBox txt)
            {
                txt.ReadOnly = true;
                txt.BackColor = SystemColors.Control;
                return;
            }

            if (controle is Krypton.Toolkit.KryptonTextBox ktxt)
            {
                ktxt.ReadOnly = true;
                ktxt.StateCommon.Back.Color1 = SystemColors.Control;
                return;
            }

            foreach (Control filho in controle.Controls)
            {
                BloquearTextBoxRecursivo(filho);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusOperacao = "NOVO";

            FrmCadEmpresa cad = new FrmCadEmpresa();
            cad.StatusOperacao = StatusOperacao;
            cad.CarregandoDados = false;
            cad.Text = "Nova Empresa";
            cad.ForeColor = Color.FromArgb(8, 142, 254);

            cad.ShowDialog();          
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um empresa na lista!");
                return;
            }

            StatusOperacao = "ALTERAR";

            FrmCadEmpresa cadEmpresa = new FrmCadEmpresa();
            cadEmpresa.EmpresaID = Convert.ToInt32(
                dgvEmpresa.CurrentRow.Cells["EmpresaID"].Value);

            cadEmpresa.StatusOperacao = StatusOperacao;
            CarregaDados(cadEmpresa);           
            
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvEmpresa.CurrentRow == null)
            {
                Utilitario.Mensagens.Aviso("Selecione um empresa na lista!");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este empresa?",
                "Confirmação de Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes)
                return;

            StatusOperacao = "EXCLUSAO";

            FrmCadEmpresa cadEmpresa = new FrmCadEmpresa();
            cadEmpresa.EmpresaID = Convert.ToInt32(
                dgvEmpresa.CurrentRow.Cells["EmpresaID"].Value);

            cadEmpresa.StatusOperacao = StatusOperacao;

            CarregaDados(cadEmpresa);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ListarEmpresa();
            timer1.Enabled = false;
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string texto = txtPesquisa.Text.Trim();

            if (string.IsNullOrEmpty(texto) && !rbtCodigo.Checked)
            {
                ListarEmpresa();
                return;
            }

            var dao = new EmpresaDal();
            DataTable dt = null;

            //if (rbtCodigo.Checked && int.TryParse(texto, out int id))
            //{
            //    dt = dao.PesquisarPorCodigo(id);
            //}
            //else if (rbtDescricao.Checked)
            //{
            //    dt = dao.PesquisarPorNome(texto);
            //}           
            //else
            //{
            //    ListarEmpresa();
            //    return;
            //}

            dgvEmpresa.DataSource = dt ?? new DataTable();
            PersonalizarDataGridView();
            Utilitario.AtualizarTotal(lblTotalRegistros, dgvEmpresa);
        }

        private void FrmManutEmpresa_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false; // 🔴 IMPORTANTE
            ListarEmpresa();           
            dgvEmpresa.CellFormatting += dataGridPesquisar_CellFormatting;
        }

        private void rbtCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }
        private void rbtDescricao_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
            txtPesquisa.Focus();
        }      
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            string columnName = dgvEmpresa.Columns[e.ColumnIndex].Name;
            string raw = e.Value.ToString();

            // Função auxiliar: extrai apenas dígitos
            string Digitos(string s) => new string(s.Where(char.IsDigit).ToArray());

            // Formatar CPF
            if (columnName == "Cpf")
            {
                string cpf = Digitos(raw);
                if (cpf.Length == 11 && ulong.TryParse(cpf, out ulong n11))
                {
                    e.Value = n11.ToString(@"000\.000\.000\-00");
                    e.FormattingApplied = true;
                    return;
                }              
                // Se não tem tamanho padrão, apenas mostra os dígitos
                if (!string.IsNullOrEmpty(cpf))
                {
                    e.Value = cpf;
                    e.FormattingApplied = true;
                    return;
                }
            }
            // Formatar CPF
            if (columnName == "Cnpj")
            {
                string cnpj = Digitos(raw);               
                if (cnpj.Length == 14 && ulong.TryParse(cnpj, out ulong n14))
                {
                    e.Value = n14.ToString(@"00\.000\.000\/0000\-00");
                    e.FormattingApplied = true;
                    return;
                }
                // Se não tem tamanho padrão, apenas mostra os dígitos
                if (!string.IsNullOrEmpty(cnpj))
                {
                    e.Value = cnpj;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Telefone
            if (columnName == "Telefone")
            {
                string tel = Digitos(raw);
                if (tel.Length == 11 && ulong.TryParse(tel, out ulong t11))
                {
                    // (00) 00000-0000
                    string s = t11.ToString("00000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 5)}-{s.Substring(7, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (tel.Length == 10 && ulong.TryParse(tel, out ulong t10))
                {
                    // (00) 0000-0000
                    string s = t10.ToString("0000000000");
                    e.Value = $"({s.Substring(0, 2)}) {s.Substring(2, 4)}-{s.Substring(6, 4)}";
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(tel))
                {
                    e.Value = tel;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar CEP
            if (columnName == "Cep")
            {
                string cep = Digitos(raw);
                if (cep.Length == 8 && ulong.TryParse(cep, out ulong c))
                {
                    e.Value = c.ToString(@"00000\-000");
                    e.FormattingApplied = true;
                    return;
                }
                if (!string.IsNullOrEmpty(cep))
                {
                    e.Value = cep;
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Datas (ex.: DataNascimento, DataCriacao, DataUltimaCompra)
            if ((columnName == "DataNascimento" || columnName == "DataCriacao" || columnName == "DataAtualizacao" || columnName == "DataUltimaCompra") && !string.IsNullOrWhiteSpace(raw))
            {
                if (DateTime.TryParse(raw, out DateTime dt))
                {
                    if (columnName == "DataCriacao")
                        e.Value = dt.ToString("dd/MM/yyyy HH:mm"); // data + hora
                    else
                        e.Value = dt.ToString("dd/MM/yyyy"); // só data
                    e.FormattingApplied = true;
                    return;
                }
            }

            // Formatar Moeda (ex.: ValorTotal, Saldo, LimiteCredito)
            if ((columnName == "ValorTotal" || columnName == "Saldo" || columnName == "LimiteCredito" ||
                 columnName == "Valor" || columnName == "Preco" || columnName == "Total") && !string.IsNullOrWhiteSpace(raw))
            {
                if (e.Value is decimal dec)
                {
                    e.Value = dec.ToString("N2", CultureInfo.CurrentCulture);
                    e.FormattingApplied = true;
                    return;
                }

            }           

        }

    }
}
