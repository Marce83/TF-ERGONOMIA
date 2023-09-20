﻿using iTextSharp.tool.xml.css.parser.state;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class REBA_RESULTADO : Form
    {
        public REBA_RESULTADO()
        {
            InitializeComponent();
            ObtenerMaximoIdReba();
        }
        private int SumaGrupoTablaAReba = 0;
        private int SumaGrupoTablaBReba = 0;
        private int SumaPuntuacionFinal = 0;


        private void btnpagant_Click(object sender, EventArgs e)
        {
            REBA1 OREBA1 = new REBA1();
            OREBA1.Show();
            Close();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ObtenerMaximoIdReba()
        {
            Reba oReba = new Reba();
            RebaBC oRebaBC = new RebaBC();
            DataTable dt23 = oRebaBC.RebaMaxIDBC(oReba);

            if (dt23.Rows.Count > 0)
            {
                int maxIdReba = Convert.ToInt32(dt23.Rows[0]["cargaIdReba"]);
                txtcargaidrebaresultado.Text = maxIdReba.ToString();
            }

        }
        private void btnRecuperarCarga_Click(object sender, EventArgs e)
        {
            RebaRescatar();
            RebaTablaA();
            RebaTablaB();


            if (int.TryParse(TotalTablaA.Text, out int valorTablaA) &&
                              int.TryParse(txtcargafuerzareba.Text, out int valorCargaFuerzaReba))
            {
                SumaGrupoTablaAReba = valorTablaA + valorCargaFuerzaReba;
                TotalGrupoAReba.Text = SumaGrupoTablaAReba.ToString();
            }

            if (int.TryParse(TotalTablaB.Text, out int valorTablaB) &&
                             int.TryParse(txtagarrereba.Text, out int valorAgarreReba))
            {
                SumaGrupoTablaBReba = valorTablaB + valorAgarreReba;
                txtTotalGrupoBReba.Text = SumaGrupoTablaBReba.ToString();
            }

            RebaTablaC();


            if (int.TryParse(txtTotalTablaCReba.Text, out int valorTablaC) &&
            int.TryParse(txtpActividadRebaFinal.Text, out int valorActividadReba))
            {
                SumaPuntuacionFinal = valorTablaC + valorActividadReba;
                txtpuntuacionTCAC.Text = SumaPuntuacionFinal.ToString();
            }

            if (txtpuntuacionTCAC.Text == "1" || txtpuntuacionTCAC.Text == "1")
            {
                txtPuntuacionReba.Text = "1";
                txtniveldeaccionReba.Text = "0";
                txtnivelderiesgoreba.Text = "Inapreciable";
                txtActuacionReba.Text = "No se requiere actuación ya que el nivel es Inapreciable.\r\n";
            }
            else if (txtpuntuacionTCAC.Text == "2" || txtpuntuacionTCAC.Text == "3")
            {
                txtPuntuacionReba.Text = txtpuntuacionTCAC.Text;
                txtniveldeaccionReba.Text = "1";
                txtnivelderiesgoreba.Text = "Bajo";
                txtActuacionReba.Text = "Puede requerir actuación ya que existe un nivel de Riesgo Bajo.\r\n";
            }
            else if (txtpuntuacionTCAC.Text == "4" || txtpuntuacionTCAC.Text == "5" || txtpuntuacionTCAC.Text == "6" || txtpuntuacionTCAC.Text == "7")
            {
                txtPuntuacionReba.Text = txtpuntuacionTCAC.Text;
                txtniveldeaccionReba.Text = "2";
                txtnivelderiesgoreba.Text = "Medio";
                txtActuacionReba.Text = "Es necesario actuar ya que existe un nivel de Riesgo Intermedio.\r\n";
            }
            else if (txtpuntuacionTCAC.Text == "8" || txtpuntuacionTCAC.Text == "9" || txtpuntuacionTCAC.Text == "10")
            {
                txtPuntuacionReba.Text = txtpuntuacionTCAC.Text;
                txtniveldeaccionReba.Text = "3";
                txtnivelderiesgoreba.Text = "Alto";
                txtActuacionReba.Text = "Es necesario actuar de forma rápida ya que existe un nivel de Riesgo Alto.\r\n";
            }
            else if(txtpuntuacionTCAC.Text == "11" || txtpuntuacionTCAC.Text == "12" || txtpuntuacionTCAC.Text == "13" || txtpuntuacionTCAC.Text == "14" || txtpuntuacionTCAC.Text == "15")
            {
                txtPuntuacionReba.Text = txtpuntuacionTCAC.Text;
                txtniveldeaccionReba.Text = "4";
                txtnivelderiesgoreba.Text = "Muy Alto";
                txtActuacionReba.Text = "Actuación Inmediata porque los nivel de Riesgos son Muy Altos.\r\n";
            }




        }

        public void RebaTablaA()
        {
            Reba oReba = new Reba();
            oReba.cargaIdReba = Convert.ToInt32(txtcargaidrebaresultado.Text);
            RebaBC oRebaBC = new RebaBC();
            DataTable dt10 = oRebaBC.RebaTablaABC(oReba);

            if (dt10.Rows.Count > 0)
            {
                string resultadoVALORTABLAA = dt10.Rows[0][3].ToString();
                oReba.ValorTablaAReba = int.Parse(resultadoVALORTABLAA);
                TotalTablaA.Text = oReba.ValorTablaAReba.ToString();
            }
        }
        public void RebaTablaB()
        {
            Reba oReba = new Reba();
            oReba.cargaIdReba = Convert.ToInt32(txtcargaidrebaresultado.Text);
            RebaBC oRebaBC = new RebaBC();
            DataTable dt11 = oRebaBC.RebaTablaBBC(oReba);

            if (dt11.Rows.Count > 0)
            {
                string resultadoVALORTABLAB = dt11.Rows[0][3].ToString();
                oReba.ValorTablaBReba = int.Parse(resultadoVALORTABLAB);
                TotalTablaB.Text = oReba.ValorTablaBReba.ToString();
            }
        }
        public void RebaRescatar()
        {
            Reba oReba = new Reba();
            oReba.cargaIdReba = Convert.ToInt32(txtcargaidrebaresultado.Text);
            RebaBC oRebaBC = new RebaBC();

            DataTable dt50 = oRebaBC.Reba_ResultadoBC(oReba);

            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][6].ToString();
                txttroncoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][7].ToString();
                txtcuelloreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][8].ToString();
                txtpiernareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][9].ToString();
                txtcargafuerzareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][10].ToString();
                txtantebrazoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][11].ToString();
                txtmunecareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][12].ToString();
                txtbrazoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][13].ToString();
                txtagarrereba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][14].ToString();
                txtpActividadRebaFinal.Text = resultado;
            }










        }
        public void RebaTablaC()
        {
            Reba oReba = new Reba();
            oReba.ValorTablaAReba = Convert.ToInt32(TotalGrupoAReba.Text);
            oReba.ValorTablaBReba = Convert.ToInt32(txtTotalGrupoBReba.Text);

            RebaBC oRebaBC = new RebaBC();
            DataTable dt16 = oRebaBC.RebaTablaCRdoBC(oReba);

            if (dt16.Rows.Count > 0)
            {
                string resultadoVALORTABLAC = dt16.Rows[0][0].ToString();
                oReba.ValorTablaCReba = int.Parse(resultadoVALORTABLAC);
                txtTotalTablaCReba.Text = oReba.ValorTablaCReba.ToString();
            }
        }



    }














    }

