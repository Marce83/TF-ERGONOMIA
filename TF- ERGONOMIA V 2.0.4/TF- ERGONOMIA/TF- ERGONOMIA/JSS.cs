using MaterialSkin;
using MaterialSkin.Controls;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class JSS : Form
    {
        public JSS()
        {
            InitializeComponent();

            // Demanda
            d1.Items.Add(new ComboBoxOption("Nunca", 1));
            d1.Items.Add(new ComboBoxOption("Rara vez", 2));
            d1.Items.Add(new ComboBoxOption("A veces", 3));
            d1.Items.Add(new ComboBoxOption("A menudo", 4));

            d2.Items.Add(new ComboBoxOption("Nunca", 1));
            d2.Items.Add(new ComboBoxOption("Rara vez", 2));
            d2.Items.Add(new ComboBoxOption("A veces", 3));
            d2.Items.Add(new ComboBoxOption("A menudo", 4));

            d3.Items.Add(new ComboBoxOption("Nunca", 1));
            d3.Items.Add(new ComboBoxOption("Rara vez", 2));
            d3.Items.Add(new ComboBoxOption("A veces", 3));
            d3.Items.Add(new ComboBoxOption("A menudo", 4));

            d4.Items.Add(new ComboBoxOption("Nunca", 1));
            d4.Items.Add(new ComboBoxOption("Rara vez", 2));
            d4.Items.Add(new ComboBoxOption("A veces", 3));
            d4.Items.Add(new ComboBoxOption("A menudo", 4));

            d5.Items.Add(new ComboBoxOption("Nunca", 1));
            d5.Items.Add(new ComboBoxOption("Rara vez", 2));
            d5.Items.Add(new ComboBoxOption("A veces", 3));
            d5.Items.Add(new ComboBoxOption("A menudo", 4));

            // Control
            c1.Items.Add(new ComboBoxOption("Nunca", 1));
            c1.Items.Add(new ComboBoxOption("Rara vez", 2));
            c1.Items.Add(new ComboBoxOption("A veces", 3));
            c1.Items.Add(new ComboBoxOption("A menudo", 4));

            c2.Items.Add(new ComboBoxOption("Nunca", 1));
            c2.Items.Add(new ComboBoxOption("Rara vez", 2));
            c2.Items.Add(new ComboBoxOption("A veces", 3));
            c2.Items.Add(new ComboBoxOption("A menudo", 4));

            c3.Items.Add(new ComboBoxOption("Nunca", 1));
            c3.Items.Add(new ComboBoxOption("Rara vez", 2));
            c3.Items.Add(new ComboBoxOption("A veces", 3));
            c3.Items.Add(new ComboBoxOption("A menudo", 4));

            c4.Items.Add(new ComboBoxOption("Nunca", 1));
            c4.Items.Add(new ComboBoxOption("Rara vez", 2));
            c4.Items.Add(new ComboBoxOption("A veces", 3));
            c4.Items.Add(new ComboBoxOption("A menudo", 4));

            c5.Items.Add(new ComboBoxOption("Nunca", 1));
            c5.Items.Add(new ComboBoxOption("Rara vez", 2));
            c5.Items.Add(new ComboBoxOption("A veces", 3));
            c5.Items.Add(new ComboBoxOption("A menudo", 4));
            c5.Items.Add(new ComboBoxOption("Siempre", 5));

            c6.Items.Add(new ComboBoxOption("Nunca", 1));
            c6.Items.Add(new ComboBoxOption("Rara vez", 2));
            c6.Items.Add(new ComboBoxOption("A veces", 3));
            c6.Items.Add(new ComboBoxOption("A menudo", 4));
            c6.Items.Add(new ComboBoxOption("Siempre", 5));

            // Apoyo Social
            as1.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as1.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as1.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as1.Items.Add(new ComboBoxOption("Siempre", 4));

            as2.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as2.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as2.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as2.Items.Add(new ComboBoxOption("Siempre", 4));

            as3.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as3.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as3.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as3.Items.Add(new ComboBoxOption("Siempre", 4));

            as4.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as4.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as4.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as4.Items.Add(new ComboBoxOption("Siempre", 4));

            as5.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as5.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as5.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as5.Items.Add(new ComboBoxOption("Siempre", 4));

            as6.Items.Add(new ComboBoxOption("Totalmente en desacuerdo", 1));
            as6.Items.Add(new ComboBoxOption("En desacuerdo", 2));
            as6.Items.Add(new ComboBoxOption("De acuerdo", 3));
            as6.Items.Add(new ComboBoxOption("Siempre", 4));







            ObtenerMaximoIdJSS();




        }

         private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void d1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d1resultado();
        }
        private void d2_SelectedIndexChanged(object sender, EventArgs e)
        {
            d2resultado();
        }
        private void d3_SelectedIndexChanged(object sender, EventArgs e)
        {
            d3resultado();
        }
        private void d4_SelectedIndexChanged(object sender, EventArgs e)
        {
            d4resultado();
        }
        private void d5_SelectedIndexChanged(object sender, EventArgs e)
        {
            d5resultado();
        }
        private void d1resultado()
        {
            double d1r = ObtenerNumeroSeleccionado(d1);
            txtd1.Text = d1r.ToString();


        }
        private void d2resultado()
        {
            double d2r = ObtenerNumeroSeleccionado(d2);
            txtd2.Text = d2r.ToString();
        }
        private void d3resultado()
        {
            double d3r = ObtenerNumeroSeleccionado(d3);
            txtd3.Text = d3r.ToString();
        }
        private void d4resultado()
        {
            double d4r = ObtenerNumeroSeleccionado(d4);
            txtd4.Text = d4r.ToString();
        }
        private void d5resultado()
        {
            double d5r = ObtenerNumeroSeleccionado(d5);
            txtd5.Text = d5r.ToString();
        }
        private void c1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1resultado();
        }
        private void c2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c2resultado();
        }
        private void c3_SelectedIndexChanged(object sender, EventArgs e)
        {
            c3resultado();
        }
        private void c4_SelectedIndexChanged(object sender, EventArgs e)
        {
            c4resultado();
        }
        private void c5_SelectedIndexChanged(object sender, EventArgs e)
        {
            c5resultado();
        }
        private void c6_SelectedIndexChanged(object sender, EventArgs e)
        {
            c6resultado();
        }
        private void c1resultado()
        {
            double c1r = ObtenerNumeroSeleccionado(c1);
            txtc1.Text = c1r.ToString();
        }
        private void c2resultado()
        {
            double c2r = ObtenerNumeroSeleccionado(c2);
            txtc2.Text = c2r.ToString();
        }
        private void c3resultado()
        {
            double c3r = ObtenerNumeroSeleccionado(c3);
            txtc3.Text = c3r.ToString();
         }
        private void c4resultado()
        {
            double c4r = ObtenerNumeroSeleccionado(c4);
            txtc4.Text = c4r.ToString();
        }
        private void c5resultado()
        {
            double c5r = ObtenerNumeroSeleccionado(c5);
            txtc5.Text = c5r.ToString();
        }
        private void c6resultado()
        {
            double c6r = ObtenerNumeroSeleccionado(c6);
            txtc6.Text = c6r.ToString();
        }
        private void as1_SelectedIndexChanged(object sender, EventArgs e)
        {
            as1resultado();
        }
        private void as2_SelectedIndexChanged(object sender, EventArgs e)
        {
            as2resultado();
        }
        private void as3_SelectedIndexChanged(object sender, EventArgs e)
        {
            as3resultado();
        }
        private void as4_SelectedIndexChanged(object sender, EventArgs e)
        {
            as4resultado();
        }
        private void as5_SelectedIndexChanged(object sender, EventArgs e)
        {
            as5resultado();
        }
        private void as6_SelectedIndexChanged(object sender, EventArgs e)
        {
            as6resultado();
        }
        private void as1resultado()
        {
            double as1r = ObtenerNumeroSeleccionado(as1);
            txtas1.Text = as1r.ToString();
        }
        private void as2resultado()
        {
            double as2r = ObtenerNumeroSeleccionado(as2);
            txtas2.Text = as2r.ToString();
        }
        private void as3resultado()
        {
            double as3r = ObtenerNumeroSeleccionado(as3);
            txtas3.Text = as3r.ToString();
        }
        private void as4resultado()
        {
            double as4r = ObtenerNumeroSeleccionado(as4);
            txtas4.Text = as4r.ToString();
        }
        private void as5resultado()
        {
            double as5r = ObtenerNumeroSeleccionado(as5);
            txtas5.Text = as5r.ToString();
        }
        private void as6resultado()
        {
            double as6r = ObtenerNumeroSeleccionado(as6);
            txtas6.Text = as6r.ToString();
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            try
            {
                int c1 = int.Parse(txtc1.Text);
                int c2 = int.Parse(txtc2.Text);
                int c3 = int.Parse(txtc3.Text);
                int c4 = int.Parse(txtc4.Text);
                int c5 = int.Parse(txtc5.Text);
                int c6 = int.Parse(txtc6.Text);
                int d1 = int.Parse(txtd1.Text);
                int d2 = int.Parse(txtd2.Text);
                int d3 = int.Parse(txtd3.Text);
                int d4 = int.Parse(txtd4.Text);
                int d5 = int.Parse(txtd5.Text);
                int as1 = int.Parse(txtas1.Text);
                int as2 = int.Parse(txtas2.Text);
                int as3 = int.Parse(txtas3.Text);
                int as4 = int.Parse(txtas4.Text);
                int as5 = int.Parse(txtas5.Text);
                int as6 = int.Parse(txtas6.Text);

                int Control = c1 + c2 + c3 + c4 + c5 + c6;
                txtControl.Text = Control.ToString();

                int Demanda = d1 + d2 + d3 + d4 + d5;
                txtDemanda.Text = Demanda.ToString();

                int ApoyoSocial = as1 + as2 + as3 + as4 + as5 + as6;
                txtApoyoSocial.Text = ApoyoSocial.ToString();


                if (Control < 18) { txtControlrdo.Text = "Bajo Control"; }
                else if (Control >= 18) { txtControlrdo.Text = "Alto Control"; }

                if (Demanda < 15) { txtDemandardo.Text = "Baja Demanda"; }
                else if (Demanda >= 15) { txtDemandardo.Text = "Alta Demanda"; }

                if (ApoyoSocial < 18) { txtApoyoSocialrdo.Text = "Bajo Apoyo Social"; }
                else if (ApoyoSocial >= 18) { txtApoyoSocialrdo.Text = "Alto Apoyo Social"; }

                     if (Demanda < 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS.Text ="Trabajo Pasivo y perjudicial para la salud, con bajo Apoyo Social" ; }
                else if (Demanda < 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS.Text = "Trabajo Pasivo y perjudicial para la salud, con Bajo Apoyo Social"; }
                else if (Demanda < 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS.Text = "Trabajo Pasivo y perjudicial para la salud, con Alto Apoyo Social"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial < 18) { txtActuacionJSS.Text = "Alto Nivel de estrés y perjudicial para la salud y con bajo Apoyo Social"; }
                else if (Demanda >= 15 && Control < 18 && ApoyoSocial >= 18) { txtActuacionJSS.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial < 18) { txtActuacionJSS.Text = "Alto Nivel de estrés y perjudicial para la salud y con Bajo Apoyo Social"; }
                else if (Demanda >= 15 && Control >= 18 && ApoyoSocial >= 18) { txtActuacionJSS.Text = "Alto Nivel de estrés y perjudicial para la salud y con Alto Apoyo Social"; }
               


            }
            catch { }

        }

        private void btnGuardarNiosh1_Click(object sender, EventArgs e)
        {
            try
            {
                jss Ojss = new jss();
                JssBC oJssBC = new JssBC();

                Ojss.cargaIdJSS = int.Parse(txtcargaidJSS.Text);
                Ojss.DemandaJss = int.Parse(txtDemanda.Text);
                Ojss.ControlJss = int.Parse(txtControl.Text);
                Ojss.ApoyoSocialJss = int.Parse(txtApoyoSocial.Text);
                Ojss.DemandaRdo = txtDemandardo.Text;
                Ojss.ControlRdo = txtControlrdo.Text;
                Ojss.ApoyoSocialRdo = txtApoyoSocialrdo.Text;

                var res = oJssBC.UpdateJssBC(Ojss);
                MessageBox.Show("Análisis JSS guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que tenga todas la Informacion Cargada");
            }

            JSSRESULTADO oJSSRESULTADO = new JSSRESULTADO();
            AddOwnedForm(oJSSRESULTADO);
            oJSSRESULTADO.TopLevel = false;
            oJSSRESULTADO.Dock = DockStyle.Fill;
            this.Controls.Add(oJSSRESULTADO);
            this.Tag = oJSSRESULTADO;
            oJSSRESULTADO.BringToFront();
            oJSSRESULTADO.Show();
            Close();


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


    }



 


}
