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
using TF.COMMON.Cache;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class FrmEmpleadosXPuestos : Form
    {
        public FrmEmpleadosXPuestos()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            userlabel1.Text = UserLoginCache.Nombre + ' ' + UserLoginCache.Apellido;
            userlabel2.Text = UserLoginCache.Cargo;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscarempresa_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                TxtCuitEmpresa.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                TxtNombreEmpresa.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();

            }
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBuscarPuestoTrabajo oFrm = new FrmBuscarPuestoTrabajo();
            oFrm.ShowDialog();

            if (oFrm.PuestoSeleccionada != null)
            {
              txtNombrePuesto.Text = oFrm.PuestoSeleccionada.NombrePuesto.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {
            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                oPuestoTrabajo.CUITEMPRESAPUESTO = TxtCuitEmpresa.Text;
                oPuestoTrabajo.NombrePuesto = txtNombrePuesto.Text;
                DataTable dt18000= oPuestoTrabajoBC.EmpleadoPuestoVerRecienteBC(oPuestoTrabajo);
                DgvPuestosRecientes.DataSource = null;
                DgvPuestosRecientes.DataSource = dt18000;
                DgvPuestosRecientes.AutoResizeColumns();
                AdjustColumnSizes(DgvPuestosRecientes);
            }

            catch
            {

                MessageBox.Show("No existe movimientos para su Consulta");

            }
        }

        private void AdjustColumnSizes(DataGridView dataGridView)
        {
            int totalWidth = dataGridView.Width - dataGridView.RowHeadersWidth;
            int totalColumns = dataGridView.Columns.Count;

            // Calcular el ancho para cada columna
            int columnWidth = totalWidth / totalColumns;

            // Ajustar el tamaño de las columnas
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = columnWidth;
            }
        }
    }
}
