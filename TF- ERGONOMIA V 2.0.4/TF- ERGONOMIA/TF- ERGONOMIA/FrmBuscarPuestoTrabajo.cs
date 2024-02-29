using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmBuscarPuestoTrabajo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                dgvResultadoPuesto.Columns[0].Visible = false;
                dgvResultadoPuesto.Columns[1].HeaderText = "Puesto";
                dgvResultadoPuesto.Columns[2].HeaderText = "Area de la Empresa";
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
                int IdPuesto = Convert.ToInt32(dgvResultadoPuesto.CurrentRow.Cells[0].Value);
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoSeleccionada = oPuestoTrabajoBC.ObtenerPuestoidBC(IdPuesto);
                this.Close();
            }
            else
            {
                    // Manejar el caso en que el valor es nulo.
                    MessageBox.Show("No se ha Seleccionado Ninguna Fila");
            }
        }
    }
}

