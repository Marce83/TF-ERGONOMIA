using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class NIOSHRESULTADO : Form
    {
        public NIOSHRESULTADO()
        {
            InitializeComponent();
            ObtenerMaximoIdNIOSH();
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
            NioshRescatar();
            resultadoIl();
            resultadofinal();
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

            catch { }

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
            }
            else if (double.Parse(txtILNIOSH.Text) >= 1.00 && double.Parse(txtILNIOSH.Text) < 1.6)
            {
                txtActuacionNIOSH.Text = "TIPO DE RIESGO: MODERADO ... La tarea debe rediseñarse para reducir el riesgo de generar lesiones graves";
            }

            else if (double.Parse(txtILNIOSH.Text) >= 1.6)
            {
                txtActuacionNIOSH.Text = "TIPO DE RIESGO: ALTO ... Inminente rediseño de las tareas, con el fin de evitar lesiones muy graves";
            }










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

    }
}
