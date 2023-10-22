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

            ObtenerMaximoIdJSS();






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

            catch { }

        }








        private void btnRecuperarCarga_Click(object sender, EventArgs e)
        {
            JssRescatar();
        }
    }
}
