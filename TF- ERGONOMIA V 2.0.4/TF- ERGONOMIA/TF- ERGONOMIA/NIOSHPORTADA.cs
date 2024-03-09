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
    public partial class NIOSHPORTADA : Form
    {
        public NIOSHPORTADA()
        {
            InitializeComponent();
            dtpNiosh.Value = DateTime.Now;
        }

        public static int IdEmpresa { get; set; }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtDniEmpleadoNiosh.Text != string.Empty)
            {
                Niosh oNiosh = new Niosh();
                NioshBC oNioshBC = new NioshBC();
                oNiosh.CUITNiosh = txtCUITEncontrado.Text;
                oNiosh.PuestoDeTrabajoNiosh = txtpuestotrabajoencontrado.Text;
                oNiosh.DniEmpleadoNiosh = txtDniEmpleadoNiosh.Text;
                oNiosh.EmpleadoNiosh = txtNombreEmpleadoNiosh.Text;
                oNiosh.EmpresaNiosh = txtNombreEmpresaNiosh.Text;
                oNiosh.FechaCargaNiosh = DateTime.Parse(dtpNiosh.Text);
                var res = oNioshBC.InsertNioshPORTADABC(oNiosh);
                //MessageBox.Show("Análisis NIOSH creado con éxito");
                Limpiar();
                // Pasar el ID de carga al siguiente formulario
                //this.Close();
                NIOSH1 ONIOSH1 = new NIOSH1();
                AddOwnedForm(ONIOSH1);
                ONIOSH1.TopLevel = false;
                ONIOSH1.Dock = DockStyle.Fill;
                this.Controls.Add(ONIOSH1);
                this.Tag = ONIOSH1;
                ONIOSH1.BringToFront();
                ONIOSH1.Show();
            }
            else
                MessageBox.Show("Debe ingresar datos de Empresa, Empleado y Puesto previamente");
        }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresaNiosh.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
                long CUIT = Convert.ToInt64(txtCUITEncontrado.Text);
                var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIT);
                IdEmpresa = Convert.ToInt32(BuscarId);
                txtDniEmpleadoNiosh.Text = string.Empty;
                txtNombreEmpleadoNiosh.Text = string.Empty;
                txtpuestotrabajoencontrado.Text = string.Empty;
                dtpNiosh.Value = DateTime.Now;
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
                        txtDniEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado2.DNI.ToString();
                        txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado2.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado2.Apellido.ToString();
                        txtpuestotrabajoencontrado.Text = oFrm.EmpleadoSeleccionado2.NombrePuesto.ToString();
                    }
                }
                catch { }
            }
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
            
        }

        private void Limpiar()
        {
            txtCUITEncontrado.Text = string.Empty;
            txtNombreEmpresaNiosh.Text = string.Empty;
            txtDniEmpleadoNiosh.Text = string.Empty;
            txtNombreEmpleadoNiosh.Text = string.Empty;
            txtpuestotrabajoencontrado.Text = string.Empty;
            dtpNiosh.Value = DateTime.Now;
        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
