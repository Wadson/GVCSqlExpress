namespace GVC.View
{
    partial class FrmPDV
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtNomeCliente = new Krypton.Toolkit.KryptonTextBox();
            kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(components);
            lblDesconto = new Label();
            txtDesconto = new Krypton.Toolkit.KryptonTextBox();
            lblTotalGeral = new Label();
            txtTotalGeral = new Krypton.Toolkit.KryptonTextBox();
            cmbFormaPagamento = new Krypton.Toolkit.KryptonComboBox();
            btnAdicionarItem = new Krypton.Toolkit.KryptonButton();
            btnSalvarVenda = new Krypton.Toolkit.KryptonButton();
            btnCancelar = new Krypton.Toolkit.KryptonButton();
            btnImprimir = new Krypton.Toolkit.KryptonButton();
            label10 = new Label();
            txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            txtPrecoUnitario = new Krypton.Toolkit.KryptonTextBox();
            label13 = new Label();
            label12 = new Label();
            txtValorRecebido = new Krypton.Toolkit.KryptonTextBox();
            lblValorRecebido = new Label();
            label1 = new Label();
            lblVendaID = new Label();
            label5 = new Label();
            btnLocalizarProduto = new Krypton.Toolkit.KryptonButton();
            btnLocalizarCliente = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label2 = new Label();
            lblData = new Label();
            txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            txtCpf = new Krypton.Toolkit.KryptonTextBox();
            txtSubTotal = new Krypton.Toolkit.KryptonTextBox();
            lblSubTotal = new Label();
            txtTroco = new Krypton.Toolkit.KryptonTextBox();
            lblTroco = new Label();
            btnGerar = new Krypton.Toolkit.KryptonButton();
            btnCancelarParcelas = new Krypton.Toolkit.KryptonButton();
            numIntervalo = new Krypton.Toolkit.KryptonNumericUpDown();
            lblIntervalo = new Label();
            dgvParcelas = new Krypton.Toolkit.KryptonDataGridView();
            numParcelas = new Krypton.Toolkit.KryptonNumericUpDown();
            lblQtdParcelas = new Label();
            lblPrimeiroVenc = new Label();
            dtPrimeira = new Krypton.Toolkit.KryptonDateTimePicker();
            lblFormaPgto = new Label();
            txtObservacao = new Krypton.Toolkit.KryptonTextBox();
            txtFechar = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            btnNovaVenda = new Krypton.Toolkit.KryptonButton();
            btnListarControles = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            lblTituloPDV = new Krypton.Toolkit.KryptonLabel();
            kryptonPanelPDV = new Krypton.Toolkit.KryptonPanel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            label9 = new Label();
            dgvitens = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label7 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelPDV).BeginInit();
            kryptonPanelPDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvitens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeCliente.CharacterCasing = CharacterCasing.Upper;
            txtNomeCliente.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeCliente.Location = new Point(10, 23);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeCliente.Size = new Size(750, 24);
            txtNomeCliente.StateCommon.Back.Color1 = Color.White;
            txtNomeCliente.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeCliente.StateCommon.Border.ColorAngle = 1F;
            txtNomeCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeCliente.StateCommon.Border.Rounding = 6F;
            txtNomeCliente.StateCommon.Border.Width = 1;
            txtNomeCliente.StateCommon.Content.Color1 = Color.Gray;
            txtNomeCliente.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeCliente.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Color1 = Color.FromArgb(192, 255, 255);
            txtNomeCliente.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeCliente.TabIndex = 100;
            txtNomeCliente.TabStop = false;
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
            // lblDesconto
            // 
            lblDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesconto.AutoSize = true;
            lblDesconto.BackColor = Color.Transparent;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.ForeColor = Color.White;
            lblDesconto.Location = new Point(70, 69);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(66, 17);
            lblDesconto.TabIndex = 638;
            lblDesconto.Text = "Desconto:";
            // 
            // txtDesconto
            // 
            txtDesconto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDesconto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtDesconto.Location = new Point(4, 91);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtDesconto.Size = new Size(195, 34);
            txtDesconto.StateCommon.Back.Color1 = Color.White;
            txtDesconto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtDesconto.StateCommon.Border.ColorAngle = 1F;
            txtDesconto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDesconto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtDesconto.StateCommon.Border.Rounding = 6F;
            txtDesconto.StateCommon.Border.Width = 1;
            txtDesconto.StateCommon.Content.Color1 = Color.Gray;
            txtDesconto.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtDesconto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtDesconto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.TabIndex = 30;
            txtDesconto.TabStop = false;
            txtDesconto.Leave += txtDesconto_Leave;
            // 
            // lblTotalGeral
            // 
            lblTotalGeral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalGeral.AutoSize = true;
            lblTotalGeral.BackColor = Color.Transparent;
            lblTotalGeral.Font = new Font("Segoe UI", 10.75F);
            lblTotalGeral.ForeColor = Color.White;
            lblTotalGeral.Location = new Point(61, 139);
            lblTotalGeral.Name = "lblTotalGeral";
            lblTotalGeral.Size = new Size(84, 20);
            lblTotalGeral.TabIndex = 640;
            lblTotalGeral.Text = "Total Geral:";
            // 
            // txtTotalGeral
            // 
            txtTotalGeral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTotalGeral.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTotalGeral.Location = new Point(4, 162);
            txtTotalGeral.Name = "txtTotalGeral";
            txtTotalGeral.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTotalGeral.ReadOnly = true;
            txtTotalGeral.Size = new Size(195, 34);
            txtTotalGeral.StateCommon.Back.Color1 = Color.White;
            txtTotalGeral.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTotalGeral.StateCommon.Border.ColorAngle = 1F;
            txtTotalGeral.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTotalGeral.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTotalGeral.StateCommon.Border.Rounding = 6F;
            txtTotalGeral.StateCommon.Border.Width = 1;
            txtTotalGeral.StateCommon.Content.Color1 = Color.Gray;
            txtTotalGeral.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtTotalGeral.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTotalGeral.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTotalGeral.TabIndex = 641;
            txtTotalGeral.TabStop = false;
            // 
            // cmbFormaPagamento
            // 
            cmbFormaPagamento.CornerRoundingRadius = 6F;
            cmbFormaPagamento.DropDownWidth = 171;
            cmbFormaPagamento.IntegralHeight = false;
            cmbFormaPagamento.Items.AddRange(new object[] { "Á Vista", "Crediário Parcelado", "Cartão de Crédito", "Cartão de Débito", "Pix", "Transferência" });
            cmbFormaPagamento.Location = new Point(11, 22);
            cmbFormaPagamento.Name = "cmbFormaPagamento";
            cmbFormaPagamento.Size = new Size(509, 27);
            cmbFormaPagamento.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Rounding = 6F;
            cmbFormaPagamento.StateCommon.ComboBox.Border.Width = 1;
            cmbFormaPagamento.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFormaPagamento.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbFormaPagamento.TabIndex = 1014;
            cmbFormaPagamento.TabStop = false;
            cmbFormaPagamento.SelectedIndexChanged += cmbFormaPgto_SelectedIndexChanged;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdicionarItem.CornerRoundingRadius = 6F;
            btnAdicionarItem.Location = new Point(1017, 69);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Back.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.OverrideDefault.Border.ColorAngle = 45F;
            btnAdicionarItem.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.OverrideDefault.Border.Rounding = 20F;
            btnAdicionarItem.OverrideDefault.Border.Width = 1;
            btnAdicionarItem.Size = new Size(105, 25);
            btnAdicionarItem.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Back.ColorAngle = 45F;
            btnAdicionarItem.StateCommon.Border.Color1 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Border.Color2 = Color.FromArgb(252, 252, 250);
            btnAdicionarItem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateCommon.Border.Rounding = 6F;
            btnAdicionarItem.StateCommon.Border.Width = 1;
            btnAdicionarItem.StateCommon.Content.ShortText.Color1 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateCommon.Content.ShortText.Color2 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnAdicionarItem.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StatePressed.Back.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnAdicionarItem.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnAdicionarItem.StatePressed.Border.ColorAngle = 135F;
            btnAdicionarItem.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StatePressed.Border.Rounding = 20F;
            btnAdicionarItem.StatePressed.Border.Width = 1;
            btnAdicionarItem.StatePressed.Content.ShortText.Color1 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StatePressed.Content.ShortText.Color2 = Color.FromArgb(50, 50, 50);
            btnAdicionarItem.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnAdicionarItem.StateTracking.Back.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnAdicionarItem.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnAdicionarItem.StateTracking.Border.ColorAngle = 45F;
            btnAdicionarItem.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnAdicionarItem.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnAdicionarItem.StateTracking.Border.Rounding = 20F;
            btnAdicionarItem.StateTracking.Border.Width = 1;
            btnAdicionarItem.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnAdicionarItem.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnAdicionarItem.TabIndex = 4;
            btnAdicionarItem.Values.Text = "Adicionar item";
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnSalvarVenda
            // 
            btnSalvarVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvarVenda.CornerRoundingRadius = 6F;
            btnSalvarVenda.Location = new Point(717, 2);
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
            btnSalvarVenda.Size = new Size(130, 27);
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
            btnSalvarVenda.Click += btnSalvarVenda_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.CornerRoundingRadius = 6F;
            btnCancelar.Location = new Point(854, 2);
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
            btnCancelar.Size = new Size(130, 27);
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
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnImprimir.CornerRoundingRadius = 6F;
            btnImprimir.Location = new Point(445, 3);
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
            btnImprimir.Size = new Size(130, 27);
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
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(10, 2);
            label10.Name = "label10";
            label10.Size = new Size(50, 17);
            label10.TabIndex = 1025;
            label10.Text = "Cliente:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomeProduto.CharacterCasing = CharacterCasing.Upper;
            txtNomeProduto.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtNomeProduto.Location = new Point(8, 70);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtNomeProduto.Size = new Size(752, 24);
            txtNomeProduto.StateCommon.Back.Color1 = Color.White;
            txtNomeProduto.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtNomeProduto.StateCommon.Border.ColorAngle = 1F;
            txtNomeProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNomeProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtNomeProduto.StateCommon.Border.Rounding = 6F;
            txtNomeProduto.StateCommon.Border.Width = 1;
            txtNomeProduto.StateCommon.Content.Color1 = Color.Gray;
            txtNomeProduto.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtNomeProduto.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtNomeProduto.TabIndex = 1;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecoUnitario.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtPrecoUnitario.Location = new Point(896, 70);
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtPrecoUnitario.Size = new Size(115, 24);
            txtPrecoUnitario.StateCommon.Back.Color1 = Color.White;
            txtPrecoUnitario.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtPrecoUnitario.StateCommon.Border.ColorAngle = 1F;
            txtPrecoUnitario.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPrecoUnitario.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtPrecoUnitario.StateCommon.Border.Rounding = 6F;
            txtPrecoUnitario.StateCommon.Border.Width = 1;
            txtPrecoUnitario.StateCommon.Content.Color1 = Color.Gray;
            txtPrecoUnitario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtPrecoUnitario.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtPrecoUnitario.TabIndex = 3;
            txtPrecoUnitario.TextChanged += txtPrecoUnitario_TextChanged;
            txtPrecoUnitario.KeyPress += txtPrecoUnitario_KeyPress;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(900, 50);
            label13.Name = "label13";
            label13.Size = new Size(91, 17);
            label13.TabIndex = 646;
            label13.Text = "Preço Unitario";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(804, 50);
            label12.Name = "label12";
            label12.Size = new Size(76, 17);
            label12.TabIndex = 644;
            label12.Text = "Quantidade";
            // 
            // txtValorRecebido
            // 
            txtValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtValorRecebido.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtValorRecebido.Location = new Point(5, 233);
            txtValorRecebido.Name = "txtValorRecebido";
            txtValorRecebido.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtValorRecebido.Size = new Size(195, 34);
            txtValorRecebido.StateCommon.Back.Color1 = Color.White;
            txtValorRecebido.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtValorRecebido.StateCommon.Border.ColorAngle = 1F;
            txtValorRecebido.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtValorRecebido.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtValorRecebido.StateCommon.Border.Rounding = 6F;
            txtValorRecebido.StateCommon.Border.Width = 1;
            txtValorRecebido.StateCommon.Content.Color1 = Color.Gray;
            txtValorRecebido.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtValorRecebido.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtValorRecebido.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtValorRecebido.TabIndex = 40;
            txtValorRecebido.TabStop = false;
            txtValorRecebido.Leave += txtValorRecebido_Leave;
            // 
            // lblValorRecebido
            // 
            lblValorRecebido.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblValorRecebido.AutoSize = true;
            lblValorRecebido.BackColor = Color.Transparent;
            lblValorRecebido.Font = new Font("Segoe UI", 9.75F);
            lblValorRecebido.ForeColor = Color.White;
            lblValorRecebido.Location = new Point(59, 212);
            lblValorRecebido.Name = "lblValorRecebido";
            lblValorRecebido.Size = new Size(89, 17);
            lblValorRecebido.TabIndex = 642;
            lblValorRecebido.Text = "Vlr. Recebido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 1033;
            label1.Text = "CÓD. VENDA:";
            // 
            // lblVendaID
            // 
            lblVendaID.AutoSize = true;
            lblVendaID.BackColor = Color.Transparent;
            lblVendaID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblVendaID.ForeColor = Color.White;
            lblVendaID.Location = new Point(99, 7);
            lblVendaID.Name = "lblVendaID";
            lblVendaID.Size = new Size(64, 17);
            lblVendaID.TabIndex = 1034;
            lblVendaID.Text = "Venda ID";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(805, 5);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 1045;
            label5.Text = "CPF:";
            // 
            // btnLocalizarProduto
            // 
            btnLocalizarProduto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarProduto.CornerRoundingRadius = 10F;
            btnLocalizarProduto.Location = new Point(766, 67);
            btnLocalizarProduto.Name = "btnLocalizarProduto";
            btnLocalizarProduto.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Back.ColorAngle = 45F;
            btnLocalizarProduto.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.OverrideDefault.Border.ColorAngle = 45F;
            btnLocalizarProduto.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.OverrideDefault.Border.Rounding = 20F;
            btnLocalizarProduto.OverrideDefault.Border.Width = 1;
            btnLocalizarProduto.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLocalizarProduto.Size = new Size(30, 29);
            btnLocalizarProduto.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnLocalizarProduto.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnLocalizarProduto.StateCommon.Back.ColorAngle = 45F;
            btnLocalizarProduto.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnLocalizarProduto.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            btnLocalizarProduto.StateCommon.Border.Rounding = 10F;
            btnLocalizarProduto.StateCommon.Border.Width = 1;
            btnLocalizarProduto.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLocalizarProduto.StateCommon.Content.ShortText.Color2 = Color.White;
            btnLocalizarProduto.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocalizarProduto.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarProduto.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarProduto.StatePressed.Back.ColorAngle = 135F;
            btnLocalizarProduto.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnLocalizarProduto.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnLocalizarProduto.StatePressed.Border.ColorAngle = 135F;
            btnLocalizarProduto.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StatePressed.Border.Rounding = 20F;
            btnLocalizarProduto.StatePressed.Border.Width = 1;
            btnLocalizarProduto.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateTracking.Back.ColorAngle = 45F;
            btnLocalizarProduto.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnLocalizarProduto.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnLocalizarProduto.StateTracking.Border.ColorAngle = 45F;
            btnLocalizarProduto.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnLocalizarProduto.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnLocalizarProduto.StateTracking.Border.Rounding = 20F;
            btnLocalizarProduto.StateTracking.Border.Width = 1;
            btnLocalizarProduto.TabIndex = 1044;
            btnLocalizarProduto.TabStop = false;
            btnLocalizarProduto.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarProduto.Values.Text = "";
            btnLocalizarProduto.Click += btnLocalizarProduto_Click;
            // 
            // btnLocalizarCliente
            // 
            btnLocalizarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLocalizarCliente.CornerRoundingRadius = 10F;
            btnLocalizarCliente.Location = new Point(766, 20);
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
            btnLocalizarCliente.TabIndex = 1043;
            btnLocalizarCliente.TabStop = false;
            btnLocalizarCliente.Values.Image = Properties.Resources.Pesquisar;
            btnLocalizarCliente.Values.Text = "";
            btnLocalizarCliente.Click += btnLocalizarCliente_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(944, 7);
            label3.Name = "label3";
            label3.Size = new Size(95, 17);
            label3.TabIndex = 1035;
            label3.Text = "DATA VENDA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1026;
            label2.Text = "Produto:";
            // 
            // lblData
            // 
            lblData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblData.AutoSize = true;
            lblData.BackColor = Color.Transparent;
            lblData.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(1042, 7);
            lblData.Name = "lblData";
            lblData.Size = new Size(79, 17);
            lblData.TabIndex = 1036;
            lblData.Text = "Data Venda";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtQuantidade.Location = new Point(802, 70);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtQuantidade.Size = new Size(90, 24);
            txtQuantidade.StateCommon.Back.Color1 = Color.White;
            txtQuantidade.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtQuantidade.StateCommon.Border.ColorAngle = 1F;
            txtQuantidade.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtQuantidade.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtQuantidade.StateCommon.Border.Rounding = 6F;
            txtQuantidade.StateCommon.Border.Width = 1;
            txtQuantidade.StateCommon.Content.Color1 = Color.Gray;
            txtQuantidade.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtQuantidade.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TextAlign = HorizontalAlignment.Center;
            txtQuantidade.KeyPress += txtQuantidade_KeyPress;
            // 
            // txtCpf
            // 
            txtCpf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCpf.CharacterCasing = CharacterCasing.Upper;
            txtCpf.Location = new Point(802, 25);
            txtCpf.Name = "txtCpf";
            txtCpf.ReadOnly = true;
            txtCpf.Size = new Size(278, 24);
            txtCpf.StateCommon.Back.Color1 = Color.White;
            txtCpf.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtCpf.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtCpf.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtCpf.StateCommon.Border.Rounding = 6F;
            txtCpf.StateCommon.Border.Width = 1;
            txtCpf.StateCommon.Content.Color1 = Color.Gray;
            txtCpf.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            txtCpf.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtCpf.TabIndex = 1037;
            txtCpf.TabStop = false;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSubTotal.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtSubTotal.Location = new Point(4, 20);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(197, 34);
            txtSubTotal.StateCommon.Back.Color1 = Color.White;
            txtSubTotal.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtSubTotal.StateCommon.Border.ColorAngle = 1F;
            txtSubTotal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSubTotal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtSubTotal.StateCommon.Border.Rounding = 6F;
            txtSubTotal.StateCommon.Border.Width = 1;
            txtSubTotal.StateCommon.Content.Color1 = Color.Gray;
            txtSubTotal.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtSubTotal.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtSubTotal.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtSubTotal.TabIndex = 1031;
            txtSubTotal.TabStop = false;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Segoe UI", 9.75F);
            lblSubTotal.ForeColor = Color.White;
            lblSubTotal.Location = new Point(73, -1);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(61, 17);
            lblSubTotal.TabIndex = 1030;
            lblSubTotal.Text = "SubTotal:";
            // 
            // txtTroco
            // 
            txtTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTroco.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtTroco.Location = new Point(4, 304);
            txtTroco.Name = "txtTroco";
            txtTroco.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtTroco.Size = new Size(195, 34);
            txtTroco.StateCommon.Back.Color1 = Color.White;
            txtTroco.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtTroco.StateCommon.Border.ColorAngle = 1F;
            txtTroco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTroco.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtTroco.StateCommon.Border.Rounding = 6F;
            txtTroco.StateCommon.Border.Width = 1;
            txtTroco.StateCommon.Content.Color1 = Color.Gray;
            txtTroco.StateCommon.Content.Font = new Font("Segoe UI", 15.75F);
            txtTroco.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtTroco.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtTroco.TabIndex = 1032;
            txtTroco.TabStop = false;
            // 
            // lblTroco
            // 
            lblTroco.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTroco.AutoSize = true;
            lblTroco.BackColor = Color.Transparent;
            lblTroco.Font = new Font("Segoe UI", 9.75F);
            lblTroco.ForeColor = Color.White;
            lblTroco.Location = new Point(81, 282);
            lblTroco.Name = "lblTroco";
            lblTroco.Size = new Size(44, 17);
            lblTroco.TabIndex = 1033;
            lblTroco.Text = "Troco:";
            // 
            // btnGerar
            // 
            btnGerar.CornerRoundingRadius = 10F;
            btnGerar.Location = new Point(333, 71);
            btnGerar.Name = "btnGerar";
            btnGerar.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Back.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.OverrideDefault.Border.ColorAngle = 45F;
            btnGerar.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.OverrideDefault.Border.Rounding = 20F;
            btnGerar.OverrideDefault.Border.Width = 1;
            btnGerar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnGerar.Size = new Size(90, 25);
            btnGerar.StateCommon.Back.Color1 = Color.FromArgb(0, 192, 0);
            btnGerar.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            btnGerar.StateCommon.Back.ColorAngle = 45F;
            btnGerar.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateCommon.Border.Rounding = 10F;
            btnGerar.StateCommon.Border.Width = 1;
            btnGerar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Color2 = Color.White;
            btnGerar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnGerar.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerar.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerar.StatePressed.Back.ColorAngle = 135F;
            btnGerar.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnGerar.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnGerar.StatePressed.Border.ColorAngle = 135F;
            btnGerar.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StatePressed.Border.Rounding = 20F;
            btnGerar.StatePressed.Border.Width = 1;
            btnGerar.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnGerar.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnGerar.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnGerar.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnGerar.StateTracking.Back.ColorAngle = 45F;
            btnGerar.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnGerar.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnGerar.StateTracking.Border.ColorAngle = 45F;
            btnGerar.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGerar.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnGerar.StateTracking.Border.Rounding = 20F;
            btnGerar.StateTracking.Border.Width = 1;
            btnGerar.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnGerar.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnGerar.TabIndex = 1040;
            btnGerar.Values.Text = "Gerar";
            btnGerar.Click += btnGerar_Click;
            // 
            // btnCancelarParcelas
            // 
            btnCancelarParcelas.CornerRoundingRadius = 10F;
            btnCancelarParcelas.Location = new Point(427, 71);
            btnCancelarParcelas.Name = "btnCancelarParcelas";
            btnCancelarParcelas.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Back.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.OverrideDefault.Border.ColorAngle = 45F;
            btnCancelarParcelas.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.OverrideDefault.Border.Rounding = 20F;
            btnCancelarParcelas.OverrideDefault.Border.Width = 1;
            btnCancelarParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnCancelarParcelas.Size = new Size(90, 25);
            btnCancelarParcelas.StateCommon.Back.Color1 = Color.FromArgb(200, 10, 39);
            btnCancelarParcelas.StateCommon.Back.Color2 = Color.Red;
            btnCancelarParcelas.StateCommon.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateCommon.Border.Rounding = 10F;
            btnCancelarParcelas.StateCommon.Border.Width = 1;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Color2 = Color.White;
            btnCancelarParcelas.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnCancelarParcelas.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StatePressed.Back.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnCancelarParcelas.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnCancelarParcelas.StatePressed.Border.ColorAngle = 135F;
            btnCancelarParcelas.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StatePressed.Border.Rounding = 20F;
            btnCancelarParcelas.StatePressed.Border.Width = 1;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnCancelarParcelas.StateTracking.Back.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnCancelarParcelas.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnCancelarParcelas.StateTracking.Border.ColorAngle = 45F;
            btnCancelarParcelas.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnCancelarParcelas.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnCancelarParcelas.StateTracking.Border.Rounding = 20F;
            btnCancelarParcelas.StateTracking.Border.Width = 1;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnCancelarParcelas.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnCancelarParcelas.TabIndex = 1041;
            btnCancelarParcelas.Values.Text = "Cancelar";
            btnCancelarParcelas.Click += btnCancelarParcelas_Click;
            // 
            // numIntervalo
            // 
            numIntervalo.Location = new Point(226, 70);
            numIntervalo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numIntervalo.Name = "numIntervalo";
            numIntervalo.Size = new Size(97, 26);
            numIntervalo.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numIntervalo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numIntervalo.StateCommon.Border.Rounding = 6F;
            numIntervalo.StateCommon.Border.Width = 1;
            numIntervalo.TabIndex = 1048;
            numIntervalo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numIntervalo.ValueChanged += numIntervalo_ValueChanged;
            // 
            // lblIntervalo
            // 
            lblIntervalo.AutoSize = true;
            lblIntervalo.BackColor = Color.Transparent;
            lblIntervalo.Font = new Font("Segoe UI", 9.75F);
            lblIntervalo.ForeColor = Color.White;
            lblIntervalo.Location = new Point(231, 50);
            lblIntervalo.Name = "lblIntervalo";
            lblIntervalo.Size = new Size(41, 17);
            lblIntervalo.TabIndex = 1047;
            lblIntervalo.Text = "Prazo";
            // 
            // dgvParcelas
            // 
            dgvParcelas.AllowUserToAddRows = false;
            dgvParcelas.Dock = DockStyle.Fill;
            dgvParcelas.Location = new Point(548, 440);
            dgvParcelas.Name = "dgvParcelas";
            dgvParcelas.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvParcelas.RowHeadersWidth = 23;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvParcelas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            tableLayoutPanel1.SetRowSpan(dgvParcelas, 2);
            dgvParcelas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParcelas.Size = new Size(369, 204);
            dgvParcelas.TabIndex = 1036;
            // 
            // numParcelas
            // 
            numParcelas.Location = new Point(11, 69);
            numParcelas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.Name = "numParcelas";
            numParcelas.Size = new Size(90, 26);
            numParcelas.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            numParcelas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            numParcelas.StateCommon.Border.Rounding = 6F;
            numParcelas.StateCommon.Border.Width = 1;
            numParcelas.TabIndex = 1043;
            numParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numParcelas.ValueChanged += numParcelas_ValueChanged;
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.BackColor = Color.Transparent;
            lblQtdParcelas.Font = new Font("Segoe UI", 9.75F);
            lblQtdParcelas.ForeColor = Color.White;
            lblQtdParcelas.Location = new Point(11, 49);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(79, 17);
            lblQtdParcelas.TabIndex = 1042;
            lblQtdParcelas.Text = "Nº Parcelas:";
            // 
            // lblPrimeiroVenc
            // 
            lblPrimeiroVenc.AutoSize = true;
            lblPrimeiroVenc.BackColor = Color.Transparent;
            lblPrimeiroVenc.Font = new Font("Segoe UI", 9.75F);
            lblPrimeiroVenc.ForeColor = Color.White;
            lblPrimeiroVenc.Location = new Point(106, 50);
            lblPrimeiroVenc.Name = "lblPrimeiroVenc";
            lblPrimeiroVenc.Size = new Size(98, 17);
            lblPrimeiroVenc.TabIndex = 1045;
            lblPrimeiroVenc.Text = "Data 1º Parcela";
            // 
            // dtPrimeira
            // 
            dtPrimeira.CalendarTodayDate = new DateTime(2025, 12, 24, 0, 0, 0, 0);
            dtPrimeira.CornerRoundingRadius = 6F;
            dtPrimeira.Format = DateTimePickerFormat.Short;
            dtPrimeira.Location = new Point(103, 70);
            dtPrimeira.Name = "dtPrimeira";
            dtPrimeira.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            dtPrimeira.Size = new Size(113, 25);
            dtPrimeira.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            dtPrimeira.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtPrimeira.StateCommon.Border.Rounding = 6F;
            dtPrimeira.StateCommon.Border.Width = 1;
            dtPrimeira.TabIndex = 1044;
            // 
            // lblFormaPgto
            // 
            lblFormaPgto.AutoSize = true;
            lblFormaPgto.BackColor = Color.Transparent;
            lblFormaPgto.Font = new Font("Segoe UI", 9.75F);
            lblFormaPgto.ForeColor = Color.White;
            lblFormaPgto.Location = new Point(11, 2);
            lblFormaPgto.Name = "lblFormaPgto";
            lblFormaPgto.Size = new Size(76, 17);
            lblFormaPgto.TabIndex = 1034;
            lblFormaPgto.Text = "Forma Pgto";
            // 
            // txtObservacao
            // 
            txtObservacao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtObservacao.CharacterCasing = CharacterCasing.Upper;
            txtObservacao.InputControlStyle = Krypton.Toolkit.InputControlStyle.Custom1;
            txtObservacao.Location = new Point(8, 27);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010BlueLightMode;
            txtObservacao.Size = new Size(512, 64);
            txtObservacao.StateCommon.Back.Color1 = Color.White;
            txtObservacao.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            txtObservacao.StateCommon.Border.ColorAngle = 1F;
            txtObservacao.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtObservacao.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            txtObservacao.StateCommon.Border.Rounding = 8F;
            txtObservacao.StateCommon.Border.Width = 1;
            txtObservacao.StateCommon.Content.Color1 = Color.Gray;
            txtObservacao.StateCommon.Content.Font = new Font("Segoe UI", 12.75F);
            txtObservacao.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            txtObservacao.StateDisabled.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.StateNormal.Content.Font = new Font("Segoe UI", 9.75F);
            txtObservacao.TabIndex = 1027;
            txtObservacao.TabStop = false;
            txtObservacao.TextChanged += txtObservacao_TextChanged;
            // 
            // txtFechar
            // 
            txtFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFechar.CornerRoundingRadius = 6F;
            txtFechar.Location = new Point(989, 2);
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
            txtFechar.Size = new Size(130, 27);
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
            txtFechar.Click += txtFechar_Click;
            // 
            // kryptonPanel2
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel2, 3);
            kryptonPanel2.Controls.Add(btnNovaVenda);
            kryptonPanel2.Controls.Add(btnListarControles);
            kryptonPanel2.Controls.Add(txtFechar);
            kryptonPanel2.Controls.Add(btnCancelar);
            kryptonPanel2.Controls.Add(btnImprimir);
            kryptonPanel2.Controls.Add(btnSalvarVenda);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 650);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            kryptonPanel2.Size = new Size(1125, 34);
            kryptonPanel2.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel2.TabIndex = 1042;
            // 
            // btnNovaVenda
            // 
            btnNovaVenda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNovaVenda.CornerRoundingRadius = 6F;
            btnNovaVenda.Location = new Point(581, 3);
            btnNovaVenda.Name = "btnNovaVenda";
            btnNovaVenda.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.OverrideDefault.Back.ColorAngle = 45F;
            btnNovaVenda.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.OverrideDefault.Border.ColorAngle = 45F;
            btnNovaVenda.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.OverrideDefault.Border.Rounding = 20F;
            btnNovaVenda.OverrideDefault.Border.Width = 1;
            btnNovaVenda.Size = new Size(130, 27);
            btnNovaVenda.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnNovaVenda.StateCommon.Back.ColorAngle = 45F;
            btnNovaVenda.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.StateCommon.Border.Rounding = 6F;
            btnNovaVenda.StateCommon.Border.Width = 1;
            btnNovaVenda.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnNovaVenda.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StatePressed.Back.ColorAngle = 135F;
            btnNovaVenda.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnNovaVenda.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnNovaVenda.StatePressed.Border.ColorAngle = 135F;
            btnNovaVenda.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StatePressed.Border.Rounding = 20F;
            btnNovaVenda.StatePressed.Border.Width = 1;
            btnNovaVenda.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnNovaVenda.StateTracking.Back.ColorAngle = 45F;
            btnNovaVenda.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnNovaVenda.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnNovaVenda.StateTracking.Border.ColorAngle = 45F;
            btnNovaVenda.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnNovaVenda.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnNovaVenda.StateTracking.Border.Rounding = 20F;
            btnNovaVenda.StateTracking.Border.Width = 1;
            btnNovaVenda.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnNovaVenda.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnNovaVenda.TabIndex = 1043;
            btnNovaVenda.TabStop = false;
            btnNovaVenda.Values.Text = "Nova Venda";
            btnNovaVenda.Click += btnNovaVenda_Click;
            // 
            // btnListarControles
            // 
            btnListarControles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnListarControles.CornerRoundingRadius = 6F;
            btnListarControles.Location = new Point(8, 2);
            btnListarControles.Name = "btnListarControles";
            btnListarControles.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.OverrideDefault.Back.ColorAngle = 45F;
            btnListarControles.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.OverrideDefault.Border.ColorAngle = 45F;
            btnListarControles.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.OverrideDefault.Border.Rounding = 20F;
            btnListarControles.OverrideDefault.Border.Width = 1;
            btnListarControles.Size = new Size(130, 27);
            btnListarControles.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            btnListarControles.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            btnListarControles.StateCommon.Back.ColorAngle = 45F;
            btnListarControles.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.StateCommon.Border.Rounding = 6F;
            btnListarControles.StateCommon.Border.Width = 1;
            btnListarControles.StateCommon.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StateCommon.Content.ShortText.Color2 = Color.Black;
            btnListarControles.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.75F);
            btnListarControles.StatePressed.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnListarControles.StatePressed.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnListarControles.StatePressed.Back.ColorAngle = 135F;
            btnListarControles.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            btnListarControles.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            btnListarControles.StatePressed.Border.ColorAngle = 135F;
            btnListarControles.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StatePressed.Border.Rounding = 20F;
            btnListarControles.StatePressed.Border.Width = 1;
            btnListarControles.StatePressed.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StatePressed.Content.ShortText.Color2 = Color.Black;
            btnListarControles.StateTracking.Back.Color1 = Color.FromArgb(119, 221, 119);
            btnListarControles.StateTracking.Back.Color2 = Color.FromArgb(119, 221, 119);
            btnListarControles.StateTracking.Back.ColorAngle = 45F;
            btnListarControles.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            btnListarControles.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            btnListarControles.StateTracking.Border.ColorAngle = 45F;
            btnListarControles.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnListarControles.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            btnListarControles.StateTracking.Border.Rounding = 20F;
            btnListarControles.StateTracking.Border.Width = 1;
            btnListarControles.StateTracking.Content.ShortText.Color1 = Color.Black;
            btnListarControles.StateTracking.Content.ShortText.Color2 = Color.Black;
            btnListarControles.TabIndex = 1042;
            btnListarControles.TabStop = false;
            btnListarControles.Values.Text = "Listar Controles";
            btnListarControles.Click += btnListarControles_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 375F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 211F));
            tableLayoutPanel1.Controls.Add(kryptonPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(kryptonPanelPDV, 0, 1);
            tableLayoutPanel1.Controls.Add(kryptonPanel5, 0, 3);
            tableLayoutPanel1.Controls.Add(dgvitens, 0, 2);
            tableLayoutPanel1.Controls.Add(dgvParcelas, 1, 3);
            tableLayoutPanel1.Controls.Add(kryptonPanel4, 2, 2);
            tableLayoutPanel1.Controls.Add(kryptonPanel2, 0, 4);
            tableLayoutPanel1.Controls.Add(kryptonPanel1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1131, 683);
            tableLayoutPanel1.TabIndex = 1043;
           
            // 
            // kryptonPanel3
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanel3, 3);
            kryptonPanel3.Controls.Add(label3);
            kryptonPanel3.Controls.Add(label1);
            kryptonPanel3.Controls.Add(lblData);
            kryptonPanel3.Controls.Add(lblVendaID);
            kryptonPanel3.Controls.Add(lblTituloPDV);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 3);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010SilverDarkMode;
            kryptonPanel3.Size = new Size(1125, 31);
            kryptonPanel3.TabIndex = 1042;
            // 
            // lblTituloPDV
            // 
            lblTituloPDV.Dock = DockStyle.Fill;
            lblTituloPDV.Location = new Point(0, 0);
            lblTituloPDV.Name = "lblTituloPDV";
            lblTituloPDV.Size = new Size(1125, 31);
            lblTituloPDV.StateCommon.ShortText.Color1 = Color.FromArgb(252, 252, 250);
            lblTituloPDV.StateCommon.ShortText.Color2 = Color.FromArgb(252, 252, 250);
            lblTituloPDV.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPDV.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTituloPDV.TabIndex = 0;
            lblTituloPDV.Values.Text = "FRENTE DE CAIXA - PDV";
            // 
            // kryptonPanelPDV
            // 
            tableLayoutPanel1.SetColumnSpan(kryptonPanelPDV, 3);
            kryptonPanelPDV.Controls.Add(kryptonButton1);
            kryptonPanelPDV.Controls.Add(label5);
            kryptonPanelPDV.Controls.Add(btnLocalizarProduto);
            kryptonPanelPDV.Controls.Add(btnLocalizarCliente);
            kryptonPanelPDV.Controls.Add(label2);
            kryptonPanelPDV.Controls.Add(txtQuantidade);
            kryptonPanelPDV.Controls.Add(txtPrecoUnitario);
            kryptonPanelPDV.Controls.Add(txtCpf);
            kryptonPanelPDV.Controls.Add(label12);
            kryptonPanelPDV.Controls.Add(btnAdicionarItem);
            kryptonPanelPDV.Controls.Add(label13);
            kryptonPanelPDV.Controls.Add(label10);
            kryptonPanelPDV.Controls.Add(txtNomeCliente);
            kryptonPanelPDV.Controls.Add(txtNomeProduto);
            kryptonPanelPDV.Dock = DockStyle.Fill;
            kryptonPanelPDV.Location = new Point(3, 40);
            kryptonPanelPDV.Name = "kryptonPanelPDV";
            kryptonPanelPDV.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverDarkMode;
            kryptonPanelPDV.Size = new Size(1125, 99);
            kryptonPanelPDV.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            kryptonPanelPDV.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            kryptonPanelPDV.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanelPDV.TabIndex = 1048;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.CornerRoundingRadius = 10F;
            kryptonButton1.Location = new Point(1086, 23);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            kryptonButton1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.OverrideDefault.Border.Rounding = 20F;
            kryptonButton1.OverrideDefault.Border.Width = 1;
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton1.Size = new Size(30, 29);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(252, 252, 250);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(252, 252, 250);
            kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            kryptonButton1.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateCommon.Border.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TopLeft;
            kryptonButton1.StateCommon.Border.Rounding = 10F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Color2 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton1.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            kryptonButton1.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            kryptonButton1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StatePressed.Border.Rounding = 20F;
            kryptonButton1.StatePressed.Border.Width = 1;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            kryptonButton1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton1.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton1.StateTracking.Border.Rounding = 20F;
            kryptonButton1.StateTracking.Border.Width = 1;
            kryptonButton1.TabIndex = 1046;
            kryptonButton1.TabStop = false;
            kryptonButton1.Values.Image = Properties.Resources.Pesquisar;
            kryptonButton1.Values.Text = "";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(lblFormaPgto);
            kryptonPanel5.Controls.Add(btnCancelarParcelas);
            kryptonPanel5.Controls.Add(cmbFormaPagamento);
            kryptonPanel5.Controls.Add(btnGerar);
            kryptonPanel5.Controls.Add(numIntervalo);
            kryptonPanel5.Controls.Add(lblIntervalo);
            kryptonPanel5.Controls.Add(label9);
            kryptonPanel5.Controls.Add(numParcelas);
            kryptonPanel5.Controls.Add(lblPrimeiroVenc);
            kryptonPanel5.Controls.Add(lblQtdParcelas);
            kryptonPanel5.Controls.Add(dtPrimeira);
            kryptonPanel5.Dock = DockStyle.Fill;
            kryptonPanel5.Location = new Point(3, 440);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010Blue;
            kryptonPanel5.Size = new Size(539, 99);
            kryptonPanel5.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            kryptonPanel5.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            kryptonPanel5.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel5.TabIndex = 1054;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1237, 0);
            label9.Name = "label9";
            label9.Size = new Size(76, 17);
            label9.TabIndex = 1034;
            label9.Text = "Forma Pgto";
            // 
            // dgvitens
            // 
            tableLayoutPanel1.SetColumnSpan(dgvitens, 2);
            dgvitens.Dock = DockStyle.Fill;
            dgvitens.Location = new Point(3, 145);
            dgvitens.Name = "dgvitens";
            dgvitens.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            dgvitens.RowHeadersWidth = 23;
            dgvitens.Size = new Size(914, 289);
            dgvitens.TabIndex = 1051;
            dgvitens.TabStop = false;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(lblTroco);
            kryptonPanel4.Controls.Add(lblValorRecebido);
            kryptonPanel4.Controls.Add(txtTroco);
            kryptonPanel4.Controls.Add(lblTotalGeral);
            kryptonPanel4.Controls.Add(txtValorRecebido);
            kryptonPanel4.Controls.Add(lblDesconto);
            kryptonPanel4.Controls.Add(txtTotalGeral);
            kryptonPanel4.Controls.Add(lblSubTotal);
            kryptonPanel4.Controls.Add(txtDesconto);
            kryptonPanel4.Controls.Add(txtSubTotal);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(923, 145);
            kryptonPanel4.Name = "kryptonPanel4";
            tableLayoutPanel1.SetRowSpan(kryptonPanel4, 3);
            kryptonPanel4.Size = new Size(205, 499);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            kryptonPanel4.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            kryptonPanel4.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel4.TabIndex = 1043;
            kryptonPanel4.Paint += kryptonPanel4_Paint;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(label7);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Controls.Add(txtObservacao);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(3, 545);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Blue;
            kryptonPanel1.Size = new Size(539, 99);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(0, 90, 180);
            kryptonPanel1.StateCommon.Color2 = Color.FromArgb(102, 178, 255);
            kryptonPanel1.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Dashed;
            kryptonPanel1.TabIndex = 1053;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 4);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 1035;
            label7.Text = "Observação";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(812, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 17);
            label4.TabIndex = 1034;
            label4.Text = "Forma Pgto";
            // 
            // FrmPDV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 250);
            ClientSize = new Size(1131, 683);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPDV";
            Palette = kryptonPalette1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDV-Ponto de Vendas";
            WindowState = FormWindowState.Maximized;
            Load += FrmPDV_Load;
            Shown += FrmPDV_Shown;
            KeyDown += FrmPDV_KeyDown;
            ((System.ComponentModel.ISupportInitialize)cmbFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParcelas).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelPDV).EndInit();
            kryptonPanelPDV.ResumeLayout(false);
            kryptonPanelPDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvitens).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Krypton.Toolkit.KryptonTextBox txtNomeCliente;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Label lblDesconto;
        public Krypton.Toolkit.KryptonTextBox txtDesconto;
        private Label lblTotalGeral;
        public Krypton.Toolkit.KryptonTextBox txtTotalGeral;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPagamento;
        public Krypton.Toolkit.KryptonButton btnAdicionarItem;
        public Krypton.Toolkit.KryptonButton btnSalvarVenda;
        public Krypton.Toolkit.KryptonButton btnCancelar;
        public Krypton.Toolkit.KryptonButton btnImprimir;
        public Krypton.Toolkit.KryptonTextBox txtValorRecebido;
        private Label lblValorRecebido;
        private Label label12;
        public Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        public Krypton.Toolkit.KryptonTextBox txtPrecoUnitario;
        private Label label13;
        private Label label10;
        private Label label1;
        private Label lblVendaID;
        private Label label3;
        private Label lblData;
        public Krypton.Toolkit.KryptonTextBox txtCpf;
        public Krypton.Toolkit.KryptonTextBox txtQuantidade;
        public Krypton.Toolkit.KryptonTextBox txtSubTotal;
        private Label lblSubTotal;
        public Krypton.Toolkit.KryptonTextBox txtTroco;
        private Label lblTroco;
        private Label lblFormaPgto;
        private Label lblIntervalo;
        private Krypton.Toolkit.KryptonDataGridView dgvParcelas;
        private Label lblPrimeiroVenc;
        private Krypton.Toolkit.KryptonDateTimePicker dtPrimeira;
        private Krypton.Toolkit.KryptonNumericUpDown numParcelas;
        private Label lblQtdParcelas;
        public Krypton.Toolkit.KryptonButton btnGerar;
        public Krypton.Toolkit.KryptonButton btnCancelarParcelas;
        private Krypton.Toolkit.KryptonNumericUpDown numIntervalo;
        private Label label2;
        public Krypton.Toolkit.KryptonTextBox txtObservacao;
        public Krypton.Toolkit.KryptonButton txtFechar;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public Krypton.Toolkit.KryptonButton btnLocalizarCliente;
        public Krypton.Toolkit.KryptonButton btnLocalizarProduto;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel lblTituloPDV;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanelPDV;
        private Krypton.Toolkit.KryptonDataGridView dgvitens;
        public Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label label7;
        private Label label4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Label label9;
        public Krypton.Toolkit.KryptonButton btnListarControles;
        public Krypton.Toolkit.KryptonButton btnNovaVenda;
    }
}