using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TF.BC;

namespace TF.WIN
{
    public partial class FrmSTATGgrafico1 : Form
    {
        public FrmSTATGgrafico1()
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
            DataTable dt1001 = oEstadisticaBC.ContEmpresasprovBC();

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1001.Rows)
            {
                string provincia = row["Provincia"].ToString();
                int cantidadEmpresas = Convert.ToInt32(row["CantidadEmpresas"]);
                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(provincia, cantidadEmpresas);
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
