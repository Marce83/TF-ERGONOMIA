namespace TF.WIN
{
    partial class FrmPuestoHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuestoHistorial));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.DtpFechahasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechadesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarresultado = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.DgvPuestosRecientes = new System.Windows.Forms.DataGridView();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtCuitEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtnBuscarempresa = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtNombreEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.userlabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.userlabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.TxtEmpresapresentar = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtCuit = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(100, 236);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 351;
            this.materialLabel2.Text = "EMPLEADO";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(928, 222);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(89, 48);
            this.btnBuscarEmpleado.TabIndex = 352;
            this.btnBuscarEmpleado.Text = "...";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // DtpFechahasta
            // 
            this.DtpFechahasta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFechahasta.Location = new System.Drawing.Point(316, 350);
            this.DtpFechahasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechahasta.Name = "DtpFechahasta";
            this.DtpFechahasta.Size = new System.Drawing.Size(303, 22);
            this.DtpFechahasta.TabIndex = 356;
            // 
            // DtpFechadesde
            // 
            this.DtpFechadesde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DtpFechadesde.Location = new System.Drawing.Point(316, 289);
            this.DtpFechadesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DtpFechadesde.Name = "DtpFechadesde";
            this.DtpFechadesde.Size = new System.Drawing.Size(303, 22);
            this.DtpFechadesde.TabIndex = 355;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(101, 290);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 19);
            this.materialLabel1.TabIndex = 354;
            this.materialLabel1.Text = "FECHA DESDE";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(101, 350);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 19);
            this.materialLabel5.TabIndex = 353;
            this.materialLabel5.Text = "FECHA HASTA";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.HideSelection = true;
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(316, 222);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.PrefixSuffixText = null;
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.ShortcutsEnabled = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(605, 48);
            this.txtNombreEmpleado.TabIndex = 363;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpleado.TrailingIcon = null;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(104, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 59);
            this.button1.TabIndex = 362;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarresultado
            // 
            this.btnBuscarresultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarresultado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarresultado.FlatAppearance.BorderSize = 0;
            this.btnBuscarresultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarresultado.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarresultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarresultado.Location = new System.Drawing.Point(789, 414);
            this.btnBuscarresultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarresultado.Name = "btnBuscarresultado";
            this.btnBuscarresultado.Size = new System.Drawing.Size(227, 59);
            this.btnBuscarresultado.TabIndex = 361;
            this.btnBuscarresultado.Text = "CONSULTAR";
            this.btnBuscarresultado.UseVisualStyleBackColor = false;
            this.btnBuscarresultado.Click += new System.EventHandler(this.btnBuscarresultado_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarraTitulo.Controls.Add(this.label12);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1135, 65);
            this.BarraTitulo.TabIndex = 364;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(735, 38);
            this.label12.TabIndex = 65;
            this.label12.Text = "CONSULTAR MOVIMIENTOS POR EMPLEADO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1069, 15);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvPuestosRecientes
            // 
            this.DgvPuestosRecientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvPuestosRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvPuestosRecientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvPuestosRecientes.ColumnHeadersHeight = 25;
            this.DgvPuestosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPuestosRecientes.EnableHeadersVisualStyles = false;
            this.DgvPuestosRecientes.Location = new System.Drawing.Point(104, 502);
            this.DgvPuestosRecientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvPuestosRecientes.Name = "DgvPuestosRecientes";
            this.DgvPuestosRecientes.RowHeadersWidth = 51;
            this.DgvPuestosRecientes.Size = new System.Drawing.Size(913, 194);
            this.DgvPuestosRecientes.TabIndex = 365;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnImprimir.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.BtnImprimir.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnImprimir.Location = new System.Drawing.Point(844, 736);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(173, 59);
            this.BtnImprimir.TabIndex = 366;
            this.BtnImprimir.Text = "EXPORTAR A PDF";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // TxtCuitEmpresa
            // 
            this.TxtCuitEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCuitEmpresa.AnimateReadOnly = false;
            this.TxtCuitEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCuitEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCuitEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCuitEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCuitEmpresa.Depth = 0;
            this.TxtCuitEmpresa.Enabled = false;
            this.TxtCuitEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCuitEmpresa.HideSelection = true;
            this.TxtCuitEmpresa.LeadingIcon = null;
            this.TxtCuitEmpresa.Location = new System.Drawing.Point(316, 89);
            this.TxtCuitEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCuitEmpresa.MaxLength = 32767;
            this.TxtCuitEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCuitEmpresa.Name = "TxtCuitEmpresa";
            this.TxtCuitEmpresa.PasswordChar = '\0';
            this.TxtCuitEmpresa.PrefixSuffixText = null;
            this.TxtCuitEmpresa.ReadOnly = true;
            this.TxtCuitEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCuitEmpresa.SelectedText = "";
            this.TxtCuitEmpresa.SelectionLength = 0;
            this.TxtCuitEmpresa.SelectionStart = 0;
            this.TxtCuitEmpresa.ShortcutsEnabled = true;
            this.TxtCuitEmpresa.Size = new System.Drawing.Size(607, 48);
            this.TxtCuitEmpresa.TabIndex = 369;
            this.TxtCuitEmpresa.TabStop = false;
            this.TxtCuitEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCuitEmpresa.TrailingIcon = null;
            this.TxtCuitEmpresa.UseSystemPasswordChar = false;
            // 
            // BtnBuscarempresa
            // 
            this.BtnBuscarempresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBuscarempresa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BtnBuscarempresa.FlatAppearance.BorderSize = 0;
            this.BtnBuscarempresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnBuscarempresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarempresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBuscarempresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarempresa.Location = new System.Drawing.Point(929, 89);
            this.BtnBuscarempresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBuscarempresa.Name = "BtnBuscarempresa";
            this.BtnBuscarempresa.Size = new System.Drawing.Size(89, 48);
            this.BtnBuscarempresa.TabIndex = 368;
            this.BtnBuscarempresa.Text = "...";
            this.BtnBuscarempresa.UseVisualStyleBackColor = false;
            this.BtnBuscarempresa.Click += new System.EventHandler(this.BtnBuscarempresa_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(101, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(111, 19);
            this.materialLabel3.TabIndex = 367;
            this.materialLabel3.Text = "CUIT EMPRESA";
            // 
            // TxtNombreEmpresa
            // 
            this.TxtNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtNombreEmpresa.AnimateReadOnly = false;
            this.TxtNombreEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtNombreEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtNombreEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNombreEmpresa.Depth = 0;
            this.TxtNombreEmpresa.Enabled = false;
            this.TxtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNombreEmpresa.HideSelection = true;
            this.TxtNombreEmpresa.LeadingIcon = null;
            this.TxtNombreEmpresa.Location = new System.Drawing.Point(316, 151);
            this.TxtNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreEmpresa.MaxLength = 32767;
            this.TxtNombreEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtNombreEmpresa.Name = "TxtNombreEmpresa";
            this.TxtNombreEmpresa.PasswordChar = '\0';
            this.TxtNombreEmpresa.PrefixSuffixText = null;
            this.TxtNombreEmpresa.ReadOnly = true;
            this.TxtNombreEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtNombreEmpresa.SelectedText = "";
            this.TxtNombreEmpresa.SelectionLength = 0;
            this.TxtNombreEmpresa.SelectionStart = 0;
            this.TxtNombreEmpresa.ShortcutsEnabled = true;
            this.TxtNombreEmpresa.Size = new System.Drawing.Size(605, 48);
            this.TxtNombreEmpresa.TabIndex = 370;
            this.TxtNombreEmpresa.TabStop = false;
            this.TxtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNombreEmpresa.TrailingIcon = null;
            this.TxtNombreEmpresa.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(101, 162);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 371;
            this.materialLabel4.Text = "EMPRESA";
            // 
            // userlabel2
            // 
            this.userlabel2.AutoSize = true;
            this.userlabel2.Depth = 0;
            this.userlabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userlabel2.Location = new System.Drawing.Point(627, 434);
            this.userlabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.userlabel2.Name = "userlabel2";
            this.userlabel2.Size = new System.Drawing.Size(107, 19);
            this.userlabel2.TabIndex = 373;
            this.userlabel2.Text = "materialLabel8";
            this.userlabel2.Visible = false;
            // 
            // userlabel1
            // 
            this.userlabel1.AutoSize = true;
            this.userlabel1.Depth = 0;
            this.userlabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userlabel1.Location = new System.Drawing.Point(445, 434);
            this.userlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.userlabel1.Name = "userlabel1";
            this.userlabel1.Size = new System.Drawing.Size(107, 19);
            this.userlabel1.TabIndex = 372;
            this.userlabel1.Text = "materialLabel7";
            this.userlabel1.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(100, 736);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(180, 19);
            this.materialLabel6.TabIndex = 374;
            this.materialLabel6.Text = "EMPRESA A PRESENTAR";
            // 
            // TxtEmpresapresentar
            // 
            this.TxtEmpresapresentar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtEmpresapresentar.AnimateReadOnly = false;
            this.TxtEmpresapresentar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtEmpresapresentar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtEmpresapresentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtEmpresapresentar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtEmpresapresentar.Depth = 0;
            this.TxtEmpresapresentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEmpresapresentar.HideSelection = true;
            this.TxtEmpresapresentar.LeadingIcon = null;
            this.TxtEmpresapresentar.Location = new System.Drawing.Point(387, 720);
            this.TxtEmpresapresentar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEmpresapresentar.MaxLength = 32767;
            this.TxtEmpresapresentar.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtEmpresapresentar.Name = "TxtEmpresapresentar";
            this.TxtEmpresapresentar.PasswordChar = '\0';
            this.TxtEmpresapresentar.PrefixSuffixText = null;
            this.TxtEmpresapresentar.ReadOnly = false;
            this.TxtEmpresapresentar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtEmpresapresentar.SelectedText = "";
            this.TxtEmpresapresentar.SelectionLength = 0;
            this.TxtEmpresapresentar.SelectionStart = 0;
            this.TxtEmpresapresentar.ShortcutsEnabled = true;
            this.TxtEmpresapresentar.Size = new System.Drawing.Size(415, 48);
            this.TxtEmpresapresentar.TabIndex = 375;
            this.TxtEmpresapresentar.TabStop = false;
            this.TxtEmpresapresentar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtEmpresapresentar.TrailingIcon = null;
            this.TxtEmpresapresentar.UseSystemPasswordChar = false;
            // 
            // TxtCuit
            // 
            this.TxtCuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtCuit.AnimateReadOnly = false;
            this.TxtCuit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCuit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtCuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCuit.Depth = 0;
            this.TxtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCuit.HideSelection = true;
            this.TxtCuit.LeadingIcon = null;
            this.TxtCuit.Location = new System.Drawing.Point(387, 786);
            this.TxtCuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCuit.MaxLength = 32767;
            this.TxtCuit.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.PasswordChar = '\0';
            this.TxtCuit.PrefixSuffixText = null;
            this.TxtCuit.ReadOnly = false;
            this.TxtCuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCuit.SelectedText = "";
            this.TxtCuit.SelectionLength = 0;
            this.TxtCuit.SelectionStart = 0;
            this.TxtCuit.ShortcutsEnabled = true;
            this.TxtCuit.Size = new System.Drawing.Size(415, 48);
            this.TxtCuit.TabIndex = 377;
            this.TxtCuit.TabStop = false;
            this.TxtCuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCuit.TrailingIcon = null;
            this.TxtCuit.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(100, 802);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(142, 19);
            this.materialLabel7.TabIndex = 376;
            this.materialLabel7.Text = "CUIT A PRESENTAR";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBorrar.Location = new System.Drawing.Point(888, 335);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 39);
            this.btnBorrar.TabIndex = 378;
            this.btnBorrar.Text = "LIMPIAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FrmPuestoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1135, 847);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.TxtEmpresapresentar);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.userlabel2);
            this.Controls.Add(this.userlabel1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.TxtNombreEmpresa);
            this.Controls.Add(this.TxtCuitEmpresa);
            this.Controls.Add(this.BtnBuscarempresa);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.DgvPuestosRecientes);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarresultado);
            this.Controls.Add(this.DtpFechahasta);
            this.Controls.Add(this.DtpFechadesde);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.materialLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPuestoHistorial";
            this.Text = "FrmVistaPuestoEmpleadocs";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestosRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.DateTimePicker DtpFechahasta;
        private System.Windows.Forms.DateTimePicker DtpFechadesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarresultado;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView DgvPuestosRecientes;
        private System.Windows.Forms.Button BtnImprimir;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCuitEmpresa;
        private System.Windows.Forms.Button BtnBuscarempresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 TxtNombreEmpresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel userlabel2;
        private MaterialSkin.Controls.MaterialLabel userlabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 TxtEmpresapresentar;
        private MaterialSkin.Controls.MaterialTextBox2 TxtCuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Button btnBorrar;
    }
}