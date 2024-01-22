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
            this.btnAsociacionPuesto.Location = new System.Drawing.Point(12, 68);
            this.btnAsociacionPuesto.Name = "btnAsociacionPuesto";
            this.btnAsociacionPuesto.Size = new System.Drawing.Size(268, 35);
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
            this.btnCargaPuesto.Location = new System.Drawing.Point(12, 12);
            this.btnCargaPuesto.Name = "btnCargaPuesto";
            this.btnCargaPuesto.Size = new System.Drawing.Size(268, 35);
            this.btnCargaPuesto.TabIndex = 76;
            this.btnCargaPuesto.Text = "CARGA PUESTO DE TRABAJO";
            this.btnCargaPuesto.UseVisualStyleBackColor = false;
            this.btnCargaPuesto.Click += new System.EventHandler(this.btnCargaPuesto_Click);
            // 
            // PuestoTrabajoSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(312, 140);
            this.Controls.Add(this.btnAsociacionPuesto);
            this.Controls.Add(this.btnCargaPuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PuestoTrabajoSeleccion";
            this.Text = "PuestoTrabajoSeleccion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsociacionPuesto;
        private System.Windows.Forms.Button btnCargaPuesto;
    }
}