namespace TF.WIN
{
    partial class frmEstadisticas2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas2));
            this.FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarresultado = new System.Windows.Forms.Button();
            this.chartempxemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ChartHistogramaRula2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPastelRula = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalMetodoPerson = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtjsscont = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNioshCont = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtREBACont = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRulaCont = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcontempleados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreEmpresa = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuscarCUIT = new System.Windows.Forms.Button();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCUIT = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.chartempxemp)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHistogramaRula2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastelRula)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaDesde
            // 
            this.FechaDesde.CustomFormat = "dd/mm/yyyy";
            this.FechaDesde.Location = new System.Drawing.Point(86, 131);
            this.FechaDesde.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(200, 20);
            this.FechaDesde.TabIndex = 1;
            this.FechaDesde.Value = new System.DateTime(2023, 12, 24, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Desde";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(310, 130);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(43, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Hasta";
            // 
            // FechaHasta
            // 
            this.FechaHasta.CustomFormat = "dd/mm/yyyy";
            this.FechaHasta.Location = new System.Drawing.Point(370, 131);
            this.FechaHasta.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(200, 20);
            this.FechaHasta.TabIndex = 3;
            this.FechaHasta.Value = new System.DateTime(2023, 12, 24, 0, 0, 0, 0);
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
            this.btnBuscarresultado.Location = new System.Drawing.Point(22, 170);
            this.btnBuscarresultado.Name = "btnBuscarresultado";
            this.btnBuscarresultado.Size = new System.Drawing.Size(322, 48);
            this.btnBuscarresultado.TabIndex = 59;
            this.btnBuscarresultado.Text = "CONSULTAR";
            this.btnBuscarresultado.UseVisualStyleBackColor = false;
            this.btnBuscarresultado.Click += new System.EventHandler(this.btnBuscarresultado_Click);
            // 
            // chartempxemp
            // 
            this.chartempxemp.BackColor = System.Drawing.Color.Transparent;
            this.chartempxemp.BorderlineColor = System.Drawing.Color.DarkGray;
            this.chartempxemp.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartempxemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartempxemp.Legends.Add(legend1);
            this.chartempxemp.Location = new System.Drawing.Point(22, 940);
            this.chartempxemp.Margin = new System.Windows.Forms.Padding(2);
            this.chartempxemp.Name = "chartempxemp";
            this.chartempxemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartempxemp.Series.Add(series1);
            this.chartempxemp.Size = new System.Drawing.Size(386, 372);
            this.chartempxemp.TabIndex = 111;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel10.Controls.Add(this.label11);
            this.panel10.Location = new System.Drawing.Point(22, 888);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(778, 46);
            this.panel10.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(290, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "ESTADISTICAS MÉTODO REBA";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChartHistogramaRula2
            // 
            this.ChartHistogramaRula2.BackColor = System.Drawing.Color.Transparent;
            this.ChartHistogramaRula2.BorderlineColor = System.Drawing.Color.DarkGray;
            this.ChartHistogramaRula2.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.ChartHistogramaRula2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartHistogramaRula2.Legends.Add(legend2);
            this.ChartHistogramaRula2.Location = new System.Drawing.Point(415, 602);
            this.ChartHistogramaRula2.Margin = new System.Windows.Forms.Padding(2);
            this.ChartHistogramaRula2.Name = "ChartHistogramaRula2";
            this.ChartHistogramaRula2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartHistogramaRula2.Series.Add(series2);
            this.ChartHistogramaRula2.Size = new System.Drawing.Size(386, 332);
            this.ChartHistogramaRula2.TabIndex = 109;
            // 
            // chartPastelRula
            // 
            this.chartPastelRula.BackColor = System.Drawing.Color.Transparent;
            this.chartPastelRula.BorderlineColor = System.Drawing.Color.DarkGray;
            this.chartPastelRula.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartPastelRula.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPastelRula.Legends.Add(legend3);
            this.chartPastelRula.Location = new System.Drawing.Point(22, 602);
            this.chartPastelRula.Margin = new System.Windows.Forms.Padding(2);
            this.chartPastelRula.Name = "chartPastelRula";
            this.chartPastelRula.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPastelRula.Series.Add(series3);
            this.chartPastelRula.Size = new System.Drawing.Size(386, 366);
            this.chartPastelRula.TabIndex = 108;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Controls.Add(this.button5);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.TotalMetodoPerson);
            this.panel9.Location = new System.Drawing.Point(223, 264);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(194, 110);
            this.panel9.TabIndex = 103;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(124, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 103);
            this.button5.TabIndex = 90;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(14, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "METODOS";
            // 
            // TotalMetodoPerson
            // 
            this.TotalMetodoPerson.AutoSize = true;
            this.TotalMetodoPerson.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.TotalMetodoPerson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TotalMetodoPerson.Location = new System.Drawing.Point(10, 36);
            this.TotalMetodoPerson.Name = "TotalMetodoPerson";
            this.TotalMetodoPerson.Size = new System.Drawing.Size(60, 46);
            this.TotalMetodoPerson.TabIndex = 4;
            this.TotalMetodoPerson.Text = "N°";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(22, 550);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(778, 46);
            this.panel8.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(290, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "ESTADISTICAS MÉTODO RULA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtjsscont);
            this.panel5.Location = new System.Drawing.Point(607, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 110);
            this.panel5.TabIndex = 107;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(106, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 110);
            this.button3.TabIndex = 90;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "JSS";
            // 
            // txtjsscont
            // 
            this.txtjsscont.AutoSize = true;
            this.txtjsscont.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtjsscont.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtjsscont.Location = new System.Drawing.Point(19, 32);
            this.txtjsscont.Name = "txtjsscont";
            this.txtjsscont.Size = new System.Drawing.Size(60, 46);
            this.txtjsscont.TabIndex = 4;
            this.txtjsscont.Text = "N°";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Olive;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNioshCont);
            this.panel2.Location = new System.Drawing.Point(214, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 110);
            this.panel2.TabIndex = 105;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(110, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 110);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "NIOSH";
            // 
            // txtNioshCont
            // 
            this.txtNioshCont.AutoSize = true;
            this.txtNioshCont.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtNioshCont.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNioshCont.Location = new System.Drawing.Point(12, 36);
            this.txtNioshCont.Name = "txtNioshCont";
            this.txtNioshCont.Size = new System.Drawing.Size(60, 46);
            this.txtNioshCont.TabIndex = 4;
            this.txtNioshCont.Text = "N°";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.txtREBACont);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(415, 433);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(186, 110);
            this.panel7.TabIndex = 106;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(103, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 110);
            this.button4.TabIndex = 87;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtREBACont
            // 
            this.txtREBACont.AutoSize = true;
            this.txtREBACont.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtREBACont.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtREBACont.Location = new System.Drawing.Point(13, 36);
            this.txtREBACont.Name = "txtREBACont";
            this.txtREBACont.Size = new System.Drawing.Size(60, 46);
            this.txtREBACont.TabIndex = 4;
            this.txtREBACont.Text = "N°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "REBA";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.txtRulaCont);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(22, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 110);
            this.panel3.TabIndex = 104;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(103, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 110);
            this.button2.TabIndex = 87;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtRulaCont
            // 
            this.txtRulaCont.AutoSize = true;
            this.txtRulaCont.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtRulaCont.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtRulaCont.Location = new System.Drawing.Point(13, 36);
            this.txtRulaCont.Name = "txtRulaCont";
            this.txtRulaCont.Size = new System.Drawing.Size(60, 46);
            this.txtRulaCont.TabIndex = 4;
            this.txtRulaCont.Text = "N°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "RULA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(22, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 46);
            this.panel1.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(334, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "METODOS DE ANALISIS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel6.Controls.Add(this.btnEmpleados);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtcontempleados);
            this.panel6.Location = new System.Drawing.Point(22, 264);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 110);
            this.panel6.TabIndex = 102;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.Location = new System.Drawing.Point(124, 3);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(68, 103);
            this.btnEmpleados.TabIndex = 90;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "EMPLEADOS";
            // 
            // txtcontempleados
            // 
            this.txtcontempleados.AutoSize = true;
            this.txtcontempleados.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.txtcontempleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtcontempleados.Location = new System.Drawing.Point(12, 36);
            this.txtcontempleados.Name = "txtcontempleados";
            this.txtcontempleados.Size = new System.Drawing.Size(60, 46);
            this.txtcontempleados.TabIndex = 4;
            this.txtcontempleados.Text = "N°";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(367, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(203, 48);
            this.btnSalir.TabIndex = 112;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 80);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 162;
            this.materialLabel3.Text = "EMPRESA";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.AnimateReadOnly = false;
            this.txtNombreEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNombreEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNombreEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Enabled = false;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpresa.HideSelection = true;
            this.txtNombreEmpresa.LeadingIcon = null;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(136, 65);
            this.txtNombreEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEmpresa.MaxLength = 32767;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.PasswordChar = '\0';
            this.txtNombreEmpresa.PrefixSuffixText = null;
            this.txtNombreEmpresa.ReadOnly = true;
            this.txtNombreEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmpresa.SelectedText = "";
            this.txtNombreEmpresa.SelectionLength = 0;
            this.txtNombreEmpresa.SelectionStart = 0;
            this.txtNombreEmpresa.ShortcutsEnabled = true;
            this.txtNombreEmpresa.Size = new System.Drawing.Size(352, 48);
            this.txtNombreEmpresa.TabIndex = 161;
            this.txtNombreEmpresa.TabStop = false;
            this.txtNombreEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmpresa.TrailingIcon = null;
            this.txtNombreEmpresa.UseSystemPasswordChar = false;
            // 
            // btnBuscarCUIT
            // 
            this.btnBuscarCUIT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscarCUIT.FlatAppearance.BorderSize = 0;
            this.btnBuscarCUIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscarCUIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCUIT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarCUIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCUIT.Location = new System.Drawing.Point(503, 11);
            this.btnBuscarCUIT.Name = "btnBuscarCUIT";
            this.btnBuscarCUIT.Size = new System.Drawing.Size(67, 48);
            this.btnBuscarCUIT.TabIndex = 160;
            this.btnBuscarCUIT.Text = "...";
            this.btnBuscarCUIT.UseVisualStyleBackColor = false;
            this.btnBuscarCUIT.Click += new System.EventHandler(this.btnBuscarCUIT_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(19, 24);
            this.materialLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(35, 19);
            this.materialLabel11.TabIndex = 159;
            this.materialLabel11.Text = "CUIT";
            // 
            // txtCUIT
            // 
            this.txtCUIT.AnimateReadOnly = false;
            this.txtCUIT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCUIT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCUIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCUIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCUIT.Depth = 0;
            this.txtCUIT.Enabled = false;
            this.txtCUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUIT.HideSelection = true;
            this.txtCUIT.LeadingIcon = null;
            this.txtCUIT.Location = new System.Drawing.Point(136, 11);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(2);
            this.txtCUIT.MaxLength = 32767;
            this.txtCUIT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.PasswordChar = '\0';
            this.txtCUIT.PrefixSuffixText = null;
            this.txtCUIT.ReadOnly = true;
            this.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCUIT.SelectedText = "";
            this.txtCUIT.SelectionLength = 0;
            this.txtCUIT.SelectionStart = 0;
            this.txtCUIT.ShortcutsEnabled = true;
            this.txtCUIT.Size = new System.Drawing.Size(352, 48);
            this.txtCUIT.TabIndex = 158;
            this.txtCUIT.TabStop = false;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCUIT.TrailingIcon = null;
            this.txtCUIT.UseSystemPasswordChar = false;
            // 
            // frmEstadisticas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(893, 850);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.btnBuscarCUIT);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chartempxemp);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.ChartHistogramaRula2);
            this.Controls.Add(this.chartPastelRula);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnBuscarresultado);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.FechaDesde);
            this.Name = "frmEstadisticas2";
            this.Text = "frmEstadisticas2";
            this.Load += new System.EventHandler(this.frmEstadisticas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartempxemp)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHistogramaRula2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPastelRula)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker FechaDesde;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker FechaHasta;
        private System.Windows.Forms.Button btnBuscarresultado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartempxemp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartHistogramaRula2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPastelRula;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalMetodoPerson;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtjsscont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtNioshCont;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtREBACont;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtRulaCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtcontempleados;
        private System.Windows.Forms.Button btnSalir;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmpresa;
        private System.Windows.Forms.Button btnBuscarCUIT;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox2 txtCUIT;
    }
}