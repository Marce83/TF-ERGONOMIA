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
    public partial class PuestoTrabajoSeleccion : Form
    {
        public PuestoTrabajoSeleccion()
        {
            InitializeComponent();
        }

        private void btnCargaPuesto_Click(object sender, EventArgs e)
        {
            FrmPuestoTrabajo oFrmPuestoTrabajo = new FrmPuestoTrabajo();
            AddOwnedForm(oFrmPuestoTrabajo);
            oFrmPuestoTrabajo.TopLevel = false;
            oFrmPuestoTrabajo.Dock = DockStyle.Fill;
            this.Controls.Add(oFrmPuestoTrabajo);
            this.Tag = oFrmPuestoTrabajo;
            oFrmPuestoTrabajo.BringToFront();
            oFrmPuestoTrabajo.Show();
        }

        private void btnAsociacionPuesto_Click(object sender, EventArgs e)
        {
            FrmAsociacionPuesto oFrmAsociacionPuesto = new FrmAsociacionPuesto();
            AddOwnedForm(oFrmAsociacionPuesto);
            oFrmAsociacionPuesto.TopLevel = false;
            oFrmAsociacionPuesto.Dock = DockStyle.Fill;
            this.Controls.Add(oFrmAsociacionPuesto);
            this.Tag = oFrmAsociacionPuesto;
            oFrmAsociacionPuesto.BringToFront();
            oFrmAsociacionPuesto.Show();
        }

        private void btnempleadosasociados_Click(object sender, EventArgs e)
        {
            FrmPuestoHistorial oFrmVistaPuesto = new FrmPuestoHistorial();
            AddOwnedForm(oFrmVistaPuesto);
            oFrmVistaPuesto.TopLevel = false;
            oFrmVistaPuesto.Dock = DockStyle.Fill;
            this.Controls.Add(oFrmVistaPuesto);
            this.Tag = oFrmVistaPuesto;
            oFrmVistaPuesto.BringToFront();
            oFrmVistaPuesto.Show();
        }
    }
}
