namespace GVC.View
{
    partial class FrmMovimentacaoEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            txtFechar = new Krypton.Toolkit.KryptonButton();
            btnSalvarVenda = new Krypton.Toolkit.KryptonButton();
            btnImprimir = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            btnListarControlesDoForm = new Krypton.Toolkit.KryptonButton();
            bnCancelar = new Krypton.Toolkit.KryptonButton();
            btnConfirmar = new Krypton.Toolkit.KryptonButton();
            cmbTipoMovimentacao = new Krypton.Toolkit.KryptonComboBox();
            txtProdutoID = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloProdutoID = new Label();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloTipoMovimentacao = new Label();
            lblRotuloDescricaoProduto = new Label();
            btnBuscarProduto = new Krypton.Toolkit.KryptonButton();
            lblEstoqueAtual = new Label();
            lblRotuloQuantidade = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloObservacoes = new Label();
            cmbOrigem = new Krypton.Toolkit.KryptonComboBox();
            grpProduto = new GroupBox();
            lblRotuloEstoque = new Label();
            grpMovimentacao = new GroupBox();
            lblRotuloOrigem = new Label();
            numQuantidade = new Krypton.Toolkit.KryptonNumericUpDown();
            grpObs = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).BeginInit();
            grpProduto.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpObs.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPalette1
            // 
            kryptonPalette1.ButtonSpecs.FormClose.Image = Properties.Resources.Exit;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImagePressed = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormClose.ImageStates.ImageTracking = Properties.Resources.Sairr;
            kryptonPalette1.ButtonSpecs.FormMax.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormMin.Image = Properties.Resources.Minimize;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.Minimizar24;
            kryptonPalette1.ButtonSpecs.FormRestore.Image = Properties.Resources.Maximize;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.Minimiza24;
            kryptonPalette1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.Maximize;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12F;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            // 
            // txtFechar
            // 
            txtFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFechar.CornerRoundingRadius = 6F;
            txtFechar.Location = new Point(1260, -63);
            txtFechar.Name = "txtFechar";
            txtFechar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.OverrideDefault.Back.ColorAngle = 45F;
            txtFechar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.OverrideDefault.Border.ColorAngle = 45F;
            txtFechar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.OverrideDefault.Border.Rounding = 20F;
            txtFechar.OverrideDefault.Border.Width = 1;
            txtFechar.Size = new Size(150, 30);
            txtFechar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            txtFechar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.StateCommon.Back.ColorAngle = 45F;
            txtFechar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.StateCommon.Border.Rounding = 6F;
            txtFechar.StateCommon.Border.Width = 1;
            txtFechar.StateCommon.Content.ShortText.Color1 = Color.White;
            txtFechar.StateCommon.Content.ShortText.Color2 = Color.White;
            txtFechar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            txtFechar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            txtFechar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            txtFechar.StatePressed.Back.ColorAngle = 135F;
            txtFechar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            txtFechar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            txtFechar.StatePressed.Border.ColorAngle = 135F;
            txtFechar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StatePressed.Border.Rounding = 20F;
            txtFechar.StatePressed.Border.Width = 1;
            txtFechar.StatePressed.Content.ShortText.Color1 = Color.Black;
            txtFechar.StatePressed.Content.ShortText.Color2 = Color.Black;
            txtFechar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            txtFechar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            txtFechar.StateTracking.Back.ColorAngle = 45F;
            txtFechar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            txtFechar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtFechar.StateTracking.Border.ColorAngle = 45F;
            txtFechar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtFechar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtFechar.StateTracking.Border.Rounding = 20F;
            txtFechar.StateTracking.Border.Width = 1;
            txtFechar.StateTracking.Content.ShortText.Color1 = Color.Black;
            txtFechar.StateTracking.Content.ShortText.Color2 = Color.Black;
            txtFechar.TabIndex = 1041;
            txtFechar.TabStop = false;
            txtFechar.Values.Text = "Fechar";
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarVenda.CornerRoundingRadius = 6F;
            btnSalvarVenda.Location = new Point(786, -63);
            btnSalvarVenda.Name = "btnSalvarVenda";
            btnSalvarVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnSalvarVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.OverrideDefault.Border.Rounding = 20F;
            btnSalvarVenda.OverrideDefault.Border.Width = 1;
            btnSalvarVenda.Size = new Size(150, 30);
            btnSalvarVenda.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateCommon.Back.ColorAngle = 45F;
            btnSalvarVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateCommon.Border.Rounding = 6F;
            btnSalvarVenda.StateCommon.Border.Width = 1;
            btnSalvarVenda.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSalvarVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnSalvarVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StatePressed.Back.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSalvarVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSalvarVenda.StatePressed.Border.ColorAngle = 135F;
            btnSalvarVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StatePressed.Border.Rounding = 20F;
            btnSalvarVenda.StatePressed.Border.Width = 1;
            btnSalvarVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnSalvarVenda.StateTracking.Back.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSalvarVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSalvarVenda.StateTracking.Border.ColorAngle = 45F;
            btnSalvarVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSalvarVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSalvarVenda.StateTracking.Border.Rounding = 20F;
            btnSalvarVenda.StateTracking.Border.Width = 1;
            btnSalvarVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnSalvarVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnSalvarVenda.TabIndex = 1016;
            btnSalvarVenda.TabStop = false;
            btnSalvarVenda.Values.Text = "Salvar Venda";
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.CornerRoundingRadius = 6F;
            btnImprimir.Location = new Point(625, -63);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Back.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.OverrideDefault.Border.ColorAngle = 45F;
            btnImprimir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.OverrideDefault.Border.Rounding = 20F;
            btnImprimir.OverrideDefault.Border.Width = 1;
            btnImprimir.Size = new Size(150, 30);
            btnImprimir.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnImprimir.StateCommon.Back.ColorAngle = 45F;
            btnImprimir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateCommon.Border.Rounding = 6F;
            btnImprimir.StateCommon.Border.Width = 1;
            btnImprimir.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnImprimir.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StatePressed.Back.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnImprimir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnImprimir.StatePressed.Border.ColorAngle = 135F;
            btnImprimir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StatePressed.Border.Rounding = 20F;
            btnImprimir.StatePressed.Border.Width = 1;
            btnImprimir.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnImprimir.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnImprimir.StateTracking.Back.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnImprimir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnImprimir.StateTracking.Border.ColorAngle = 45F;
            btnImprimir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnImprimir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnImprimir.StateTracking.Border.Rounding = 20F;
            btnImprimir.StateTracking.Border.Width = 1;
            btnImprimir.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnImprimir.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnImprimir.TabIndex = 1020;
            btnImprimir.TabStop = false;
            btnImprimir.Values.Text = "Imprimir Cupom";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(947, -63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.OverrideDefault.Border.Rounding = 20F;
            btnCancelar.OverrideDefault.Border.Width = 1;
            btnCancelar.Size = new Size(150, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 6F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelar.TabIndex = 1019;
            btnCancelar.TabStop = false;
            btnCancelar.Values.Text = "Cancelar";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(btnListarControlesDoForm);
            kryptonPanel2.Controls.Add(bnCancelar);
            kryptonPanel2.Controls.Add(txtFechar);
            kryptonPanel2.Controls.Add(btnSalvarVenda);
            kryptonPanel2.Controls.Add(btnImprimir);
            kryptonPanel2.Controls.Add(btnConfirmar);
            kryptonPanel2.Controls.Add(btnCancelar);
            kryptonPanel2.Dock = DockStyle.Bottom;
            kryptonPanel2.Location = new Point(0, 347);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(634, 34);
            kryptonPanel2.TabIndex = 1043;
            // 
            // btnListarControlesDoForm
            // 
            btnListarControlesDoForm.CornerRoundingRadius = 6F;
            btnListarControlesDoForm.Location = new Point(4, 1);
            btnListarControlesDoForm.Margin = new Padding(4, 3, 4, 3);
            btnListarControlesDoForm.Name = "btnListarControlesDoForm";
            btnListarControlesDoForm.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.OverrideDefault.Back.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.OverrideDefault.Border.ColorAngle = 45F;
            btnListarControlesDoForm.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.OverrideDefault.Border.Rounding = 20F;
            btnListarControlesDoForm.OverrideDefault.Border.Width = 1;
            btnListarControlesDoForm.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnListarControlesDoForm.Size = new Size(120, 30);
            btnListarControlesDoForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnListarControlesDoForm.StateCommon.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateCommon.Border.Rounding = 6F;
            btnListarControlesDoForm.StateCommon.Border.Width = 1;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateCommon.Content.ShortText.Color2 = Color.White;
            btnListarControlesDoForm.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListarControlesDoForm.StatePressed.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StatePressed.Back.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnListarControlesDoForm.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnListarControlesDoForm.StatePressed.Border.ColorAngle = 135F;
            btnListarControlesDoForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StatePressed.Border.Rounding = 20F;
            btnListarControlesDoForm.StatePressed.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Back.Color1 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.Color2 = Color.Red;
            btnListarControlesDoForm.StateTracking.Back.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControlesDoForm.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControlesDoForm.StateTracking.Border.ColorAngle = 45F;
            btnListarControlesDoForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControlesDoForm.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControlesDoForm.StateTracking.Border.Rounding = 20F;
            btnListarControlesDoForm.StateTracking.Border.Width = 1;
            btnListarControlesDoForm.StateTracking.Content.ShortText.Color1 = Color.White;
            btnListarControlesDoForm.TabIndex = 1089;
            btnListarControlesDoForm.TabStop = false;
            btnListarControlesDoForm.Values.Text = "Listar Controles";
            btnListarControlesDoForm.Click += btnListarControlesDoForm_Click;
            // 
            // bnCancelar
            // 
            bnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bnCancelar.CornerRoundingRadius = 6F;
            bnCancelar.Location = new Point(478, 2);
            bnCancelar.Name = "bnCancelar";
            bnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.OverrideDefault.Back.ColorAngle = 45F;
            bnCancelar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.OverrideDefault.Border.ColorAngle = 45F;
            bnCancelar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.OverrideDefault.Border.Rounding = 20F;
            bnCancelar.OverrideDefault.Border.Width = 1;
            bnCancelar.Size = new Size(150, 30);
            bnCancelar.StateCommon.Back.Color1 = Color.Red;
            bnCancelar.StateCommon.Back.Color2 = Color.Red;
            bnCancelar.StateCommon.Back.ColorAngle = 45F;
            bnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.StateCommon.Border.Rounding = 6F;
            bnCancelar.StateCommon.Border.Width = 1;
            bnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            bnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            bnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            bnCancelar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnCancelar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnCancelar.StatePressed.Back.ColorAngle = 135F;
            bnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            bnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            bnCancelar.StatePressed.Border.ColorAngle = 135F;
            bnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StatePressed.Border.Rounding = 20F;
            bnCancelar.StatePressed.Border.Width = 1;
            bnCancelar.StatePressed.Content.ShortText.Color1 = Color.Black;
            bnCancelar.StatePressed.Content.ShortText.Color2 = Color.Black;
            bnCancelar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            bnCancelar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            bnCancelar.StateTracking.Back.ColorAngle = 45F;
            bnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            bnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            bnCancelar.StateTracking.Border.ColorAngle = 45F;
            bnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            bnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            bnCancelar.StateTracking.Border.Rounding = 20F;
            bnCancelar.StateTracking.Border.Width = 1;
            bnCancelar.StateTracking.Content.ShortText.Color1 = Color.Black;
            bnCancelar.StateTracking.Content.ShortText.Color2 = Color.Black;
            bnCancelar.TabIndex = 1085;
            bnCancelar.TabStop = false;
            bnCancelar.Values.Text = "Cancelar";
            bnCancelar.Click += bnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.CornerRoundingRadius = 6F;
            btnConfirmar.Location = new Point(322, 2);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Back.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.OverrideDefault.Border.ColorAngle = 45F;
            btnConfirmar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.OverrideDefault.Border.Rounding = 20F;
            btnConfirmar.OverrideDefault.Border.Width = 1;
            btnConfirmar.Size = new Size(150, 30);
            btnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateCommon.Back.ColorAngle = 45F;
            btnConfirmar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateCommon.Border.Rounding = 6F;
            btnConfirmar.StateCommon.Border.Width = 1;
            btnConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnConfirmar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnConfirmar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StatePressed.Back.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnConfirmar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnConfirmar.StatePressed.Border.ColorAngle = 135F;
            btnConfirmar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StatePressed.Border.Rounding = 20F;
            btnConfirmar.StatePressed.Border.Width = 1;
            btnConfirmar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnConfirmar.StateTracking.Back.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnConfirmar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnConfirmar.StateTracking.Border.ColorAngle = 45F;
            btnConfirmar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConfirmar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnConfirmar.StateTracking.Border.Rounding = 20F;
            btnConfirmar.StateTracking.Border.Width = 1;
            btnConfirmar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnConfirmar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnConfirmar.TabIndex = 1044;
            btnConfirmar.TabStop = false;
            btnConfirmar.Values.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cmbTipoMovimentacao
            // 
            cmbTipoMovimentacao.CornerRoundingRadius = 6F;
            cmbTipoMovimentacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMovimentacao.DropDownWidth = 115;
            cmbTipoMovimentacao.IntegralHeight = false;
            cmbTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saída", "Ajuste" });
            cmbTipoMovimentacao.Location = new Point(6, 52);
            cmbTipoMovimentacao.Name = "cmbTipoMovimentacao";
            cmbTipoMovimentacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbTipoMovimentacao.Size = new Size(180, 25);
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbTipoMovimentacao.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbTipoMovimentacao.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTipoMovimentacao.TabIndex = 1066;
            cmbTipoMovimentacao.TabStop = false;
            // 
            // txtProdutoID
            // 
            txtProdutoID.Location = new Point(9, 56);
            txtProdutoID.Name = "txtProdutoID";
            txtProdutoID.ReadOnly = true;
            txtProdutoID.Size = new Size(73, 24);
            txtProdutoID.StateCommon.Back.Color1 = Color.White;
            txtProdutoID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtProdutoID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtProdutoID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtProdutoID.StateCommon.Border.Rounding = 8F;
            txtProdutoID.StateCommon.Border.Width = 1;
            txtProdutoID.StateCommon.Content.Color1 = Color.Gray;
            txtProdutoID.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtProdutoID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtProdutoID.TabIndex = 1061;
            txtProdutoID.TabStop = false;
            txtProdutoID.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRotuloProdutoID
            // 
            lblRotuloProdutoID.AutoSize = true;
            lblRotuloProdutoID.BackColor = Color.Transparent;
            lblRotuloProdutoID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRotuloProdutoID.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloProdutoID.Location = new Point(9, 37);
            lblRotuloProdutoID.Name = "lblRotuloProdutoID";
            lblRotuloProdutoID.Size = new Size(57, 16);
            lblRotuloProdutoID.TabIndex = 1059;
            lblRotuloProdutoID.Text = "Código";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.Location = new Point(89, 56);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Size = new Size(404, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 8F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.TabIndex = 1044;
            // 
            // lblRotuloTipoMovimentacao
            // 
            lblRotuloTipoMovimentacao.AutoSize = true;
            lblRotuloTipoMovimentacao.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloTipoMovimentacao.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloTipoMovimentacao.Location = new Point(9, 30);
            lblRotuloTipoMovimentacao.Name = "lblRotuloTipoMovimentacao";
            lblRotuloTipoMovimentacao.Size = new Size(127, 16);
            lblRotuloTipoMovimentacao.TabIndex = 1065;
            lblRotuloTipoMovimentacao.Text = "Tipo movimentação";
            // 
            // lblRotuloDescricaoProduto
            // 
            lblRotuloDescricaoProduto.AutoSize = true;
            lblRotuloDescricaoProduto.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDescricaoProduto.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDescricaoProduto.Location = new Point(89, 37);
            lblRotuloDescricaoProduto.Name = "lblRotuloDescricaoProduto";
            lblRotuloDescricaoProduto.Size = new Size(137, 16);
            lblRotuloDescricaoProduto.TabIndex = 1057;
            lblRotuloDescricaoProduto.Text = "Descrição do produto";
            // 
            // btnBuscarProduto
            // 
            btnBuscarProduto.CornerRoundingRadius = 10F;
            btnBuscarProduto.Location = new Point(499, 53);
            btnBuscarProduto.Name = "btnBuscarProduto";
            btnBuscarProduto.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscarProduto.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscarProduto.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.OverrideDefault.Border.Rounding = 20F;
            btnBuscarProduto.OverrideDefault.Border.Width = 1;
            btnBuscarProduto.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscarProduto.Size = new Size(30, 29);
            btnBuscarProduto.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnBuscarProduto.StateCommon.Back.ColorAngle = 45F;
            btnBuscarProduto.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.StateCommon.Border.Rounding = 10F;
            btnBuscarProduto.StateCommon.Border.Width = 1;
            btnBuscarProduto.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscarProduto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarProduto.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarProduto.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarProduto.StatePressed.Back.ColorAngle = 135F;
            btnBuscarProduto.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscarProduto.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscarProduto.StatePressed.Border.ColorAngle = 135F;
            btnBuscarProduto.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StatePressed.Border.Rounding = 20F;
            btnBuscarProduto.StatePressed.Border.Width = 1;
            btnBuscarProduto.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateTracking.Back.ColorAngle = 45F;
            btnBuscarProduto.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscarProduto.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscarProduto.StateTracking.Border.ColorAngle = 45F;
            btnBuscarProduto.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscarProduto.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscarProduto.StateTracking.Border.Rounding = 20F;
            btnBuscarProduto.StateTracking.Border.Width = 1;
            btnBuscarProduto.StateTracking.Content.ShortText.Color1 = Color.White;
            btnBuscarProduto.TabIndex = 1078;
            btnBuscarProduto.TabStop = false;
            btnBuscarProduto.Values.Image = Properties.Resources.Pesquisar;
            btnBuscarProduto.Values.Text = "";
            btnBuscarProduto.Click += btnBuscarProduto_Click;
            // 
            // lblEstoqueAtual
            // 
            lblEstoqueAtual.AutoSize = true;
            lblEstoqueAtual.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoqueAtual.ForeColor = Color.FromArgb(0, 76, 172);
            lblEstoqueAtual.Location = new Point(568, 56);
            lblEstoqueAtual.Name = "lblEstoqueAtual";
            lblEstoqueAtual.Size = new Size(14, 16);
            lblEstoqueAtual.TabIndex = 1080;
            lblEstoqueAtual.Text = "0";
            // 
            // lblRotuloQuantidade
            // 
            lblRotuloQuantidade.AutoSize = true;
            lblRotuloQuantidade.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloQuantidade.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloQuantidade.Location = new Point(227, 33);
            lblRotuloQuantidade.Name = "lblRotuloQuantidade";
            lblRotuloQuantidade.Size = new Size(77, 16);
            lblRotuloQuantidade.TabIndex = 1082;
            lblRotuloQuantidade.Text = "Quantidade";
            // 
            // txtObservacao
            // 
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.Location = new Point(6, 40);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(616, 24);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 8F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 10.25F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.TabIndex = 1083;
            // 
            // lblRotuloObservacoes
            // 
            lblRotuloObservacoes.AutoSize = true;
            lblRotuloObservacoes.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloObservacoes.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloObservacoes.Location = new Point(6, 21);
            lblRotuloObservacoes.Name = "lblRotuloObservacoes";
            lblRotuloObservacoes.Size = new Size(82, 16);
            lblRotuloObservacoes.TabIndex = 1084;
            lblRotuloObservacoes.Text = "Observaçao";
            // 
            // cmbOrigem
            // 
            cmbOrigem.CornerRoundingRadius = 6F;
            cmbOrigem.DropDownWidth = 115;
            cmbOrigem.IntegralHeight = false;
            cmbOrigem.Items.AddRange(new object[] { "Ajuste Manual", "Inventário", "Perda", "Devolução" });
            cmbOrigem.Location = new Point(437, 52);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            cmbOrigem.Size = new Size(180, 25);
            cmbOrigem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbOrigem.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbOrigem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbOrigem.TabIndex = 1085;
            cmbOrigem.TabStop = false;
            // 
            // grpProduto
            // 
            grpProduto.Controls.Add(lblRotuloEstoque);
            grpProduto.Controls.Add(txtNomeProduto);
            grpProduto.Controls.Add(lblRotuloDescricaoProduto);
            grpProduto.Controls.Add(btnBuscarProduto);
            grpProduto.Controls.Add(lblRotuloProdutoID);
            grpProduto.Controls.Add(txtProdutoID);
            grpProduto.Controls.Add(lblEstoqueAtual);
            grpProduto.Dock = DockStyle.Top;
            grpProduto.Location = new Point(0, 0);
            grpProduto.Name = "grpProduto";
            grpProduto.Size = new Size(634, 110);
            grpProduto.TabIndex = 1086;
            grpProduto.TabStop = false;
            grpProduto.Text = "Produto";
            // 
            // lblRotuloEstoque
            // 
            lblRotuloEstoque.AutoSize = true;
            lblRotuloEstoque.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloEstoque.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloEstoque.Location = new Point(537, 35);
            lblRotuloEstoque.Name = "lblRotuloEstoque";
            lblRotuloEstoque.Size = new Size(89, 16);
            lblRotuloEstoque.TabIndex = 1083;
            lblRotuloEstoque.Text = "Estoque atual";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(lblRotuloOrigem);
            grpMovimentacao.Controls.Add(numQuantidade);
            grpMovimentacao.Controls.Add(cmbTipoMovimentacao);
            grpMovimentacao.Controls.Add(lblRotuloTipoMovimentacao);
            grpMovimentacao.Controls.Add(cmbOrigem);
            grpMovimentacao.Controls.Add(lblRotuloQuantidade);
            grpMovimentacao.Location = new Point(0, 120);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Size = new Size(634, 100);
            grpMovimentacao.TabIndex = 1087;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentações";
            // 
            // lblRotuloOrigem
            // 
            lblRotuloOrigem.AutoSize = true;
            lblRotuloOrigem.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloOrigem.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloOrigem.Location = new Point(437, 30);
            lblRotuloOrigem.Name = "lblRotuloOrigem";
            lblRotuloOrigem.Size = new Size(51, 16);
            lblRotuloOrigem.TabIndex = 1087;
            lblRotuloOrigem.Text = "Origem";
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(227, 55);
            numQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.Name = "numQuantidade";
            numQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            numQuantidade.Size = new Size(180, 26);
            numQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numQuantidade.StateCommon.Border.Rounding = 6F;
            numQuantidade.TabIndex = 1086;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpObs
            // 
            grpObs.Controls.Add(txtObservacao);
            grpObs.Controls.Add(lblRotuloObservacoes);
            grpObs.Location = new Point(0, 225);
            grpObs.Name = "grpObs";
            grpObs.Size = new Size(634, 80);
            grpObs.TabIndex = 1088;
            grpObs.TabStop = false;
            grpObs.Text = "Observações";
            // 
            // FrmMovimentacaoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(634, 381);
            Controls.Add(grpObs);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpProduto);
            Controls.Add(kryptonPanel2);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMovimentacaoEstoque";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movimentacao Estoque";
            Load += FrmMovimentacaoEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cmbTipoMovimentacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbOrigem).EndInit();
            grpProduto.ResumeLayout(false);
            grpProduto.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpObs.ResumeLayout(false);
            grpObs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        public ToolStripStatusLabel toolStripStatusLabelUsuarioCriacao;
        private ToolStripStatusLabel toolStripStatusLabel2;
        public ToolStripStatusLabel ToolStripLabelDataCriacao;
        private ToolStripStatusLabel toolStripStatusLabel4;
        public ToolStripStatusLabel ToolStripLabelDataUtimaCompra;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelUsuarioAtualizacao;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabelDataAtualizacao;
        private ToolStripStatusLabel lblStatus;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        public Krypton.Toolkit.KryptonButton txtFechar;
        public Krypton.Toolkit.KryptonButton btnSalvarVenda;
        public Krypton.Toolkit.KryptonButton btnImprimir;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnConfirmar;
        public Krypton.Toolkit.KryptonButton kryptonButton4;
        public Krypton.Toolkit.KryptonTextBox txtDataValidade;
        public Krypton.Toolkit.KryptonComboBox cmbSituacao;
        private Label label10;
        public PictureBox pbImagem;
        public Krypton.Toolkit.KryptonComboBox cmbTipoMovimentacao;
        public Krypton.Toolkit.KryptonTextBox txtEstoque;
        public Krypton.Toolkit.KryptonTextBox txtProdutoID;
        private Label lblRotuloProdutoID;
        private Label lblRotuloOrigem;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private Label lblRotuloTipoMovimentacao;
        private Label lblRotuloDescricaoProduto;
        public Krypton.Toolkit.KryptonButton btnBuscarProduto;
        public Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonNumericUpDown numQuantidade;
        private Label lblRotuloQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        private Label lblRotuloObservacoes;
        public Krypton.Toolkit.KryptonButton bnCancelar;
        public Krypton.Toolkit.KryptonComboBox cmbOrigem;
        private GroupBox grpProduto;
        private GroupBox grpMovimentacao;
        private Label lblRotuloEstoque;
        private GroupBox grpObs;
        private Krypton.Toolkit.KryptonButton btnListarControlesDoForm;
        public Label lblEstoqueAtual;
    }
}