﻿namespace TF.WIN
{
    partial class frmBuscarEmpleados
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
            this.btnBuscartodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDNIempleado = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
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
            this.btnBuscartodo.Location = new System.Drawing.Point(514, 67);
            this.btnBuscartodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscartodo.Name = "btnBuscartodo";
            this.btnBuscartodo.Size = new System.Drawing.Size(155, 43);
            this.btnBuscartodo.TabIndex = 77;
            this.btnBuscartodo.Text = "Buscar Todo";
            this.btnBuscartodo.UseVisualStyleBackColor = false;
            this.btnBuscartodo.Click += new System.EventHandler(this.btnBuscartodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 76;
            this.label1.Text = "BUSCAR EMPLEADO";
            // 
            // dgvResultado
            // 
            this.dgvResultado.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(13, 146);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(656, 209);
            this.dgvResultado.TabIndex = 75;
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
            this.btnCancelar.Location = new System.Drawing.Point(387, 375);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 43);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(352, 67);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 43);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(178, 375);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 43);
            this.btnAceptar.TabIndex = 72;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(10, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 19);
            this.materialLabel1.TabIndex = 70;
            this.materialLabel1.Text = "DNI:";
            // 
            // txtDNIempleado
            // 
            this.txtDNIempleado.AnimateReadOnly = false;
            this.txtDNIempleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDNIempleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDNIempleado.Depth = 0;
            this.txtDNIempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDNIempleado.HideSelection = true;
            this.txtDNIempleado.LeadingIcon = null;
            this.txtDNIempleado.Location = new System.Drawing.Point(82, 62);
            this.txtDNIempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNIempleado.MaxLength = 32767;
            this.txtDNIempleado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDNIempleado.Name = "txtDNIempleado";
            this.txtDNIempleado.PasswordChar = '\0';
            this.txtDNIempleado.PrefixSuffixText = null;
            this.txtDNIempleado.ReadOnly = false;
            this.txtDNIempleado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDNIempleado.SelectedText = "";
            this.txtDNIempleado.SelectionLength = 0;
            this.txtDNIempleado.SelectionStart = 0;
            this.txtDNIempleado.ShortcutsEnabled = true;
            this.txtDNIempleado.Size = new System.Drawing.Size(251, 48);
            this.txtDNIempleado.TabIndex = 71;
            this.txtDNIempleado.TabStop = false;
            this.txtDNIempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDNIempleado.TrailingIcon = null;
            this.txtDNIempleado.UseSystemPasswordChar = false;
            // 
            // frmBuscarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.btnBuscartodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtDNIempleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarEmpleados";
            this.Text = "frmBuscarEmpleados";
            this.Load += new System.EventHandler(this.frmBuscarEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscartodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtDNIempleado;
    }
}