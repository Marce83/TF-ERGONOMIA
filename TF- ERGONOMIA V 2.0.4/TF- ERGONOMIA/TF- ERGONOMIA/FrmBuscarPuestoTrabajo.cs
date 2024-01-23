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
    public partial class FrmBuscarPuestoTrabajo : Form
    {
        public FrmBuscarPuestoTrabajo()
        {
            InitializeComponent();
            Listar();

        }

        public PuestoTrabajo PuestoSeleccionada { get; set; }

        private void Listar()
        {
         try
          {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                DataTable dt = oPuestoTrabajoBC.GetAll();
                    dgvResultadoPuesto.DataSource = null;
                    dgvResultadoPuesto.DataSource = dt;
          }
          catch (Exception ex)
          {
                    MessageBox.Show(ex.Message);
          }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvResultadoPuesto.SelectedRows.Count == 1) // si selecciona una fila
            {
                // Obtén el valor de la celda de la primera columna
                object cellValue = dgvResultadoPuesto.CurrentRow.Cells[0].Value;

                if (cellValue != null)
                {
                    // Intenta convertir el valor a un entero
                    if (int.TryParse(cellValue.ToString(), out int IdPuesto))
                    {
                        PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                        PuestoSeleccionada = oPuestoTrabajoBC.ObtenerPuestoidBC(IdPuesto);
                        this.Close();
                    }
                    else
                    {
                        // Manejar el caso en que la conversión no fue exitosa.
                        MessageBox.Show("La celda no contiene un valor válido para IdPuesto.");
                    }
                }
                else
                {
                    // Manejar el caso en que el valor es nulo.
                    MessageBox.Show("La celda está vacía.");
                }
            }
            else
            {
                MessageBox.Show("Aún no ha seleccionado ningún Puesto de Trabajo");
            }
        }
    }
}
