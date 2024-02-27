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
    public partial class FrmSTATGgrafico2 : Form
    {
        public FrmSTATGgrafico2()
        {
            InitializeComponent();
            ConfigurarGraficoEmpLoc();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfigurarGraficoEmpLoc()
        {
             CargarDatosDesdeBDEmpLoc();
        }
        private void CargarDatosDesdeBDEmpLoc()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            DataTable dt1003 = oEstadisticaBC.ContEmpresasLocBC();

            foreach (DataRow row in dt1003.Rows)
            {
                string Localidad = row["Localidad"].ToString();
                int cantidadEmpresas1 = Convert.ToInt32(row["CantidadEmpresas"]);

                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(Localidad, cantidadEmpresas1);
            }
        }
















    }
}
