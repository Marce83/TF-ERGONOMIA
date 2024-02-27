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
    public partial class FrmPersonNiosh : Form
    {
        public FrmPersonNiosh()
        {
            InitializeComponent();
            ConfigurarGraficoEmpxProv();
        }
        private void ConfigurarGraficoEmpxProv()
        {
            CargarDatosDesdeBDEmpxProv();
        }
        private void CargarDatosDesdeBDEmpxProv()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            DataTable dt26001 = oEstadisticaBC.PuestoNioshPersonBC(oEstadisticasPersonales);

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt26001.Rows)
            {
                string PuestoDeTrabajoNiosh = row["PuestoDeTrabajoNiosh"].ToString();
                int PuestoAnalizado = Convert.ToInt32(row["PuestoAnalizado"]);
                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(PuestoDeTrabajoNiosh, PuestoAnalizado);
            }
        }
    }
}
