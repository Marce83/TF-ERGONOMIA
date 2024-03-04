using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmBuscarEmpresa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        Empresas oBe = new Empresas();
        public Empresas EmpresaSeleccionada { get; set; }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboBuscadorDinamico.Text == "CUIT")
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    e.Handled = true;
            }
            else
            {
                if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                    e.Handled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboBuscadorDinamico.Text == "CUIT")
            {
                oBe.CUIT = txtBuscador.Text;
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.ConsultarEmpresas(oBe);
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = dt;
            }
            else
                if (cboBuscadorDinamico.Text == "Razón Social")
            {
                oBe.Nombre = txtBuscador.Text;
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.ConsultarNombreEmpresa(oBe);
                dgvResultado.DataSource = null;
                dgvResultado.DataSource = dt;
            }
            if (txtBuscador.Text == String.Empty)
            {
                Listar();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows.Count == 1) // si selecciona un fila
            {
                long CUIT = Convert.ToInt64(dgvResultado.SelectedRows[0].Cells[0].Value);
                //long CUIT = Convert.ToInt32(dgvResultado.CurrentRow.Cells[0].Value);
                //long CUIT = Convert.ToInt64(dgvResultado.CurrentRow.Cells[0].Value);
                //long CUIT = Convert.ToInt64(dgvResultado.Rows[0].Cells[0].Value);
                //string nombreEmpresa = dgvResultado.Rows[0].Cells[1].Value.ToString();
                EmpresasBC oEmpresaBC = new EmpresasBC();
                EmpresaSeleccionada = oEmpresaBC.ObtenerEmpresa(CUIT);
                this.Close();
            }
            else
            {
                MessageBox.Show("No existe empresa seleccionada");
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
