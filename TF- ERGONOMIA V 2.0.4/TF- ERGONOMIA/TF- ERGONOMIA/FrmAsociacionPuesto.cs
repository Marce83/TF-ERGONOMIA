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
    public partial class FrmAsociacionPuesto : Form
    {
        public FrmAsociacionPuesto()
        {
            InitializeComponent();

        }

        DateTime FechaEgreso = DateTime.Now;
        DateTime FechaIngreso = DateTime.Now;

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarPuesto_Click(object sender, EventArgs e)
        {
            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                oPuestoTrabajo.IdEmpleado = int.Parse(txtIdEmpleado.Text);
                oPuestoTrabajo.IdPuesto = int.Parse(txtIdPuestoTrabajo.Text);

                DataTable dt4000 = oPuestoTrabajoBC.GetAllSiNoBC(oPuestoTrabajo);

                if (dt4000.Rows.Count > 0)
                {
                    oPuestoTrabajo.FechaEgreso = FechaEgreso;
                    var res = oPuestoTrabajoBC.UpdatePuestoEmpleadoBC(oPuestoTrabajo);
                    MessageBox.Show("Asociación Actualizada");
                }

                else
                {
                    oPuestoTrabajo.IdEmpleado = int.Parse(txtIdEmpleado.Text);
                    oPuestoTrabajo.IdPuesto = int.Parse(txtIdPuestoTrabajo.Text);
                    oPuestoTrabajo.FechaIngreso = FechaIngreso;
                    var res = oPuestoTrabajoBC.InsertPuestoEmpleadoBC(oPuestoTrabajo);
                    MessageBox.Show("Asociación Realizada con éxito");
                }
            }
            catch { }
    }
    }
}
