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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNomEmpr.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            Empleados oBe = new Empleados();
            DialogResult resp = MessageBox.Show("¿Está seguro que desea cargar el siguiente Empleado?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                if (txtDNI.Text != string.Empty)
                {
                    try
                    {
                        oBe.DNI = txtDNI.Text;
                        oBe.Apellido = txtApellido.Text;
                        oBe.Nombre = txtNombre.Text;
                        oBe.FechaNacimiento = Convert.ToDateTime(dtpNacimiento.Text);
                        oBe.Genero = cboGenero.Text;
                        oBe.FechaIngreso = Convert.ToDateTime(dtpIngreso.Text);
                        oBe.Peso = float.Parse(txtPeso.Text);
                        oBe.Altura = float.Parse(txtAltura.Text);
                        //oBe.AreaEmpresa = cboAreaempresa.Text;
                        long CUIL = Convert.ToInt64(txtCUITEncontrado.Text);
                        var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIL);
                        oBe.IdEmpresa = Convert.ToInt32(BuscarId);
                        oEmpleadosBC.BuscarEmpleado(oBe);
                        var res = oEmpleadosBC.InsertEmpleadosBC(oBe);
                        MessageBox.Show("Empleado cargado exitosamente");
                        Listar();
                        Limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Debe ingresar el DNI");
            }
            Listar();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void Listar()
        {
            try
            {
                EmpleadosBC oEmpleadosBC = new EmpleadosBC();
                DataTable dt = oEmpleadosBC.EmpleadosBC_GetAll();
                //dgvEmpleados.DataSource = null;
                //dgvEmpleados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtDNI.Text = string.Empty;
            txtDNI.ReadOnly = false;
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
            txtDNI.Focus();

        }
        private void dgvempleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Empleadoss_Load(object sender, EventArgs e)
        {
            Listar();
            RolesCargo();
        }

        private void btnBuscartodo_Click_1(object sender, EventArgs e)
        {      
            Listar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnCargar.Enabled = false;
                //btnModificar.Enabled = false;
                //btnEliminar.Enabled = false;
            }
            //if (UserLoginCache.Cargo == Cargos.Profesional)
            //{
            //    btnEliminar.Enabled = false;
            //}
            //if (UserLoginCache.Cargo == Cargos.Contador)
            //{
            //    btnEliminar.Enabled = false;
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultarEmpleado ofrmConsultarEmpleado = new frmConsultarEmpleado();
            AddOwnedForm(ofrmConsultarEmpleado);
            ofrmConsultarEmpleado.TopLevel = false;
            ofrmConsultarEmpleado.Dock = DockStyle.Fill;
            this.Controls.Add(ofrmConsultarEmpleado);
            this.Tag = ofrmConsultarEmpleado;
            ofrmConsultarEmpleado.BringToFront();
            ofrmConsultarEmpleado.Show();
        }
    }
}
