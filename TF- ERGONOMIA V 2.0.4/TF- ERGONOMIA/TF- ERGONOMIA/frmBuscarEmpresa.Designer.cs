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
            this.cboBuscadorDinamico = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBuscador = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 23);
            this.materialLabel1.TabIndex = 62;
            // 
            // txtCUITEmpresa
            // 
            this.txtCUITEmpresa.AnimateReadOnly = false;
            this.txtCUITEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCUITEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCUITEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUITEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUITEmpresa.Depth = 0;
            this.txtCUITEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUITEmpresa.HideSelection = true;
            this.txtCUITEmpresa.LeadingIcon = null;
            this.txtCUITEmpresa.Location = new System.Drawing.Point(101, 57);
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
            this.btnAceptar.Location = new System.Drawing.Point(240, 219);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 35);
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
            this.btnBuscar.Location = new System.Drawing.Point(268, 36);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 38);
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
            this.btnCancelar.Location = new System.Drawing.Point(88, 219);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 35);
            this.btnCancelar.TabIndex = 54;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(9, 89);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(381, 124);
            this.dgvResultado.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.Location = new System.Drawing.Point(112, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
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
            this.btnBuscartodo.Location = new System.Drawing.Point(377, 37);
            this.btnBuscartodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(40, 38);
            this.btnBuscartodo.TabIndex = 61;
            this.btnBuscartodo.Text = "Buscar Todo";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            this.btnBuscartodo.Visible = false;
            this.btnBuscartodo.Click += new System.EventHandler(this.btnBuscartodo_Click);
            // 
            // cboBuscadorDinamico
            // 
            this.cboBuscadorDinamico.AutoResize = false;
            this.cboBuscadorDinamico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboBuscadorDinamico.Depth = 0;
            this.cboBuscadorDinamico.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboBuscadorDinamico.DropDownHeight = 174;
            this.cboBuscadorDinamico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscadorDinamico.DropDownWidth = 121;
            this.cboBuscadorDinamico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cboBuscadorDinamico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboBuscadorDinamico.FormattingEnabled = true;
            this.cboBuscadorDinamico.IntegralHeight = false;
            this.cboBuscadorDinamico.ItemHeight = 43;
            this.cboBuscadorDinamico.Items.AddRange(new object[] {
            "CUIT",
            "Razón Social"});
            this.cboBuscadorDinamico.Location = new System.Drawing.Point(9, 37);
            this.cboBuscadorDinamico.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscadorDinamico.MaxDropDownItems = 4;
            this.cboBuscadorDinamico.MouseState = MaterialSkin.MouseState.OUT;
            this.cboBuscadorDinamico.Name = "cboBuscadorDinamico";
            this.cboBuscadorDinamico.Size = new System.Drawing.Size(112, 49);
            this.cboBuscadorDinamico.StartIndex = 0;
            this.cboBuscadorDinamico.TabIndex = 110;
            // 
            // txtBuscador
            // 
            this.txtBuscador.AnimateReadOnly = false;
            this.txtBuscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscador.Depth = 0;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscador.HideSelection = true;
            this.txtBuscador.LeadingIcon = null;
            this.txtBuscador.Location = new System.Drawing.Point(123, 38);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscador.MaxLength = 32767;
            this.txtBuscador.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PasswordChar = '\0';
            this.txtBuscador.PrefixSuffixText = null;
            this.txtBuscador.ReadOnly = false;
            this.txtBuscador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.SelectionLength = 0;
            this.txtBuscador.SelectionStart = 0;
            this.txtBuscador.ShortcutsEnabled = true;
            this.txtBuscador.Size = new System.Drawing.Size(141, 48);
            this.txtBuscador.TabIndex = 109;
            this.txtBuscador.TabStop = false;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscador.TrailingIcon = null;
            this.txtBuscador.UseSystemPasswordChar = false;
            // 
            // frmBuscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(446, 297);
            this.Controls.Add(this.cboBuscadorDinamico);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.btnBuscartodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtCUITEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private MaterialSkin.Controls.MaterialComboBox cboBuscadorDinamico;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscador;
    }
}