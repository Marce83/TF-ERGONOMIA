using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF.WIN
{
    public partial class FrmLMCPortada : Form
    {
        public FrmLMCPortada()
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
                txtNombreEmpresaReba.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
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

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Analisis LMC creado con éxito");
            NIOSH1 ONIOSH1 = new NIOSH1();
            AddOwnedForm(ONIOSH1);
            ONIOSH1.TopLevel = false;
            ONIOSH1.Dock = DockStyle.Fill;
            this.Controls.Add(ONIOSH1);
            this.Tag = ONIOSH1;
            ONIOSH1.BringToFront();
            ONIOSH1.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
