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

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cboBuscadorDinamico.Text == "DNI")
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                        e.Handled = true;
            }
            else
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                    e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            switch (cboBuscadorDinamico.Text)
            {
                case "DNI":
                    oempl.DNI = txtBuscador.Text;
                    DataTable dt = oEmpleadosBC.ConsultarEmpleadosDNI(oempl);
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = dt;
                    break;
                case "Nombre":
                    oempl.Nombre = txtBuscador.Text;
                    DataTable dtNom = oEmpleadosBC.ConsultarEmpleadosPorNombre(oempl);
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados .DataSource = dtNom;
                    break;
                case "Apellido":
                    oempl.Apellido = txtBuscador.Text;
                    DataTable dtApe = oEmpleadosBC.ConsultarEmpleadosPorApellido(oempl);
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = dtApe;
                    break;
            }
            if(txtBuscador == null)
            {
                Listar();
            }
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
                    oBe.FechaIngreso = dtpIngreso.Value;
                    long CUIL = Convert.ToInt64(txtCUITEncontrado.Text);
                    var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIL);
                    oBe.IdEmpresa = Convert.ToInt32(BuscarId);
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
            txtNomEmp.Text = string.Empty;

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
            txtNomEmp.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
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

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNomEmp.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }
    }
}
