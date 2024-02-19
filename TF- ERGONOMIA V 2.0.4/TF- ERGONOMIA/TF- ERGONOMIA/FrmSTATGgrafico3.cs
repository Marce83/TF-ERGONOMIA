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
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class FrmSTATGgrafico3 : Form
    {
        public FrmSTATGgrafico3()
        {
            InitializeComponent();
            ContEmpresasPublPriv();
        }
        private void ContEmpresasPublPriv()
        {
            try
            {
                // Configura el gráfico aquí
                // Por ejemplo, crea una serie de pastel
                //Series series = new Series
                //{
                //    Name = "Cantidad de Empresas Por Tipo",
                //    ChartType = SeriesChartType.Pie, // Cambiado a SeriesChartType.Pie para el gráfico de pastel
                //};

                //// Configura los ejes (no es tan relevante para el gráfico de pastel)
                //ChartArea chartArea = new ChartArea();
                //chartArea.AxisX.Title = "Tipos de Empresas";
                //chartArea.AxisY.Title = "Cantidad";

                //// Limpia las series existentes antes de agregar la nueva
                //GraphEmpresasTipo.Series.Clear();

                //// Asigna la serie y el área del gráfico
                //GraphEmpresasTipo.Series.Add(series);
                //GraphEmpresasTipo.ChartAreas.Add(chartArea);

                //// Agrega un título al gráfico
                //GraphEmpresasTipo.Titles.Add("Tipos de Empresas");
                //GraphEmpresasTipo.Font = new Font("Arial", 14, FontStyle.Bold);

                //// Establece el formato de la serie
                //series.Font = new Font("Arial", 10, FontStyle.Bold);

                //// Añade datos de ejemplo al gráfico de pastel

                DatosBDEmpxemp();
            }
            catch (Exception ex)
            {

            }
        }

        private void DatosBDEmpxemp()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            DataTable dt1999 = oEstadisticaBC.ContEmpresasPublPrivaBC();
            //// Limpia los datos existentes en el gráfico
            //GraphEmpresasTipo.Series[0].Points.Clear();

            //// Configura la serie para un gráfico de pastel
            //GraphEmpresasTipo.Series[0].ChartType = SeriesChartType.Pie;

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1999.Rows)
            {
                string NivelRiesgo = row["Tipo"].ToString();
                int CantidadRiesgo = Convert.ToInt32(row["CantidadTipo"]);

                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
            }

            //Agrega un título al gráfico de pastel
            //GraphEmpresasTipo.Titles.Clear();
            //GraphEmpresasTipo.Titles.Add("Distribución de Empresas por Tipo");

            //Establece el formato de la serie
            //GraphEmpresasTipo.Series[0].Font = new Font("Arial", 10, FontStyle.Bold);

        }






        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
