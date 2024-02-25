namespace TF.WIN
{
    partial class frmEditUsrAdmin
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
            this.linkEditarClave = new System.Windows.Forms.LinkLabel();
            this.txtRepetirClave = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblEditarCargo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvEditarPerfil = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // linkEditarClave
            // 
            this.linkEditarClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkEditarClave.AutoSize = true;
            this.linkEditarClave.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkEditarClave.Location = new System.Drawing.Point(110, 257);
            this.linkEditarClave.Name = "linkEditarClave";
            this.linkEditarClave.Size = new System.Drawing.Size(45, 13);
            this.linkEditarClave.TabIndex = 33;
            this.linkEditarClave.TabStop = true;
            this.linkEditarClave.Text = "Cambiar";
            this.linkEditarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEditarClave_LinkClicked);
            // 
            // txtRepetirClave
            // 
            this.txtRepetirClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRepetirClave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRepetirClave.Location = new System.Drawing.Point(19, 315);
            this.txtRepetirClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepetirClave.Name = "txtRepetirClave";
            this.txtRepetirClave.PasswordChar = '*';
            this.txtRepetirClave.Size = new System.Drawing.Size(327, 20);
            this.txtRepetirClave.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(18, 298);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Repetir Clave nueva";
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClaveNueva.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClaveNueva.Location = new System.Drawing.Point(19, 274);
            this.txtClaveNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '*';
            this.txtClaveNueva.Size = new System.Drawing.Size(327, 20);
            this.txtClaveNueva.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(18, 257);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Clave Nueva";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtClaveActual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtClaveActual.Location = new System.Drawing.Point(19, 233);
            this.txtClaveActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(327, 20);
            this.txtClaveActual.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(16, 216);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Clave Actual";
            // 
            // btnGuardar
            // 
<<<<<<< HEAD
            this.btnGuardar.Location = new System.Drawing.Point(279, 390);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 28);
=======
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(688, 482);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 60);
>>>>>>> ff3cbafab246a38e45ccb78e4d8ae193295cb9de
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
<<<<<<< HEAD
            this.btnCancelar.Location = new System.Drawing.Point(171, 390);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 28);
=======
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(487, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 60);
>>>>>>> ff3cbafab246a38e45ccb78e4d8ae193295cb9de
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboCargo
            // 
            this.cboCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCargo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Administrador",
            "Contador",
            "Profesional",
            "Recepcionista",
            "Usuario"});
            this.cboCargo.Location = new System.Drawing.Point(21, 356);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(162, 21);
            this.cboCargo.TabIndex = 40;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCorreo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCorreo.Location = new System.Drawing.Point(19, 192);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(327, 20);
            this.txtCorreo.TabIndex = 39;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellido.Location = new System.Drawing.Point(20, 151);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(327, 20);
            this.txtApellido.TabIndex = 38;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(20, 110);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 20);
            this.txtNombre.TabIndex = 37;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsuario.Location = new System.Drawing.Point(19, 69);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(327, 20);
            this.txtUsuario.TabIndex = 36;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
<<<<<<< HEAD
            this.label12.Location = new System.Drawing.Point(153, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 24);
=======
            this.label12.Location = new System.Drawing.Point(313, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(639, 36);
>>>>>>> ff3cbafab246a38e45ccb78e4d8ae193295cb9de
            this.label12.TabIndex = 35;
            this.label12.Text = "ADMINISTRADOR DE DATOS DE USUARIOS";
            // 
            // lblEditarCargo
            // 
            this.lblEditarCargo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditarCargo.AutoSize = true;
            this.lblEditarCargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEditarCargo.Location = new System.Drawing.Point(18, 339);
            this.lblEditarCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditarCargo.Name = "lblEditarCargo";
            this.lblEditarCargo.Size = new System.Drawing.Size(35, 13);
            this.lblEditarCargo.TabIndex = 34;
            this.lblEditarCargo.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(18, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Correo Electrónico";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(18, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(17, 93);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(16, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Usuario";
            // 
            // dgvEditarPerfil
            // 
            this.dgvEditarPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvEditarPerfil.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEditarPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditarPerfil.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEditarPerfil.Location = new System.Drawing.Point(365, 69);
            this.dgvEditarPerfil.Name = "dgvEditarPerfil";
            this.dgvEditarPerfil.RowHeadersWidth = 51;
            this.dgvEditarPerfil.Size = new System.Drawing.Size(604, 308);
            this.dgvEditarPerfil.TabIndex = 49;
            this.dgvEditarPerfil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditarPerfil_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(303, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 60);
            this.button1.TabIndex = 50;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEditUsrAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(982, 431);
=======
            this.ClientSize = new System.Drawing.Size(1425, 556);
            this.Controls.Add(this.button1);
>>>>>>> ff3cbafab246a38e45ccb78e4d8ae193295cb9de
            this.Controls.Add(this.dgvEditarPerfil);
            this.Controls.Add(this.linkEditarClave);
            this.Controls.Add(this.txtRepetirClave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtClaveNueva);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblEditarCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditUsrAdmin";
            this.Text = "frmEditUsrAdmin";
            this.Load += new System.EventHandler(this.frmEditUsrAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditarPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkEditarClave;
        private System.Windows.Forms.TextBox txtRepetirClave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEditarCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvEditarPerfil;
        private System.Windows.Forms.Button button1;
    }
}