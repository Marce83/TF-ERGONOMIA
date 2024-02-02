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
    public partial class FrmVistaPuestoEmpleado : Form
    {
        public FrmVistaPuestoEmpleado()
        {
            InitializeComponent();
            Listar();


        }

        public PuestoTrabajo PersonaSeleccionada { get; set; }

        private void Listar()
        {
            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                DataTable dt = oPuestoTrabajoBC.GetAllVistaPuestoBC();
                dgvVistaPuestoEmpleado.DataSource = null;
                dgvVistaPuestoEmpleado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvVistaPuestoEmpleado.SelectedRows.Count == 1) // si selecciona una fila
            {
                // Obtén el valor de la celda de la primera columna de la fila seleccionada
                object cellValue = dgvVistaPuestoEmpleado.SelectedRows[0].Cells[0].Value;

                if (cellValue != null)
                {
                    // Convierte el valor a cadena (string)
                    string NombreEmpleado = cellValue.ToString();

                    PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                    PersonaSeleccionada = oPuestoTrabajoBC.GetNombreEmpleadoBC(NombreEmpleado);
                    this.Close();
                }
                else
                {
                    // Manejar el caso en que el valor es nulo.
                    MessageBox.Show("La celda está vacía.");
                }
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún empleado");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVistaPuestoEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
