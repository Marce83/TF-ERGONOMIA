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
    public partial class FrmVistaPuesto : Form
    {

        public PuestoTrabajo PersonaSeleccionada { get; set; }


        public FrmVistaPuesto()
        {
            InitializeComponent();

            DtpFechadesde.Value = DateTime.Now;
            DtpFechahasta.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
            oFrm.ShowDialog();

            if (oFrm.PersonaSeleccionada != null)
            {
                txtNombreEmpleado.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();
                //txtNombrePuesto.Text = oFrm.PuestoSeleccionada.NombrePuesto.ToString();
            }

        }

        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {
            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                oPuestoTrabajo.NombreEmpleado = txtNombreEmpleado.Text;

                // Verificar si la conversión de la fecha de inicio es exitosa
                if (DateTime.TryParse(DtpFechadesde.Text, out DateTime fechaInicio))
                {
                    oPuestoTrabajo.FechaIngreso = fechaInicio;

                    // Verificar si la conversión de la fecha de fin es exitosa
                    if (DateTime.TryParse(DtpFechahasta.Text, out DateTime fechaFin))
                    {
                        oPuestoTrabajo.FechaIngreso2 = fechaFin;

                        DataTable dt = oPuestoTrabajoBC.PuestoEmpleadoVerRecienteBC(oPuestoTrabajo);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            DgvPuestosRecientes.DataSource = null;
                            DgvPuestosRecientes.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron resultados.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha de fin no válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha de inicio no válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
