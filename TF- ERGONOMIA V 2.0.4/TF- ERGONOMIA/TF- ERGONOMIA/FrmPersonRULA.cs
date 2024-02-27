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
    public partial class FrmPersonRULA : Form
    {
        public FrmPersonRULA()
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
            DataTable dt26003 = oEstadisticaBC.PuestoRulaPersonBC(oEstadisticasPersonales);

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt26003.Rows)
            {
                string PuestoDeTrabajo = row["PuestoDeTrabajo"].ToString();
                int PuestoAnalizado = Convert.ToInt32(row["PuestoAnalizado"]);
                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(PuestoDeTrabajo, PuestoAnalizado);
            }
        }

    }
}
