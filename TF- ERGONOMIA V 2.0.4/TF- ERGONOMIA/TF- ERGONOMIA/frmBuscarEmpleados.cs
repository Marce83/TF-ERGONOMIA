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
    public partial class frmBuscarEmpleados : Form
    {
        public frmBuscarEmpleados()
        {
            InitializeComponent();
        }
        public Empleados EmpleadoSeleccionado { get; set; }

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

        private void btnBuscartodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                DataTable dt = oEmpleadosBC.EmpleadosBC_GetAll();
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBuscarEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvResultado.SelectedRows.Count == 1) // si selecciona un fila
            {
                int DNI = Convert.ToInt32(dgvResultado.Rows[0].Cells[2].Value);
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                EmpleadoSeleccionado = oEmpleadosBC.EmpleadosObtenerDNI(DNI);
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
