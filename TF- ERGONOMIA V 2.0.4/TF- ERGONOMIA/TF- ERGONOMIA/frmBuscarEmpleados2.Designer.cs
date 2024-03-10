namespace TF.WIN
{
    partial class frmBuscarEmpleados2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtBuscador = new MaterialSkin.Controls.MaterialTextBox2();
            this.cboBuscadorDinamico = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 83;
            this.label1.Text = "BUSCAR EMPLEADO";
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResultado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvResultado.ColumnHeadersHeight = 25;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultado.EnableHeadersVisualStyles = false;
            this.dgvResultado.Location = new System.Drawing.Point(4, 104);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(513, 160);
            this.dgvResultado.TabIndex = 82;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(51, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 41);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.Text = "SALIR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(372, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 43);
            this.btnBuscar.TabIndex = 80;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(359, 270);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 41);
            this.btnAceptar.TabIndex = 79;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscador.AnimateReadOnly = false;
            this.txtBuscador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBuscador.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscador.Depth = 0;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscador.HideSelection = true;
            this.txtBuscador.LeadingIcon = null;
            this.txtBuscador.Location = new System.Drawing.Point(154, 51);
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
            this.txtBuscador.Size = new System.Drawing.Size(213, 48);
            this.txtBuscador.TabIndex = 78;
            this.txtBuscador.TabStop = false;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscador.TrailingIcon = null;
            this.txtBuscador.UseSystemPasswordChar = false;
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // cboBuscadorDinamico
            // 
            this.cboBuscadorDinamico.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            "DNI",
            "NOMBRE"});
            this.cboBuscadorDinamico.Location = new System.Drawing.Point(4, 50);
            this.cboBuscadorDinamico.Margin = new System.Windows.Forms.Padding(2);
            this.cboBuscadorDinamico.MaxDropDownItems = 4;
            this.cboBuscadorDinamico.MouseState = MaterialSkin.MouseState.OUT;
            this.cboBuscadorDinamico.Name = "cboBuscadorDinamico";
            this.cboBuscadorDinamico.Size = new System.Drawing.Size(146, 49);
            this.cboBuscadorDinamico.StartIndex = 0;
            this.cboBuscadorDinamico.TabIndex = 109;
            this.cboBuscadorDinamico.SelectedIndexChanged += new System.EventHandler(this.cboBuscadorDinamico_SelectedIndexChanged);
            // 
            // frmBuscarEmpleados2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(520, 324);
            this.Controls.Add(this.cboBuscadorDinamico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBuscador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarEmpleados2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarEmpleados2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBuscarEmpleados2_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuscador;
        private MaterialSkin.Controls.MaterialComboBox cboBuscadorDinamico;
    }
}