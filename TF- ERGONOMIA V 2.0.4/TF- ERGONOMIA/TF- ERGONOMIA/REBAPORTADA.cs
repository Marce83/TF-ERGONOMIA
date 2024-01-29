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
            FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
            oFrm.ShowDialog();

            if (oFrm.PersonaSeleccionada != null)
            {
                txtDniEmpleadoReba.Text = oFrm.PersonaSeleccionada.DNI.ToString();

                txtNombreEmpleadoReba.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();

                txtpuestotrabajoencontrado.Text = oFrm.PersonaSeleccionada.NombrePuesto.ToString();

            }

        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
           
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
            oReba.FechaCargaReba = DateTime.Parse(dtpReba.Text);

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

        private void REBA_PORTADA_Load(object sender, EventArgs e)
        {

        }
    }
}
