namespace TF.WIN
{
    partial class PuestoTrabajoSeleccion
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
            this.btnAsociacionPuesto = new System.Windows.Forms.Button();
            this.btnCargaPuesto = new System.Windows.Forms.Button();
            this.btnempleadosasociados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAsociacionPuesto
            // 
            this.btnAsociacionPuesto.BackColor = System.Drawing.Color.IndianRed;
            this.btnAsociacionPuesto.FlatAppearance.BorderSize = 0;
            this.btnAsociacionPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAsociacionPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsociacionPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAsociacionPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsociacionPuesto.Location = new System.Drawing.Point(16, 80);
            this.btnAsociacionPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsociacionPuesto.Name = "btnAsociacionPuesto";
            this.btnAsociacionPuesto.Size = new System.Drawing.Size(357, 58);
            this.btnAsociacionPuesto.TabIndex = 77;
            this.btnAsociacionPuesto.Text = "ASOCIACION DE PUESTOS";
            this.btnAsociacionPuesto.UseVisualStyleBackColor = false;
            this.btnAsociacionPuesto.Click += new System.EventHandler(this.btnAsociacionPuesto_Click);
            // 
            // btnCargaPuesto
            // 
            this.btnCargaPuesto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargaPuesto.FlatAppearance.BorderSize = 0;
            this.btnCargaPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCargaPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargaPuesto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCargaPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargaPuesto.Location = new System.Drawing.Point(16, 15);
            this.btnCargaPuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargaPuesto.Name = "btnCargaPuesto";
            this.btnCargaPuesto.Size = new System.Drawing.Size(357, 58);
            this.btnCargaPuesto.TabIndex = 76;
            this.btnCargaPuesto.Text = "CARGA PUESTO DE TRABAJO";
            this.btnCargaPuesto.UseVisualStyleBackColor = false;
            this.btnCargaPuesto.Click += new System.EventHandler(this.btnCargaPuesto_Click);
            // 
            // btnempleadosasociados
            // 
            this.btnempleadosasociados.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnempleadosasociados.FlatAppearance.BorderSize = 0;
            this.btnempleadosasociados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnempleadosasociados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleadosasociados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnempleadosasociados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleadosasociados.Location = new System.Drawing.Point(16, 212);
            this.btnempleadosasociados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnempleadosasociados.Name = "btnempleadosasociados";
            this.btnempleadosasociados.Size = new System.Drawing.Size(357, 58);
            this.btnempleadosasociados.TabIndex = 78;
            this.btnempleadosasociados.Text = "VER EMPLEADOS ASOCIADOS";
            this.btnempleadosasociados.UseVisualStyleBackColor = false;
            this.btnempleadosasociados.Click += new System.EventHandler(this.btnempleadosasociados_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 146);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 58);
            this.button1.TabIndex = 79;
            this.button1.Text = "ASOCIACION DE PUESTOS MULTIPLES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PuestoTrabajoSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(416, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnempleadosasociados);
            this.Controls.Add(this.btnAsociacionPuesto);
            this.Controls.Add(this.btnCargaPuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PuestoTrabajoSeleccion";
            this.Text = "PuestoTrabajoSeleccion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsociacionPuesto;
        private System.Windows.Forms.Button btnCargaPuesto;
        private System.Windows.Forms.Button btnempleadosasociados;
        private System.Windows.Forms.Button button1;
    }
}