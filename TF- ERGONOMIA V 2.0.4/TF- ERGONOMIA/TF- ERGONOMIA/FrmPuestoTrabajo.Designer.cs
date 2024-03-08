namespace TF.WIN
{
    partial class FrmPuestoTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuestoTrabajo));
            this.CboPuestoTrabajo = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCargarPuesto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CboAreaempresa = new MaterialSkin.Controls.MaterialComboBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CboPuestoTrabajo
            // 
            this.CboPuestoTrabajo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboPuestoTrabajo.AutoResize = false;
            this.CboPuestoTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboPuestoTrabajo.Depth = 0;
            this.CboPuestoTrabajo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboPuestoTrabajo.DropDownHeight = 174;
            this.CboPuestoTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPuestoTrabajo.DropDownWidth = 121;
            this.CboPuestoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboPuestoTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboPuestoTrabajo.FormattingEnabled = true;
            this.CboPuestoTrabajo.IntegralHeight = false;
            this.CboPuestoTrabajo.ItemHeight = 43;
            this.CboPuestoTrabajo.Items.AddRange(new object[] {
            "Seleccione",
            "Vendedor",
            "Administrador",
            "Operario",
            "Supervisor / Coordinador",
            "Jefe",
            "Gerente",
            "Director",
            "Vicepresidente",
            "Presidente"});
            this.CboPuestoTrabajo.Location = new System.Drawing.Point(252, 80);
            this.CboPuestoTrabajo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboPuestoTrabajo.MaxDropDownItems = 4;
            this.CboPuestoTrabajo.MouseState = MaterialSkin.MouseState.OUT;
            this.CboPuestoTrabajo.Name = "CboPuestoTrabajo";
            this.CboPuestoTrabajo.Size = new System.Drawing.Size(265, 49);
            this.CboPuestoTrabajo.StartIndex = 0;
            this.CboPuestoTrabajo.TabIndex = 0;
            this.CboPuestoTrabajo.SelectedIndexChanged += new System.EventHandler(this.CboPuestoTrabajo_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(56, 96);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "PUESTO";
            // 
            // btnCargarPuesto
            // 
            this.btnCargarPuesto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargarPuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargarPuesto.FlatAppearance.BorderSize = 0;
            this.btnCargarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPuesto.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCargarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarPuesto.Location = new System.Drawing.Point(573, 80);
            this.btnCargarPuesto.Name = "btnCargarPuesto";
            this.btnCargarPuesto.Size = new System.Drawing.Size(116, 49);
            this.btnCargarPuesto.TabIndex = 74;
            this.btnCargarPuesto.Text = "CARGAR";
            this.btnCargarPuesto.UseVisualStyleBackColor = false;
            this.btnCargarPuesto.Click += new System.EventHandler(this.btnCargarPuesto_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(573, 152);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 49);
            this.btnSalir.TabIndex = 75;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(56, 168);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(163, 19);
            this.materialLabel2.TabIndex = 76;
            this.materialLabel2.Text = "ÁREA DE LA EMPRESA";
            // 
            // CboAreaempresa
            // 
            this.CboAreaempresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboAreaempresa.AutoResize = false;
            this.CboAreaempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboAreaempresa.Depth = 0;
            this.CboAreaempresa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CboAreaempresa.DropDownHeight = 174;
            this.CboAreaempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAreaempresa.DropDownWidth = 121;
            this.CboAreaempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CboAreaempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CboAreaempresa.FormattingEnabled = true;
            this.CboAreaempresa.IntegralHeight = false;
            this.CboAreaempresa.ItemHeight = 43;
            this.CboAreaempresa.Items.AddRange(new object[] {
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
            this.CboAreaempresa.Location = new System.Drawing.Point(252, 152);
            this.CboAreaempresa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboAreaempresa.MaxDropDownItems = 4;
            this.CboAreaempresa.MouseState = MaterialSkin.MouseState.OUT;
            this.CboAreaempresa.Name = "CboAreaempresa";
            this.CboAreaempresa.Size = new System.Drawing.Size(265, 49);
            this.CboAreaempresa.StartIndex = 0;
            this.CboAreaempresa.TabIndex = 77;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BarraTitulo.Controls.Add(this.pictureBox3);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(750, 53);
            this.BarraTitulo.TabIndex = 342;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(716, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 239;
            this.label1.Text = "CARGA PUESTO DE TRABAJO";
            // 
            // FrmPuestoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(750, 234);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.CboAreaempresa);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarPuesto);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CboPuestoTrabajo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPuestoTrabajo";
            this.Text = "FrmPuestoTrabajocs";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox CboPuestoTrabajo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Button btnCargarPuesto;
        private System.Windows.Forms.Button btnSalir;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        private MaterialSkin.Controls.MaterialComboBox CboAreaempresa;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;


    }
}