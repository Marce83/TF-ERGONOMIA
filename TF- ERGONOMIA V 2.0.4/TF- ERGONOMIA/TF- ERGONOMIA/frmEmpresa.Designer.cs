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
            this.btnCargar = new System.Windows.Forms.Button();
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cboProvincia = new MaterialSkin.Controls.MaterialComboBox();
            this.cboLocalidad = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.cboActEmpr = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCargar.Location = new System.Drawing.Point(245, 528);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(155, 60);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel1.Location = new System.Drawing.Point(33, 65);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(35, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "CUIT";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(33, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 35;
            this.materialLabel2.Text = "Razon Social";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCUIT.AnimateReadOnly = false;
            this.txtCUIT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCUIT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCUIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUIT.Depth = 0;
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUIT.HideSelection = true;
            this.txtCUIT.LeadingIcon = null;
            this.txtCUIT.Location = new System.Drawing.Point(245, 49);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtCUIT.Size = new System.Drawing.Size(367, 48);
            this.txtCUIT.TabIndex = 0;
            this.txtCUIT.TabStop = false;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUIT.TrailingIcon = null;
            this.txtCUIT.UseSystemPasswordChar = false;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
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
            this.txtCorreo.Location = new System.Drawing.Point(901, 311);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtCorreo.Size = new System.Drawing.Size(367, 48);
            this.txtCorreo.TabIndex = 7;
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
            this.txtNombreEmpresa.Location = new System.Drawing.Point(245, 113);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtNombreEmpresa.Size = new System.Drawing.Size(367, 48);
            this.txtNombreEmpresa.TabIndex = 1;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpresa.TrailingIcon = null;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            this.txtNombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(33, 193);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 36;
            this.materialLabel3.Text = "Condición Fiscal";
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel8.Location = new System.Drawing.Point(692, 247);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(68, 19);
            this.materialLabel8.TabIndex = 41;
            this.materialLabel8.Text = "Sitio Web";
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
            this.txtWeb.Location = new System.Drawing.Point(901, 249);
            this.txtWeb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtWeb.Size = new System.Drawing.Size(367, 48);
            this.txtWeb.TabIndex = 6;
            this.txtWeb.TabStop = false;
            this.txtWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWeb.TrailingIcon = null;
            this.txtWeb.UseSystemPasswordChar = false;
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
            "Responsable Inscripto",
            "Monotributo",
            "Consumidor Final"});
            this.cboCondFiscal.Location = new System.Drawing.Point(245, 177);
            this.cboCondFiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCondFiscal.MaxDropDownItems = 4;
            this.cboCondFiscal.MouseState = MaterialSkin.MouseState.OUT;
            this.cboCondFiscal.Name = "cboCondFiscal";
            this.cboCondFiscal.Size = new System.Drawing.Size(365, 49);
            this.cboCondFiscal.StartIndex = 0;
            this.cboCondFiscal.TabIndex = 2;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(33, 254);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(154, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "Actividad empresarial";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(692, 313);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(129, 19);
            this.materialLabel7.TabIndex = 40;
            this.materialLabel7.Text = "Correo Electrónico";
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
            this.txtTelefono.Location = new System.Drawing.Point(245, 373);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtTelefono.Size = new System.Drawing.Size(367, 48);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.TrailingIcon = null;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(692, 193);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 38;
            this.materialLabel5.Text = "Calle";
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(33, 385);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(64, 19);
            this.materialLabel6.TabIndex = 39;
            this.materialLabel6.Text = "Teléfono";
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
            this.txtCalle.Location = new System.Drawing.Point(901, 190);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtCalle.Size = new System.Drawing.Size(367, 48);
            this.txtCalle.TabIndex = 4;
            this.txtCalle.TabStop = false;
            this.txtCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCalle.TrailingIcon = null;
            this.txtCalle.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 38);
            this.label1.TabIndex = 59;
            this.label1.Text = "CARGA DE EMPRESAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
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
            this.groupBox1.Location = new System.Drawing.Point(29, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1300, 633);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRAR EMPRESA";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConsultar.Location = new System.Drawing.Point(516, 528);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(155, 60);
            this.btnConsultar.TabIndex = 81;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpiar.Location = new System.Drawing.Point(780, 528);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 60);
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaAlta.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtpFechaAlta.Location = new System.Drawing.Point(901, 400);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaAlta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(365, 26);
            this.dtpFechaAlta.TabIndex = 75;
            // 
            // materialLabel13
            // 
            this.materialLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(692, 400);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(97, 19);
            this.materialLabel13.TabIndex = 76;
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
            this.cboTipo.Location = new System.Drawing.Point(245, 308);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipo.MaxDropDownItems = 4;
            this.cboTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(365, 49);
            this.cboTipo.StartIndex = 0;
            this.cboTipo.TabIndex = 50;
            // 
            // materialLabel12
            // 
            this.materialLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel12.Location = new System.Drawing.Point(33, 319);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(33, 19);
            this.materialLabel12.TabIndex = 49;
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
            this.cboProvincia.Location = new System.Drawing.Point(901, 62);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProvincia.MaxDropDownItems = 4;
            this.cboProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(365, 49);
            this.cboProvincia.StartIndex = 0;
            this.cboProvincia.TabIndex = 48;
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
            this.cboLocalidad.Location = new System.Drawing.Point(901, 123);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLocalidad.MaxDropDownItems = 4;
            this.cboLocalidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(365, 49);
            this.cboLocalidad.StartIndex = 0;
            this.cboLocalidad.TabIndex = 47;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel11.Location = new System.Drawing.Point(692, 65);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(67, 19);
            this.materialLabel11.TabIndex = 46;
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
            "Agricultura",
            "Alimentación y Bebidas",
            "Aeroespacial",
            "Automotriz",
            "Comercio",
            "Construcción",
            "Manufactura",
            "Salud",
            "Telecomunicaciones",
            "Transporte"});
            this.cboActEmpr.Location = new System.Drawing.Point(245, 242);
            this.cboActEmpr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboActEmpr.MaxDropDownItems = 4;
            this.cboActEmpr.MouseState = MaterialSkin.MouseState.OUT;
            this.cboActEmpr.Name = "cboActEmpr";
            this.cboActEmpr.Size = new System.Drawing.Size(365, 49);
            this.cboActEmpr.StartIndex = 0;
            this.cboActEmpr.TabIndex = 42;
            // 
            // materialLabel9
            // 
            this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel9.Location = new System.Drawing.Point(692, 128);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(71, 19);
            this.materialLabel9.TabIndex = 44;
            this.materialLabel9.Text = "Localidad";
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1344, 725);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10";
            this.Load += new System.EventHandler(this.CargaEmpresa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
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
        private System.Windows.Forms.Button btnConsultar;
        private MaterialSkin.Controls.MaterialComboBox cboActEmpr;
    }
}