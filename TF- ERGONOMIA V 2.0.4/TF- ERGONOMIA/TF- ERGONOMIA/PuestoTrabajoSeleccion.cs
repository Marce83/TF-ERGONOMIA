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
            oFrmPuestoTrabajo.Show();
        }

        private void btnAsociacionPuesto_Click(object sender, EventArgs e)
        {
            FrmAsociacionPuesto oFrmAsociacionPuesto = new FrmAsociacionPuesto();
            oFrmAsociacionPuesto.Show();
        }

        private void btnempleadosasociados_Click(object sender, EventArgs e)
        {
            FrmVistaPuesto oFrmVistaPuesto = new FrmVistaPuesto();
            oFrmVistaPuesto.Show();
        }
    }
}
