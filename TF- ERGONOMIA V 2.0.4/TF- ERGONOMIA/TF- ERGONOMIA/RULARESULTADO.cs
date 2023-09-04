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

namespace TF.WIN
{
    public partial class RULARESULTADO : Form
    {

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public RULARESULTADO()
        {
            InitializeComponent();
            ObtenerMaximoIdRula();
            RescatarResultados();
        }

        private int fileCounter = 0;

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


            DataTable dt = oRulaBC.RULABC_GetAllBC();

            if (dt.Rows.Count > 0)
            {
                string resultado = dt.Rows[0][1].ToString();
                txtempresaRula.Text = resultado;
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

            string paginahtml_texto = TF.WIN.Properties.Resources.plantilla.ToString();




            paginahtml_texto = paginahtml_texto.Replace("@txtempresaRula", txtempresaRula.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtpuestoRula", txtpuestoRula.Text);
            paginahtml_texto = paginahtml_texto.Replace("@Fecha", DateTime.Now.ToString("G"));
            paginahtml_texto = paginahtml_texto.Replace("@txtbrazo", txtbrazo.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtantebrazo", txtantebrazo.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtmuneca", txtmuneca.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtmusculaturaA", txtmusculaturaA.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtcargafuerzaA", txtcargafuerzaA.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtcuelloB", txtcuelloB.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txttroncoB", txttroncoB.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtpiernaB", txtpiernaB.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtmusculaturaB", txtmusculaturaB.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtcargafuerzaB", txtcargafuerzaB.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtpuntuacionRula", txtpuntuacionRula.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtniveldeRiesgo", txtniveldeRiesgo.Text);
            paginahtml_texto = paginahtml_texto.Replace("@txtactuacion", txtactuacion.Text);




            if (guardar.ShowDialog() == DialogResult.OK)
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


                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {

                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);

                    }

                    pdfDoc.Close();

                    stream.Close();

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
                txtempresaRula.Text = resultado;
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
                oRula.ValorB= int.Parse(resultadoVALORTABLAB);
                rdoTablaB.Text = resultadoVALORTABLAB.ToString();
            }

            ///////////                    NIVEL DE RIESGO Y ACTUACIÓN                             ///////////


            DataTable dt3 = oRulaBC.RulaTablaCRdoBC(oRula);
            //oRula.ValorA = int.Parse(rdoTablaA.Text);
            //oRula.ValorB = int.Parse(rdoTablaB.Text);

            if (dt.Rows.Count > 0)
            {
                string resultadoTABLAC = dt3.Rows[0][3].ToString();
                txtpuntuacionRula.Text = resultadoTABLAC;
            }


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
            RULA3 oRULACARGA3 = new RULA3();
            oRULACARGA3.Show();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        }
    }

