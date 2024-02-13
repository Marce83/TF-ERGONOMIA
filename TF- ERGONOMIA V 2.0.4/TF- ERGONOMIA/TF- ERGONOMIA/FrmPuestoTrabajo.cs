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
    public partial class FrmPuestoTrabajo : Form
    {
        public FrmPuestoTrabajo()
        {
            InitializeComponent();
        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //btnMaximizar.Visible = false;
            //btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //btnRestaurar.Visible = false;
            //btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargarPuesto_Click(object sender, EventArgs e)
        {
            PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
            PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
            oPuestoTrabajo.NombrePuesto = CboPuestoTrabajo.Text;
            oPuestoTrabajo.AreaEmpresa= CboAreaempresa.Text;
            var res = oPuestoTrabajoBC.InsertPuestoTrabajoBC(oPuestoTrabajo);
            MessageBox.Show("Puesto Cargador con éxito");
        }
    }
}
