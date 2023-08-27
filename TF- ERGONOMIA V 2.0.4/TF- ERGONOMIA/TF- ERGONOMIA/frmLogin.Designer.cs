
namespace TF.WIN
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtClave = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnIniciar = new MaterialSkin.Controls.MaterialButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistrar = new System.Windows.Forms.LinkLabel();
            this.lblRecuperar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.AnimateReadOnly = true;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HelperText = "Por favor, ingresar usuario";
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(90, 86);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffixText = null;
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(221, 48);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.AnimateReadOnly = false;
            this.txtClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Depth = 0;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClave.HelperText = "Por favor, ingresar Password";
            this.txtClave.HideSelection = true;
            this.txtClave.LeadingIcon = null;
            this.txtClave.Location = new System.Drawing.Point(90, 170);
            this.txtClave.Margin = new System.Windows.Forms.Padding(2);
            this.txtClave.MaxLength = 32767;
            this.txtClave.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.PrefixSuffixText = null;
            this.txtClave.ReadOnly = false;
            this.txtClave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.Size = new System.Drawing.Size(221, 48);
            this.txtClave.TabIndex = 4;
            this.txtClave.TabStop = false;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClave.TrailingIcon = null;
            this.txtClave.UseSystemPasswordChar = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIniciar.Depth = 0;
            this.btnIniciar.HighEmphasis = true;
            this.btnIniciar.Icon = null;
            this.btnIniciar.Location = new System.Drawing.Point(70, 252);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.btnIniciar.Size = new System.Drawing.Size(95, 36);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Siguiente";
            this.btnIniciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIniciar.UseAccentColor = false;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalir.Depth = 0;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.HighEmphasis = true;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(235, 252);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalir.Size = new System.Drawing.Size(64, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalir.UseAccentColor = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 170);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(331, 86);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 38);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "";
            this.toolTip1.SetToolTip(this.pictureBox3, "Caso contrario, apriete en el Boton \"Nuevo Usuario\" \r\ne ingrese la informacion qu" +
        "e le solicite.");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(331, 170);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 38);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "";
            this.toolTip2.SetToolTip(this.pictureBox4, "Caso contrario, apriete en el Boton \"Nuevo Usuario\" \r\ne ingrese la informacion qu" +
        "e le solicite.\r\n");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Por favor, ingrese su Usuario";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Por favor, ingrese su Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 39);
            this.label1.TabIndex = 60;
            this.label1.Text = "BIENVENIDO";
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.LinkColor = System.Drawing.Color.Black;
            this.lblRegistrar.Location = new System.Drawing.Point(232, 346);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(93, 20);
            this.lblRegistrar.TabIndex = 61;
            this.lblRegistrar.TabStop = true;
            this.lblRegistrar.Text = "Registrate";
            this.lblRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistrar_LinkClicked);
            // 
            // lblRecuperar
            // 
            this.lblRecuperar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecuperar.AutoSize = true;
            this.lblRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar.LinkColor = System.Drawing.Color.Black;
            this.lblRecuperar.Location = new System.Drawing.Point(110, 311);
            this.lblRecuperar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecuperar.Name = "lblRecuperar";
            this.lblRecuperar.Size = new System.Drawing.Size(160, 20);
            this.lblRecuperar.TabIndex = 62;
            this.lblRecuperar.TabStop = true;
            this.lblRecuperar.Text = "Recuperar Usuario";
            this.lblRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperar_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "¿No tienes Cuenta?";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(391, 458);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecuperar);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(2, 51, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicia Sesion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtClave;
        private MaterialSkin.Controls.MaterialButton btnIniciar;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblRegistrar;
        private System.Windows.Forms.LinkLabel lblRecuperar;
        private System.Windows.Forms.Label label2;
    }
}