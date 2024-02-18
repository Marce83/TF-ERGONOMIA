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
    public partial class FrmAsociacionPuestosMultiples : Form
    {
        public FrmAsociacionPuestosMultiples()
        {
            InitializeComponent();
            DtpFechaIngreso.Value = DateTime.Now;
            DtpFechaEgreso.Value = DateTime.Now;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscarPuesto_Click(object sender, EventArgs e)
        {
            FrmBuscarPuestoTrabajo oFrm = new FrmBuscarPuestoTrabajo();
            oFrm.ShowDialog();

            if (oFrm.PuestoSeleccionada != null)
            {
                txtIdPuestoTrabajo.Text = oFrm.PuestoSeleccionada.IdPuesto.ToString();
                txtNombrePuesto.Text = oFrm.PuestoSeleccionada.NombrePuesto.ToString();
            }
        }
        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleados oFrm = new frmBuscarEmpleados();
            oFrm.ShowDialog();

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtIdEmpleado.Text = oFrm.EmpleadoSeleccionado.IdEmpleado.ToString();
                txtNombreEmpleado.Text = oFrm.EmpleadoSeleccionado.Apellido.ToString() + " " + oFrm.EmpleadoSeleccionado.Nombre.ToString();
            }
        }
        private void btnCargarPuesto_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Estas seguro que deseas Realizar la Asociación? No realizarlo mas de una vez", "Aviso de Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    Carga1();
                    MessageBox.Show("Asociación Realizada con éxito");
                  
                }
                catch (Exception ex)
                {
                    // Manejar excepciones de manera apropiada
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void Carga1()

        {

            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                oPuestoTrabajo.IdEmpleado = int.Parse(txtIdEmpleado.Text);
                oPuestoTrabajo.IdPuesto = int.Parse(txtIdPuestoTrabajo.Text);

                // Realizar inserción
                oPuestoTrabajo.FechaIngreso = DateTime.Parse(DtpFechaIngreso.Text);
                var res = oPuestoTrabajoBC.InsertPuestoEmpleadoBC(oPuestoTrabajo);
                MessageBox.Show("Asociación Realizada con éxito");

            }
            catch (Exception ex)
            {
                // Manejar excepciones de manera apropiada
                MessageBox.Show($"Error: {ex.Message}");
            }






        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
