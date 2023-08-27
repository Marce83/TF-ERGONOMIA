namespace TF.WIN
{
    partial class frmBuscarEmpresa
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUITEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscartodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Empresa:";
            // 
            // txtCUITEmpresa
            // 
            this.txtCUITEmpresa.AnimateReadOnly = false;
            this.txtCUITEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUITEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUITEmpresa.Depth = 0;
            this.txtCUITEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUITEmpresa.HideSelection = true;
            this.txtCUITEmpresa.LeadingIcon = null;
            this.txtCUITEmpresa.Location = new System.Drawing.Point(102, 57);
            this.txtCUITEmpresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCUITEmpresa.MaxLength = 32767;
            this.txtCUITEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCUITEmpresa.Name = "txtCUITEmpresa";
            this.txtCUITEmpresa.PasswordChar = '\0';
            this.txtCUITEmpresa.PrefixSuffixText = null;
            this.txtCUITEmpresa.ReadOnly = false;
            this.txtCUITEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCUITEmpresa.SelectedText = "";
            this.txtCUITEmpresa.SelectionLength = 0;
            this.txtCUITEmpresa.SelectionStart = 0;
            this.txtCUITEmpresa.ShortcutsEnabled = true;
            this.txtCUITEmpresa.Size = new System.Drawing.Size(209, 48);
            this.txtCUITEmpresa.TabIndex = 44;
            this.txtCUITEmpresa.TabStop = false;
            this.txtCUITEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUITEmpresa.TrailingIcon = null;
            this.txtCUITEmpresa.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(375, 380);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 43);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(328, 57);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 48);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(156, 380);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 43);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(102, 140);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(544, 209);
            this.dgvResultado.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 38);
            this.label1.TabIndex = 60;
            this.label1.Text = "BUSCAR EMPRESAS";
            // 
            // btnBuscartodo
            // 
            this.btnBuscartodo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscartodo.FlatAppearance.BorderSize = 0;
            this.btnBuscartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscartodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscartodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscartodo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscartodo.Location = new System.Drawing.Point(491, 57);
            this.btnBuscartodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(155, 47);
            this.btnBuscartodo.TabIndex = 61;
            this.btnBuscartodo.Text = "Buscar Todo";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            this.btnBuscartodo.Click += new System.EventHandler(this.btnBuscartodo_Click);
            // 
            // frmBuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(677, 449);
            this.Controls.Add(this.btnBuscartodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCUITEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarEmpresa";
            this.Text = "BuscarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUITEmpresa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscartodo;
    }
}