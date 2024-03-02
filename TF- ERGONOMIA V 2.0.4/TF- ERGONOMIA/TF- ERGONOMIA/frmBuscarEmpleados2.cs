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
    public partial class frmBuscarEmpleados2 : Form
    {
        public frmBuscarEmpleados2()
        {
            InitializeComponent();
            Listar();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void frmBuscarEmpleados2_MouseDown(object sender, MouseEventArgs e)

        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Empleados EmpleadoSeleccionado2 { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            oempl.DNI = txtDNIempleado.Text;
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            DataTable dt = oEmpleadosBC.ConsultarEmpleadosDNI(oempl);

            dgvResultado.DataSource = null;
            dgvResultado.DataSource = dt;
            //dgvempleados.Columns[0].Visible = false;
        }
        private void Listar()
        {
            PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
            PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
            try
            {
                oPuestoTrabajo.IdEmpresa = RULA_PORTADA.IdEmpresa;
                DataTable dt = oPuestoTrabajoBC.GetAllVistaPuestoBC(oPuestoTrabajo);
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1) // BUSQUEDA DE EMPLEADOS 
            {
                int DNI = Convert.ToInt32(dgvResultado.CurrentRow.Cells[1].Value);
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                EmpleadoSeleccionado2 = oEmpleadosBC.EmpleadosConPuestoBC(DNI);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Empleado");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
