using iTextSharp.tool.xml.html.head;
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

namespace TF.WIN
{
    public partial class JSSRESULTADO : Form
    {
        public JSSRESULTADO()
        {
            InitializeComponent();
        }

        private void JSSRESULTADO_Load(object sender, EventArgs e)
        {

           






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
                
                if (Demanda < 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con bajo Apoyo Social"; }
                else if (Demanda < 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Bajo Apoyo Social"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con bajo Apoyo Social"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Bajo Apoyo Social"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS1.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; }

            }
            catch { }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
    }
