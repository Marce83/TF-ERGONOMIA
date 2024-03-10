using MaterialSkin;
using MaterialSkin.Controls;
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
            if (cboBuscadorDinamico.Text == "DNI")
            {
                // Permitir solo dígitos y la tecla de retroceso
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    e.Handled = true;

                // Limitar la longitud a 8 caracteres
                if (txtBuscador.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            }
            else
            {
                // Permitir letras, espacios y la tecla de retroceso
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                    e.Handled = true;

                // Limitar la longitud a 100 caracteres
                if (txtBuscador.Text.Length >= 100 && e.KeyChar != (char)Keys.Back)
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
                    dgvEmpleados.Columns["Apellido"].DisplayIndex = 0;
                    dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
                    dgvEmpleados.Columns[10].Visible = false;
                    break;
                case "NOMBRE":
                    oempl.Nombre = txtBuscador.Text;
                    DataTable dtNom = oEmpleadosBC.ConsultarEmpleadosPorNombre(oempl);
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = dtNom;
                    dgvEmpleados.Columns["Apellido"].DisplayIndex = 0;
                    dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
                    dgvEmpleados.Columns[10].Visible = false;
                    break;
                case "APELLIDO":
                    oempl.Apellido = txtBuscador.Text;
                    DataTable dtApe = oEmpleadosBC.ConsultarEmpleadosPorApellido(oempl);
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = dtApe;
                    dgvEmpleados.Columns["Apellido"].DisplayIndex = 0;
                    dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
                    dgvEmpleados.Columns[10].Visible = false;
                    break;
            }
            if (txtBuscador == null)
            {
                Listar();
            }
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

        private void cboBuscadorDinamico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBuscadorDinamico.Text == "DNI")
            {
                txtBuscador.Text = string.Empty;
            }
            else if (cboBuscadorDinamico.Text == "NOMBRE")
            {
                txtBuscador.Text = string.Empty;
            }
            else
                txtBuscador.Text = string.Empty;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar este Empleado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if(txtNombre.Text == string.Empty)
                {

                }
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
                dgvEmpleados.Columns["Apellido"].DisplayIndex = 0;
                dgvEmpleados.Columns["Nombre"].DisplayIndex = 1;
                dgvEmpleados.Columns[10].Visible = false;
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
            txtNombre.ReadOnly = true;
            txtApellido.Text = string.Empty;
            txtApellido.ReadOnly = true;
            dtpNacimiento.Text = string.Empty;
            dtpNacimiento.Enabled = false;
            dtpIngreso.Text = string.Empty;
            dtpIngreso.Enabled = false;
            dtpIngreso.Value = DateTime.Now;
            cboGenero.SelectedIndex = 0;
            cboGenero.Enabled = false;
            //cbopuestotrabajo.SelectedIndex = 0;
            txtPeso.Text = string.Empty;
            txtPeso.ReadOnly = true;
            txtAltura.Text = string.Empty;
            txtAltura.ReadOnly = true;
            txtCUITEncontrado.Text = string.Empty;
            txtCUITEncontrado.ReadOnly = true;
            txtNomEmp.Text = string.Empty;
            txtNomEmp.ReadOnly = true;
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.ReadOnly = false;
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.ReadOnly = false;
            cboGenero.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            cboGenero.Enabled = true;
            txtPeso.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtPeso.ReadOnly=false;
            txtAltura.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtAltura.ReadOnly=false;
            dtpNacimiento.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            dtpNacimiento.Enabled = true;
            dtpIngreso.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            dtpIngreso.Enabled = true;
            txtNomEmp.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
            txtNomEmp.ReadOnly=false;
            txtCUITEncontrado.Text = dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
            txtCUITEncontrado.ReadOnly=false;
            dgvEmpleados.Columns[10].Visible = false;
            //txtNomEmp.Text = dgvEmpleados.CurrentRow.Cells[9].Value.ToString();
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

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
