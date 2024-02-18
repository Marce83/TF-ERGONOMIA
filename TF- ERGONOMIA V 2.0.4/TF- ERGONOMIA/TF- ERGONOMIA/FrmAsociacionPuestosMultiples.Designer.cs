namespace TF.WIN
{
    partial class FrmAsociacionPuestosMultiples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsociacionPuestosMultiples));
            this.DtpFechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarPuesto = new System.Windows.Forms.Button();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombrePuesto = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarPuesto = new System.Windows.Forms.Button();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdPuestoTrabajo = new MaterialSkin.Controls.MaterialTextBox2();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFechaEgreso
            // 
            this.DtpFechaEgreso.Enabled = false;
            this.DtpFechaEgreso.Location = new System.Drawing.Point(279, 291);
            this.DtpFechaEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaEgreso.Name = "DtpFechaEgreso";
            this.DtpFechaEgreso.Size = new System.Drawing.Size(379, 22);
            this.DtpFechaEgreso.TabIndex = 369;
            // 
            // DtpFechaIngreso
            // 
            this.DtpFechaIngreso.Enabled = false;
            this.DtpFechaIngreso.Location = new System.Drawing.Point(279, 231);
            this.DtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFechaIngreso.Name = "DtpFechaIngreso";
            this.DtpFechaIngreso.Size = new System.Drawing.Size(379, 22);
            this.DtpFechaIngreso.TabIndex = 368;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 236);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 367;
            this.materialLabel1.Text = "FECHA ALTA";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(18, 291);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(163, 19);
            this.materialLabel5.TabIndex = 366;
            this.materialLabel5.Text = "FECHA MODIFICACION";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(186, 19);
            this.materialLabel3.TabIndex = 365;
            this.materialLabel3.Text = "NOMBRE DEL EMPLEADO";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(20, 105);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(122, 19);
            this.materialLabel2.TabIndex = 364;
            this.materialLabel2.Text = "PRIMER PUESTO";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.HideSelection = true;
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(280, 156);
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
            this.txtNombreEmpleado.Size = new System.Drawing.Size(378, 48);
            this.txtNombreEmpleado.TabIndex = 363;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpleado.TrailingIcon = null;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1034, 65);
            this.BarraTitulo.TabIndex = 362;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(989, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 38);
            this.label1.TabIndex = 239;
            this.label1.Text = "ASOCIACIÓN DE PUESTO  MULTIPLES";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(844, 169);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 59);
            this.btnSalir.TabIndex = 361;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarPuesto
            // 
            this.btnCargarPuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPuesto.FlatAppearance.BorderSize = 0;
            this.btnCargarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPuesto.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCargarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarPuesto.Location = new System.Drawing.Point(844, 89);
            this.btnCargarPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarPuesto.Name = "btnCargarPuesto";
            this.btnCargarPuesto.Size = new System.Drawing.Size(155, 59);
            this.btnCargarPuesto.TabIndex = 360;
            this.btnCargarPuesto.Text = "Cargar";
            this.btnCargarPuesto.UseVisualStyleBackColor = false;
            this.btnCargarPuesto.Click += new System.EventHandler(this.btnCargarPuesto_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(681, 270);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(84, 19);
            this.materialLabel4.TabIndex = 359;
            this.materialLabel4.Text = "EMPLEADO";
            this.materialLabel4.Visible = false;
            // 
            // txtNombrePuesto
            // 
            this.txtNombrePuesto.AnimateReadOnly = false;
            this.txtNombrePuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombrePuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombrePuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombrePuesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombrePuesto.Depth = 0;
            this.txtNombrePuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombrePuesto.HideSelection = true;
            this.txtNombrePuesto.LeadingIcon = null;
            this.txtNombrePuesto.Location = new System.Drawing.Point(280, 89);
            this.txtNombrePuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombrePuesto.MaxLength = 32767;
            this.txtNombrePuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombrePuesto.Name = "txtNombrePuesto";
            this.txtNombrePuesto.PasswordChar = '\0';
            this.txtNombrePuesto.PrefixSuffixText = null;
            this.txtNombrePuesto.ReadOnly = true;
            this.txtNombrePuesto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombrePuesto.SelectedText = "";
            this.txtNombrePuesto.SelectionLength = 0;
            this.txtNombrePuesto.SelectionStart = 0;
            this.txtNombrePuesto.ShortcutsEnabled = true;
            this.txtNombrePuesto.Size = new System.Drawing.Size(379, 48);
            this.txtNombrePuesto.TabIndex = 358;
            this.txtNombrePuesto.TabStop = false;
            this.txtNombrePuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombrePuesto.TrailingIcon = null;
            this.txtNombrePuesto.UseSystemPasswordChar = false;
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarEmpleados.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(683, 156);
            this.btnBuscarEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(89, 48);
            this.btnBuscarEmpleados.TabIndex = 357;
            this.btnBuscarEmpleados.Text = "...";
            this.btnBuscarEmpleados.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.AnimateReadOnly = false;
            this.txtIdEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEmpleado.HideSelection = true;
            this.txtIdEmpleado.LeadingIcon = null;
            this.txtIdEmpleado.Location = new System.Drawing.Point(786, 253);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEmpleado.MaxLength = 32767;
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.PrefixSuffixText = null;
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.ShortcutsEnabled = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(60, 48);
            this.txtIdEmpleado.TabIndex = 356;
            this.txtIdEmpleado.TabStop = false;
            this.txtIdEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdEmpleado.TrailingIcon = null;
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            this.txtIdEmpleado.Visible = false;
            // 
            // btnBuscarPuesto
            // 
            this.btnBuscarPuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarPuesto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPuesto.Location = new System.Drawing.Point(684, 89);
            this.btnBuscarPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarPuesto.Name = "btnBuscarPuesto";
            this.btnBuscarPuesto.Size = new System.Drawing.Size(89, 48);
            this.btnBuscarPuesto.TabIndex = 355;
            this.btnBuscarPuesto.Text = "...";
            this.btnBuscarPuesto.UseVisualStyleBackColor = false;
            this.btnBuscarPuesto.Click += new System.EventHandler(this.btnBuscarPuesto_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(880, 270);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(30, 19);
            this.materialLabel11.TabIndex = 354;
            this.materialLabel11.Text = "PT1";
            this.materialLabel11.Visible = false;
            // 
            // txtIdPuestoTrabajo
            // 
            this.txtIdPuestoTrabajo.AnimateReadOnly = false;
            this.txtIdPuestoTrabajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdPuestoTrabajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdPuestoTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtIdPuestoTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdPuestoTrabajo.Depth = 0;
            this.txtIdPuestoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdPuestoTrabajo.HideSelection = true;
            this.txtIdPuestoTrabajo.LeadingIcon = null;
            this.txtIdPuestoTrabajo.Location = new System.Drawing.Point(916, 253);
            this.txtIdPuestoTrabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPuestoTrabajo.MaxLength = 32767;
            this.txtIdPuestoTrabajo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdPuestoTrabajo.Name = "txtIdPuestoTrabajo";
            this.txtIdPuestoTrabajo.PasswordChar = '\0';
            this.txtIdPuestoTrabajo.PrefixSuffixText = null;
            this.txtIdPuestoTrabajo.ReadOnly = true;
            this.txtIdPuestoTrabajo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIdPuestoTrabajo.SelectedText = "";
            this.txtIdPuestoTrabajo.SelectionLength = 0;
            this.txtIdPuestoTrabajo.SelectionStart = 0;
            this.txtIdPuestoTrabajo.ShortcutsEnabled = true;
            this.txtIdPuestoTrabajo.Size = new System.Drawing.Size(83, 48);
            this.txtIdPuestoTrabajo.TabIndex = 353;
            this.txtIdPuestoTrabajo.TabStop = false;
            this.txtIdPuestoTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdPuestoTrabajo.TrailingIcon = null;
            this.txtIdPuestoTrabajo.UseSystemPasswordChar = false;
            this.txtIdPuestoTrabajo.Visible = false;
            // 
            // FrmAsociacionPuestosMultiples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 340);
            this.Controls.Add(this.DtpFechaEgreso);
            this.Controls.Add(this.DtpFechaIngreso);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarPuesto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.txtNombrePuesto);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.btnBuscarPuesto);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtIdPuestoTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsociacionPuestosMultiples";
            this.Text = "FrmAsociacionPuestosMultiples";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFechaEgreso;
        private System.Windows.Forms.DateTimePicker DtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpleado;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarPuesto;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombrePuesto;
        private System.Windows.Forms.Button btnBuscarEmpleados;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdEmpleado;
        private System.Windows.Forms.Button btnBuscarPuesto;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtIdPuestoTrabajo;
    }
}