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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUIT = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtWeb = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboCondFiscal = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvCargaEmpresas = new System.Windows.Forms.DataGridView();
            this.txtcuitconsultacuit = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.cboLocalidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtActEmpr = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscartodo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnModificar.Location = new System.Drawing.Point(914, 141);
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
            this.btnCargar.Location = new System.Drawing.Point(914, 91);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(116, 35);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Registrar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminar.Location = new System.Drawing.Point(914, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.txtCUIT.Location = new System.Drawing.Point(182, 41);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtCUIT.Size = new System.Drawing.Size(188, 48);
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
            this.txtCorreo.Location = new System.Drawing.Point(624, 255);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtCorreo.Size = new System.Drawing.Size(208, 48);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtNombre
            // 
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(182, 92);
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
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
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
            this.materialLabel8.Location = new System.Drawing.Point(392, 206);
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
            this.txtWeb.Location = new System.Drawing.Point(624, 197);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtWeb.Size = new System.Drawing.Size(208, 48);
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
            this.cboCondFiscal.Location = new System.Drawing.Point(182, 144);
            this.cboCondFiscal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCondFiscal.MaxDropDownItems = 4;
            this.cboCondFiscal.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCondFiscal.Name = "cboCondFiscal";
            this.cboCondFiscal.Size = new System.Drawing.Size(188, 49);
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
            this.materialLabel7.Location = new System.Drawing.Point(392, 266);
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
            this.txtTelefono.Location = new System.Drawing.Point(182, 255);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtTelefono.Size = new System.Drawing.Size(188, 48);
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
            this.materialLabel5.Location = new System.Drawing.Point(392, 53);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(223, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Dirección ( Calle y Numeración)";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(25, 266);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AnimateReadOnly = false;
            this.txtDireccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.HideSelection = true;
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(624, 41);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PrefixSuffixText = null;
            this.txtDireccion.ReadOnly = false;
            this.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.ShortcutsEnabled = true;
            this.txtDireccion.Size = new System.Drawing.Size(208, 48);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TabStop = false;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.TrailingIcon = null;
            this.txtDireccion.UseSystemPasswordChar = false;
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
            this.btnBuscar.Location = new System.Drawing.Point(467, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 35);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar por CUIT";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvCargaEmpresas
            // 
            this.dgvCargaEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargaEmpresas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCargaEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCargaEmpresas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvCargaEmpresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargaEmpresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCargaEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargaEmpresas.EnableHeadersVisualStyles = false;
            this.dgvCargaEmpresas.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCargaEmpresas.Location = new System.Drawing.Point(4, 58);
            this.dgvCargaEmpresas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCargaEmpresas.Name = "dgvCargaEmpresas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargaEmpresas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCargaEmpresas.RowHeadersVisible = false;
            this.dgvCargaEmpresas.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCargaEmpresas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCargaEmpresas.RowTemplate.Height = 24;
            this.dgvCargaEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargaEmpresas.Size = new System.Drawing.Size(803, 273);
            this.dgvCargaEmpresas.TabIndex = 57;
            this.dgvCargaEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargaEmpresas_CellContentClick);
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
            this.txtcuitconsultacuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtcuitconsultacuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuitconsultacuit_KeyPress);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(204, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(577, 31);
            this.label1.TabIndex = 59;
            this.label1.Text = "REGISTRAR Y CONSULTAR DE EMPRESAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboProvincia);
            this.groupBox1.Controls.Add(this.cboLocalidad);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.txtActEmpr);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtDireccion);
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
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(22, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(869, 324);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR EMPRESA";
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
            this.cboProvincia.Location = new System.Drawing.Point(624, 144);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboProvincia.MaxDropDownItems = 4;
            this.cboProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(209, 49);
            this.cboProvincia.StartIndex = 0;
            this.cboProvincia.TabIndex = 48;
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
            this.cboLocalidad.Items.AddRange(new object[] {
            "Seleccione",
            "Buenos Aires\t",
            "Córdoba",
            "Rosario\t",
            "Mar del Plata",
            "San Miguel de Tucumán",
            "Salta",
            "Santa Fe",
            "Corrientes",
            "Bahía Blanca",
            "Resistencia",
            "Posadas",
            "Merlo de Buenos Aires",
            "Quilmes",
            "San Salvador de Jujuy",
            "Guaymallén",
            "Santiago del Estero",
            "Gregorio de Laferrere",
            "José C. Paz",
            "Paraná",
            "Banfield",
            "González Catán\t",
            "Neuquén",
            "Formosa",
            "Lanús\t",
            "La Plata\t",
            "Godoy Cruz",
            "Isidro Casanova",
            "Las Heras",
            "Berazategui",
            "La Rioja",
            "Comodoro Rivadavia",
            "Moreno",
            "San Luis",
            "San Miguel de Buenos Aires",
            "San Fernando del Valle de Catamarca",
            "Río Cuarto",
            "Virrey del Pino"});
            this.cboLocalidad.Location = new System.Drawing.Point(624, 92);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboLocalidad.MaxDropDownItems = 4;
            this.cboLocalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(209, 49);
            this.cboLocalidad.StartIndex = 0;
            this.cboLocalidad.TabIndex = 47;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel11.Location = new System.Drawing.Point(392, 157);
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
            this.materialLabel9.Location = new System.Drawing.Point(392, 106);
            this.materialLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Localidad";
            // 
            // txtActEmpr
            // 
            this.txtActEmpr.AutoResize = false;
            this.txtActEmpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtActEmpr.Depth = 0;
            this.txtActEmpr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtActEmpr.DropDownHeight = 174;
            this.txtActEmpr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtActEmpr.DropDownWidth = 121;
            this.txtActEmpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtActEmpr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtActEmpr.FormattingEnabled = true;
            this.txtActEmpr.IntegralHeight = false;
            this.txtActEmpr.ItemHeight = 43;
            this.txtActEmpr.Items.AddRange(new object[] {
            "Seleccione",
            "ACTIVIDADES ADMINISTRATIVAS Y SERVICIOS DE APOYO",
            "ADMINISTRACION PUBLICA, DEFENSA Y SEGURIDAD SOCIAL OBLIGATORIA",
            "AGRICULTURA, GANADERÍA, CAZA, SILVICULTURA Y PESCA",
            "COMERCIO AL POR MAYOR Y AL POR MENOR; REPARACIÓN DE VEHÍCULOS AUTOMOTORES Y MOTOC" +
                "ICLETAS",
            "CONSTRUCCIÓN",
            "ENSEÑANZA",
            "EXPLOTACIÓN DE MINAS Y CANTERAS",
            "INDUSTRIA MANUFACTURERA",
            "INFORMACIÓN Y COMUNICACIONES",
            "INTERMEDIACIÓN FINANCIERA Y SERVICIOS DE SEGUROS",
            "SALUD HUMANA Y SERVICIOS SOCIALES",
            "SERVICIOS ARTÍSTICOS, CULTURALES, DEPORTIVOS Y DE ESPARCIMIENTO",
            "SERVICIOS DE ALOJAMIENTO Y SERVICIOS DE COMIDA",
            "SERVICIOS DE ASOCIACIONES Y SERVICIOS PERSONALES",
            "SERVICIOS DE HOGARES PRIVADOS QUE CONTRATAN SERVICIO DOMESTICO",
            "SERVICIOS DE ORGANIZACIONES Y ÓRGANOS EXTRATERRITORIALES",
            "SERVICIOS DE TRANSPORTE Y ALMACENAMIENTO",
            "SERVICIOS INMOBILIARIOS",
            "SERVICIOS PROFESIONALES, CIENTÍFICOS Y TÉCNICOS",
            "SUMINISTRO DE AGUA, CLOACAS, GESTIÓN DE RESIDUOS Y RECUPERACIÓN DE MATERIALES Y S" +
                "ANEAMIENTO PÚBLICO",
            "SUMINISTRO DE ELECTRICIDAD, GAS, VAPOR Y AIRE ACONDICIONADO"});
            this.txtActEmpr.Location = new System.Drawing.Point(182, 197);
            this.txtActEmpr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtActEmpr.MaxDropDownItems = 4;
            this.txtActEmpr.MouseState = MaterialSkin.MouseState.OUT;
            this.txtActEmpr.Name = "txtActEmpr";
            this.txtActEmpr.Size = new System.Drawing.Size(188, 49);
            this.txtActEmpr.StartIndex = 0;
            this.txtActEmpr.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscartodo);
            this.groupBox2.Controls.Add(this.dgvCargaEmpresas);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.txtcuitconsultacuit);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(22, 419);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(869, 336);
            this.groupBox2.TabIndex = 61;
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
            this.btnBuscartodo.Location = new System.Drawing.Point(611, 18);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(116, 35);
            this.btnBuscartodo.TabIndex = 58;
            this.btnBuscartodo.Text = "Buscar Todo";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            this.btnBuscartodo.Click += new System.EventHandler(this.btnBuscartodo_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(914, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 35);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 718);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnEliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CargaEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargaEmpresas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnEliminar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUIT;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox2 txtWeb;
        private MaterialSkin.Controls.MaterialComboBox cboCondFiscal;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvCargaEmpresas;
        private MaterialSkin.Controls.MaterialTextBox2 txtcuitconsultacuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscartodo;
        private MaterialSkin.Controls.MaterialComboBox txtActEmpr;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialComboBox cboProvincia;
        private MaterialSkin.Controls.MaterialComboBox cboLocalidad;
    }
}