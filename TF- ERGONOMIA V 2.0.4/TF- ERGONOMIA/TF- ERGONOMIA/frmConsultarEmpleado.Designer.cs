namespace TF.WIN
{
    partial class frmConsultarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbEmpresa = new System.Windows.Forms.GroupBox();
            this.txtNomEmp = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUITEncontrado = new MaterialSkin.Controls.MaterialTextBox2();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.cboBuscadorDinamico = new MaterialSkin.Controls.MaterialComboBox();
            this.cboAreaempresa = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarCUIT = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAltura = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPeso = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscador = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.linkLimpiar = new System.Windows.Forms.LinkLabel();
            this.groupBox3.SuspendLayout();
            this.grbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.linkLimpiar);
            this.groupBox3.Controls.Add(this.grbEmpresa);
            this.groupBox3.Controls.Add(this.btnCerrar);
            this.groupBox3.Controls.Add(this.cboBuscadorDinamico);
            this.groupBox3.Controls.Add(this.cboAreaempresa);
            this.groupBox3.Controls.Add(this.materialLabel9);
            this.groupBox3.Controls.Add(this.dtpIngreso);
            this.groupBox3.Controls.Add(this.materialLabel7);
            this.groupBox3.Controls.Add(this.btnBuscarCUIT);
            this.groupBox3.Controls.Add(this.dtpNacimiento);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.cboGenero);
            this.groupBox3.Controls.Add(this.materialLabel4);
            this.groupBox3.Controls.Add(this.materialLabel8);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.materialLabel2);
            this.groupBox3.Controls.Add(this.materialLabel1);
            this.groupBox3.Controls.Add(this.txtBuscador);
            this.groupBox3.Controls.Add(this.btnBaja);
            this.groupBox3.Controls.Add(this.btnModificar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.dgvEmpleados);
            this.groupBox3.Location = new System.Drawing.Point(11, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(929, 640);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONSULTAR EMPLEADOS CARGADOS";
            // 
            // grbEmpresa
            // 
            this.grbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbEmpresa.Controls.Add(this.txtNomEmp);
            this.grbEmpresa.Controls.Add(this.materialLabel11);
            this.grbEmpresa.Controls.Add(this.txtCUITEncontrado);
            this.grbEmpresa.Controls.Add(this.button1);
            this.grbEmpresa.Location = new System.Drawing.Point(470, 299);
            this.grbEmpresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmpresa.Name = "grbEmpresa";
            this.grbEmpresa.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmpresa.Size = new System.Drawing.Size(300, 145);
            this.grbEmpresa.TabIndex = 111;
            this.grbEmpresa.TabStop = false;
            this.grbEmpresa.Text = "Empresa";
            // 
            // txtNomEmp
            // 
            this.txtNomEmp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNomEmp.AnimateReadOnly = false;
            this.txtNomEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNomEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNomEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNomEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNomEmp.Depth = 0;
            this.txtNomEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomEmp.HideSelection = true;
            this.txtNomEmp.LeadingIcon = null;
            this.txtNomEmp.Location = new System.Drawing.Point(47, 76);
            this.txtNomEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomEmp.MaxLength = 32767;
            this.txtNomEmp.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomEmp.Name = "txtNomEmp";
            this.txtNomEmp.PasswordChar = '\0';
            this.txtNomEmp.PrefixSuffixText = null;
            this.txtNomEmp.ReadOnly = true;
            this.txtNomEmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNomEmp.SelectedText = "";
            this.txtNomEmp.SelectionLength = 0;
            this.txtNomEmp.SelectionStart = 0;
            this.txtNomEmp.ShortcutsEnabled = true;
            this.txtNomEmp.Size = new System.Drawing.Size(166, 48);
            this.txtNomEmp.TabIndex = 92;
            this.txtNomEmp.TabStop = false;
            this.txtNomEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNomEmp.TrailingIcon = null;
            this.txtNomEmp.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(11, 33);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(35, 19);
            this.materialLabel11.TabIndex = 89;
            this.materialLabel11.Text = "CUIT";
            // 
            // txtCUITEncontrado
            // 
            this.txtCUITEncontrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCUITEncontrado.AnimateReadOnly = false;
            this.txtCUITEncontrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCUITEncontrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCUITEncontrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUITEncontrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUITEncontrado.Depth = 0;
            this.txtCUITEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUITEncontrado.HideSelection = true;
            this.txtCUITEncontrado.LeadingIcon = null;
            this.txtCUITEncontrado.Location = new System.Drawing.Point(47, 23);
            this.txtCUITEncontrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCUITEncontrado.MaxLength = 32767;
            this.txtCUITEncontrado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCUITEncontrado.Name = "txtCUITEncontrado";
            this.txtCUITEncontrado.PasswordChar = '\0';
            this.txtCUITEncontrado.PrefixSuffixText = null;
            this.txtCUITEncontrado.ReadOnly = true;
            this.txtCUITEncontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCUITEncontrado.SelectedText = "";
            this.txtCUITEncontrado.SelectionLength = 0;
            this.txtCUITEncontrado.SelectionStart = 0;
            this.txtCUITEncontrado.ShortcutsEnabled = true;
            this.txtCUITEncontrado.Size = new System.Drawing.Size(166, 48);
            this.txtCUITEncontrado.TabIndex = 83;
            this.txtCUITEncontrado.TabStop = false;
            this.txtCUITEncontrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUITEncontrado.TrailingIcon = null;
            this.txtCUITEncontrado.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(230, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 39);
            this.button1.TabIndex = 91;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(907, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 109;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            "DNI",
            "Nombre",
            "Apellido"});
            this.cboBuscadorDinamico.Location = new System.Drawing.Point(21, 45);
            this.cboBuscadorDinamico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboBuscadorDinamico.MaxDropDownItems = 4;
            this.cboBuscadorDinamico.MouseState = MaterialSkin.MouseState.OUT;
            this.cboBuscadorDinamico.Name = "cboBuscadorDinamico";
            this.cboBuscadorDinamico.Size = new System.Drawing.Size(146, 49);
            this.cboBuscadorDinamico.StartIndex = 0;
            this.cboBuscadorDinamico.TabIndex = 108;
            // 
            // cboAreaempresa
            // 
            this.cboAreaempresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboAreaempresa.AutoResize = false;
            this.cboAreaempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboAreaempresa.Depth = 0;
            this.cboAreaempresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboAreaempresa.DropDownHeight = 174;
            this.cboAreaempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaempresa.DropDownWidth = 121;
            this.cboAreaempresa.Enabled = false;
            this.cboAreaempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboAreaempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboAreaempresa.FormattingEnabled = true;
            this.cboAreaempresa.IntegralHeight = false;
            this.cboAreaempresa.ItemHeight = 43;
            this.cboAreaempresa.Items.AddRange(new object[] {
            "Seleccione",
            "Dirección General",
            "Administración",
            "Recursos Humanos",
            "Comercialización",
            "Producción",
            "Logística",
            "Finanzas y Contabilidad",
            "Marketing",
            "Informática",
            "Mantenimiento",
            "Legales"});
            this.cboAreaempresa.Location = new System.Drawing.Point(612, 579);
            this.cboAreaempresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboAreaempresa.MaxDropDownItems = 4;
            this.cboAreaempresa.MouseState = MaterialSkin.MouseState.OUT;
            this.cboAreaempresa.Name = "cboAreaempresa";
            this.cboAreaempresa.Size = new System.Drawing.Size(206, 49);
            this.cboAreaempresa.StartIndex = 0;
            this.cboAreaempresa.TabIndex = 95;
            this.cboAreaempresa.Visible = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Enabled = false;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(467, 595);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(136, 19);
            this.materialLabel9.TabIndex = 94;
            this.materialLabel9.Text = "Área de la empresa";
            this.materialLabel9.Visible = false;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpIngreso.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.Location = new System.Drawing.Point(163, 497);
            this.dtpIngreso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpIngreso.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(188, 26);
            this.dtpIngreso.TabIndex = 92;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 497);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(121, 19);
            this.materialLabel7.TabIndex = 93;
            this.materialLabel7.Text = "Fecha de Ingreso";
            // 
            // btnBuscarCUIT
            // 
            this.btnBuscarCUIT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCUIT.FlatAppearance.BorderSize = 0;
            this.btnBuscarCUIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCUIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCUIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCUIT.Location = new System.Drawing.Point(1052, 373);
            this.btnBuscarCUIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCUIT.Name = "btnBuscarCUIT";
            this.btnBuscarCUIT.Size = new System.Drawing.Size(89, 59);
            this.btnBuscarCUIT.TabIndex = 91;
            this.btnBuscarCUIT.Text = "...";
            this.btnBuscarCUIT.UseVisualStyleBackColor = false;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(163, 408);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(188, 26);
            this.dtpNacimiento.TabIndex = 81;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtAltura);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialLabel5);
            this.groupBox2.Controls.Add(this.txtPeso);
            this.groupBox2.Location = new System.Drawing.Point(427, 481);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(376, 94);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información para Metodos de Analisis";
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(335, 37);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(25, 19);
            this.materialLabel10.TabIndex = 82;
            this.materialLabel10.Text = "CM";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(154, 37);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(22, 19);
            this.materialLabel3.TabIndex = 81;
            this.materialLabel3.Text = "KG";
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAltura.AnimateReadOnly = false;
            this.txtAltura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAltura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAltura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAltura.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAltura.Depth = 0;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAltura.HideSelection = true;
            this.txtAltura.LeadingIcon = null;
            this.txtAltura.Location = new System.Drawing.Point(257, 24);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltura.MaxLength = 32767;
            this.txtAltura.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.PrefixSuffixText = null;
            this.txtAltura.ReadOnly = false;
            this.txtAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.ShortcutsEnabled = true;
            this.txtAltura.Size = new System.Drawing.Size(74, 48);
            this.txtAltura.TabIndex = 1;
            this.txtAltura.TabStop = false;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAltura.TrailingIcon = null;
            this.txtAltura.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(13, 37);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(36, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Peso";
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(204, 37);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Altura";
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPeso.AnimateReadOnly = false;
            this.txtPeso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPeso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPeso.Depth = 0;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.HideSelection = true;
            this.txtPeso.LeadingIcon = null;
            this.txtPeso.Location = new System.Drawing.Point(75, 24);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PrefixSuffixText = null;
            this.txtPeso.ReadOnly = false;
            this.txtPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.ShortcutsEnabled = true;
            this.txtPeso.Size = new System.Drawing.Size(74, 48);
            this.txtPeso.TabIndex = 0;
            this.txtPeso.TabStop = false;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPeso.TrailingIcon = null;
            this.txtPeso.UseSystemPasswordChar = false;
            // 
            // cboGenero
            // 
            this.cboGenero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboGenero.AutoResize = false;
            this.cboGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboGenero.Depth = 0;
            this.cboGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboGenero.DropDownHeight = 174;
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.DropDownWidth = 121;
            this.cboGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.IntegralHeight = false;
            this.cboGenero.ItemHeight = 43;
            this.cboGenero.Items.AddRange(new object[] {
            "Seleccione",
            "Masculino",
            "Femenino",
            "Otros"});
            this.cboGenero.Location = new System.Drawing.Point(162, 445);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGenero.MaxDropDownItems = 4;
            this.cboGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(190, 49);
            this.cboGenero.StartIndex = 0;
            this.cboGenero.TabIndex = 82;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(18, 450);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 87;
            this.materialLabel4.Text = "Genero";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(17, 407);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 88;
            this.materialLabel8.Text = "Fecha Nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellido.Depth = 0;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellido.HideSelection = true;
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.Location = new System.Drawing.Point(163, 315);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.PrefixSuffixText = null;
            this.txtApellido.ReadOnly = false;
            this.txtApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(188, 48);
            this.txtApellido.TabIndex = 79;
            this.txtApellido.TabStop = false;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(163, 358);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PrefixSuffixText = null;
            this.txtNombre.ReadOnly = false;
            this.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(188, 48);
            this.txtNombre.TabIndex = 80;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 316);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 85;
            this.materialLabel2.Text = "Apellido";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 361);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 84;
            this.materialLabel1.Text = "Nombre";
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
            this.txtBuscador.Location = new System.Drawing.Point(194, 46);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscador.MaxLength = 32767;
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
            this.txtBuscador.Size = new System.Drawing.Size(188, 48);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.TabStop = false;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscador.TrailingIcon = null;
            this.txtBuscador.UseSystemPasswordChar = false;
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaja.BackColor = System.Drawing.Color.Red;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.Location = new System.Drawing.Point(773, 45);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(116, 49);
            this.btnBaja.TabIndex = 2;
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
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(651, 45);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 49);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "ACTUALIZAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(407, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 49);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeight = 25;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.Location = new System.Drawing.Point(4, 107);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(885, 177);
            this.dgvEmpleados.TabIndex = 57;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // linkLimpiar
            // 
            this.linkLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLimpiar.AutoSize = true;
            this.linkLimpiar.Location = new System.Drawing.Point(886, 615);
            this.linkLimpiar.Name = "linkLimpiar";
            this.linkLimpiar.Size = new System.Drawing.Size(40, 13);
            this.linkLimpiar.TabIndex = 165;
            this.linkLimpiar.TabStop = true;
            this.linkLimpiar.Text = "Limpiar";
            this.linkLimpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpiar_LinkClicked);
            // 
            // frmConsultarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(951, 677);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultarEmpleado";
            this.Text = "frmConsultarEmpleado";
            this.Load += new System.EventHandler(this.frmConsultarEmpleado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbEmpresa.ResumeLayout(false);
            this.grbEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscador;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private MaterialSkin.Controls.MaterialComboBox cboAreaempresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Button btnBuscarCUIT;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox2 txtAltura;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtPeso;
        private MaterialSkin.Controls.MaterialComboBox cboGenero;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellido;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private MaterialSkin.Controls.MaterialComboBox cboBuscadorDinamico;
        private System.Windows.Forms.GroupBox grbEmpresa;
        private MaterialSkin.Controls.MaterialTextBox2 txtNomEmp;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUITEncontrado;
        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.LinkLabel linkLimpiar;
    }
}