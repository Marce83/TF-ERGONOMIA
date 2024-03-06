namespace TF.WIN
{
    partial class frmConsultarEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEmpresa));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCargaEmpresas = new System.Windows.Forms.DataGridView();
            this.linkLimpiar = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.cboBuscadorDinamico = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.cboLocalidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cboActEmpr = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cboCondFiscal = new MaterialSkin.Controls.MaterialComboBox();
            this.txtWeb = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombreEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtBuscador = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.dgvCargaEmpresas);
            this.groupBox2.Controls.Add(this.linkLimpiar);
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.dtpFechaAlta);
            this.groupBox2.Controls.Add(this.cboBuscadorDinamico);
            this.groupBox2.Controls.Add(this.materialLabel13);
            this.groupBox2.Controls.Add(this.cboTipo);
            this.groupBox2.Controls.Add(this.materialLabel12);
            this.groupBox2.Controls.Add(this.cboProvincia);
            this.groupBox2.Controls.Add(this.cboLocalidad);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.cboActEmpr);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.cboCondFiscal);
            this.groupBox2.Controls.Add(this.txtWeb);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.txtNombreEmpresa);
            this.groupBox2.Controls.Add(this.btnBaja);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.txtBuscador);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(956, 580);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONSULTAR EMPRESAS CARGADAS";
            // 
            // dgvCargaEmpresas
            // 
            this.dgvCargaEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCargaEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargaEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCargaEmpresas.ColumnHeadersHeight = 25;
            this.dgvCargaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCargaEmpresas.EnableHeadersVisualStyles = false;
            this.dgvCargaEmpresas.Location = new System.Drawing.Point(7, 92);
            this.dgvCargaEmpresas.Name = "dgvCargaEmpresas";
            this.dgvCargaEmpresas.RowHeadersVisible = false;
            this.dgvCargaEmpresas.Size = new System.Drawing.Size(944, 188);
            this.dgvCargaEmpresas.TabIndex = 165;
            this.dgvCargaEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargaEmpresas_CellContentClick);
            // 
            // linkLimpiar
            // 
            this.linkLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLimpiar.AutoSize = true;
            this.linkLimpiar.Location = new System.Drawing.Point(899, 561);
            this.linkLimpiar.Name = "linkLimpiar";
            this.linkLimpiar.Size = new System.Drawing.Size(40, 13);
            this.linkLimpiar.TabIndex = 164;
            this.linkLimpiar.TabStop = true;
            this.linkLimpiar.Text = "Limpiar";
            this.linkLimpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpiar_LinkClicked);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(927, 17);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 108;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaAlta.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(612, 510);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaAlta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(251, 26);
            this.dtpFechaAlta.TabIndex = 77;
            // 
            // cboBuscadorDinamico
            // 
            this.cboBuscadorDinamico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboBuscadorDinamico.AutoResize = false;
            this.cboBuscadorDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboBuscadorDinamico.Depth = 0;
            this.cboBuscadorDinamico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboBuscadorDinamico.DropDownHeight = 174;
            this.cboBuscadorDinamico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscadorDinamico.DropDownWidth = 121;
            this.cboBuscadorDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboBuscadorDinamico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboBuscadorDinamico.FormattingEnabled = true;
            this.cboBuscadorDinamico.IntegralHeight = false;
            this.cboBuscadorDinamico.ItemHeight = 43;
            this.cboBuscadorDinamico.Items.AddRange(new object[] {
            "CUIT",
            "Razón Social"});
            this.cboBuscadorDinamico.Location = new System.Drawing.Point(7, 24);
            this.cboBuscadorDinamico.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscadorDinamico.MaxDropDownItems = 4;
            this.cboBuscadorDinamico.MouseState = MaterialSkin.MouseState.OUT;
            this.cboBuscadorDinamico.Name = "cboBuscadorDinamico";
            this.cboBuscadorDinamico.Size = new System.Drawing.Size(181, 49);
            this.cboBuscadorDinamico.StartIndex = 0;
            this.cboBuscadorDinamico.TabIndex = 107;
            this.cboBuscadorDinamico.SelectedIndexChanged += new System.EventHandler(this.cboBuscadorDinamico_SelectedIndexChanged);
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(466, 508);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(97, 19);
            this.materialLabel13.TabIndex = 78;
            this.materialLabel13.Text = "Fecha de Alta";
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTipo.AutoResize = false;
            this.cboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboTipo.Depth = 0;
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboTipo.DropDownHeight = 174;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.DropDownWidth = 121;
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.ItemHeight = 43;
            this.cboTipo.Items.AddRange(new object[] {
            "Seleccione",
            "PUBLICA",
            "PRIVADA"});
            this.cboTipo.Location = new System.Drawing.Point(163, 464);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(251, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 102;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel12.Location = new System.Drawing.Point(4, 468);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(33, 19);
            this.materialLabel12.TabIndex = 101;
            this.materialLabel12.Text = "Tipo";
            // 
            // cboProvincia
            // 
            this.cboProvincia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboProvincia.AutoResize = false;
            this.cboProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboProvincia.Depth = 0;
            this.cboProvincia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboProvincia.DropDownHeight = 174;
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.DropDownWidth = 121;
            this.cboProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.IntegralHeight = false;
            this.cboProvincia.ItemHeight = 43;
            this.cboProvincia.Items.AddRange(new object[] {
            "Seleccione",
            "Buenos Aires",
            "Ciudad Autónoma de Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego, Antártida e Islas del Atlántico Sur",
            "Tucumán"});
            this.cboProvincia.Location = new System.Drawing.Point(612, 306);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvincia.MaxDropDownItems = 4;
            this.cboProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(251, 49);
            this.cboProvincia.StartIndex = 0;
            this.cboProvincia.TabIndex = 100;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLocalidad.AutoResize = false;
            this.cboLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboLocalidad.Depth = 0;
            this.cboLocalidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboLocalidad.DropDownHeight = 174;
            this.cboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalidad.DropDownWidth = 121;
            this.cboLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.IntegralHeight = false;
            this.cboLocalidad.ItemHeight = 43;
            this.cboLocalidad.Location = new System.Drawing.Point(612, 347);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cboLocalidad.MaxDropDownItems = 4;
            this.cboLocalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(251, 49);
            this.cboLocalidad.StartIndex = 0;
            this.cboLocalidad.TabIndex = 99;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel11.Location = new System.Drawing.Point(466, 308);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(67, 19);
            this.materialLabel11.TabIndex = 98;
            this.materialLabel11.Text = "Provincia";
            // 
            // cboActEmpr
            // 
            this.cboActEmpr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboActEmpr.AutoResize = false;
            this.cboActEmpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboActEmpr.Depth = 0;
            this.cboActEmpr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboActEmpr.DropDownHeight = 174;
            this.cboActEmpr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActEmpr.DropDownWidth = 121;
            this.cboActEmpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboActEmpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboActEmpr.FormattingEnabled = true;
            this.cboActEmpr.IntegralHeight = false;
            this.cboActEmpr.ItemHeight = 43;
            this.cboActEmpr.Items.AddRange(new object[] {
            "Seleccione",
            "AGRICULTURA",
            "ALIMENTACIÓN Y BEBIDAS",
            "AEROESPACIAL",
            "AUTOMOTRIZ",
            "COMERCIO",
            "CONSTRUCCION",
            "MANUFACTURA",
            "SALUD",
            "TELECOMUNICACIONES",
            "TRANSPORTE"});
            this.cboActEmpr.Location = new System.Drawing.Point(163, 411);
            this.cboActEmpr.Margin = new System.Windows.Forms.Padding(2);
            this.cboActEmpr.MaxDropDownItems = 4;
            this.cboActEmpr.MouseState = MaterialSkin.MouseState.OUT;
            this.cboActEmpr.Name = "cboActEmpr";
            this.cboActEmpr.Size = new System.Drawing.Size(251, 49);
            this.cboActEmpr.StartIndex = 0;
            this.cboActEmpr.TabIndex = 96;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel9.Location = new System.Drawing.Point(466, 349);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 97;
            this.materialLabel9.Text = "Localidad";
            // 
            // txtCalle
            // 
            this.txtCalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.HideSelection = true;
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(612, 391);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalle.MaxLength = 32767;
            this.txtCalle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.PasswordChar = '\0';
            this.txtCalle.PrefixSuffixText = null;
            this.txtCalle.ReadOnly = false;
            this.txtCalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCalle.SelectedText = "";
            this.txtCalle.SelectionLength = 0;
            this.txtCalle.SelectionStart = 0;
            this.txtCalle.ShortcutsEnabled = true;
            this.txtCalle.Size = new System.Drawing.Size(250, 48);
            this.txtCalle.TabIndex = 84;
            this.txtCalle.TabStop = false;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(4, 515);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 93;
            this.materialLabel6.Text = "Teléfono";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(466, 389);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 92;
            this.materialLabel5.Text = "Calle";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(163, 517);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PrefixSuffixText = null;
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.ShortcutsEnabled = true;
            this.txtTelefono.Size = new System.Drawing.Size(250, 48);
            this.txtTelefono.TabIndex = 85;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(466, 468);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(129, 19);
            this.materialLabel7.TabIndex = 94;
            this.materialLabel7.Text = "Correo Electrónico";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(4, 420);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 19);
            this.materialLabel4.TabIndex = 91;
            this.materialLabel4.Text = "Actividad empresarial";
            // 
            // cboCondFiscal
            // 
            this.cboCondFiscal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCondFiscal.AutoResize = false;
            this.cboCondFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCondFiscal.Depth = 0;
            this.cboCondFiscal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboCondFiscal.DropDownHeight = 174;
            this.cboCondFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondFiscal.DropDownWidth = 121;
            this.cboCondFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboCondFiscal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboCondFiscal.FormattingEnabled = true;
            this.cboCondFiscal.IntegralHeight = false;
            this.cboCondFiscal.ItemHeight = 43;
            this.cboCondFiscal.Items.AddRange(new object[] {
            "Seleccione",
            "RESPONSABLE INSCRIPTO",
            "MONOTRIBUTO",
            "COMSUMIDOR FINAL"});
            this.cboCondFiscal.Location = new System.Drawing.Point(163, 358);
            this.cboCondFiscal.Margin = new System.Windows.Forms.Padding(2);
            this.cboCondFiscal.MaxDropDownItems = 4;
            this.cboCondFiscal.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCondFiscal.Name = "cboCondFiscal";
            this.cboCondFiscal.Size = new System.Drawing.Size(251, 49);
            this.cboCondFiscal.StartIndex = 0;
            this.cboCondFiscal.TabIndex = 83;
            // 
            // txtWeb
            // 
            this.txtWeb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtWeb.AnimateReadOnly = false;
            this.txtWeb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtWeb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWeb.Depth = 0;
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWeb.HideSelection = true;
            this.txtWeb.LeadingIcon = null;
            this.txtWeb.Location = new System.Drawing.Point(612, 427);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeb.MaxLength = 32767;
            this.txtWeb.MouseState = MaterialSkin.MouseState.OUT;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.PasswordChar = '\0';
            this.txtWeb.PrefixSuffixText = null;
            this.txtWeb.ReadOnly = false;
            this.txtWeb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWeb.SelectedText = "";
            this.txtWeb.SelectionLength = 0;
            this.txtWeb.SelectionStart = 0;
            this.txtWeb.ShortcutsEnabled = true;
            this.txtWeb.Size = new System.Drawing.Size(250, 48);
            this.txtWeb.TabIndex = 86;
            this.txtWeb.TabStop = false;
            this.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWeb.TrailingIcon = null;
            this.txtWeb.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(4, 320);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 89;
            this.materialLabel2.Text = "Razon Social";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel8.Location = new System.Drawing.Point(466, 425);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(68, 19);
            this.materialLabel8.TabIndex = 95;
            this.materialLabel8.Text = "Sitio Web";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(4, 371);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 90;
            this.materialLabel3.Text = "Condición Fiscal";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(612, 468);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PrefixSuffixText = null;
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.Size = new System.Drawing.Size(250, 48);
            this.txtCorreo.TabIndex = 87;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreEmpresa.AnimateReadOnly = false;
            this.txtNombreEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpresa.HideSelection = true;
            this.txtNombreEmpresa.LeadingIcon = null;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(163, 306);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.PrefixSuffixText = null;
            this.txtNombreEmpresa.ReadOnly = false;
            this.txtNombreEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.ShortcutsEnabled = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(250, 48);
            this.txtNombreEmpresa.TabIndex = 82;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpresa.TrailingIcon = null;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaja.BackColor = System.Drawing.Color.Red;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBaja.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaja.Location = new System.Drawing.Point(802, 24);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(116, 49);
            this.btnBaja.TabIndex = 66;
            this.btnBaja.Text = "BAJA";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(682, 24);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 48);
            this.btnModificar.TabIndex = 65;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscador.AnimateReadOnly = false;
            this.txtBuscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscador.Depth = 0;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscador.HideSelection = true;
            this.txtBuscador.LeadingIcon = null;
            this.txtBuscador.Location = new System.Drawing.Point(211, 24);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscador.MaxLength = 11;
            this.txtBuscador.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PasswordChar = '\0';
            this.txtBuscador.PrefixSuffixText = null;
            this.txtBuscador.ReadOnly = false;
            this.txtBuscador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.SelectionLength = 0;
            this.txtBuscador.SelectionStart = 0;
            this.txtBuscador.ShortcutsEnabled = true;
            this.txtBuscador.Size = new System.Drawing.Size(322, 48);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TabStop = false;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscador.TrailingIcon = null;
            this.txtBuscador.UseSystemPasswordChar = false;
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(555, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 48);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(981, 618);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarEmpresa";
            this.Text = "frmConsultarEmpresa";
            this.Load += new System.EventHandler(this.frmConsultarEmpresa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private MaterialSkin.Controls.MaterialComboBox cboTipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialComboBox cboLocalidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialComboBox cboActEmpr;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox2 txtCalle;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox cboCondFiscal;
        private MaterialSkin.Controls.MaterialTextBox2 txtWeb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpresa;
        private MaterialSkin.Controls.MaterialComboBox cboBuscadorDinamico;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.LinkLabel linkLimpiar;
        private System.Windows.Forms.DataGridView dgvCargaEmpresas;
    }
}