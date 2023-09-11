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
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class RULA3 : Form
    {
        //private RULARESULTADO formResultado;
        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;



        public RULA3()
        {
            InitializeComponent();

            ObtenerMaximoIdRula();
        }

        public void RULACARGA3_Load(object sender, EventArgs e)
        {

            //Puntuacion del Tronco
            cbotronco.Items.Add(new ComboBoxOption("1", 1));
            cbotronco.Items.Add(new ComboBoxOption("2", 2));
            cbotronco.Items.Add(new ComboBoxOption("3", 3));
            cbotronco.Items.Add(new ComboBoxOption("4", 4));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Normal", 0));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Torsión", 1));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Inclinación Lateral", 1));
            cbotroncotorcion.Items.Add(new ComboBoxOption("Torsión e Inclinación Lateral", 2));

            //Puntuación de las Piernas
            cbopiernas.Items.Add(new ComboBoxOption("1", 1));
            cbopiernas.Items.Add(new ComboBoxOption("2", 2));

            //Puntuación actividad Muscular ( Grupo B )
            cboactmuscular2.Items.Add(new ComboBoxOption("0", 0));
            cboactmuscular2.Items.Add(new ComboBoxOption("1", 1));

            //Puntuación Carga / Fuerza (Grupo B)
            cbocargafuerza2.Items.Add(new ComboBoxOption("0", 0));
            cbocargafuerza2.Items.Add(new ComboBoxOption("1", 1));
            cbocargafuerza2.Items.Add(new ComboBoxOption("2", 2));
            cbocargafuerza2.Items.Add(new ComboBoxOption("3", 3));

        }
        private void cbotronco_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void cbotroncotorcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            int resultado = ObtenerNumeroSeleccionado(cbotronco) + ObtenerNumeroSeleccionado(cbotroncotorcion);

            if (resultado == 0)
            {
                resultado = 0;
            }

            txttroncofinal.Text = resultado.ToString();
        }

        private void cbopiernas_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void MostrarResultado1()
        {
            int resultado1 = ObtenerNumeroSeleccionado(cbopiernas);

            if (resultado1 == 0)
            {
                resultado1 = 0;
            }

            txtpiernasfinal.Text = resultado1.ToString();
        }
        private void cboactmuscular2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }
        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(cboactmuscular2);

            if (resultado2 == 0)
            {
                resultado2 = 0;
            }
            txtmuscular2.Text = resultado2.ToString();
        }
        private void cbocargafuerza2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }
        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(cbocargafuerza2);

            if (resultado3 == 0)
            {
                resultado3 = 0;
            }
            txtcargafuerza2.Text = resultado3.ToString();
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


        private void btnpagsig_Click(object sender, EventArgs e)
        {
            //RulaBC oRulaBC = new RulaBC();
            //Rula oRula = new Rula();
            //oRula.Tronco = int.Parse(txttroncofinal.Text);
            //oRula.Piernas = int.Parse(txtpiernasfinal.Text);
            //oRula.cargaId = int.Parse(txtcargaid.Text);
            //oRula.Actividadmuscularb = int.Parse(txtmuscular2.Text);
            //oRula.Cargafuerzab = int.Parse(txtcargafuerza2.Text);

            //var res = oRulaBC.UpdateRula3BC(oRula);
            //MessageBox.Show("Carga Guardada");


            //// Pasar el ID de carga al siguiente formulario
            //RULARESULTADO ORULARESULTADO = new RULARESULTADO();
            //ORULARESULTADO.Show();

            //Close();
        }

        private void btnpagant_Click(object sender, EventArgs e)
        {
            RULA2 oRULACARGA2 = new RULA2();
            oRULACARGA2.Show();
            Close();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcargaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtcargafuerza2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
