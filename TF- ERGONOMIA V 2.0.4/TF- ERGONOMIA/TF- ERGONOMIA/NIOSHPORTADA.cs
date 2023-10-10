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
            var res = oNioshBC.InsertNioshPORTADABC(oNiosh);
            MessageBox.Show("Análisis NIOSH creado con éxito");

            // Pasar el ID de carga al siguiente formulario

            this.Close();


            NIOSH1 ONIOSH1 = new NIOSH1();
            ONIOSH1.Show();
            this.Close();
        }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();

            }
            if (oFrm.EmpresaSeleccionada != null)
            {
                txtNombreEmpresaNiosh.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleados oFrm = new frmBuscarEmpleados();
            oFrm.ShowDialog();

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtDniEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.DNI.ToString();

            }

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.Apellido.ToString() + " " + oFrm.EmpleadoSeleccionado.Nombre.ToString();

            }
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            oempl.DNI = txtDniEmpleadoNiosh.Text;

            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            DataTable dt = oEmpleadosBC.ConsultarPuesto(oempl);

            if (dt.Rows.Count > 0)
            {
                string resultado1 = dt.Rows[0][0].ToString();
                txtpuestotrabajoencontrado.Text = resultado1;
            }
        }
    }
}
