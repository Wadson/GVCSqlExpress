namespace GVC.View
{
    partial class FrmGerenciarVendas
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
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabelUsuarioCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            ToolStripLabelDataCriacao = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            ToolStripLabelDataUtimaCompra = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelUsuarioAtualizacao = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabelDataAtualizacao = new ToolStripStatusLabel();
            lblStatus = new ToolStripStatusLabel();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            toolTip = new ToolTip(components);
            Timer1 = new System.Windows.Forms.Timer(components);
            txtCliente = new Krypton.Toolkit.KryptonTextBox();
            lblRotuloNome = new Label();
            lblRotuloVendaID = new Label();
            txtVendaID = new Krypton.Toolkit.KryptonTextBox();
            btnSair = new Krypton.Toolkit.KryptonButton();
            btnExcluir = new Krypton.Toolkit.KryptonButton();
            btnVisualizar = new Krypton.Toolkit.KryptonButton();
            btnAlterar = new Krypton.Toolkit.KryptonButton();
            dtpDataInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDataFim = new Krypton.Toolkit.KryptonDateTimePicker();
            lblRotuloDataInicio = new Label();
            lblRotuloDataFim = new Label();
            btnBuscar = new Krypton.Toolkit.KryptonButton();
            dgvVendas = new Krypton.Toolkit.KryptonDataGridView();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnLocalizarCliente = new Krypton.Toolkit.KryptonButton();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelUsuarioCriacao, toolStripStatusLabel2, ToolStripLabelDataCriacao, toolStripStatusLabel4, ToolStripLabelDataUtimaCompra, toolStripStatusLabel1, toolStripStatusLabelUsuarioAtualizacao, toolStripStatusLabel3, toolStripStatusLabelDataAtualizacao, lblStatus });
            kryptonStatusStrip1.Location = new Point(0, 428);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(927, 22);
            kryptonStatusStrip1.TabIndex = 1028;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabelUsuarioCriacao
            // 
            toolStripStatusLabelUsuarioCriacao.ForeColor = Color.White;
            toolStripStatusLabelUsuarioCriacao.Name = "toolStripStatusLabelUsuarioCriacao";
            toolStripStatusLabelUsuarioCriacao.Size = new Size(99, 17);
            toolStripStatusLabelUsuarioCriacao.Text = "Usuario Criação...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(16, 17);
            toolStripStatusLabel2.Text = " | ";
            // 
            // ToolStripLabelDataCriacao
            // 
            ToolStripLabelDataCriacao.ForeColor = Color.White;
            ToolStripLabelDataCriacao.Name = "ToolStripLabelDataCriacao";
            ToolStripLabelDataCriacao.Size = new Size(99, 17);
            ToolStripLabelDataCriacao.Text = "Data da Criação...";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(16, 17);
            toolStripStatusLabel4.Text = " | ";
            // 
            // ToolStripLabelDataUtimaCompra
            // 
            ToolStripLabelDataUtimaCompra.ForeColor = Color.White;
            ToolStripLabelDataUtimaCompra.Name = "ToolStripLabelDataUtimaCompra";
            ToolStripLabelDataUtimaCompra.Size = new Size(131, 17);
            ToolStripLabelDataUtimaCompra.Text = "Data da Ultima Compra";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 17);
            toolStripStatusLabel1.Text = " | ";
            // 
            // toolStripStatusLabelUsuarioAtualizacao
            // 
            toolStripStatusLabelUsuarioAtualizacao.Name = "toolStripStatusLabelUsuarioAtualizacao";
            toolStripStatusLabelUsuarioAtualizacao.Size = new Size(100, 17);
            toolStripStatusLabelUsuarioAtualizacao.Text = "Usuário Alteração";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(16, 17);
            toolStripStatusLabel3.Text = " | ";
            // 
            // toolStripStatusLabelDataAtualizacao
            // 
            toolStripStatusLabelDataAtualizacao.Name = "toolStripStatusLabelDataAtualizacao";
            toolStripStatusLabelDataAtualizacao.Size = new Size(95, 17);
            toolStripStatusLabelDataAtualizacao.Text = "Data Atualização";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.FromArgb(0, 192, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
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
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCliente.CharacterCasing = CharacterCasing.Upper;
            txtCliente.Location = new Point(124, 31);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(472, 27);
            txtCliente.StateCommon.Back.Color1 = Color.White;
            txtCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCliente.StateCommon.Border.Rounding = 8F;
            txtCliente.StateCommon.Border.Width = 1;
            txtCliente.StateCommon.Content.Color1 = Color.Gray;
            txtCliente.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCliente.TabIndex = 1029;
            // 
            // lblRotuloNome
            // 
            lblRotuloNome.AutoSize = true;
            lblRotuloNome.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloNome.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloNome.Location = new Point(130, 10);
            lblRotuloNome.Name = "lblRotuloNome";
            lblRotuloNome.Size = new Size(112, 16);
            lblRotuloNome.TabIndex = 1030;
            lblRotuloNome.Text = "Nome do cliente?";
            // 
            // lblRotuloVendaID
            // 
            lblRotuloVendaID.AutoSize = true;
            lblRotuloVendaID.BackColor = Color.Transparent;
            lblRotuloVendaID.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloVendaID.Location = new Point(12, 11);
            lblRotuloVendaID.Name = "lblRotuloVendaID";
            lblRotuloVendaID.Size = new Size(102, 15);
            lblRotuloVendaID.TabIndex = 1031;
            lblRotuloVendaID.Text = "Código da Venda?";
            // 
            // txtVendaID
            // 
            txtVendaID.Location = new Point(12, 31);
            txtVendaID.Name = "txtVendaID";
            txtVendaID.Size = new Size(102, 27);
            txtVendaID.StateCommon.Back.Color1 = Color.White;
            txtVendaID.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtVendaID.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtVendaID.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtVendaID.StateCommon.Border.Rounding = 8F;
            txtVendaID.StateCommon.Border.Width = 1;
            txtVendaID.StateCommon.Content.Color1 = Color.Gray;
            txtVendaID.StateCommon.Content.Font = new Font("Segoe UI", 10.25F);
            txtVendaID.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtVendaID.TabIndex = 1032;
            txtVendaID.TabStop = false;
            txtVendaID.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSair.CornerRoundingRadius = 10F;
            btnSair.Location = new Point(802, 384);
            btnSair.Margin = new Padding(5, 3, 5, 3);
            btnSair.Name = "btnSair";
            btnSair.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Back.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.OverrideDefault.Border.ColorAngle = 45F;
            btnSair.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.OverrideDefault.Border.Rounding = 20F;
            btnSair.OverrideDefault.Border.Width = 1;
            btnSair.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnSair.Size = new Size(100, 30);
            btnSair.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Back.ColorAngle = 45F;
            btnSair.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateCommon.Border.Rounding = 10F;
            btnSair.StateCommon.Border.Width = 1;
            btnSair.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSair.StateCommon.Content.ShortText.Color2 = Color.White;
            btnSair.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnSair.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Back.ColorAngle = 135F;
            btnSair.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnSair.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnSair.StatePressed.Border.ColorAngle = 135F;
            btnSair.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StatePressed.Border.Rounding = 20F;
            btnSair.StatePressed.Border.Width = 1;
            btnSair.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Back.ColorAngle = 45F;
            btnSair.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnSair.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnSair.StateTracking.Border.ColorAngle = 45F;
            btnSair.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSair.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnSair.StateTracking.Border.Rounding = 20F;
            btnSair.StateTracking.Border.Width = 1;
            btnSair.TabIndex = 1035;
            btnSair.Values.Text = "&Sair";
            btnSair.Click += btnSair_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExcluir.CornerRoundingRadius = 10F;
            btnExcluir.Location = new Point(702, 384);
            btnExcluir.Margin = new Padding(5, 3, 5, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.OverrideDefault.Back.ColorAngle = 45F;
            btnExcluir.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.OverrideDefault.Border.ColorAngle = 45F;
            btnExcluir.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.OverrideDefault.Border.Rounding = 20F;
            btnExcluir.OverrideDefault.Border.Width = 1;
            btnExcluir.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExcluir.Size = new Size(100, 30);
            btnExcluir.StateCommon.Back.Color1 = Color.Red;
            btnExcluir.StateCommon.Back.Color2 = Color.Red;
            btnExcluir.StateCommon.Back.ColorAngle = 45F;
            btnExcluir.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.StateCommon.Border.Rounding = 10F;
            btnExcluir.StateCommon.Border.Width = 1;
            btnExcluir.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExcluir.StateCommon.Content.ShortText.Color2 = Color.White;
            btnExcluir.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnExcluir.StateNormal.Back.Color1 = Color.Red;
            btnExcluir.StateNormal.Back.Color2 = Color.Red;
            btnExcluir.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluir.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluir.StatePressed.Back.ColorAngle = 135F;
            btnExcluir.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnExcluir.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnExcluir.StatePressed.Border.ColorAngle = 135F;
            btnExcluir.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StatePressed.Border.Rounding = 20F;
            btnExcluir.StatePressed.Border.Width = 1;
            btnExcluir.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateTracking.Back.ColorAngle = 45F;
            btnExcluir.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnExcluir.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnExcluir.StateTracking.Border.ColorAngle = 45F;
            btnExcluir.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExcluir.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnExcluir.StateTracking.Border.Rounding = 20F;
            btnExcluir.StateTracking.Border.Width = 1;
            btnExcluir.TabIndex = 1033;
            btnExcluir.Values.Text = "&Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisualizar.CornerRoundingRadius = 10F;
            btnVisualizar.Location = new Point(402, 384);
            btnVisualizar.Margin = new Padding(5, 3, 5, 3);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizar.OverrideDefault.Back.ColorAngle = 45F;
            btnVisualizar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizar.OverrideDefault.Border.ColorAngle = 45F;
            btnVisualizar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizar.OverrideDefault.Border.Rounding = 20F;
            btnVisualizar.OverrideDefault.Border.Width = 1;
            btnVisualizar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnVisualizar.Size = new Size(100, 30);
            btnVisualizar.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizar.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizar.StateCommon.Back.ColorAngle = 45F;
            btnVisualizar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizar.StateCommon.Border.Rounding = 10F;
            btnVisualizar.StateCommon.Border.Width = 1;
            btnVisualizar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnVisualizar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnVisualizar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnVisualizar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnVisualizar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnVisualizar.StatePressed.Back.ColorAngle = 135F;
            btnVisualizar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnVisualizar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnVisualizar.StatePressed.Border.ColorAngle = 135F;
            btnVisualizar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizar.StatePressed.Border.Rounding = 20F;
            btnVisualizar.StatePressed.Border.Width = 1;
            btnVisualizar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnVisualizar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnVisualizar.StateTracking.Back.ColorAngle = 45F;
            btnVisualizar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnVisualizar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnVisualizar.StateTracking.Border.ColorAngle = 45F;
            btnVisualizar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnVisualizar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnVisualizar.StateTracking.Border.Rounding = 20F;
            btnVisualizar.StateTracking.Border.Width = 1;
            btnVisualizar.TabIndex = 1036;
            btnVisualizar.Values.Text = "&Visualizar";
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlterar.CornerRoundingRadius = 10F;
            btnAlterar.Location = new Point(502, 384);
            btnAlterar.Margin = new Padding(5, 3, 5, 3);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterar.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterar.OverrideDefault.Back.ColorAngle = 45F;
            btnAlterar.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.OverrideDefault.Border.ColorAngle = 45F;
            btnAlterar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.OverrideDefault.Border.Rounding = 20F;
            btnAlterar.OverrideDefault.Border.Width = 1;
            btnAlterar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnAlterar.Size = new Size(100, 30);
            btnAlterar.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            btnAlterar.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            btnAlterar.StateCommon.Back.ColorAngle = 45F;
            btnAlterar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.StateCommon.Border.Rounding = 10F;
            btnAlterar.StateCommon.Border.Width = 1;
            btnAlterar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnAlterar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnAlterar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterar.StatePressed.Back.ColorAngle = 135F;
            btnAlterar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAlterar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAlterar.StatePressed.Border.ColorAngle = 135F;
            btnAlterar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StatePressed.Border.Rounding = 20F;
            btnAlterar.StatePressed.Border.Width = 1;
            btnAlterar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateTracking.Back.ColorAngle = 45F;
            btnAlterar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAlterar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAlterar.StateTracking.Border.ColorAngle = 45F;
            btnAlterar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAlterar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAlterar.StateTracking.Border.Rounding = 20F;
            btnAlterar.StateTracking.Border.Width = 1;
            btnAlterar.StateTracking.Content.ShortText.Color1 = Color.White;
            btnAlterar.TabIndex = 1034;
            btnAlterar.Values.Text = "&Alterar";
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataInicio.CornerRoundingRadius = 8F;
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(639, 31);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(110, 27);
            dtpDataInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataInicio.StateCommon.Border.Rounding = 8F;
            dtpDataInicio.TabIndex = 1037;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtpDataFim.CornerRoundingRadius = 8F;
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(754, 31);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(110, 27);
            dtpDataFim.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDataFim.StateCommon.Border.Rounding = 8F;
            dtpDataFim.TabIndex = 1038;
            // 
            // lblRotuloDataInicio
            // 
            lblRotuloDataInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataInicio.AutoSize = true;
            lblRotuloDataInicio.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataInicio.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataInicio.Location = new Point(639, 11);
            lblRotuloDataInicio.Name = "lblRotuloDataInicio";
            lblRotuloDataInicio.Size = new Size(70, 16);
            lblRotuloDataInicio.TabIndex = 1039;
            lblRotuloDataInicio.Text = "Data Inicio";
            // 
            // lblRotuloDataFim
            // 
            lblRotuloDataFim.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRotuloDataFim.AutoSize = true;
            lblRotuloDataFim.Font = new Font("Microsoft Sans Serif", 9.25F);
            lblRotuloDataFim.ForeColor = Color.FromArgb(0, 76, 172);
            lblRotuloDataFim.Location = new Point(754, 9);
            lblRotuloDataFim.Name = "lblRotuloDataFim";
            lblRotuloDataFim.Size = new Size(61, 16);
            lblRotuloDataFim.TabIndex = 1040;
            lblRotuloDataFim.Text = "Data Fim";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.CornerRoundingRadius = 10F;
            btnBuscar.Location = new Point(870, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.OverrideDefault.Back.ColorAngle = 45F;
            btnBuscar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.OverrideDefault.Border.ColorAngle = 45F;
            btnBuscar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.OverrideDefault.Border.Rounding = 20F;
            btnBuscar.OverrideDefault.Border.Width = 1;
            btnBuscar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnBuscar.Size = new Size(30, 29);
            btnBuscar.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnBuscar.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnBuscar.StateCommon.Back.ColorAngle = 45F;
            btnBuscar.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnBuscar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnBuscar.StateCommon.Border.Rounding = 10F;
            btnBuscar.StateCommon.Border.Width = 1;
            btnBuscar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnBuscar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscar.StatePressed.Back.ColorAngle = 135F;
            btnBuscar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnBuscar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnBuscar.StatePressed.Border.ColorAngle = 135F;
            btnBuscar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StatePressed.Border.Rounding = 20F;
            btnBuscar.StatePressed.Border.Width = 1;
            btnBuscar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateTracking.Back.ColorAngle = 45F;
            btnBuscar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnBuscar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnBuscar.StateTracking.Border.ColorAngle = 45F;
            btnBuscar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnBuscar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnBuscar.StateTracking.Border.Rounding = 20F;
            btnBuscar.StateTracking.Border.Width = 1;
            btnBuscar.TabIndex = 1041;
            btnBuscar.TabStop = false;
            btnBuscar.Values.Image = Properties.Resources.Pesquisar;
            btnBuscar.Values.Text = "";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvVendas
            // 
            dgvVendas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendas.Location = new Point(12, 73);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvVendas.RowHeadersWidth = 23;
            dgvVendas.Size = new Size(888, 275);
            dgvVendas.TabIndex = 1042;
            dgvVendas.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 10F;
            btnCancelar.Location = new Point(602, 384);
            btnCancelar.Margin = new Padding(5, 3, 5, 3);
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
            btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.StateCommon.Back.Color1 = Color.Red;
            btnCancelar.StateCommon.Back.Color2 = Color.Red;
            btnCancelar.StateCommon.Back.ColorAngle = 45F;
            btnCancelar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateCommon.Border.Rounding = 10F;
            btnCancelar.StateCommon.Border.Width = 1;
            btnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelar.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F);
            btnCancelar.StateNormal.Back.Color1 = Color.Red;
            btnCancelar.StateNormal.Back.Color2 = Color.Red;
            btnCancelar.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Back.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelar.StatePressed.Border.ColorAngle = 135F;
            btnCancelar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StatePressed.Border.Rounding = 20F;
            btnCancelar.StatePressed.Border.Width = 1;
            btnCancelar.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Back.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelar.StateTracking.Border.ColorAngle = 45F;
            btnCancelar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelar.StateTracking.Border.Rounding = 20F;
            btnCancelar.StateTracking.Border.Width = 1;
            btnCancelar.TabIndex = 1043;
            btnCancelar.Values.Text = "&Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLocalizarCliente
            // 
            btnLocalizarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarCliente.CornerRoundingRadius = 10F;
            btnLocalizarCliente.Location = new Point(602, 31);
            btnLocalizarCliente.Name = "btnLocalizarCliente";
            btnLocalizarCliente.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarCliente.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarCliente.OverrideDefault.Border.Width = 1;
            btnLocalizarCliente.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarCliente.Size = new Size(30, 29);
            btnLocalizarCliente.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLocalizarCliente.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLocalizarCliente.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnLocalizarCliente.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnLocalizarCliente.StateCommon.Border.Rounding = 10F;
            btnLocalizarCliente.StateCommon.Border.Width = 1;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarCliente.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarCliente.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarCliente.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarCliente.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarCliente.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StatePressed.Border.Rounding = 20F;
            btnLocalizarCliente.StatePressed.Border.Width = 1;
            btnLocalizarCliente.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarCliente.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarCliente.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarCliente.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarCliente.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarCliente.StateTracking.Border.Rounding = 20F;
            btnLocalizarCliente.StateTracking.Border.Width = 1;
            btnLocalizarCliente.TabIndex = 1044;
            btnLocalizarCliente.TabStop = false;
            btnLocalizarCliente.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarCliente.Values.Text = "";
            btnLocalizarCliente.Click += btnLocalizarCliente_Click;
            // 
            // FrmGerenciarVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(927, 450);
            Controls.Add(btnLocalizarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(dgvVendas);
            Controls.Add(btnBuscar);
            Controls.Add(lblRotuloDataFim);
            Controls.Add(lblRotuloDataInicio);
            Controls.Add(dtpDataFim);
            Controls.Add(dtpDataInicio);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnVisualizar);
            Controls.Add(btnAlterar);
            Controls.Add(txtCliente);
            Controls.Add(lblRotuloNome);
            Controls.Add(lblRotuloVendaID);
            Controls.Add(txtVendaID);
            Controls.Add(kryptonStatusStrip1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGerenciarVendas";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            Text = "Gerenciar Vendas";
            Load += FrmGerenciarVendas_Load;
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolTip toolTip;
        private System.Windows.Forms.Timer Timer1;
        public Krypton.Toolkit.KryptonTextBox txtCliente;
        private Label lblRotuloNome;
        private Label lblRotuloVendaID;
        public Krypton.Toolkit.KryptonTextBox txtVendaID;
        public Krypton.Toolkit.KryptonButton btnSair;
        public Krypton.Toolkit.KryptonButton btnExcluir;
        public Krypton.Toolkit.KryptonButton btnVisualizar;
        public Krypton.Toolkit.KryptonButton btnAlterar;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataInicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDataFim;
        private Label lblRotuloDataInicio;
        private Label lblRotuloDataFim;
        public Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonDataGridView dgvVendas;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnLocalizarCliente;
    }
}