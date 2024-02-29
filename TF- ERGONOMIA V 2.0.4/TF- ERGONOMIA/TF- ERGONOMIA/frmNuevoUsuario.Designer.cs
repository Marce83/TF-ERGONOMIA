namespace TF.WIN
{
    partial class frmNuevoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoUsuario));
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCargarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ToolTipClave = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.chbVisualizarClave = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // txtClave
            // 
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.AnimateReadOnly = false;
            this.txtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClave.Depth = 0;
            this.txtClave.HideSelection = true;
            this.txtClave.LeadingIcon = null;
            this.txtClave.MaxLength = 32767;
            this.txtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.ReadOnly = false;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.TabStop = false;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClave.TrailingIcon = null;
            this.txtClave.UseSystemPasswordChar = false;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.AnimateReadOnly = false;
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombre.Depth = 0;
            this.txtNombre.HideSelection = true;
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ReadOnly = false;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.TabStop = false;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.AnimateReadOnly = false;
            this.txtApellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtApellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtApellido.Depth = 0;
            this.txtApellido.HideSelection = true;
            this.txtApellido.LeadingIcon = null;
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ReadOnly = false;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.TabStop = false;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.TrailingIcon = null;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // btnCargarUsuario
            // 
            resources.ApplyResources(this.btnCargarUsuario, "btnCargarUsuario");
            this.btnCargarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargarUsuario.Depth = 0;
            this.btnCargarUsuario.HighEmphasis = true;
            this.btnCargarUsuario.Icon = null;
            this.btnCargarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargarUsuario.Name = "btnCargarUsuario";
            this.btnCargarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargarUsuario.UseAccentColor = false;
            this.btnCargarUsuario.UseVisualStyleBackColor = true;
            this.btnCargarUsuario.Click += new System.EventHandler(this.CargarUsuario_Click);
            // 
            // btnSalir
            // 
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            this.ToolTipClave.SetToolTip(this.pictureBox3, resources.GetString("pictureBox3.ToolTip"));
            // 
            // ToolTipClave
            // 
            this.ToolTipClave.IsBalloon = true;
            this.ToolTipClave.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTipClave.ToolTipTitle = "Datos a tener en cuenta:";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Name = "label1";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // txtConfClave
            // 
            resources.ApplyResources(this.txtConfClave, "txtConfClave");
            this.txtConfClave.AnimateReadOnly = false;
            this.txtConfClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtConfClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtConfClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfClave.Depth = 0;
            this.txtConfClave.HideSelection = true;
            this.txtConfClave.LeadingIcon = null;
            this.txtConfClave.MaxLength = 32767;
            this.txtConfClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfClave.Name = "txtConfClave";
            this.txtConfClave.PasswordChar = '*';
            this.txtConfClave.ReadOnly = false;
            this.txtConfClave.SelectedText = "";
            this.txtConfClave.SelectionLength = 0;
            this.txtConfClave.SelectionStart = 0;
            this.txtConfClave.ShortcutsEnabled = true;
            this.txtConfClave.TabStop = false;
            this.txtConfClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfClave.TrailingIcon = null;
            this.txtConfClave.UseSystemPasswordChar = false;
            // 
            // chbVisualizarClave
            // 
            resources.ApplyResources(this.chbVisualizarClave, "chbVisualizarClave");
            this.chbVisualizarClave.Name = "chbVisualizarClave";
            this.chbVisualizarClave.UseVisualStyleBackColor = true;
            this.chbVisualizarClave.CheckedChanged += new System.EventHandler(this.chbVisualizarClave_CheckedChanged);
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.HideSelection = true;
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.TabStop = false;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.TrailingIcon = null;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // frmNuevoUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.chbVisualizarClave);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtConfClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarUsuario);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevoUsuario";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmNuevoUsuario_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtClave;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellido;
        private MaterialSkin.Controls.MaterialButton btnCargarUsuario;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip ToolTipClave;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtConfClave;
        private System.Windows.Forms.CheckBox chbVisualizarClave;
        private MaterialSkin.Controls.MaterialTextBox2 txtCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}