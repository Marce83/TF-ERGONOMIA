
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TF.WIN
{
    public partial class RULA1 : Form
    {
       private RULARESULTADO formResultado;


        public RULA1()
        {
            InitializeComponent();
            formResultado = new RULARESULTADO();
        }

        public void RULA1_Load(object sender, EventArgs e)
        {
            // Puntuación de Brazo
            cboBrazoposicion.Items.Add(new ComboBoxOption("1", 1));
            cboBrazoposicion.Items.Add(new ComboBoxOption("2", 2));
            cboBrazoposicion.Items.Add(new ComboBoxOption("3", 3));
            cboBrazoposicion.Items.Add(new ComboBoxOption("4", 4));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Normal", 0));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Abducido", 1));
            cboBrazoAbdApo.Items.Add(new ComboBoxOption("Apoyado o Sostenido", -1));
            cbobrazoHombro.Items.Add(new ComboBoxOption("Normal", 0));
            cbobrazoHombro.Items.Add(new ComboBoxOption("Elevado", 1));


            // Puntuación Ante Brazo  
            antebrazoposicion.Items.Add(new ComboBoxOption("1", 1));
            antebrazoposicion.Items.Add(new ComboBoxOption("2", 2));
            antebrazocruza.Items.Add(new ComboBoxOption("Normal", 0));
            antebrazocruza.Items.Add(new ComboBoxOption("Despejado del Cuerpo", 1));
            antebrazocruza.Items.Add(new ComboBoxOption("Cruza Línea del Cuerpo", 1));


            // Puntuación Muñeca
            muñecaposicion.Items.Add(new ComboBoxOption("1", 1));
            muñecaposicion.Items.Add(new ComboBoxOption("2", 2));
            muñecaposicion.Items.Add(new ComboBoxOption("3", 3));
            muñecadesviado.Items.Add(new ComboBoxOption("Normal", 0));
            muñecadesviado.Items.Add(new ComboBoxOption("Desviada", 1));

            // Puntuacion Giro de Muñeca
            cbogiroMuñeca.Items.Add(new ComboBoxOption("1", 1));
            cbogiroMuñeca.Items.Add(new ComboBoxOption("2", 2));


            // Trasladar saldos al resumen 
            DatosCompartidos.BrazoA = txtBrazoFinal.Text;
            DatosCompartidos.AnteBrazoA = txtantebrazofinal.Text;
            DatosCompartidos.MunecaA = txtgirofinal.Text;

            // Mantener los datos de los  combobox
            DatosCompartidos.DatoComboBox1 = cboBrazoposicion.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox2 = cboBrazoAbdApo.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox3 = cbobrazoHombro.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox4 = antebrazoposicion.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox5 = antebrazocruza.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox6 = muñecaposicion.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox7 = muñecadesviado.SelectedItem?.ToString();
            DatosCompartidos.DatoComboBox8 = cbogiroMuñeca.SelectedItem?.ToString();

            //Restaurar la info por mas que cambiemos de pagina
            txtBrazoFinal.Text = DatosCompartidos.BrazoA;
            txtantebrazofinal.Text = DatosCompartidos.AnteBrazoA;
            txtgirofinal.Text = DatosCompartidos.MunecaA;

            cboBrazoposicion.SelectedItem = DatosCompartidos.DatoComboBox1;
            cboBrazoAbdApo.SelectedItem = DatosCompartidos.DatoComboBox2;
            cbobrazoHombro.SelectedItem = DatosCompartidos.DatoComboBox3;
            antebrazoposicion.SelectedItem = DatosCompartidos.DatoComboBox4;
            antebrazocruza.SelectedItem = DatosCompartidos.DatoComboBox5;
            muñecaposicion.SelectedItem = DatosCompartidos.DatoComboBox6;
            muñecadesviado.SelectedItem = DatosCompartidos.DatoComboBox7;
            cbogiroMuñeca.SelectedItem = DatosCompartidos.DatoComboBox8;

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

            ObtenerMaximoIdRula();
        }


        private void cboBrazoposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void cboBrazoAbdApo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void cbobrazoHombro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado1();
        }

        private void cboactmanuala_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoGA();
        }

        private void MostrarResultadoGA()
        {
            int resultadoGA = ObtenerNumeroSeleccionado(cboactmanuala);

            if (resultadoGA == 0)
            {
                resultadoGA = 0;
            }

            actividadgrupoAfinal.Text = resultadoGA.ToString();
        }

        private void cbocargafuerza_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCF();
        }

        private void MostrarResultadoCF()
        {
            int resultadoCF = ObtenerNumeroSeleccionado(cbocargafuerza);

            if (resultadoCF == 0)
            {
                resultadoCF = 0;
            }

            txtcargafuerzafinal.Text = resultadoCF.ToString();
        }

        private void cuellopuntuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCuello();
        }
        
        private void cuelloposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCuello();
        }
        private void MostrarResultadoCuello()
        {
            int resultadoCuello = ObtenerNumeroSeleccionadoCuello(cuellopuntuacion) + ObtenerNumeroSeleccionadoCuello(cuelloposicion);

            if (resultadoCuello == 0)
            {
                resultadoCuello = 0;
            }

            txtcuellofinal.Text = resultadoCuello.ToString();
        }
        private int ObtenerNumeroSeleccionadoCuello(MaterialComboBox comboBox)
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
        private void MostrarResultado1()
        {
            int resultado1 = ObtenerNumeroSeleccionado(cboBrazoposicion) + ObtenerNumeroSeleccionado(cboBrazoAbdApo) + ObtenerNumeroSeleccionado(cbobrazoHombro);

            if (resultado1 == 0)
            {
                resultado1 = 1;
            }

            txtBrazoFinal.Text = resultado1.ToString();
        }

        private void antebrazoposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }

        private void antebrazocruza_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado2();
        }

        private void MostrarResultado2()
        {
            int resultado2 = ObtenerNumeroSeleccionado(antebrazoposicion) + ObtenerNumeroSeleccionado(antebrazocruza);

            if (resultado2 == 0)
            {
                resultado2 = 1;
            }

            txtantebrazofinal.Text = resultado2.ToString();
        }

        private void muñecaposicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }

        private void muñecadesviado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado3();
        }
        private void cbogiroMuñeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultado4();
        }
        private void MostrarResultado3()
        {
            int resultado3 = ObtenerNumeroSeleccionado(muñecaposicion) + ObtenerNumeroSeleccionado(muñecadesviado);

            if (resultado3 == 0)
            {
                resultado3 = 1;
            }

            txtmunecafinal.Text = resultado3.ToString();
        }

        private void MostrarResultado4()
        {
            int resultado4 = ObtenerNumeroSeleccionado(cbogiroMuñeca);

            if (resultado4 == 0)
            {
                resultado4 = 1;
            }

            txtgirofinal.Text = resultado4.ToString();
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


        //private void btnpagina2_Click(object sender, EventArgs e)
        //{
        //    RULA2 oRULA2 = new RULA2();
        //    oRULA2.Show();

        //}
        private void cbotronco_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoTronco();
        }

        private void cbotroncotorcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoTronco();
        }

        private void MostrarResultadoTronco()
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
            MostrarResultadoPierna();
        }
        
        private void MostrarResultadoPierna()
        {
            int resultadoPierna = ObtenerNumeroSeleccionado(cbopiernas);

            if (resultadoPierna == 0)
            {
                resultadoPierna = 0;
            }

            txtpiernasfinal.Text = resultadoPierna.ToString();
        }

        private void cboactmuscular2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoMuscular2();
        }

        private void MostrarResultadoMuscular2()
        {
            int resultadoMuscular2 = ObtenerNumeroSeleccionado(cboactmuscular2);

            if (resultadoMuscular2 == 0)
            {
                resultadoMuscular2 = 0;
            }
            txtmuscular2.Text = resultadoMuscular2.ToString();
        }

        private void cbocargafuerza2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoFuerza2();
        }

        private void MostrarResultadoFuerza2()
        {
            int resultadoFuerza2 = ObtenerNumeroSeleccionado(cbocargafuerza2);

            if (resultadoFuerza2 == 0)
            {
                resultadoFuerza2 = 0;
            }
            txtcargafuerza2.Text = resultadoFuerza2.ToString();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                RulaBC oRulaBC = new RulaBC();
                Rula oRula = new Rula();
                oRula.Antebrazo = int.Parse(txtantebrazofinal.Text);
                oRula.Brazo = int.Parse(txtBrazoFinal.Text);
                oRula.cargaId = int.Parse(txtcargaid.Text);
                oRula.Muneca = int.Parse(txtmunecafinal.Text);
                oRula.Giro = int.Parse(txtgirofinal.Text);
                oRula.Actividadmusculara = int.Parse(actividadgrupoAfinal.Text);
                oRula.Cargafuerzaa = int.Parse(txtcargafuerzafinal.Text);
                oRula.Cuellob = int.Parse(txtcuellofinal.Text);
                oRula.Tronco = int.Parse(txttroncofinal.Text);
                oRula.Piernas = int.Parse(txtpiernasfinal.Text);
                oRula.Actividadmuscularb = int.Parse(txtmuscular2.Text);
                oRula.Cargafuerzab = int.Parse(txtcargafuerza2.Text);

                var res = oRulaBC.UpdateRula1BC(oRula);
                MessageBox.Show("Carga Guardada");

                // Pasar al siguiente formulario
                RULARESULTADO ORULARESULTADO = new RULARESULTADO();
                ORULARESULTADO.Show();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "verificar si existen caracteristicas sin completar");
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

