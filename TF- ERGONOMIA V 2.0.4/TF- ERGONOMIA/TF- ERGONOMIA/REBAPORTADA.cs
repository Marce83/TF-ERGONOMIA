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
                txtNombreEmpresaReba.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }


        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleados oFrm = new frmBuscarEmpleados();
            oFrm.ShowDialog();

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtDniEmpleadoReba.Text = oFrm.EmpleadoSeleccionado.DNI.ToString();
                
            }

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtNombreEmpleadoReba.Text = oFrm.EmpleadoSeleccionado.Apellido.ToString() + " " + oFrm.EmpleadoSeleccionado.Nombre.ToString();

            }

        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
            Empleados oempl = new Empleados();
            oempl.DNI = txtDniEmpleadoReba.Text;

            EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            DataTable dt = oEmpleadosBC.ConsultarPuesto(oempl);

            if (dt.Rows.Count > 0)
            {
                string resultado1 = dt.Rows[0][0].ToString();
                txtpuestotrabajoencontrado.Text = resultado1;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Reba oReba = new Reba();
            RebaBC oRebaBC = new RebaBC();
            oReba.CUITReba = txtCUITEncontrado.Text;
            oReba.PuestoDeTrabajoReba = txtpuestotrabajoencontrado.Text;
            oReba.DniEmpleadoReba = txtDniEmpleadoReba.Text;
            oReba.EmpleadoReba = txtNombreEmpleadoReba.Text;
            oReba.EmpresaReba = txtNombreEmpresaReba.Text;
            var res = oRebaBC.InsertRebaPORTADABC(oReba);
            MessageBox.Show("Analisis REBA creado con éxito");

            // Pasar el ID de carga al siguiente formulario
            REBA1 OREBA1 = new REBA1();
            OREBA1.Show();

            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
