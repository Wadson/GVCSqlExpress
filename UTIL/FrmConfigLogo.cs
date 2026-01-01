using GVC.DALL;
using GVC.MODEL;
using Krypton.Toolkit;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static GVC.Utilitario;

namespace GVC.View
{
    public partial class FrmConfigLogo : KryptonForm
    {

        private bool _logoAlterada = false;
        private byte[] _logoBytesNovos = null;  // bytes da nova imagem selecionada
        private int _empresaId = 0;  // Agora começa em 0 (nenhuma selecionada)


        public FrmConfigLogo()
        {
            InitializeComponent();
        }
        private void CarregarComboEmpresas()
        {
            try
            {
                // Você precisa de um método na DAL para listar empresas
                // Crie esse método na EmpresaDal (vou mostrar abaixo)
                var empresas = EmpresaDal.ListarEmpresasSimples();

                cmbEmpresas.DataSource = empresas;
                cmbEmpresas.DisplayMember = "NomeFantasia";  // Ou "RazaoSocial" se preferir
                cmbEmpresas.ValueMember = "EmpresaID";
                cmbEmpresas.SelectedIndex = -1;  // Nenhum selecionado inicialmente

                // Opcional: texto de ajuda
                cmbEmpresas.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao carregar empresas: " + ex.Message);
            }
        }
        private void FrmConfigLogo_Shown(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is KryptonTextBox kryptonTxt)
                    Utilitario.AplicarCorFoco(kryptonTxt);
            }
        }

        private void FrmConfigLogo_Load(object sender, EventArgs e)
        {
            // LINHA TEMPORÁRIA PARA DEBUG
            MessageBox.Show($"EmpresaID recebido: {_empresaId}", "Debug ID");
            btnSalvar.Text = "Alterar";
            //picLogo.Enabled = false;
            //btnSelecionarLogo.Enabled = false;

            CarregarLogo();
        }
        private void CarregarLogo()
        {
            try
            {
                if (_empresaId <= 0)
                {
                    picLogo.Image = Properties.Resources.UsuarioBlue24;
                    return;
                }

                var logoBytes = EmpresaDal.ObterImagem(_empresaId);
                picLogo.Image?.Dispose();

                if (logoBytes != null && logoBytes.Length > 0)
                {
                    using var ms = new MemoryStream(logoBytes);
                    picLogo.Image = Image.FromStream(ms);
                }
                else
                {
                    picLogo.Image = Properties.Resources.UsuarioBlue24;
                }

                picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao carregar logo: " + ex.Message);
                picLogo.Image = Properties.Resources.UsuarioBlue24;
            }
        }
        private void btnSelecionarLogo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Imagens (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logoBytesNovos = File.ReadAllBytes(ofd.FileName);

                    using var ms = new MemoryStream(_logoBytesNovos);
                    picLogo.Image?.Dispose();
                    picLogo.Image = Image.FromStream(ms);

                    picLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    _logoAlterada = true;
                }
                catch (Exception ex)
                {
                    Utilitario.Mensagens.Erro("Erro ao carregar imagem: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (btnSalvar.Text == "Alterar")
            {
                btnSalvar.Text = "Salvar";
                btnSelecionarLogo.Enabled = true;
                return;
            }

            // Modo Salvar
            if (!_logoAlterada || _logoBytesNovos == null || _logoBytesNovos.Length == 0)
            {
                Utilitario.Mensagens.Aviso("Selecione uma nova imagem antes de salvar.");
                return;
            }

            try
            {
                EmpresaDal.AtualizarLogo(_empresaId, _logoBytesNovos);
                Utilitario.Mensagens.Info("Logo atualizada com sucesso!");

                _logoAlterada = false;
                _logoBytesNovos = null;
                ConfigurarEstadoInicial();
            }
            catch (Exception ex)
            {
                Utilitario.Mensagens.Erro("Erro ao salvar logo: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfigurarEstadoInicial()
        {
            bool empresaSelecionada = _empresaId > 0;

            btnSalvar.Text = "Alterar";
            btnSalvar.Enabled = empresaSelecionada;
            btnSelecionarLogo.Enabled = false;
            picLogo.Enabled = empresaSelecionada;
            lblInstrucao.Text = empresaSelecionada ? "Clique em Alterar para mudar a logo" : "Selecione uma empresa acima";
        }
        private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresas.SelectedIndex == -1)
            {
                _empresaId = 0;
                ConfigurarEstadoInicial();
                picLogo.Image?.Dispose();
                picLogo.Image = Properties.Resources.UsuarioBlue24; // padrão
                return;
            }

            _empresaId = Convert.ToInt32(cmbEmpresas.SelectedValue);
            _logoAlterada = false;
            _logoBytesNovos = null;

            CarregarLogo();  // Carrega a logo da empresa selecionada
            ConfigurarEstadoInicial();  // Volta botão para "Alterar"
        }
    }
}
