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
    public partial class REBA1 : Form
    {
        public REBA1()
        {
            InitializeComponent();

            //GRUPO A

            // Puntuación de Tronco
            cboTroncomvimiento.Items.Add(new ComboBoxOption("1", 1));
            cboTroncomvimiento.Items.Add(new ComboBoxOption("2", 2));
            cboTroncomvimiento.Items.Add(new ComboBoxOption("3", 3));
            cboTroncomvimiento.Items.Add(new ComboBoxOption("4", 4));
            cboTroncocorreccion.Items.Add(new ComboBoxOption("Normal", 0));
            cboTroncocorreccion.Items.Add(new ComboBoxOption("Hay Torsión o Inclinacion", 1));

            // Puntuación de Cuello
            cboCuellomovimiento.Items.Add(new ComboBoxOption("1", 1));
            cboCuellomovimiento.Items.Add(new ComboBoxOption("2", 2));
            cboCuelloCorreccion.Items.Add(new ComboBoxOption("Normal", 0));
            cboCuelloCorreccion.Items.Add(new ComboBoxOption("Hay Torsión o Inclinacion", 1));

            // Puntuación de Piernas
            cboPiernasMovimiento.Items.Add(new ComboBoxOption("1", 1));
            cboPiernasMovimiento.Items.Add(new ComboBoxOption("2", 2));
            cboPiernasCorreccion.Items.Add(new ComboBoxOption("Normal", 0));
            cboPiernasCorreccion.Items.Add(new ComboBoxOption("Hay Flexión entre 30° y 60°", 1));
            cboPiernasCorreccion.Items.Add(new ComboBoxOption("Hay Flexión en mas de 60°", 2));

            // Puntuación de Carga / Fuerza
            cboCargaFuerzapuntuacion.Items.Add(new ComboBoxOption("0", 0));
            cboCargaFuerzapuntuacion.Items.Add(new ComboBoxOption("1", 1));
            cboCargaFuerzapuntuacion.Items.Add(new ComboBoxOption("2", 2));
            cboCargaFuerzaadicional.Items.Add(new ComboBoxOption("Normal", 0));
            cboCargaFuerzaadicional.Items.Add(new ComboBoxOption("Instauración Rápida", 1));

            //GRUPO B

            // Puntuación de AnteBrazo
            cboAntebrazoPuntuacion.Items.Add(new ComboBoxOption("1", 1));
            cboAntebrazoPuntuacion.Items.Add(new ComboBoxOption("2", 2));

            // Puntuación de Muñeca
            cboMunecaMovimiento.Items.Add(new ComboBoxOption("1", 1));
            cboMunecaMovimiento.Items.Add(new ComboBoxOption("2", 2));
            cboMunecaCorreccion.Items.Add(new ComboBoxOption("Normal", 0));
            cboMunecaCorreccion.Items.Add(new ComboBoxOption("Hay Torsión o Inclinacion", 1));

            // Puntuación de Brazo
            cboBrazoPosicion.Items.Add(new ComboBoxOption("1", 1));
            cboBrazoPosicion.Items.Add(new ComboBoxOption("2", 2));
            cboBrazoPosicion.Items.Add(new ComboBoxOption("3", 3));
            cboBrazoPosicion.Items.Add(new ComboBoxOption("4", 4));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Normal", 0));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Hay Abducción o rotación", 1));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Hay elebación", 1));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Hay apoyo o postura a favor de gravedad", -1));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Hay Abducción y elebacón", 2));
            cboBrazoCorreccion.Items.Add(new ComboBoxOption("Hay Abducción y apollo", 0));

            // Puntuación de Agarre
            cboAgarre.Items.Add(new ComboBoxOption("Buen Agarre", 0));
            cboAgarre.Items.Add(new ComboBoxOption("Agarre Regular", 1));
            cboAgarre.Items.Add(new ComboBoxOption("Mal Agarre", 2));
            cboAgarre.Items.Add(new ComboBoxOption("Agarre Inaceptable", 3));

            // Puntuación Actividad
            cboActividadpartescuerpo.Items.Add(new ComboBoxOption("No", 0));
            cboActividadpartescuerpo.Items.Add(new ComboBoxOption("Si", 1));
            cboactividadmovimiento.Items.Add(new ComboBoxOption("No", 0));
            cboactividadmovimiento.Items.Add(new ComboBoxOption("Si", 1));
            cboactividadpostura.Items.Add(new ComboBoxOption("No", 0));
            cboactividadpostura.Items.Add(new ComboBoxOption("Si", 1));

            ObtenerMaximoIdReba();

        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                RebaBC oRebaBC = new RebaBC();
                Reba oReba = new Reba();

                oReba.cargaIdReba = int.Parse(txtcargaidreba.Text);
                oReba.TroncoReba = int.Parse(txtTroncoReba.Text);
                oReba.CuelloReba = int.Parse(txtCuelloReba.Text);
                oReba.PiernasReba = int.Parse(txtPiernasReba.Text);
                oReba.CargafuerzaReba = int.Parse(txtCargaFuerzaReba.Text);
                oReba.AntebrazoReba = int.Parse(txtAntebrazoReba.Text);
                oReba.MunecaReba = int.Parse(txtMunecaReba.Text);
                oReba.BrazoReba = int.Parse(txtBrazoReba.Text);
                oReba.AgarreReba = int.Parse(txtAgarreReba.Text);
                oReba.ActividadReba = int.Parse(txtpuntuacionActividadReba.Text);
                var res = oRebaBC.UpdateReba1BC(oReba);
                MessageBox.Show("Carga Guardada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que tenga todas la Informacion Cargada");
            }

            REBA_RESULTADO OREBA_RESULTADO = new REBA_RESULTADO();
            OREBA_RESULTADO.Show();
            Close();
        }
        private void cboTroncomvimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoTRONCO();
        }
        private void MostrarResultadoTRONCO()
        {
            int resultadoTRONCO = ObtenerNumeroSeleccionado(cboTroncomvimiento) + ObtenerNumeroSeleccionado(cboTroncocorreccion);

            if (resultadoTRONCO == 0)
            {
                resultadoTRONCO = 0;
            }

            txtTroncoReba.Text = resultadoTRONCO.ToString();
        }
        private void cboTroncocorreccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoTRONCO();
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
        private void cboCuellomovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCUELLO();
        }
        private void cboCuelloCorreccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCUELLO();
        }
        private void MostrarResultadoCUELLO()
        {
            int resultadoCUELLO = ObtenerNumeroSeleccionado(cboCuellomovimiento) + ObtenerNumeroSeleccionado(cboCuelloCorreccion);

            if (resultadoCUELLO == 0)
            {
                resultadoCUELLO = 0;
            }

            txtCuelloReba.Text = resultadoCUELLO.ToString();
        }
        private void cboPiernasMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoPIERNA();
        }
        private void cboPiernasCorreccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoPIERNA();
        }
        private void MostrarResultadoPIERNA()
        {
            int resultadoPIERNA = ObtenerNumeroSeleccionado(cboPiernasMovimiento) + ObtenerNumeroSeleccionado(cboPiernasCorreccion);

            if (resultadoPIERNA == 0)
            {
                resultadoPIERNA = 0;
            }

            txtPiernasReba.Text = resultadoPIERNA.ToString();
        }
        private void cboCargaFuerzapuntuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCARGAFUERZA();
        }
        private void cboCargaFuerzaadicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoCARGAFUERZA();
        }
        private void MostrarResultadoCARGAFUERZA()
        {
            int resultadoCARGAFUERZA = ObtenerNumeroSeleccionado(cboCargaFuerzapuntuacion) + ObtenerNumeroSeleccionado(cboCargaFuerzaadicional);

            if (resultadoCARGAFUERZA == 0)
            {
                resultadoCARGAFUERZA = 0;
            }

            txtCargaFuerzaReba.Text = resultadoCARGAFUERZA.ToString();
        }
        private void cboAntebrazoPuntuacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoANTEBRAZO();
        }
        private void MostrarResultadoANTEBRAZO()
        {
            int resultadoANTEBRAZO = ObtenerNumeroSeleccionado(cboAntebrazoPuntuacion);

            if (resultadoANTEBRAZO == 0)
            {
                resultadoANTEBRAZO = 0;
            }

            txtAntebrazoReba.Text = resultadoANTEBRAZO.ToString();
        }
        private void cboBrazoPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoBRAZO();
        }
        private void cboBrazoCorreccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoBRAZO();
        }
        private void MostrarResultadoBRAZO()
        {
            int resultadoBRAZO = ObtenerNumeroSeleccionado(cboBrazoPosicion) + ObtenerNumeroSeleccionado(cboBrazoCorreccion);

            if (resultadoBRAZO == 0)
            {
                resultadoBRAZO = 0;
            }

            txtBrazoReba.Text = resultadoBRAZO.ToString();
        }
        private void cboMunecaMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoMUNECA();
        }
        private void cboMunecaCorreccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoMUNECA();
        }
        private void MostrarResultadoMUNECA()
        {
            int resultadoMUNECA = ObtenerNumeroSeleccionado(cboMunecaMovimiento) + ObtenerNumeroSeleccionado(cboMunecaCorreccion);

            if (resultadoMUNECA == 0)
            {
                resultadoMUNECA = 0;
            }

            txtMunecaReba.Text = resultadoMUNECA.ToString();
        }
        private void cboAgarre_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoAGARRE();
        }
        private void MostrarResultadoAGARRE()
        {
            int resultadoAGARRE = ObtenerNumeroSeleccionado(cboAgarre);

            if (resultadoAGARRE == 0)
            {
                resultadoAGARRE = 0;
            }

            txtAgarreReba.Text = resultadoAGARRE.ToString();
        }
        private void cboActividadpartescuerpo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoACTIVIDAD();
        }
        private void cboactividadmovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoACTIVIDAD();
        }
        private void cboactividadpostura_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarResultadoACTIVIDAD();
        }
        private void MostrarResultadoACTIVIDAD()
        {
            int resultadoACTIVIDAD = ObtenerNumeroSeleccionado(cboActividadpartescuerpo)+ ObtenerNumeroSeleccionado(cboactividadmovimiento)+ ObtenerNumeroSeleccionado(cboactividadpostura);

            if (resultadoACTIVIDAD == 0)
            {
                resultadoACTIVIDAD = 0;
            }

            txtpuntuacionActividadReba.Text = resultadoACTIVIDAD.ToString();
        }

        public void ObtenerMaximoIdReba()
        {
            RebaBC oRebaBC = new RebaBC(); ;
            Reba oReba = new Reba();
            DataTable dt = oRebaBC.RebaMaxIDBC(oReba);

            if (dt.Rows.Count > 0)
            {
                int maxIdReba = Convert.ToInt32(dt.Rows[0]["cargaIdReba"]);
                txtcargaidreba.Text = maxIdReba.ToString();
            }

        }




    }
}
