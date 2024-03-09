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
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class JSSPORTADA : Form
    {
        public JSSPORTADA()
        {
            InitializeComponent();
            dtpJss.Value = DateTime.Now;
        }

        public static int IdEmpresa { get; set; }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresaJss.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
                long CUIT = Convert.ToInt64(txtCUITEncontrado.Text);
                var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIT);
                IdEmpresa = Convert.ToInt32(BuscarId);
                txtDniEmpleadoJss.Text = string.Empty;
                txtNombreEmpleadoJss.Text = string.Empty;
                txtpuestotrabajoencontrado.Text = string.Empty;
                dtpJss.Value = DateTime.Now;
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            if (txtCUITEncontrado.Text == string.Empty)
                MessageBox.Show("Tiene que Ingresar una Empresa antes");
            else
            {
                try
                {
                    frmBuscarEmpleados2 oFrm = new frmBuscarEmpleados2();
                    oFrm.ShowDialog();

                    if (oFrm.EmpleadoSeleccionado2 != null)
                    {
                        txtDniEmpleadoJss.Text = oFrm.EmpleadoSeleccionado2.DNI.ToString();
                        txtNombreEmpleadoJss.Text = oFrm.EmpleadoSeleccionado2.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado2.Apellido.ToString();
                        txtpuestotrabajoencontrado.Text = oFrm.EmpleadoSeleccionado2.NombrePuesto.ToString();
                    }
                }
                catch { }
            }
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtDniEmpleadoJss.Text != string.Empty)
            {
                jss Ojss = new jss();
                JssBC oJssBC = new JssBC();
                Ojss.CUITJSS = txtCUITEncontrado.Text;
                Ojss.PuestoDeTrabajoJSS = txtpuestotrabajoencontrado.Text;
                Ojss.DniEmpleadoJSS = txtDniEmpleadoJss.Text;
                Ojss.EmpleadoJSS = txtNombreEmpleadoJss.Text;
                Ojss.EmpresaJSS = txtNombreEmpresaJss.Text;
                Ojss.FechaCargaJss = DateTime.Parse(dtpJss.Text);
                var res = oJssBC.InserJssPORTADABC(Ojss);
                //MessageBox.Show("Análisis JSS creado con éxito");
                Limpiar();
                // Pasar el ID de carga al siguiente formulario
                txtApoyoSocial OJSS = new txtApoyoSocial();
                AddOwnedForm(OJSS);
                OJSS.TopLevel = false;
                OJSS.Dock = DockStyle.Fill;
                this.Controls.Add(OJSS);
                this.Tag = OJSS;
                OJSS.BringToFront();
                OJSS.Show();
            }
            else
                MessageBox.Show("Debe ingresar datos de Empresa, Empleado y Puesto previamente");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtCUITEncontrado.Text = string.Empty;
            txtNombreEmpresaJss.Text = string.Empty;
            txtDniEmpleadoJss.Text = string.Empty;
            txtNombreEmpleadoJss.Text = string.Empty;
            txtpuestotrabajoencontrado.Text = string.Empty;
            dtpJss.Value = DateTime.Now;
        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
