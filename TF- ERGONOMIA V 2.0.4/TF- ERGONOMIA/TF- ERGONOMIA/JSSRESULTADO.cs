using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using iTextSharp.tool.xml.html.head;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;
using System.Windows.Forms.DataVisualization.Charting;
using TF.COMMON.Cache;

namespace TF.WIN
{
    public partial class JSSRESULTADO : Form
    {

        private int fileCounter = 1; // Declarar fileCounter en el ámbito de la clase

        public JSSRESULTADO()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void JSSRESULTADO_Load(object sender, EventArgs e)
        {

           






        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadUserData()
        {
            userlabel1.Text = UserLoginCache.Nombre + ' ' + UserLoginCache.Apellido;
            userlabel2.Text = UserLoginCache.Cargo;
        }

        public void ObtenerMaximoIdJSS()
        {
            JssBC oJssBC = new JssBC();
            jss Ojss = new jss();
            DataTable dt200 = oJssBC.JssMaxIDBC(Ojss);

            if (dt200.Rows.Count > 0)
            {
                int maxIdJSS = Convert.ToInt32(dt200.Rows[0]["cargaIdJSS"]);
                txtcargaidJSS.Text = maxIdJSS.ToString();
            }

        }
        public void JssRescatar()
        {
            try
            {

                jss Ojss = new jss();
                Ojss.cargaIdJSS  = Convert.ToInt32(txtcargaidJSS.Text);
                JssBC oJssBC = new JssBC();

                DataTable dt225 = oJssBC.Jss_ResultadoBC(Ojss);

                if (dt225.Rows.Count > 0)
                {
                    string resultado = dt225.Rows[0][1].ToString();
                    txtCuit.Text = resultado;

                    string resultado1 = dt225.Rows[0][2].ToString();
                    txtpuestotrabajojss.Text = resultado1;

                    string resultado2 = dt225.Rows[0][3].ToString();
                    txtDMAR.Text = resultado2;

                    string resultado3 = dt225.Rows[0][4].ToString();
                    txtEmpleadojss.Text = resultado3;

                    string resultado4 = dt225.Rows[0][5].ToString();
                    txtEmpresajss.Text = resultado4;

                    string resultado5 = dt225.Rows[0][6].ToString();
                    txtDMA.Text = resultado5;

                    string resultado6 = dt225.Rows[0][7].ToString();
                    txtCTL.Text = resultado6;

                    string resultado7 = dt225.Rows[0][8].ToString();
                    txtAS.Text = resultado7;

                    string resultado8 = dt225.Rows[0][9].ToString();
                    txtDMAR.Text = resultado8;

                    string resultado9 = dt225.Rows[0][10].ToString();
                    txtCTLR.Text = resultado9;

                    string resultado10 = dt225.Rows[0][11].ToString();
                    txtASR.Text = resultado10;
                }
            }

            catch { }
        }
        private void btnRecuperarCarga_Click(object sender, EventArgs e)
        {
            JssRescatar();
            ObtenerMaximoIdJSS();

            try
            {
                int c1 = int.Parse(txtCTL.Text);
       
                int d1 = int.Parse(txtDMA.Text);
               
                int as6 = int.Parse(txtAS.Text);

                int Control = c1;

                int Demanda = d1;
             
                int ApoyoSocial = as6;
                
                if (Demanda < 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con bajo Apoyo Social"; txtSituacionJss.Text = "Trabajo Pasivo"; }
                else if (Demanda < 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; txtSituacionJss.Text = "Trabajo Pasivo"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Bajo Apoyo Social"; txtSituacionJss.Text = "Trabajo Pasivo"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; txtSituacionJss.Text = "Trabajo Pasivo"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con bajo Apoyo Social"; txtSituacionJss.Text = "Alto Nivel de estrés"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; txtSituacionJss.Text = "Alto Nivel de estrés"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Bajo Apoyo Social"; txtSituacionJss.Text = "Alto Nivel de estrés"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; txtSituacionJss.Text = "Alto Nivel de estrés"; }

            }
            catch { }


            GuardarResultado();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
        private string GetUniqueFileName(string baseFileName)
        {
            string fileName = $"{baseFileName}{fileCounter}.pdf";
            fileCounter++;
            return fileName;
        }
        private void btnobtenerinforme_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = GetUniqueFileName("Informe");

            // Configurar el cuadro de diálogo para guardar como PDF
            guardar.DefaultExt = "pdf";
            guardar.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 80, 30, 25, 50);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(TF.WIN.Properties.Resources.ergo, System.Drawing.Imaging.ImageFormat.Png);
                        img.ScaleToFit(90, 90);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 50);
                        pdfDoc.Add(img);

                        // Reemplazos en el HTML
                        string paginahtml3_texto = TF.WIN.Properties.Resources.planilla1.ToString();

                        paginahtml3_texto = paginahtml3_texto.Replace("@Fecha", DateTime.Now.ToString("G"));
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtCuit", txtCuit.Text); 
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtpuestotrabajojss", txtpuestotrabajojss.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtEmpleadojss", txtEmpleadojss.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtEmpresajss", txtEmpresajss.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtDMA", txtDMA.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtCTL", txtCTL.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtAS", txtAS.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtSituacionJss", txtSituacionJss.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@txtActuacionJSS1", txtActuacionJSS1.Text);
                        paginahtml3_texto = paginahtml3_texto.Replace("@lblUsuario", userlabel1.Text);


                        // Agregar más reemplazos para los campos adicionales según tus necesidades...

                        using (StringReader sr = new StringReader(paginahtml3_texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        private void GuardarResultado()
        {

                   jss Ojss = new jss();
                JssBC oJssBC = new JssBC();

                Ojss.cargaIdJSS = Convert.ToInt32(txtcargaidJSS.Text);
                Ojss.ResultadoAnalisisJss = txtSituacionJss.Text;
               
                var res = oJssBC.UpdateJss2BC(Ojss);
         
        }

    }
    }
