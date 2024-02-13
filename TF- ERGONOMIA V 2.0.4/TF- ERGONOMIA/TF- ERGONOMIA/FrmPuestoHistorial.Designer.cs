namespace TF.WIN
{
    partial class FrmPuestoHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuestoHistorial));
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.DtpFechahasta = new System.Windows.Forms.DateTimePicker();
            this.DtpFechadesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarresultado = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.DgvPuestosRecientes = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestosRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(91, 93);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(186, 19);
            this.materialLabel2.TabIndex = 351;
            this.materialLabel2.Text = "NOMBRE DEL EMPLEADO";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmpleado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(696, 77);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(67, 48);
            this.btnBuscarEmpleado.TabIndex = 352;
            this.btnBuscarEmpleado.Text = "...";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // DtpFechahasta
            // 
            this.DtpFechahasta.Location = new System.Drawing.Point(287, 196);
            this.DtpFechahasta.Name = "DtpFechahasta";
            this.DtpFechahasta.Size = new System.Drawing.Size(476, 20);
            this.DtpFechahasta.TabIndex = 356;
            // 
            // DtpFechadesde
            // 
            this.DtpFechadesde.Location = new System.Drawing.Point(287, 146);
            this.DtpFechadesde.Name = "DtpFechadesde";
            this.DtpFechadesde.Size = new System.Drawing.Size(476, 20);
            this.DtpFechadesde.TabIndex = 355;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(100, 148);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(104, 19);
            this.materialLabel1.TabIndex = 354;
            this.materialLabel1.Text = "FECHA DESDE";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(100, 197);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 19);
            this.materialLabel5.TabIndex = 353;
            this.materialLabel5.Text = "FECHA HASTA";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.AnimateReadOnly = false;
            this.txtNombreEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpleado.HideSelection = true;
            this.txtNombreEmpleado.LeadingIcon = null;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(287, 77);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtNombreEmpleado.Size = new System.Drawing.Size(404, 48);
            this.txtNombreEmpleado.TabIndex = 363;
            this.txtNombreEmpleado.TabStop = false;
            this.txtNombreEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpleado.TrailingIcon = null;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(94, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 48);
            this.button1.TabIndex = 362;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarresultado
            // 
            this.btnBuscarresultado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarresultado.FlatAppearance.BorderSize = 0;
            this.btnBuscarresultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscarresultado.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBuscarresultado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarresultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarresultado.Location = new System.Drawing.Point(511, 270);
            this.btnBuscarresultado.Name = "btnBuscarresultado";
            this.btnBuscarresultado.Size = new System.Drawing.Size(252, 48);
            this.btnBuscarresultado.TabIndex = 361;
            this.btnBuscarresultado.Text = "CONSULTAR";
            this.btnBuscarresultado.UseVisualStyleBackColor = false;
            this.btnBuscarresultado.Click += new System.EventHandler(this.btnBuscarresultado_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarraTitulo.Controls.Add(this.label12);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(851, 53);
            this.BarraTitulo.TabIndex = 364;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(606, 31);
            this.label12.TabIndex = 65;
            this.label12.Text = "CONSULTAR MOVIMIENTOS POR EMPLEADO";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(802, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // DgvPuestosRecientes
            // 
            this.DgvPuestosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPuestosRecientes.Location = new System.Drawing.Point(85, 342);
            this.DgvPuestosRecientes.Name = "DgvPuestosRecientes";
            this.DgvPuestosRecientes.Size = new System.Drawing.Size(678, 243);
            this.DgvPuestosRecientes.TabIndex = 365;
            // 
            // FrmPuestoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(851, 640);
            this.Controls.Add(this.DgvPuestosRecientes);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarresultado);
            this.Controls.Add(this.DtpFechahasta);
            this.Controls.Add(this.DtpFechadesde);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.materialLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPuestoHistorial";
            this.Text = "FrmVistaPuestoEmpleadocs";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPuestosRecientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.DateTimePicker DtpFechahasta;
        private System.Windows.Forms.DateTimePicker DtpFechadesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarresultado;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView DgvPuestosRecientes;
    }
}