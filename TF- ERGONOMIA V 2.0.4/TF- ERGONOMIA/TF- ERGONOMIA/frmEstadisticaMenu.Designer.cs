namespace TF.WIN
{
    partial class frmEstadisticaMenu
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
            this.btnEstidisticaparticular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstadisticageneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstidisticaparticular
            // 
            this.btnEstidisticaparticular.BackColor = System.Drawing.Color.IndianRed;
            this.btnEstidisticaparticular.FlatAppearance.BorderSize = 0;
            this.btnEstidisticaparticular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEstidisticaparticular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstidisticaparticular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstidisticaparticular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstidisticaparticular.Location = new System.Drawing.Point(81, 109);
            this.btnEstidisticaparticular.Name = "btnEstidisticaparticular";
            this.btnEstidisticaparticular.Size = new System.Drawing.Size(268, 35);
            this.btnEstidisticaparticular.TabIndex = 75;
            this.btnEstidisticaparticular.Text = "ESTADISTICAS POR EMPRESA";
            this.btnEstidisticaparticular.UseVisualStyleBackColor = false;
            this.btnEstidisticaparticular.Click += new System.EventHandler(this.btnEstidisticaparticular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "SELECCION DE ESTADISTICA";
            // 
            // btnEstadisticageneral
            // 
            this.btnEstadisticageneral.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEstadisticageneral.FlatAppearance.BorderSize = 0;
            this.btnEstadisticageneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEstadisticageneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticageneral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEstadisticageneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticageneral.Location = new System.Drawing.Point(81, 53);
            this.btnEstadisticageneral.Name = "btnEstadisticageneral";
            this.btnEstadisticageneral.Size = new System.Drawing.Size(268, 35);
            this.btnEstadisticageneral.TabIndex = 71;
            this.btnEstadisticageneral.Text = "ESTADISTICA GENERAL";
            this.btnEstadisticageneral.UseVisualStyleBackColor = false;
            this.btnEstadisticageneral.Click += new System.EventHandler(this.btnEstadisticageneral_Click);
            // 
            // frmEstadisticaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(424, 177);
            this.Controls.Add(this.btnEstidisticaparticular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstadisticageneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstadisticaMenu";
            this.Text = "frmEstadisticaMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEstidisticaparticular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstadisticageneral;
    }
}