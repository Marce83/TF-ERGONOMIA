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
    public partial class FrmPersonReba : Form
    {
        public FrmPersonReba()
        {
            InitializeComponent();
            PuestoRebaPerson();
        }
        private void PuestoRebaPerson()
        {
            PuestoRebaPersonDato();
        }
        private void PuestoRebaPersonDato()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            DataTable dt26002 = oEstadisticaBC.PuestoRebaPersonBC(oEstadisticasPersonales);

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt26002.Rows)
            {
                string PuestoDeTrabajoReba = row["PuestoDeTrabajoReba"].ToString();
                int PuestoAnalizado = Convert.ToInt32(row["PuestoAnalizado"]);
                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(PuestoDeTrabajoReba, PuestoAnalizado);
            }
        }
    }
}
