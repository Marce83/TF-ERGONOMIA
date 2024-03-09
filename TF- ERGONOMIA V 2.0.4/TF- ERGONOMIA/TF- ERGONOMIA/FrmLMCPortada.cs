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
    public partial class FrmLMCPortada : Form
    {
        public FrmLMCPortada()
        {
            InitializeComponent();
            dtpReba.Value = DateTime.Now;
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
                txtNombreEmpresaReba.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
                long CUIT = Convert.ToInt64(txtCUITEncontrado.Text);
                var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIT);
                IdEmpresa = Convert.ToInt32(BuscarId);
                txtDniEmpleadoReba.Text = string.Empty;
                txtNombreEmpleadoReba.Text = string.Empty;
                txtpuestotrabajoencontrado.Text = string.Empty;
                dtpReba.Value = DateTime.Now;
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
                        txtDniEmpleadoReba.Text = oFrm.EmpleadoSeleccionado2.DNI.ToString();
                        txtNombreEmpleadoReba.Text = oFrm.EmpleadoSeleccionado2.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado2.Apellido.ToString();
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
            if (txtDniEmpleadoReba.Text != string.Empty)
            {
                Limpiar();
                //MessageBox.Show("Analisis LMC creado con éxito");
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtCUITEncontrado.Text = string.Empty;
            txtNombreEmpresaReba.Text = string.Empty;
            txtDniEmpleadoReba.Text = string.Empty;
            txtNombreEmpleadoReba.Text = string.Empty;
            txtpuestotrabajoencontrado.Text = string.Empty;
            dtpReba.Value = DateTime.Now;
        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
