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
    public partial class frmEstadisticas2 : Form
    {
        public frmEstadisticas2()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmEstadisticas2_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUIT.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresa.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();

            }

        }
        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {
            ContNIOSH();
            ContREBA();
            ContRULA();
            ContJSS();
            ContMetodos();
            GraficoPastelRula();
            HistoRulaPerson();
            GraficoPastelReba();
            HistoRebaPerson();

        }
        public void ContNIOSH()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitNiosh = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaNiosh = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Niosh = FechaHasta.Text;


                DataTable dt1100 = oEstadisticaBC.ContNIOSHPersonBC(oEstadisticasPersonales);

                if (dt1100.Rows.Count > 0)
                {
                    string resultado1 = dt1100.Rows[0][0].ToString();
                    txtNioshCont.Text = resultado1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }

        }
        public void ContREBA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitReba = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaReba = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Reba = FechaHasta.Text;

                DataTable dt1101 = oEstadisticaBC.ContREBAPersonBC(oEstadisticasPersonales);

                if (dt1101.Rows.Count > 0)
                {
                    string resultado2 = dt1101.Rows[0][0].ToString();
                    txtREBACont.Text = resultado2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContRULA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();

                oEstadisticasPersonales.CuitRula = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaRula = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Rula = FechaHasta.Text;

                DataTable dt1102 = oEstadisticaBC.ContRULAPersonBC(oEstadisticasPersonales);

                if (dt1102.Rows.Count > 0)
                {
                    string resultado3 = dt1102.Rows[0][0].ToString();
                    txtRulaCont.Text = resultado3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContJSS()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitJss = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaJss = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Jss = FechaHasta.Text;

                DataTable dt1103 = oEstadisticaBC.ContJSSPersonBC(oEstadisticasPersonales);

                if (dt1103.Rows.Count > 0)
                {
                    string resultado4 = dt1103.Rows[0][0].ToString();
                    txtjsscont.Text = resultado4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContMetodos()
        {
            try
            {
                double SumaMetodosPerson = 0;

                SumaMetodosPerson = double.Parse(txtRulaCont.Text) + double.Parse(txtNioshCont.Text) + double.Parse(txtREBACont.Text) + double.Parse(txtjsscont.Text);

                TotalMetodoPerson.Text = SumaMetodosPerson.ToString();
            }
            catch (Exception ex)
            {

            }
        }
        public void GraficoPastelRula()
        {
            try
            {
                // Configura el gráfico aquí
                // Por ejemplo, crea una serie de pastel
                Series series = new Series
                {
                    Name = "Cantidad de Riesgo",
                    ChartType = SeriesChartType.Pie, // Cambiado a SeriesChartType.Pie para el gráfico de pastel
                };

                // Configura los ejes (no es tan relevante para el gráfico de pastel)
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Nivel de Riesgo";
                chartArea.AxisY.Title = "Cantidad de Riesgo";

                // Limpia las series existentes antes de agregar la nueva
                chartPastelRula.Series.Clear();

                // Asigna la serie y el área del gráfico
                chartPastelRula.Series.Add(series);
                chartPastelRula.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico
                chartPastelRula.Titles.Add("Riesgos obtenidos");
                chartPastelRula.Font = new Font("Arial", 14, FontStyle.Bold);

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold);

                // Añade datos de ejemplo al gráfico de pastel

                GraficoPastelRulaDATOS();
            }
            catch (Exception ex)
            {

            }
        }
        private void HistoRulaPerson()
        {
            try
            {
                // Configura el gráfico aquí
                // Por ejemplo, crea una serie de barras
                Series series = new Series
                {
                    Name = "Cantidad de riesgos por día",
                    ChartType = SeriesChartType.Bar // Cambiado a SeriesChartType.Bar para el gráfico de barras
                };

                // Configura los ejes
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Fecha y Cantidad por día";
                chartArea.AxisY.Title = "Niveles";

                // Limpia las series existentes antes de agregar la nueva
                ChartHistogramaRula2.Series.Clear();

                // Asigna la serie y el área del gráfico
                ChartHistogramaRula2.Series.Add(series);
                ChartHistogramaRula2.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico
                ChartHistogramaRula2.Titles.Clear();
                ChartHistogramaRula2.Titles.Add("Cantidad de Riesgos por día");
                ChartHistogramaRula2.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

                // Añade datos al gráfico
                GraficoHistRulaDATOS();
            }
            catch (Exception ex)
            {
                // Maneja la excepción, si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GraficoPastelRulaDATOS()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            oEstadisticasPersonales.CuitRula = txtCUIT.Text;
            oEstadisticasPersonales.FechaCargaRula = FechaDesde.Text;
            oEstadisticasPersonales.FechaCarga2Rula = FechaHasta.Text;
            DataTable dt1200 = oEstadisticaBC.PastelRulaPersonBC(oEstadisticasPersonales);
            // Limpia los datos existentes en el gráfico
            chartPastelRula.Series[0].Points.Clear();

            // Configura la serie para un gráfico de pastel
            chartPastelRula.Series[0].ChartType = SeriesChartType.Pie;

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1200.Rows)
            {
                string NivelRiesgo = row["NivelRiesgo"].ToString();
                int CantidadRiesgo = Convert.ToInt32(row["CantidadRiesgo"]);

                // Agrega un punto a la serie para cada provincia
                chartPastelRula.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
            }

            // Agrega un título al gráfico de pastel
            chartPastelRula.Titles.Clear();
            chartPastelRula.Titles.Add("Distribución de Riesgo por nivel");

            // Establece el formato de la serie
            chartPastelRula.Series[0].Font = new Font("Arial", 10, FontStyle.Bold);

        }
        private void GraficoHistRulaDATOS()
        {
            try
            {
                // Utiliza la instancia de EstadisticaBC para obtener los datos
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitRula = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaRula = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Rula = FechaHasta.Text;
                DataTable dt1201 = oEstadisticaBC.HistoRulaPersonBC(oEstadisticasPersonales);

                // Limpia los datos existentes en el gráfico
                ChartHistogramaRula2.Series.Clear();

                // Configura las series para un gráfico de barras
                Series series = new Series();
                series.ChartType = SeriesChartType.Bar;
                series.Name = "Analisis x Dia";

                // Agrega las series al gráfico
                ChartHistogramaRula2.Series.Add(series);

                // Agrega los nuevos datos desde el DataTable
                foreach (DataRow row in dt1201.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(row["FechaCarga"]);
                    int nivelRiesgo = Convert.ToInt32(row["NivelRiesgo"]);
                    int Analisisxdia = Convert.ToInt32(row["AnalisisxDia"]);

                    // Combina la fecha y AnalisisxDia para obtener un nombre único
                    string nombrePunto = $"{fecha.ToShortDateString()} - {Analisisxdia}";

                    // Agrega un punto a la serie para cada fecha, nivel de riesgo y AnalisisxDia
                    series.Points.AddXY(nombrePunto, nivelRiesgo);
                }

                // Configura los ejes
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Fecha de Carga y Analisis x Dia";
                chartArea.AxisY.Title = "Nivel de Riesgo";

                // Ajusta las etiquetas del eje X para mostrar cada barra
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
                chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy";

                // Asigna el área del gráfico
                ChartHistogramaRula2.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico de barras
                ChartHistogramaRula2.Titles.Clear();
                ChartHistogramaRula2.Titles.Add("Distribución de Riesgo por Nivel y Fecha");

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                // Maneja la excepción, si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GraficoPastelReba()
        {
            try
            {
                // Configura el gráfico aquí
                // Por ejemplo, crea una serie de pastel
                Series series = new Series
                {
                    Name = "Cantidad de Riesgo",
                    ChartType = SeriesChartType.Pie, // Cambiado a SeriesChartType.Pie para el gráfico de pastel
                };

                // Configura los ejes (no es tan relevante para el gráfico de pastel)
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Nivel de Riesgo";
                chartArea.AxisY.Title = "Cantidad de Riesgo";

                // Limpia las series existentes antes de agregar la nueva
                chartPastelReba.Series.Clear();

                // Asigna la serie y el área del gráfico
                chartPastelReba.Series.Add(series);
                chartPastelReba.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico
                chartPastelReba.Titles.Add("Riesgos obtenidos");
                chartPastelReba.Font = new Font("Arial", 14, FontStyle.Bold);

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold);

                // Añade datos de ejemplo al gráfico de pastel

                GraficoPastelRebaDATOS();
            }
            catch (Exception ex)
            {

            }
        }
        private void HistoRebaPerson()
        {
            try
            {
                // Configura el gráfico aquí
                // Por ejemplo, crea una serie de barras
                Series series = new Series
                {
                    Name = "Cantidad de riesgos por día",
                    ChartType = SeriesChartType.Bar // Cambiado a SeriesChartType.Bar para el gráfico de barras
                };

                // Configura los ejes
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Fecha y Cantidad por día";
                chartArea.AxisY.Title = "Niveles";

                // Limpia las series existentes antes de agregar la nueva
                ChartHistogramaReba2.Series.Clear();

                // Asigna la serie y el área del gráfico
                ChartHistogramaReba2.Series.Add(series);
                ChartHistogramaReba2.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico
                ChartHistogramaReba2.Titles.Clear();
                ChartHistogramaReba2.Titles.Add("Cantidad de Riesgos por día");
                ChartHistogramaReba2.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

                // Añade datos al gráfico
                HistoRebaPersonDATOS();
            }
            catch (Exception ex)
            {
                // Maneja la excepción, si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GraficoPastelRebaDATOS()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            oEstadisticasPersonales.CuitReba = txtCUIT.Text;
            oEstadisticasPersonales.FechaCargaReba = FechaDesde.Text;
            oEstadisticasPersonales.FechaCarga2Reba = FechaHasta.Text;
            DataTable dt1203 = oEstadisticaBC.PastelRebaPersonBC(oEstadisticasPersonales);
            // Limpia los datos existentes en el gráfico
            chartPastelReba.Series[0].Points.Clear();

            // Configura la serie para un gráfico de pastel
            chartPastelReba.Series[0].ChartType = SeriesChartType.Pie;

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1203.Rows)
            {
                string NivelRiesgo = row["NivelRiesgo"].ToString();
                int CantidadRiesgo = Convert.ToInt32(row["CantidadRiesgo"]);

                // Agrega un punto a la serie para cada provincia
                chartPastelReba.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
            }

            // Agrega un título al gráfico de pastel
            chartPastelReba.Titles.Clear();
            chartPastelReba.Titles.Add("Distribución de Riesgo por nivel");

            // Establece el formato de la serie
            chartPastelReba.Series[0].Font = new Font("Arial", 10, FontStyle.Bold);

        }
        private void HistoRebaPersonDATOS()
        {
            try
            {
                // Utiliza la instancia de EstadisticaBC para obtener los datos
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitReba = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaReba = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Reba = FechaHasta.Text;
                DataTable dt1205 = oEstadisticaBC.HistoRebaPersonBC(oEstadisticasPersonales);

                // Limpia los datos existentes en el gráfico
                ChartHistogramaReba2.Series.Clear();

                // Configura las series para un gráfico de barras
                Series series = new Series();
                series.ChartType = SeriesChartType.Bar;
                series.Name = "Analisis x Dia";

                // Agrega las series al gráfico
                ChartHistogramaReba2.Series.Add(series);

                // Agrega los nuevos datos desde el DataTable
                foreach (DataRow row in dt1205.Rows)
                {
                    DateTime fecha = Convert.ToDateTime(row["FechaCargaReba"]);
                    int nivelRiesgo = Convert.ToInt32(row["NivelRiesgo"]);
                    int Analisisxdia = Convert.ToInt32(row["AnalisisxDia"]);

                    // Combina la fecha y AnalisisxDia para obtener un nombre único
                    string nombrePunto = $"{fecha.ToShortDateString()} - {Analisisxdia}";

                    // Agrega un punto a la serie para cada fecha, nivel de riesgo y AnalisisxDia
                    series.Points.AddXY(nombrePunto, nivelRiesgo);
                }

                // Configura los ejes
                ChartArea chartArea = new ChartArea();
                chartArea.AxisX.Title = "Fecha de Carga y Analisis x Dia";
                chartArea.AxisY.Title = "Nivel de Riesgo";

                // Ajusta las etiquetas del eje X para mostrar cada barra
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.IntervalType = DateTimeIntervalType.Days;
                chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy";

                // Asigna el área del gráfico
                ChartHistogramaReba2.ChartAreas.Add(chartArea);

                // Agrega un título al gráfico de barras
                ChartHistogramaReba2.Titles.Clear();
                ChartHistogramaReba2.Titles.Add("Distribución de Riesgo por Nivel y Fecha");

                // Establece el formato de la serie
                series.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                // Maneja la excepción, si es necesario
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
