using MaterialSkin;
using MaterialSkin.Controls;
using iTextSharp.tool.xml.html.head;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            ContEmpresas();
            //ContEmpresasprov();
            //ContEmpresasLoc();
            //ContEmpleadosemp();
            ContEmpleados();
            ContJSS();
            ContNIOSH();
            ContREBA();
            ContRULA();
            //ConfigurarGraficoEmpxProv();
            //ConfigurarGraficoEmpLoc();
            //ConfigurarGraficoEmpxemp();
            //ContEmpresasPublPriv();
            //ContEmpleadosSexo();

            double SumaMetodos = 0;

            SumaMetodos = double.Parse(txtRulaCont.Text) + double.Parse(txtNioshCont.Text) + double.Parse(txtREBACont.Text) + double.Parse(txtjsscont.Text);

            TotalMetodo.Text = SumaMetodos.ToString();
        }


        public void ContEmpresas()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1000 = oEstadisticaBC.ContEmpresasBC();

            if (dt1000.Rows.Count > 0)
            {
                string resultado = dt1000.Rows[0][0].ToString();
                txtempresasregistradas.Text = resultado;
            }

        }
        //private void ContEmpresasprov()
        //{
        //    try
        //    {
        //        EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //        DataTable dt1001 = oEstadisticaBC.ContEmpresasprovBC();
        //        dgvprovemp.DataSource = null;
        //        dgvprovemp.DataSource = dt1001;
        //        dgvprovemp.Columns[1].HeaderText = "Número";

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //private void ContEmpresasLoc()
        //{
        //    try
        //    {
        //        EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //        DataTable dt1003 = oEstadisticaBC.ContEmpresasLocBC();
        //        dgvlocemp.DataSource = null;
        //        dgvlocemp.DataSource = dt1003;
        //        dgvlocemp.Columns[1].HeaderText = "Número";

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void ContEmpleados()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1005 = oEstadisticaBC.ContEmpleadosBC();

            if (dt1005.Rows.Count > 0)
            {
                string resultado = dt1005.Rows[0][0].ToString();
                txtcontempleados.Text = resultado;
            }

        }
        //private void ContEmpleadosemp()
        //{
        //    try
        //    {
        //        EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //        DataTable dt1004 = oEstadisticaBC.ContEmpleadosempresaBC();
        //        dgvEmpleadosEmpresas.DataSource = null;
        //        dgvEmpleadosEmpresas.DataSource = dt1004;
        //        dgvEmpleadosEmpresas.Columns[0].Visible = false;
        //        dgvEmpleadosEmpresas.Columns[1].HeaderText = "Nombre de la empresa";
        //        dgvEmpleadosEmpresas.Columns[2].HeaderText = "Número";

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        public void ContJSS()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1005 = oEstadisticaBC.ContJSSBC();

            if (dt1005.Rows.Count > 0)
            {
                string resultado = dt1005.Rows[0][0].ToString();
                txtjsscont.Text = resultado;
            }

        }
        public void ContNIOSH()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1006 = oEstadisticaBC.ContNIOSHBC();

            if (dt1006.Rows.Count > 0)
            {
                string resultado = dt1006.Rows[0][0].ToString();
                txtNioshCont.Text = resultado;
            }

        }
        public void ContREBA()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            DataTable dt1007 = oEstadisticaBC.ContREBABC();

            if (dt1007.Rows.Count > 0)
            {
                string resultado = dt1007.Rows[0][0].ToString();
                txtREBACont.Text = resultado;
            }

        }
        public void ContRULA()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            DataTable dt1008 = oEstadisticaBC.ContRULABC();

            if (dt1008.Rows.Count > 0)
            {
                string resultado = dt1008.Rows[0][0].ToString();
                txtRulaCont.Text = resultado;
            }

        }

        //private void ConfigurarGraficoEmpxProv()
        //{
        //    // Configura el gráfico aquí
        //    // Por ejemplo, crea una serie de columnas
        //    Series series = new Series
        //    {
        //        Name = "Cantidad",
        //        ChartType = SeriesChartType.Bar
        //    };

        //    // Configura los ejes
        //    ChartArea chartArea = new ChartArea();
        //    chartArea.AxisX.Title = "Provincia";
        //    chartArea.AxisY.Title = "Cantidad de Empresas";

        //    // Limpia las series existentes antes de agregar la nueva
        //    chartEmpresasProv.Series.Clear();

        //    // Asigna la serie y el área del gráfico
        //    chartEmpresasProv.Series.Add(series);
        //    chartEmpresasProv.ChartAreas.Add(chartArea);

        //    // Agrega un título al gráfico
        //    chartEmpresasProv.Titles.Add("Empresas por Provincias");  // Cambia "Mi Título" al título que desees
        //    chartEmpresasProv.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

        //    // Establece el formato de la serie
        //    series.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

        //    //chartEmpresasProv.ChartAreas[0].Position.Width = 40; // Porcentaje del ancho del gráfico
        //    //chartEmpresasProv.ChartAreas[0].Position.Height = 50; // Porcentaje de la altura del gráfico


        //    CargarDatosDesdeBDEmpxProv();
        //}
        //private void CargarDatosDesdeBDEmpxProv()
        //{
        //    // Utiliza la instancia de EstadisticaBC para obtener los datos
        //    EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //    DataTable dt1001 = oEstadisticaBC.ContEmpresasprovBC();

        //    // Limpia los datos existentes en el gráfico
        //    chartEmpresasProv.Series[0].Points.Clear();

        //    // Agrega los nuevos datos desde el DataTable
        //    foreach (DataRow row in dt1001.Rows)
        //    {
        //        string provincia = row["Provincia"].ToString();
        //        int cantidadEmpresas = Convert.ToInt32(row["CantidadEmpresas"]);

        //        // Agrega un punto a la serie para cada provincia
        //        chartEmpresasProv.Series[0].Points.AddXY(provincia, cantidadEmpresas);
        //    }
        //}

        //private void ConfigurarGraficoEmpLoc()
        //{
        //    // Configura el gráfico aquí
        //    // Por ejemplo, crea una serie de columnas
        //    Series series = new Series
        //    {
        //        Name = "Cantidad",
        //        ChartType = SeriesChartType.Column
        //    };

        //    // Configura los ejes
        //    ChartArea chartArea = new ChartArea();
        //    chartArea.AxisX.Title = "Localidad";
        //    chartArea.AxisY.Title = "Cantidad de Empresas";

        //    // Limpia las series existentes antes de agregar la nueva
        //    ChartEmpLocal.Series.Clear();

        //    // Asigna la serie y el área del gráfico
        //    ChartEmpLocal.Series.Add(series);
        //    ChartEmpLocal.ChartAreas.Add(chartArea);

        //    // Agrega un título al gráfico
        //    ChartEmpLocal.Titles.Add("Empresas por Localidad");  // Cambia "Mi Título" al título que desees
        //    ChartEmpLocal.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

        //    // Establece el formato de la serie
        //    series.Font = new Font("Arial", 10, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias



        //    CargarDatosDesdeBDEmpLoc();
        //}
        //private void CargarDatosDesdeBDEmpLoc()
        //{
        //    // Utiliza la instancia de EstadisticaBC para obtener los datos
        //    EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //    DataTable dt1003 = oEstadisticaBC.ContEmpresasLocBC();

        //    // Limpia los datos existentes en el gráfico
        //    ChartEmpLocal.Series[0].Points.Clear();

        //    // Agrega los nuevos datos desde el DataTable
        //    foreach (DataRow row in dt1003.Rows)
        //    {
        //        string Localidad = row["Localidad"].ToString();
        //        int cantidadEmpresas1 = Convert.ToInt32(row["CantidadEmpresas"]);

        //        // Agrega un punto a la serie para cada provincia
        //        ChartEmpLocal.Series[0].Points.AddXY(Localidad, cantidadEmpresas1);
        //    }
        //}
        //private void ConfigurarGraficoEmpxemp()
        //{
        //    // Configura el gráfico aquí
        //    // Por ejemplo, crea una serie de columnas
        //    Series series = new Series
        //    {
        //        Name = "Cantidad",
        //        ChartType = SeriesChartType.Column
        //    };

        //    // Configura los ejes
        //    ChartArea chartArea = new ChartArea();
        //    chartArea.AxisX.Title = "Localidad";
        //    chartArea.AxisY.Title = "EmpleadosporEmpresas";

        //    // Limpia las series existentes antes de agregar la nueva
        //    chartempxemp.Series.Clear();

        //    // Asigna la serie y el área del gráfico
        //    chartempxemp.Series.Add(series);
        //    chartempxemp.ChartAreas.Add(chartArea);

        //    // Agrega un título al gráfico
        //    chartempxemp.Titles.Add("Cantidad de Empleados por Empresas");  // Cambia "Mi Título" al título que desees
        //    chartempxemp.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

        //    // Establece el formato de la serie
        //    series.Font = new Font("Arial", 10, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias



        //    CargarDatosDesdeBDEmpxemp();
        //}
        //private void CargarDatosDesdeBDEmpxemp()
        //{
        //    // Utiliza la instancia de EstadisticaBC para obtener los datos
        //    EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //    DataTable dt1004 = oEstadisticaBC.ContEmpleadosempresaBC();

        //    // Limpia los datos existentes en el gráfico
        //    chartempxemp.Series[0].Points.Clear();

        //    // Agrega los nuevos datos desde el DataTable
        //    foreach (DataRow row in dt1004.Rows)
        //    {
        //        string Empleadosporempresas = row["Nombre"].ToString();
        //        int cantidadEmpleados1 = Convert.ToInt32(row["CantidadEmpleados"]);

        //        // Agrega un punto a la serie para cada provincia
        //        chartempxemp.Series[0].Points.AddXY(Empleadosporempresas, cantidadEmpleados1);
        //    }
        //}
        private void TotalMetodo_Click(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        //private void ContEmpresasPublPriv()
        //{
        //    try { 
        //    // Configura el gráfico aquí
        //    // Por ejemplo, crea una serie de pastel
        //    Series series = new Series
        //    {
        //        Name = "Cantidad de Empresas Por Tipo",
        //        ChartType = SeriesChartType.Pie, // Cambiado a SeriesChartType.Pie para el gráfico de pastel
        //    };

        //    // Configura los ejes (no es tan relevante para el gráfico de pastel)
        //    ChartArea chartArea = new ChartArea();
        //    chartArea.AxisX.Title = "Tipos de Empresas";
        //    chartArea.AxisY.Title = "Cantidad";

        //    // Limpia las series existentes antes de agregar la nueva
        //    GraphEmpresasTipo.Series.Clear();

        //    // Asigna la serie y el área del gráfico
        //    GraphEmpresasTipo.Series.Add(series);
        //    GraphEmpresasTipo.ChartAreas.Add(chartArea);

        //    // Agrega un título al gráfico
        //    GraphEmpresasTipo.Titles.Add("Tipos de Empresas");
        //    GraphEmpresasTipo.Font = new Font("Arial", 14, FontStyle.Bold);

        //    // Establece el formato de la serie
        //    series.Font = new Font("Arial", 10, FontStyle.Bold);

        //    // Añade datos de ejemplo al gráfico de pastel

        //    DatosBDEmpxemp();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void DatosBDEmpxemp()
        //{
        //        // Utiliza la instancia de EstadisticaBC para obtener los datos
        //        EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //        EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
        //        DataTable dt1999 = oEstadisticaBC.ContEmpresasPublPrivaBC();
        //    // Limpia los datos existentes en el gráfico
        //    GraphEmpresasTipo.Series[0].Points.Clear();

        //    // Configura la serie para un gráfico de pastel
        //    GraphEmpresasTipo.Series[0].ChartType = SeriesChartType.Pie;

        //        // Agrega los nuevos datos desde el DataTable
        //        foreach (DataRow row in dt1999.Rows)
        //        {
        //            string NivelRiesgo = row["Tipo"].ToString();
        //            int CantidadRiesgo = Convert.ToInt32(row["CantidadTipo"]);

        //        // Agrega un punto a la serie para cada provincia
        //        GraphEmpresasTipo.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
        //        }

        //    // Agrega un título al gráfico de pastel
        //    GraphEmpresasTipo.Titles.Clear();
        //    GraphEmpresasTipo.Titles.Add("Distribución de Empresas por Tipo");

        //    // Establece el formato de la serie
        //    GraphEmpresasTipo.Series[0].Font = new Font("Arial", 10, FontStyle.Bold);

        //    }
        //private void ContEmpleadosSexo()
        //{
        //    try
        //    {
        //        // Configura el gráfico aquí
        //        // Por ejemplo, crea una serie de pastel
        //        Series series = new Series
        //        {
        //            Name = "Cantidad de EmpleadosPor Genero",
        //            ChartType = SeriesChartType.Pie, // Cambiado a SeriesChartType.Pie para el gráfico de pastel
        //        };

        //        // Configura los ejes (no es tan relevante para el gráfico de pastel)
        //        ChartArea chartArea = new ChartArea();
        //        chartArea.AxisX.Title = "Genero";
        //        chartArea.AxisY.Title = "Cantidad";

        //        // Limpia las series existentes antes de agregar la nueva
        //        chartsMujeresVarones.Series.Clear();

        //        // Asigna la serie y el área del gráfico
        //        chartsMujeresVarones.Series.Add(series);
        //        chartsMujeresVarones.ChartAreas.Add(chartArea);

        //        // Agrega un título al gráfico
        //        chartsMujeresVarones.Titles.Add("Genero");
        //        chartsMujeresVarones.Font = new Font("Arial", 10, FontStyle.Bold);

        //        // Establece el formato de la serie
        //        series.Font = new Font("Arial", 10, FontStyle.Bold);

        //        // Añade datos de ejemplo al gráfico de pastel

        //        DatosBDEmpleadosSexo();
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
        //private void DatosBDEmpleadosSexo()
        //{
        //    // Utiliza la instancia de EstadisticaBC para obtener los datos
        //    EstadisticaBC oEstadisticaBC = new EstadisticaBC();
        //    EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
        //    DataTable dt6999 = oEstadisticaBC.ContEmpleadosSexoBC();
        //    // Limpia los datos existentes en el gráfico
        //    chartsMujeresVarones.Series[0].Points.Clear();

        //    // Configura la serie para un gráfico de pastel
        //    chartsMujeresVarones.Series[0].ChartType = SeriesChartType.Pie;

        //    // Agrega los nuevos datos desde el DataTable
        //    foreach (DataRow row in dt6999.Rows)
        //    {
        //        string NivelRiesgo = row["Genero"].ToString();
        //        int CantidadRiesgo = Convert.ToInt32(row["CantidadTipo"]);

        //        // Agrega un punto a la serie para cada provincia
        //        chartsMujeresVarones.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
        //    }

        //    // Agrega un título al gráfico de pastel
        //    chartsMujeresVarones.Titles.Clear();
        //    chartsMujeresVarones.Titles.Add("Generos");

        //    // Establece el formato de la serie
        //    chartsMujeresVarones.Series[0].Font = new Font("Arial", 10, FontStyle.Bold);

        //}

        private void BtnEmpxProv_Click(object sender, EventArgs e)
        {
            FrmSTATGgrafico1 OFrmSTATGgrafico1 = new FrmSTATGgrafico1();
            OFrmSTATGgrafico1.ShowDialog();
        }

        private void BtnEmpresaTipo_Click(object sender, EventArgs e)
        {
            FrmSTATGgrafico3 OFrmSTATGgrafico3 = new FrmSTATGgrafico3();
            OFrmSTATGgrafico3.ShowDialog();



        }

        private void BtnEmplxEmp_Click(object sender, EventArgs e)
        {
            FrmSTATGgrafico4 OFrmSTATGgrafico4 = new FrmSTATGgrafico4();
            OFrmSTATGgrafico4.ShowDialog();
        }

        private void BtnEmplxGen_Click(object sender, EventArgs e)
        {
            FrmSTATGgrafico5 OFrmSTATGgrafico5 = new FrmSTATGgrafico5();
            OFrmSTATGgrafico5.ShowDialog();
        }

        //private void BtnEmpresaxLoc_Click(object sender, EventArgs e)
        //{
        //    FrmSTATGgrafico2 OFrmSTATGgrafico2 = new FrmSTATGgrafico2();
        //    OFrmSTATGgrafico2.ShowDialog();
        //}
    }

        }
