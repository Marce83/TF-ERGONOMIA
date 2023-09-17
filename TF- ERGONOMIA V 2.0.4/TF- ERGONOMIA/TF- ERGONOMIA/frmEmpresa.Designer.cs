namespace TF.WIN
{
    partial class frmEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUIT = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombreEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtWeb = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboCondFiscal = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCalle = new MaterialSkin.Controls.MaterialTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCodPos = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumeracion = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.cboLocalidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscartodo = new System.Windows.Forms.Button();
            this.dgvCargaEmpresas = new System.Windows.Forms.DataGridView();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtcuitconsultacuit = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboActEmpr = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnModificar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificar.Location = new System.Drawing.Point(1091, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCargar.Location = new System.Drawing.Point(184, 429);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(116, 35);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBaja.FlatAppearance.BorderSize = 0;
            this.btnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBaja.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaja.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBaja.Location = new System.Drawing.Point(1223, 19);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(116, 35);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(25, 53);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(35, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "CUIT";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(25, 106);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Razon Social";
            // 
            // txtCUIT
            // 
            this.txtCUIT.AnimateReadOnly = false;
            this.txtCUIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUIT.Depth = 0;
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUIT.HideSelection = true;
            this.txtCUIT.LeadingIcon = null;
            this.txtCUIT.Location = new System.Drawing.Point(184, 40);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCUIT.MaxLength = 11;
            this.txtCUIT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.PasswordChar = '\0';
            this.txtCUIT.PrefixSuffixText = null;
            this.txtCUIT.ReadOnly = false;
            this.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCUIT.SelectedText = "";
            this.txtCUIT.SelectionLength = 0;
            this.txtCUIT.SelectionStart = 0;
            this.txtCUIT.ShortcutsEnabled = true;
            this.txtCUIT.Size = new System.Drawing.Size(517, 48);
            this.txtCUIT.TabIndex = 0;
            this.txtCUIT.TabStop = false;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUIT.TrailingIcon = null;
            this.txtCUIT.UseSystemPasswordChar = false;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(906, 366);
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
            this.txtCorreo.Size = new System.Drawing.Size(433, 48);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.AnimateReadOnly = false;
            this.txtNombreEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpresa.HideSelection = true;
            this.txtNombreEmpresa.LeadingIcon = null;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(184, 92);
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
            this.txtNombreEmpresa.Size = new System.Drawing.Size(517, 48);
            this.txtNombreEmpresa.TabIndex = 1;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpresa.TrailingIcon = null;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(25, 157);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "Condición Fiscal";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel8.Location = new System.Drawing.Point(749, 314);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(68, 19);
            this.materialLabel8.TabIndex = 41;
            this.materialLabel8.Text = "Sitio Web";
            // 
            // txtWeb
            // 
            this.txtWeb.AnimateReadOnly = false;
            this.txtWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWeb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtWeb.Depth = 0;
            this.txtWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWeb.HideSelection = true;
            this.txtWeb.LeadingIcon = null;
            this.txtWeb.Location = new System.Drawing.Point(906, 315);
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
            this.txtWeb.Size = new System.Drawing.Size(433, 48);
            this.txtWeb.TabIndex = 6;
            this.txtWeb.TabStop = false;
            this.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWeb.TrailingIcon = null;
            this.txtWeb.UseSystemPasswordChar = false;
            // 
            // cboCondFiscal
            // 
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
            "Responsable Inscripto",
            "Monotributo",
            "Consumidor Final"});
            this.cboCondFiscal.Location = new System.Drawing.Point(184, 144);
            this.cboCondFiscal.Margin = new System.Windows.Forms.Padding(2);
            this.cboCondFiscal.MaxDropDownItems = 4;
            this.cboCondFiscal.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCondFiscal.Name = "cboCondFiscal";
            this.cboCondFiscal.Size = new System.Drawing.Size(517, 49);
            this.cboCondFiscal.StartIndex = 0;
            this.cboCondFiscal.TabIndex = 2;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(25, 206);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Actividad empresarial";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(749, 367);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(129, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Correo Electrónico";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.HideSelection = true;
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(184, 303);
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
            this.txtTelefono.Size = new System.Drawing.Size(517, 48);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(750, 157);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Calle";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(25, 313);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Teléfono";
            // 
            // txtCalle
            // 
            this.txtCalle.AnimateReadOnly = false;
            this.txtCalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCalle.Depth = 0;
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCalle.HideSelection = true;
            this.txtCalle.LeadingIcon = null;
            this.txtCalle.Location = new System.Drawing.Point(907, 154);
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
            this.txtCalle.Size = new System.Drawing.Size(432, 48);
            this.txtCalle.TabIndex = 4;
            this.txtCalle.TabStop = false;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(526, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "CARGA DE EMPRESAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtCodPos);
            this.groupBox1.Controls.Add(this.materialLabel15);
            this.groupBox1.Controls.Add(this.txtNumeracion);
            this.groupBox1.Controls.Add(this.materialLabel14);
            this.groupBox1.Controls.Add(this.dtpFechaAlta);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.cboTipo);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.cboLocalidad);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.cboActEmpr);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.cboCondFiscal);
            this.groupBox1.Controls.Add(this.txtWeb);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.txtCUIT);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNombreEmpresa);
            this.groupBox1.Location = new System.Drawing.Point(22, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1343, 484);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR EMPRESA";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiar.Location = new System.Drawing.Point(585, 429);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 35);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCodPos
            // 
            this.txtCodPos.AnimateReadOnly = false;
            this.txtCodPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCodPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCodPos.Depth = 0;
            this.txtCodPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodPos.HideSelection = true;
            this.txtCodPos.LeadingIcon = null;
            this.txtCodPos.Location = new System.Drawing.Point(907, 264);
            this.txtCodPos.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodPos.MaxLength = 32767;
            this.txtCodPos.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.PasswordChar = '\0';
            this.txtCodPos.PrefixSuffixText = null;
            this.txtCodPos.ReadOnly = false;
            this.txtCodPos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodPos.SelectedText = "";
            this.txtCodPos.SelectionLength = 0;
            this.txtCodPos.SelectionStart = 0;
            this.txtCodPos.ShortcutsEnabled = true;
            this.txtCodPos.Size = new System.Drawing.Size(432, 48);
            this.txtCodPos.TabIndex = 79;
            this.txtCodPos.TabStop = false;
            this.txtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodPos.TrailingIcon = null;
            this.txtCodPos.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel15.Location = new System.Drawing.Point(750, 266);
            this.materialLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(100, 19);
            this.materialLabel15.TabIndex = 80;
            this.materialLabel15.Text = "Código Postal";
            // 
            // txtNumeracion
            // 
            this.txtNumeracion.AnimateReadOnly = false;
            this.txtNumeracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNumeracion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNumeracion.Depth = 0;
            this.txtNumeracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeracion.HideSelection = true;
            this.txtNumeracion.LeadingIcon = null;
            this.txtNumeracion.Location = new System.Drawing.Point(907, 206);
            this.txtNumeracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeracion.MaxLength = 32767;
            this.txtNumeracion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeracion.Name = "txtNumeracion";
            this.txtNumeracion.PasswordChar = '\0';
            this.txtNumeracion.PrefixSuffixText = null;
            this.txtNumeracion.ReadOnly = false;
            this.txtNumeracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNumeracion.SelectedText = "";
            this.txtNumeracion.SelectionLength = 0;
            this.txtNumeracion.SelectionStart = 0;
            this.txtNumeracion.ShortcutsEnabled = true;
            this.txtNumeracion.Size = new System.Drawing.Size(432, 48);
            this.txtNumeracion.TabIndex = 77;
            this.txtNumeracion.TabStop = false;
            this.txtNumeracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNumeracion.TrailingIcon = null;
            this.txtNumeracion.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel14.Location = new System.Drawing.Point(750, 208);
            this.materialLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(87, 19);
            this.materialLabel14.TabIndex = 78;
            this.materialLabel14.Text = "Numeración";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaAlta.Location = new System.Drawing.Point(906, 438);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaAlta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(433, 26);
            this.dtpFechaAlta.TabIndex = 75;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(749, 438);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(97, 19);
            this.materialLabel13.TabIndex = 76;
            this.materialLabel13.Text = "Fecha de Alta";
            // 
            // cboTipo
            // 
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
            this.cboTipo.Location = new System.Drawing.Point(184, 250);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(517, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 50;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel12.Location = new System.Drawing.Point(25, 259);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(33, 19);
            this.materialLabel12.TabIndex = 49;
            this.materialLabel12.Text = "Tipo";
            // 
            // cboProvincia
            // 
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
            this.cboProvincia.Location = new System.Drawing.Point(907, 50);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cboProvincia.MaxDropDownItems = 4;
            this.cboProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(432, 49);
            this.cboProvincia.StartIndex = 0;
            this.cboProvincia.TabIndex = 48;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // cboLocalidad
            // 
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
            this.cboLocalidad.Location = new System.Drawing.Point(907, 100);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cboLocalidad.MaxDropDownItems = 4;
            this.cboLocalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(432, 49);
            this.cboLocalidad.StartIndex = 0;
            this.cboLocalidad.TabIndex = 47;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel11.Location = new System.Drawing.Point(750, 53);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(67, 19);
            this.materialLabel11.TabIndex = 46;
            this.materialLabel11.Text = "Provincia";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel9.Location = new System.Drawing.Point(750, 104);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Localidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscartodo);
            this.groupBox2.Controls.Add(this.dgvCargaEmpresas);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.txtcuitconsultacuit);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnBaja);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Location = new System.Drawing.Point(22, 555);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1343, 219);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONSULTAR EMPRESAS CARGADAS";
            // 
            // btnBuscartodo
            // 
            this.btnBuscartodo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscartodo.FlatAppearance.BorderSize = 0;
            this.btnBuscartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscartodo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscartodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscartodo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscartodo.Location = new System.Drawing.Point(959, 19);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(116, 35);
            this.btnBuscartodo.TabIndex = 58;
            this.btnBuscartodo.Text = "Buscar Todo";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            // 
            // dgvCargaEmpresas
            // 
            this.dgvCargaEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargaEmpresas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCargaEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCargaEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCargaEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargaEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCargaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaEmpresas.EnableHeadersVisualStyles = false;
            this.dgvCargaEmpresas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCargaEmpresas.Location = new System.Drawing.Point(4, 58);
            this.dgvCargaEmpresas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCargaEmpresas.Name = "dgvCargaEmpresas";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargaEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCargaEmpresas.RowHeadersVisible = false;
            this.dgvCargaEmpresas.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCargaEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCargaEmpresas.RowTemplate.Height = 24;
            this.dgvCargaEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargaEmpresas.Size = new System.Drawing.Size(1335, 153);
            this.dgvCargaEmpresas.TabIndex = 57;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel10.Location = new System.Drawing.Point(232, 28);
            this.materialLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(35, 19);
            this.materialLabel10.TabIndex = 53;
            this.materialLabel10.Text = "CUIT";
            // 
            // txtcuitconsultacuit
            // 
            this.txtcuitconsultacuit.AnimateReadOnly = false;
            this.txtcuitconsultacuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcuitconsultacuit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcuitconsultacuit.Depth = 0;
            this.txtcuitconsultacuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcuitconsultacuit.HideSelection = true;
            this.txtcuitconsultacuit.LeadingIcon = null;
            this.txtcuitconsultacuit.Location = new System.Drawing.Point(292, 16);
            this.txtcuitconsultacuit.Margin = new System.Windows.Forms.Padding(2);
            this.txtcuitconsultacuit.MaxLength = 11;
            this.txtcuitconsultacuit.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcuitconsultacuit.Name = "txtcuitconsultacuit";
            this.txtcuitconsultacuit.PasswordChar = '\0';
            this.txtcuitconsultacuit.PrefixSuffixText = null;
            this.txtcuitconsultacuit.ReadOnly = false;
            this.txtcuitconsultacuit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcuitconsultacuit.SelectedText = "";
            this.txtcuitconsultacuit.SelectionLength = 0;
            this.txtcuitconsultacuit.SelectionStart = 0;
            this.txtcuitconsultacuit.ShortcutsEnabled = true;
            this.txtcuitconsultacuit.Size = new System.Drawing.Size(170, 48);
            this.txtcuitconsultacuit.TabIndex = 0;
            this.txtcuitconsultacuit.TabStop = false;
            this.txtcuitconsultacuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcuitconsultacuit.TrailingIcon = null;
            this.txtcuitconsultacuit.UseSystemPasswordChar = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscar.Location = new System.Drawing.Point(825, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar por CUIT";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultar.Location = new System.Drawing.Point(387, 429);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 35);
            this.btnConsultar.TabIndex = 81;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // cboActEmpr
            // 
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
            "Actividades Administrativas Y Servicios De Apoyo",
            "Administración Publica, Defensa Y Seguridad Social Obligatoria",
            "Agricultura, Ganadería, Caza, Silvicultura Y Pesca",
            "Comercio Al Por Mayor Y Al Por Menor",
            "Reparación De Vehículos Automotores Y Motocicletas",
            "Construcción",
            "Enseñanza",
            "Explotación De Minas Y Canteras",
            "Industria Manufacturera",
            "Información Y Comunicaciones",
            "Intermediación Financiera Y Servicios De Seguros",
            "Salud Humana Y Servicios Sociales",
            "Servicios Artísticos, Culturales, Deportivos Y De Esparcimiento",
            "Servicios De Alojamiento Y Servicios De Comida",
            "Servicios De Asociaciones Y Servicios Personales",
            "Servicios De Hogares Privados Que Contratan Servicio Domestico",
            "Servicios De Organizaciones Y Órganos Extraterritoriales",
            "Servicios De Transporte Y Almacenamiento",
            "Servicios Inmobiliarios",
            "Servicios Profesionales, Científicos Y Técnicos",
            "Suministro De Agua, Cloacas, Gestión De Residuos",
            "Suministro De Electricidad, Gas, Vapor Y Aire Acondicionado"});
            this.cboActEmpr.Location = new System.Drawing.Point(184, 197);
            this.cboActEmpr.Margin = new System.Windows.Forms.Padding(2);
            this.cboActEmpr.MaxDropDownItems = 4;
            this.cboActEmpr.MouseState = MaterialSkin.MouseState.OUT;
            this.cboActEmpr.Name = "cboActEmpr";
            this.cboActEmpr.Size = new System.Drawing.Size(517, 49);
            this.cboActEmpr.StartIndex = 0;
            this.cboActEmpr.TabIndex = 42;
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1420, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CargaEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBaja;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUIT;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpresa;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtWeb;
        private MaterialSkin.Controls.MaterialComboBox cboCondFiscal;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtCalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialComboBox cboLocalidad;
        private MaterialSkin.Controls.MaterialComboBox cboTipo;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox2 txtNumeracion;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialTextBox2 txtCodPos;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscartodo;
        private System.Windows.Forms.DataGridView dgvCargaEmpresas;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTextBox2 txtcuitconsultacuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConsultar;
        private MaterialSkin.Controls.MaterialComboBox cboActEmpr;
    }
}