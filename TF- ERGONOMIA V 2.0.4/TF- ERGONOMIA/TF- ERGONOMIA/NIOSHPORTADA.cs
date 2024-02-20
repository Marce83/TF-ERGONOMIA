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
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
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
            MessageBox.Show("Análisis NIOSH creado con éxito");

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

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresaNiosh.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {

            frmBuscarEmpleados2 oFrm = new frmBuscarEmpleados2();
            oFrm.ShowDialog();

            if (oFrm.EmpleadoSeleccionado2 != null)
            {
                txtDniEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado2.DNI.ToString();
                txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado2.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado2.Apellido.ToString();
                txtpuestotrabajoencontrado.Text = oFrm.EmpleadoSeleccionado2.NombrePuesto.ToString();
            }

            //FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
            //oFrm.ShowDialog();

            //if (oFrm.PersonaSeleccionada != null)
            //{
            //    txtDniEmpleadoNiosh.Text = oFrm.PersonaSeleccionada.DNI.ToString();
            //    txtNombreEmpleadoNiosh.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();
            //    txtpuestotrabajoencontrado.Text = oFrm.PersonaSeleccionada.NombrePuesto.ToString();
            //}

            //if (oFrm.EmpleadoSeleccionado != null)
            //{
            //    txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.Apellido.ToString() + " " + oFrm.EmpleadoSeleccionado.Nombre.ToString();

            //}
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
            
        }
    }
}
