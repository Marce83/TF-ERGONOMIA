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
    public partial class frmBuscarEmpresa : Form
    {
        public frmBuscarEmpresa()
        {
            InitializeComponent();
        }

        public Empresas EmpresaSeleccionada { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empresas oBe = new Empresas();
            oBe.CUIT = txtCUITEmpresa.Text;
            EmpresasBC oEmpresasBC = new EmpresasBC();
            DataTable dt = oEmpresasBC.ConsultarEmpresas(oBe);
            dgvResultado.DataSource = null;
            dgvResultado.DataSource = dt;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1) // si selecciona un fila
            {
                //long CUIT = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                long CUIT = Convert.ToInt64(dgvResultado.Rows[0].Cells[0].Value);
                EmpresasBC oEmpresaBC = new EmpresasBC();
                EmpresaSeleccionada = oEmpresaBC.ObtenerEmpresa(CUIT);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Cliente");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscartodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.GetAll();
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
