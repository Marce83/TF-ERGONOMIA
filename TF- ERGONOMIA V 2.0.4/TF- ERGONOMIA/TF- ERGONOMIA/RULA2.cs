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
using TF.WIN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class RULA2 : Form
    {
        private RULARESULTADO formResultado;
        // readonly MaterialSkin.MaterialSkinManager materialSkinManager;



        public RULA2()
        {
            InitializeComponent();
            formResultado = new RULARESULTADO();
            ObtenerMaximoIdRula();
        }

         public void RULACARGA2_Load(object sender, EventArgs e)
        {

            // Puntuacion tipo actividad manual ( grupo A)
            cboactmanuala.Items.Add(new ComboBoxOption("0", 0));
            cboactmanuala.Items.Add(new ComboBoxOption("1", 1));

            // Puntuacion Carga/Fuerza
            cbocargafuerza.Items.Add(new ComboBoxOption("0", 0));
            cbocargafuerza.Items.Add(new ComboBoxOption("1", 1));
            cbocargafuerza.Items.Add(new ComboBoxOption("2", 2));
            cbocargafuerza.Items.Add(new ComboBoxOption("3", 3));

            // Puntuacion del Cuello
            cuellopuntuacion.Items.Add(new ComboBoxOption("1", 1));
            cuellopuntuacion.Items.Add(new ComboBoxOption("2", 2));
            cuellopuntuacion.Items.Add(new ComboBoxOption("3", 3));
            cuellopuntuacion.Items.Add(new ComboBoxOption("4", 4));
            cuelloposicion.Items.Add(new ComboBoxOption("Normal", 0));
            cuelloposicion.Items.Add(new ComboBoxOption("Rotado", 1));
            cuelloposicion.Items.Add(new ComboBoxOption("Lateral", 1));
            cuelloposicion.Items.Add(new ComboBoxOption("Rotado y Lateral", 2));

        }

        private void cboactmanuala_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }
        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(cboactmanuala);

            if (resultado2 == 0)
            {
                resultado2 = 0;
            }

            actividadgrupoAfinal.Text = resultado2.ToString();
        }

        private void cbocargafuerza_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }

        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(cbocargafuerza);

            if (resultado3 == 0)
            {
                resultado3 = 0;
            }

            txtcargafuerzafinal.Text = resultado3.ToString();
        }


        private void cuellopuntuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void cuelloposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado();
        }

        private void MostrarResultado()
        {
            int resultado = ObtenerNumeroSeleccionado(cuellopuntuacion) + ObtenerNumeroSeleccionado(cuelloposicion);

            if (resultado == 0)
            {
                resultado = 0;
            }

            txtcuellofinal.Text = resultado.ToString();
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

        private void btnpagsig_Click_1(object sender, EventArgs e)
        {
            {
                RulaBC oRulaBC = new RulaBC();
                Rula oRula = new Rula();
                oRula.Actividadmusculara = int.Parse(actividadgrupoAfinal.Text);
                oRula.Cargafuerzaa = int.Parse(txtcargafuerzafinal.Text);
                oRula.cargaId = int.Parse(txtcargaid.Text);
                oRula.Cuellob = int.Parse(txtcuellofinal.Text);


                var res = oRulaBC.UpdateRula2BC(oRula);
                MessageBox.Show("Carga Guardada");

                // Pasar el ID de carga al siguiente formulario
                RULA2 ORULA2 = new RULA2();
                ORULA2.Show();

                // Pasar el ID de carga al siguiente formulario
                RULA3 ORULA3 = new RULA3();
                ORULA3.Show();

                Close();
            }
        }

        private void btnpagant_Click_1(object sender, EventArgs e)
        {
            RULA1 oRULA1 = new RULA1();
            oRULA1.Show();
            Close();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
