using MaterialSkin.Controls;
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

            int Demanda = 0;
            int Control = 0;
            int ApoyoSocial = 0;


            Control = int.Parse(txtc1.Text + txtc2.Text+ txtc3.Text + txtc4.Text + txtc5.Text+ txtc6.Text);
            txtControl.Text = Control.ToString();
            Demanda = int.Parse(txtd1.Text+ txtd2.Text +txtd3.Text + txtd4.Text + txtd5.Text);
            txtDemanda.Text = Demanda.ToString();
            ApoyoSocial = int.Parse(txtas1.Text+ txtas2.Text+ txtas3.Text+ txtas4.Text+ txtas5.Text+ txtas6.Text);
            txtApoyoSocial.Text = ApoyoSocial.ToString();

        }
    }
}
