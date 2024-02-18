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
using System.Linq.Expressions;
using TF.COMMON.Cache;

namespace TF.WIN
{
    public partial class RULARESULTADO : Form
    {

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public RULARESULTADO()
        {
            InitializeComponent();
            ObtenerMaximoIdRula();
            //RescatarResultados();
            LoadUserData();
        }


 
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }


        private void LoadUserData()
        {
            userlabel1.Text = UserLoginCache.Nombre + ' ' + UserLoginCache.Apellido;
            userlabel2.Text = UserLoginCache.Cargo;
        }



        private int fileCounter = 0;
            private int SumaTablaA = 0;
            private int SumaTablaB = 0;

        private void RULARESULTADO_Load(object sender, EventArgs e)
        {
            //Formulario RULA PORTADA y Resultado Final
            txtempresaRula.Text = DatosCompartidos.Empresa;
            txtpuestoRula.Text = DatosCompartidos.PuestoRula;


            //Formulario RULA1 y Resultado Final
            txtbrazo.Text = DatosCompartidos.BrazoA;
            txtantebrazo.Text = DatosCompartidos.AnteBrazoA;
            txtmuneca.Text = DatosCompartidos.MunecaA;


            //Formulario RULA2 y Resultado Final
            txtmusculaturaA.Text = DatosCompartidos.ActividadManualA;
            txtcargafuerzaA.Text = DatosCompartidos.CargaFuerza;
            txtcuelloB.Text = DatosCompartidos.CuelloA;

            //Formulario RULA2 y Resultado Final
            txttroncoB.Text = DatosCompartidos.Tronco;
            txtpiernaB.Text = DatosCompartidos.Piernas;
            txtmusculaturaB.Text = DatosCompartidos.MuscularB;
            txtcargafuerzaB.Text = DatosCompartidos.CargafuerzaB;
        }

        private string GetUniqueFileName(string baseFileName)
        {
            string fileName = $"{baseFileName}{fileCounter}.pdf";
            fileCounter++;
            return fileName;
        }

        public void RescatarResultados()
        {
            Rula oRula = new Rula();
            oRula.cargaId = Convert.ToInt32(txtcargaid.Text);
            RulaBC oRulaBC = new RulaBC();
            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);
            RescatarResultados();

            DataTable dt = oRulaBC.RULABC_GetAllBC();

            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][1].ToString();
                txtCuitRula.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][2].ToString();
                txtpuestoRula.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][3].ToString();
                txtbrazo.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][4].ToString();
                txtantebrazo.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][5].ToString();
                txtmuneca.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][6].ToString();
                txtgiromuneca.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][7].ToString();
                txtmusculaturaA.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][8].ToString();
                txtcargafuerzaA.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][9].ToString();
                txtcuelloB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][10].ToString();
                txttroncoB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][11].ToString();
                txtpiernaB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][12].ToString();
                txtmusculaturaB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][13].ToString();
                txtcargafuerzaB.Text = resultado;
            }
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
                        string paginahtml_texto = TF.WIN.Properties.Resources.plantilla.ToString();

                        paginahtml_texto = paginahtml_texto.Replace("@txtCuitRula", txtCuitRula.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtempresaRula", txtempresaRula.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtpuestoRula", txtpuestoRula.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtEmpleadoRula", txtEmpleadoRula.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@Fecha", DateTime.Now.ToString("G"));
                        paginahtml_texto = paginahtml_texto.Replace("@txtbrazo", txtbrazo.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtantebrazo", txtantebrazo.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtmuneca", txtmuneca.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtgiromuneca", txtgiromuneca.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtmusculaturaA", txtmusculaturaA.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtcargafuerzaA", txtcargafuerzaA.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtcuelloB", txtcuelloB.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txttroncoB", txttroncoB.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtpiernaB", txtpiernaB.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtmusculaturaB", txtmusculaturaB.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtcargafuerzaB", txtcargafuerzaB.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtpuntuacionRula", txtPuntuacionRula.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtniveldeRiesgo", txtNivelDeRiesgo.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@txtactuacion", txtActuacion.Text);
                        paginahtml_texto = paginahtml_texto.Replace("@lblUsuario", userlabel1.Text);




                        // Agregar más reemplazos para los campos adicionales según tus necesidades...

                        using (StringReader sr = new StringReader(paginahtml_texto))
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
        private void btnRecuperarCarga_Click(object sender, EventArgs e)
        {
            Rula oRula = new Rula();
            oRula.cargaId = Convert.ToInt32(txtcargaid.Text);

            RulaBC oRulaBC = new RulaBC();
            DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);

            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][1].ToString();
                txtCuitRula.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][2].ToString();
                txtpuestoRula.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][3].ToString();
                txtbrazo.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][4].ToString();
                txtantebrazo.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][5].ToString();
                txtmuneca.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][6].ToString();
                txtgiromuneca.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][7].ToString();
                txtmusculaturaA.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][8].ToString();
                txtcargafuerzaA.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][9].ToString();
                txtcuelloB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][10].ToString();
                txttroncoB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][11].ToString();
                txtpiernaB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][12].ToString();
                txtmusculaturaB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][13].ToString();
                txtcargafuerzaB.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][18].ToString();
                txtEmpleadoRula.Text = resultado;
            }
            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][19].ToString();
                txtempresaRula.Text = resultado;
            }

            ///////////                    RESULTADO TABLA A Y B                             ///////////

            DataTable dt1 = oRulaBC.RulaTablaARdoBC(oRula);

            if (dt1.Rows.Count > 0)
            {
                string resultadoVALORTABLAA = dt1.Rows[0][4].ToString();
                oRula.ValorA = int.Parse(resultadoVALORTABLAA);
                rdoTablaA.Text = oRula.ValorA.ToString();
            }

            DataTable dt2 = oRulaBC.RulaTablaBRdoBC(oRula);

            if (dt2.Rows.Count > 0)
            {
                string resultadoVALORTABLAB = dt2.Rows[0][3].ToString();
                oRula.ValorB = int.Parse(resultadoVALORTABLAB);
                rdoTablaB.Text = resultadoVALORTABLAB.ToString();
            }

            ///////////                    NIVEL DE RIESGO Y ACTUACIÓN                             ///////////


            //DataTable dt3 = oRulaBC.RulaTablaCRdoBC(oRula);
            ////oRula.ValorA = int.Parse(rdoTablaA.Text);
            ////oRula.ValorB = int.Parse(rdoTablaB.Text);

            //if (dt.Rows.Count > 0)
            //{
            //    string resultadoTABLAC = dt3.Rows[0][0].ToString();
            //    txtpuntuacionRula.Text = resultadoTABLAC;
            //}


            if (int.TryParse(txtmusculaturaA.Text, out int valorMusculaturaA) &&
                  int.TryParse(txtcargafuerzaA.Text, out int valorCargaFuerzaA) &&
                  int.TryParse(rdoTablaA.Text, out int valorTablaA))
            {
                SumaTablaA = valorMusculaturaA + valorCargaFuerzaA + valorTablaA;
                TotalGrupoA.Text = SumaTablaA.ToString();
            }


            if (int.TryParse(txtmusculaturaB.Text, out int valorMusculaturaB) &&
                int.TryParse(txtcargafuerzaB.Text, out int valorCargaFuerzaB) &&
                int.TryParse(rdoTablaB.Text, out int valorTablaB))
            {
                SumaTablaB = valorMusculaturaB + valorCargaFuerzaB + valorTablaB;
                TotalGrupoB.Text = SumaTablaB.ToString();
            }


            if (int.Parse(TotalGrupoA.Text) < 8 && int.Parse(TotalGrupoB.Text) < 7)
            {

                oRula.ValorTablaA = int.Parse(TotalGrupoA.Text);
                oRula.ValorTablaB = int.Parse(TotalGrupoB.Text);

                DataTable dt3 = oRulaBC.RulaTablaCRdoBC(oRula);

                if (dt3.Rows.Count > 0)
                {
                    string resultadoTABLAC = dt3.Rows[0][0].ToString();
                    txtPuntuacionRula.Text = resultadoTABLAC;
                }

            }
            else
            //(int.Parse(TotalGrupoA.Text) > 8 && int.Parse(TotalGrupoB.Text) > 7)
            {
                txtPuntuacionRula.Text = "7";
            }



            if (txtPuntuacionRula.Text == "1" || txtPuntuacionRula.Text == "2")
            {
                txtNivelDeRiesgo.Text = "1";
                txtActuacion.Text = "Nivel de Riesgo Bajo: Posturas en las que no se observan factores de riesgo significativos para la salud musculoesquelética del trabajador. No se requieren cambios inmediatos.\r\n";
            }
            else if (txtPuntuacionRula.Text == "3" || txtPuntuacionRula.Text == "4")
            {
                txtNivelDeRiesgo.Text = "2";
                txtActuacion.Text = "Nivel de Riesgo Moderado: Posturas que presentan ciertos factores de riesgo que podrían contribuir a problemas musculoesqueléticos a largo plazo. Se recomiendan evaluaciones y ajustes periódicos.\r\n";
            }
            else if (txtPuntuacionRula.Text == "5" || txtPuntuacionRula.Text == "6")
            {
                txtNivelDeRiesgo.Text = "3";
                txtActuacion.Text = "Nivel de Riesgo Alto: Posturas con factores de riesgo significativos que requieren cambios inmediatos para reducir el riesgo de lesiones. Se deben tomar medidas correctivas de manera inmediata.\r\n";
            }
            else
            {
                txtNivelDeRiesgo.Text = "4";
                txtActuacion.Text = "Nivel de Riesgo Muy Alto: Posturas que presentan factores de riesgo extremadamente altos, lo que indica un peligro inminente para la salud del trabajador. Se deben tomar medidas inmediatas y enérgicas para evitar lesiones.";
            }


            oRula.ResultadoAnalisisRula = txtPuntuacionRula.Text;
            oRula.niveldeRiesgo = int.Parse(txtNivelDeRiesgo.Text);
            var res = oRulaBC.UpdateRula2BC(oRula);
            // Pasar al siguiente formulario

        }

        public void ObtenerMaximoIdRula()
        {
            RulaBC oRulaBC = new RulaBC();
            Rula oRula = new Rula();
            DataTable dt = oRulaBC.RulaIdMaxBC(oRula);

            if (dt.Rows.Count > 0)
            {   
                int maxId = Convert.ToInt32(dt.Rows[0]["cargaid"]);
                txtcargaid.Text = maxId.ToString();
            }

        }


        private void btnpagant_Click(object sender, EventArgs e)
        {
            RULA1 oRULACARGA1 = new RULA1();
            oRULACARGA1.Show();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        }
    }

