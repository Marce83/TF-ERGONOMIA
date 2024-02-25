using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.WIN;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using iTextSharp.tool.xml.css.parser.state;
using TF.ENTITIES;
using TF.BC;
using System.Diagnostics.Eventing.Reader;
using TF.COMMON.Cache;

namespace TF.WIN
{
    public partial class NIOSHRESULTADO : Form
    {

        private int fileCounter = 1; // Declarar fileCounter en el ámbito de la clase

        public NIOSHRESULTADO()
        {
            InitializeComponent();
            ObtenerMaximoIdNIOSH();
            LoadUserData();
        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //btnRestaurar.Visible = false;
            //btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void NIOSHRESULTADO_Load(object sender, EventArgs e)
        {

            // POBLACION
            cboPoblacion.Items.Add(new ComboBoxOption("General", 25));
            cboPoblacion.Items.Add(new ComboBoxOption("Mayor Proteccion", 15));


            // CONTROL
            cboControl.Items.Add(new ComboBoxOption("SI", 1));
            cboControl.Items.Add(new ComboBoxOption("NO", 2));

        }


        public void ObtenerMaximoIdNIOSH()
        {
            NioshBC oNioshBC = new NioshBC();
            Niosh oNiosh = new Niosh();
            DataTable dt = oNioshBC.NioshMaxIDBC(oNiosh);

            if (dt.Rows.Count > 0)
            {
                int maxId = Convert.ToInt32(dt.Rows[0]["cargaIdNiosh"]);
                txtcargaidrebaresultado.Text = maxId.ToString();
            }

        }

        private void btnRecuperarCarga_Click(object sender, EventArgs e)
        {
            try
            {
                NioshRescatar();
                resultadoIl();
                resultadofinal();
                NioshGuardarfinal();
            }
            catch {}

            //NioshGuardarfinal();

        }


        public void NioshRescatar()
        {
            try
            {

                Niosh oNiosh = new Niosh();
                oNiosh.cargaIdNiosh = Convert.ToInt32(txtcargaidrebaresultado.Text);
                NioshBC oNioshBC = new NioshBC();

                DataTable dt109 = oNioshBC.Niosh_ResultadoBC(oNiosh);

                if (dt109.Rows.Count > 0)
                {
                    string resultado = dt109.Rows[0][6].ToString();
                    txtHMD.Text = resultado;

                    string resultado1 = dt109.Rows[0][7].ToString();
                    txtHMI.Text = resultado1;

                    string resultado2 = dt109.Rows[0][8].ToString();
                    txtVMD.Text = resultado2;

                    string resultado3 = dt109.Rows[0][9].ToString();
                    txtVMI.Text = resultado3;

                    string resultado4 = dt109.Rows[0][10].ToString();
                    txtDM.Text = resultado4;

                    string resultado5 = dt109.Rows[0][11].ToString();
                    txtAMD.Text = resultado5;

                    string resultado6 = dt109.Rows[0][12].ToString();
                    txtAMI.Text = resultado6;

                    string resultado7 = dt109.Rows[0][24].ToString();
                    txtFMD.Text = resultado7;

                    string resultado8 = dt109.Rows[0][25].ToString();
                    txtFMI.Text = resultado8;

                    string resultado9 = dt109.Rows[0][26].ToString();
                    txtCMD.Text = resultado9;

                    string resultado10 = dt109.Rows[0][27].ToString();
                    txtCMI.Text = resultado10;

                    string resultado11 = dt109.Rows[0][1].ToString();
                    txtCuit.Text = resultado11;

                    string resultado16 = dt109.Rows[0][20].ToString();
                    txtLC.Text = resultado16;

                    string resultado12 = dt109.Rows[0][2].ToString();
                    txtpuestotrabajoNiosh.Text = resultado12;

                    string resultado14 = dt109.Rows[0][4].ToString();
                    txtEmpleadoNiosh.Text = resultado14;

                    string resultado15 = dt109.Rows[0][5].ToString();
                    txtEmpresaNiosh.Text = resultado15;

                }


            }

            catch 
            {
             MessageBox.Show("No se encontró un análisis realizado");
            }

        }

        private void resultadoIl()
        {

            double LPRD = 0;
            double LPRI = 0;

            LPRD = double.Parse(txtPoblacion.Text) * double.Parse(txtHMD.Text) * double.Parse(txtVMD.Text) * double.Parse(txtDM.Text) * double.Parse(txtAMD.Text) * double.Parse(txtFMD.Text) * double.Parse(txtCMD.Text);
            txtLPRD.Text = LPRD.ToString();

            LPRI = double.Parse(txtPoblacion.Text) * double.Parse(txtHMI.Text) * double.Parse(txtVMI.Text) * double.Parse(txtDM.Text) * double.Parse(txtAMI.Text) * double.Parse(txtFMI.Text) * double.Parse(txtCMI.Text);
            txtLPRI.Text = LPRI.ToString();

            double ILD = 0;
            double ILI = 0;

            ILD = double.Parse(txtLC.Text) / double.Parse(txtLPRD.Text);


            ILI = double.Parse(txtLC.Text) / double.Parse(txtLPRI.Text);



            int CONTROLRESPUESTA = ObtenerNumeroSeleccionado(cboControl);

            if (CONTROLRESPUESTA == 1)
            {
                txtILNIOSH.Text = ILD.ToString();
            }
            else txtILNIOSH.Text = ILI.ToString();







        }

        private void resultadofinal()
        {

            if (double.Parse(txtILNIOSH.Text) < 1.00)
            {
                txtActuacionNIOSH.Text = "TIPO DE RIESGO: LIMITADO ... La tarea debería rediseñarse para reducir el riesgo de generar lesiones";
                txtriesgoniosh.Text = "RIESGO LIMITADO";

            }
            else if (double.Parse(txtILNIOSH.Text) >= 1.00 && double.Parse(txtILNIOSH.Text) < 1.6)
            {
                txtActuacionNIOSH.Text = "TIPO DE RIESGO: MODERADO ... La tarea debe rediseñarse para reducir el riesgo de generar lesiones graves";
                txtriesgoniosh.Text = "RIESGO MODERADO";
            }

            else if (double.Parse(txtILNIOSH.Text) >= 1.6)
            {
                txtActuacionNIOSH.Text = "TIPO DE RIESGO: ALTO ... Inminente rediseño de las tareas, con el fin de evitar lesiones muy graves";
                txtriesgoniosh.Text = "RIESGO ALTO";
            }

        }


        public void NioshGuardarfinal()
        {
               NioshBC oNioshBC = new NioshBC();
                Niosh oNiosh = new Niosh();

                oNiosh.cargaIdNiosh = Convert.ToInt32(txtcargaidrebaresultado.Text);
                oNiosh.ILNiosh = double.Parse(txtILNIOSH.Text);
                oNiosh.RiesgoNiosh = txtriesgoniosh.Text;
                oNiosh.PoblacionNiosh = Convert.ToInt32(txtPoblacion.Text);
                oNiosh.ControlNiosh = Convert.ToInt32(ObtenerNumeroSeleccionado(cboControl));
                
                var res = oNioshBC.UpdateNiosh2BC(oNiosh);
        }



        private void cbopoblacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Poblacioncbo();
        }

        private int ObtenerNumeroSeleccionado(MaterialComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                ComboBoxOption selectedOption = comboBox.SelectedItem as ComboBoxOption;

                if (selectedOption != null)
                {
                    return selectedOption.Numero;
                }
            }

            return 0;
        }

        private void Poblacioncbo()
        {
            int poblacion1 = ObtenerNumeroSeleccionado(cboPoblacion);

            if (poblacion1 == 25)
            {
                txtPoblacion.Text = "25";
            }
            else txtPoblacion.Text = "15";
        }





        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        private string GetUniqueFileName(string baseFileName)
        {
            string fileName = $"{baseFileName}{fileCounter}.pdf";
            fileCounter++;
            return fileName;
        }


        private void LoadUserData()
        {
            userlabel1.Text = UserLoginCache.Nombre + ' ' + UserLoginCache.Apellido;
            userlabel2.Text = UserLoginCache.Cargo;
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
                        string paginahtml2_texto = TF.WIN.Properties.Resources.plantilla2.ToString();

                        paginahtml2_texto = paginahtml2_texto.Replace("@Fecha", DateTime.Now.ToString("G"));
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtHMD", txtHMD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtHMI", txtHMI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtVMD", txtVMD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtVMI", txtVMI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtDM", txtDM.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtAMD", txtAMD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtAMI", txtAMI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtFMD", txtFMD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtFMI", txtFMI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtCMD", txtCMD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtCMI", txtCMI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtCuit", txtCuit.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtLC", txtLC.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtpuestotrabajoNiosh", txtpuestotrabajoNiosh.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtEmpleadoNiosh", txtEmpleadoNiosh.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtEmpresaNiosh", txtEmpresaNiosh.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtLPRD", txtLPRD.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtLPRI", txtLPRI.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtILNIOSH", txtILNIOSH.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtActuacionNIOSH", txtActuacionNIOSH.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtriesgoniosh", txtriesgoniosh.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@txtPoblacion", txtPoblacion.Text);
                        paginahtml2_texto = paginahtml2_texto.Replace("@lblUsuario", userlabel1.Text);




                        // Agregar más reemplazos para los campos adicionales según tus necesidades...

                        using (StringReader sr = new StringReader(paginahtml2_texto))
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
    }
  }






    

