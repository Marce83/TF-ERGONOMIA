namespace TF.WIN
{
    partial class FrmLMCPortada
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
            this.dtpReba = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpleadoReba = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpresaReba = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarpuesto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpuestotrabajoencontrado = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDniEmpleadoReba = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarCUIT = new System.Windows.Forms.Button();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUITEncontrado = new MaterialSkin.Controls.MaterialTextBox2();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.linkLimpiar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dtpReba
            // 
            this.dtpReba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpReba.CustomFormat = "";
            this.dtpReba.Location = new System.Drawing.Point(224, 450);
            this.dtpReba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpReba.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpReba.Name = "dtpReba";
            this.dtpReba.Size = new System.Drawing.Size(276, 22);
            this.dtpReba.TabIndex = 163;
            this.dtpReba.Value = new System.DateTime(2023, 12, 21, 20, 52, 44, 0);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(71, 450);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 162;
            this.materialLabel5.Text = "FECHA";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(71, 292);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 19);
            this.materialLabel4.TabIndex = 161;
            this.materialLabel4.Text = "EMPLEADO";
            // 
            // txtNombreEmpleadoReba
            // 
            this.txtNombreEmpleadoReba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreEmpleadoReba.AnimateReadOnly = false;
            this.txtNombreEmpleadoReba.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpleadoReba.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpleadoReba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpleadoReba.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpleadoReba.Depth = 0;
            this.txtNombreEmpleadoReba.Enabled = false;
            this.txtNombreEmpleadoReba.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleadoReba.HideSelection = true;
            this.txtNombreEmpleadoReba.LeadingIcon = null;
            this.txtNombreEmpleadoReba.Location = new System.Drawing.Point(224, 276);
            this.txtNombreEmpleadoReba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleadoReba.MaxLength = 32767;
            this.txtNombreEmpleadoReba.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpleadoReba.Name = "txtNombreEmpleadoReba";
            this.txtNombreEmpleadoReba.PasswordChar = '\0';
            this.txtNombreEmpleadoReba.PrefixSuffixText = null;
            this.txtNombreEmpleadoReba.ReadOnly = true;
            this.txtNombreEmpleadoReba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpleadoReba.SelectedText = "";
            this.txtNombreEmpleadoReba.SelectionLength = 0;
            this.txtNombreEmpleadoReba.SelectionStart = 0;
            this.txtNombreEmpleadoReba.ShortcutsEnabled = true;
            this.txtNombreEmpleadoReba.Size = new System.Drawing.Size(277, 48);
            this.txtNombreEmpleadoReba.TabIndex = 160;
            this.txtNombreEmpleadoReba.TabStop = false;
            this.txtNombreEmpleadoReba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpleadoReba.TrailingIcon = null;
            this.txtNombreEmpleadoReba.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(71, 142);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 159;
            this.materialLabel3.Text = "EMPRESA";
            // 
            // txtNombreEmpresaReba
            // 
            this.txtNombreEmpresaReba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombreEmpresaReba.AnimateReadOnly = false;
            this.txtNombreEmpresaReba.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpresaReba.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpresaReba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpresaReba.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpresaReba.Depth = 0;
            this.txtNombreEmpresaReba.Enabled = false;
            this.txtNombreEmpresaReba.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpresaReba.HideSelection = true;
            this.txtNombreEmpresaReba.LeadingIcon = null;
            this.txtNombreEmpresaReba.Location = new System.Drawing.Point(224, 126);
            this.txtNombreEmpresaReba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpresaReba.MaxLength = 32767;
            this.txtNombreEmpresaReba.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpresaReba.Name = "txtNombreEmpresaReba";
            this.txtNombreEmpresaReba.PasswordChar = '\0';
            this.txtNombreEmpresaReba.PrefixSuffixText = null;
            this.txtNombreEmpresaReba.ReadOnly = true;
            this.txtNombreEmpresaReba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpresaReba.SelectedText = "";
            this.txtNombreEmpresaReba.SelectionLength = 0;
            this.txtNombreEmpresaReba.SelectionStart = 0;
            this.txtNombreEmpresaReba.ShortcutsEnabled = true;
            this.txtNombreEmpresaReba.Size = new System.Drawing.Size(277, 48);
            this.txtNombreEmpresaReba.TabIndex = 158;
            this.txtNombreEmpresaReba.TabStop = false;
            this.txtNombreEmpresaReba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpresaReba.TrailingIcon = null;
            this.txtNombreEmpresaReba.UseSystemPasswordChar = false;
            // 
            // btnBuscarpuesto
            // 
            this.btnBuscarpuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarpuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarpuesto.FlatAppearance.BorderSize = 0;
            this.btnBuscarpuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarpuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarpuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarpuesto.Location = new System.Drawing.Point(508, 356);
            this.btnBuscarpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarpuesto.Name = "btnBuscarpuesto";
            this.btnBuscarpuesto.Size = new System.Drawing.Size(76, 48);
            this.btnBuscarpuesto.TabIndex = 157;
            this.btnBuscarpuesto.Text = "...";
            this.btnBuscarpuesto.UseVisualStyleBackColor = false;
            this.btnBuscarpuesto.Visible = false;
            this.btnBuscarpuesto.Click += new System.EventHandler(this.btnBuscarpuesto_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 38);
            this.label1.TabIndex = 156;
            this.label1.Text = "FORMULARIO DE CARGA LMC";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(71, 369);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 155;
            this.materialLabel2.Text = "PUESTO";
            // 
            // txtpuestotrabajoencontrado
            // 
            this.txtpuestotrabajoencontrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpuestotrabajoencontrado.AnimateReadOnly = false;
            this.txtpuestotrabajoencontrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtpuestotrabajoencontrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtpuestotrabajoencontrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpuestotrabajoencontrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpuestotrabajoencontrado.Depth = 0;
            this.txtpuestotrabajoencontrado.Enabled = false;
            this.txtpuestotrabajoencontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpuestotrabajoencontrado.HideSelection = true;
            this.txtpuestotrabajoencontrado.LeadingIcon = null;
            this.txtpuestotrabajoencontrado.Location = new System.Drawing.Point(224, 356);
            this.txtpuestotrabajoencontrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpuestotrabajoencontrado.MaxLength = 32767;
            this.txtpuestotrabajoencontrado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpuestotrabajoencontrado.Name = "txtpuestotrabajoencontrado";
            this.txtpuestotrabajoencontrado.PasswordChar = '\0';
            this.txtpuestotrabajoencontrado.PrefixSuffixText = null;
            this.txtpuestotrabajoencontrado.ReadOnly = true;
            this.txtpuestotrabajoencontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpuestotrabajoencontrado.SelectedText = "";
            this.txtpuestotrabajoencontrado.SelectionLength = 0;
            this.txtpuestotrabajoencontrado.SelectionStart = 0;
            this.txtpuestotrabajoencontrado.ShortcutsEnabled = true;
            this.txtpuestotrabajoencontrado.Size = new System.Drawing.Size(276, 48);
            this.txtpuestotrabajoencontrado.TabIndex = 154;
            this.txtpuestotrabajoencontrado.TabStop = false;
            this.txtpuestotrabajoencontrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpuestotrabajoencontrado.TrailingIcon = null;
            this.txtpuestotrabajoencontrado.UseSystemPasswordChar = false;
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarEmpleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(508, 196);
            this.btnBuscarEmpleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(76, 48);
            this.btnBuscarEmpleados.TabIndex = 153;
            this.btnBuscarEmpleados.Text = "...";
            this.btnBuscarEmpleados.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(71, 209);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(27, 19);
            this.materialLabel1.TabIndex = 152;
            this.materialLabel1.Text = "DNI";
            // 
            // txtDniEmpleadoReba
            // 
            this.txtDniEmpleadoReba.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDniEmpleadoReba.AnimateReadOnly = false;
            this.txtDniEmpleadoReba.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDniEmpleadoReba.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDniEmpleadoReba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDniEmpleadoReba.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDniEmpleadoReba.Depth = 0;
            this.txtDniEmpleadoReba.Enabled = false;
            this.txtDniEmpleadoReba.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDniEmpleadoReba.HideSelection = true;
            this.txtDniEmpleadoReba.LeadingIcon = null;
            this.txtDniEmpleadoReba.Location = new System.Drawing.Point(224, 196);
            this.txtDniEmpleadoReba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniEmpleadoReba.MaxLength = 32767;
            this.txtDniEmpleadoReba.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDniEmpleadoReba.Name = "txtDniEmpleadoReba";
            this.txtDniEmpleadoReba.PasswordChar = '\0';
            this.txtDniEmpleadoReba.PrefixSuffixText = null;
            this.txtDniEmpleadoReba.ReadOnly = true;
            this.txtDniEmpleadoReba.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDniEmpleadoReba.SelectedText = "";
            this.txtDniEmpleadoReba.SelectionLength = 0;
            this.txtDniEmpleadoReba.SelectionStart = 0;
            this.txtDniEmpleadoReba.ShortcutsEnabled = true;
            this.txtDniEmpleadoReba.Size = new System.Drawing.Size(277, 48);
            this.txtDniEmpleadoReba.TabIndex = 151;
            this.txtDniEmpleadoReba.TabStop = false;
            this.txtDniEmpleadoReba.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDniEmpleadoReba.TrailingIcon = null;
            this.txtDniEmpleadoReba.UseSystemPasswordChar = false;
            // 
            // btnBuscarCUIT
            // 
            this.btnBuscarCUIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCUIT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCUIT.FlatAppearance.BorderSize = 0;
            this.btnBuscarCUIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCUIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCUIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCUIT.Location = new System.Drawing.Point(508, 62);
            this.btnBuscarCUIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCUIT.Name = "btnBuscarCUIT";
            this.btnBuscarCUIT.Size = new System.Drawing.Size(76, 48);
            this.btnBuscarCUIT.TabIndex = 150;
            this.btnBuscarCUIT.Text = "...";
            this.btnBuscarCUIT.UseVisualStyleBackColor = false;
            this.btnBuscarCUIT.Click += new System.EventHandler(this.btnBuscarCUIT_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(76, 73);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(35, 19);
            this.materialLabel11.TabIndex = 149;
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
            this.txtCUITEncontrado.Enabled = false;
            this.txtCUITEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUITEncontrado.HideSelection = true;
            this.txtCUITEncontrado.LeadingIcon = null;
            this.txtCUITEncontrado.Location = new System.Drawing.Point(224, 62);
            this.txtCUITEncontrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtCUITEncontrado.Size = new System.Drawing.Size(277, 48);
            this.txtCUITEncontrado.TabIndex = 148;
            this.txtCUITEncontrado.TabStop = false;
            this.txtCUITEncontrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUITEncontrado.TrailingIcon = null;
            this.txtCUITEncontrado.UseSystemPasswordChar = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(76, 511);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(155, 58);
            this.BtnSalir.TabIndex = 147;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCrear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCrear.FlatAppearance.BorderSize = 0;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrear.Location = new System.Drawing.Point(444, 511);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(155, 58);
            this.btnCrear.TabIndex = 146;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // linkLimpiar
            // 
            this.linkLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLimpiar.AutoSize = true;
            this.linkLimpiar.Location = new System.Drawing.Point(545, 480);
            this.linkLimpiar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLimpiar.Name = "linkLimpiar";
            this.linkLimpiar.Size = new System.Drawing.Size(51, 16);
            this.linkLimpiar.TabIndex = 164;
            this.linkLimpiar.TabStop = true;
            this.linkLimpiar.Text = "Limpiar";
            this.linkLimpiar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLimpiar_LinkClicked);
            // 
            // FrmLMCPortada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(677, 582);
            this.Controls.Add(this.linkLimpiar);
            this.Controls.Add(this.dtpReba);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtNombreEmpleadoReba);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNombreEmpresaReba);
            this.Controls.Add(this.btnBuscarpuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtpuestotrabajoencontrado);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtDniEmpleadoReba);
            this.Controls.Add(this.btnBuscarCUIT);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtCUITEncontrado);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLMCPortada";
            this.Text = "FrmLMCPortada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReba;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpleadoReba;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpresaReba;
        private System.Windows.Forms.Button btnBuscarpuesto;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtpuestotrabajoencontrado;
        private System.Windows.Forms.Button btnBuscarEmpleados;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtDniEmpleadoReba;
        private System.Windows.Forms.Button btnBuscarCUIT;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUITEncontrado;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.LinkLabel linkLimpiar;
    }
}