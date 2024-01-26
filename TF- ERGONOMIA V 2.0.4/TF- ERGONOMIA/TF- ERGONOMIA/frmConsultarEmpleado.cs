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
using TF.COMMON.Cache;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmConsultarEmpleado : Form
    {
        public frmConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void frmConsultarEmpleado_Load(object sender, EventArgs e)
        {
            RolesCargo();
            Listar();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            oempl.DNI = txtcuitconsulta.Text;

            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            DataTable dt = oEmpleadosBC.ConsultarEmpleadosDNI(oempl);

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = dt;
            //dgvempleados.Columns[0].Visible = false;
            Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar este Empleado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    oBe.Nombre = txtNombre.Text;
                    oBe.Apellido = txtApellido.Text;
                    oBe.DNI = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                    oBe.Genero = cboGenero.Text;
                    //oBe.AreaEmpresa = cboAreaempresa.Text;
                    oBe.Peso = float.Parse(txtPeso.Text);
                    oBe.Altura = float.Parse(txtAltura.Text);
                    oBe.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text);

                    var res = oEmpleadosBC.EmpleadosUpdate(oBe);
                    MessageBox.Show("Empleado modificado exitosamente");
                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //if (txtDNI.Text != string.Empty)
                //{}
                //else MessageBox.Show("Verifique los Datos a modificar");
            }
            Listar();
            Limpiar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea dar de baja al Empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    oBe.DNI = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                    var res = oEmpleadosBC.BajaEmpleado(oBe);
                    MessageBox.Show("Empleado dado de baja exitosamente");
                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Listar();
            Limpiar();
        }
        private void Listar()
        {
            try
            {
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                DataTable dt = oEmpleadosBC.EmpleadosBC_GetAll();
                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            //txtDNI.Text = string.Empty;
            //txtDNI.ReadOnly = false;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtpNacimiento.Text = string.Empty;
            dtpIngreso.Text = string.Empty;
            dtpIngreso.Enabled = true;
            cboGenero.SelectedIndex = 0;
            //cbopuestotrabajo.SelectedIndex = 0;
            txtPeso.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtCUITEncontrado.Text = string.Empty;
            //txtDNI.Focus();

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            //txtDNI.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            //txtDNI.ReadOnly = true;
            cboGenero.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtPeso.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtAltura.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            dtpNacimiento.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            dtpIngreso.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            //dtpIngreso.Enabled = false;
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnBuscar.Enabled = false;
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {
                btnBaja.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnBaja.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
