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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class REBA_PORTADA : Form
    {
        public REBA_PORTADA()
        {
            InitializeComponent();
            dtpReba.Value = DateTime.Now;
        }

        public static int IdEmpresa { get; set; }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresaReba.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
                long CUIT = Convert.ToInt64(txtCUITEncontrado.Text);
                var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIT);
                IdEmpresa = Convert.ToInt32(BuscarId);
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtDniEmpleadoReba.Text != string.Empty)
            {
                Reba oReba = new Reba();
                RebaBC oRebaBC = new RebaBC();
                oReba.CUITReba = txtCUITEncontrado.Text;
                oReba.PuestoDeTrabajoReba = txtpuestotrabajoencontrado.Text;
                oReba.DniEmpleadoReba = txtDniEmpleadoReba.Text;
                oReba.EmpleadoReba = txtNombreEmpleadoReba.Text;
                oReba.EmpresaReba = txtNombreEmpresaReba.Text;
                oReba.FechaCargaReba = DateTime.Parse(dtpReba.Text);
                var res = oRebaBC.InsertRebaPORTADABC(oReba);
                //MessageBox.Show("Analisis REBA creado con éxito");
                Limpiar();
                // Pasar el ID de carga al siguiente formulario
                REBA1 OREBA1 = new REBA1();
                AddOwnedForm(OREBA1);
                OREBA1.TopLevel = false;
                OREBA1.Dock = DockStyle.Fill;
                this.Controls.Add(OREBA1);
                this.Tag = OREBA1;
                OREBA1.BringToFront();
                OREBA1.Show();

                //this.Close();
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
            dtpReba.Text = string.Empty;
        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
