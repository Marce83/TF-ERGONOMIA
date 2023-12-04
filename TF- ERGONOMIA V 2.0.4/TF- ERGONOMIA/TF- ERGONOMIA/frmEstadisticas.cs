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
            ContEmpresasLoc();
            ContEmpleadosemp();
            ContEmpleados();
            ContJSS();
            ContNIOSH();
            ContREBA();
            ContRULA();
            ConfigurarGraficoEmpxProv();

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
        private void ContEmpresasLoc()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                DataTable dt1003 = oEstadisticaBC.ContEmpresasLocBC();
                dgvlocemp.DataSource = null;
                dgvlocemp.DataSource = dt1003;
                dgvlocemp.Columns[1].HeaderText = "Número";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
        private void ContEmpleadosemp()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                DataTable dt1004 = oEstadisticaBC.ContEmpleadosempresaBC();
                dgvEmpleadosEmpresas.DataSource = null;
                dgvEmpleadosEmpresas.DataSource = dt1004;
                dgvEmpleadosEmpresas.Columns[0].Visible = false;
                dgvEmpleadosEmpresas.Columns[1].HeaderText = "Nombre de la empresa";
                dgvEmpleadosEmpresas.Columns[2].HeaderText = "Número";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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

        private void ConfigurarGraficoEmpxProv()
        {
            // Configura el gráfico aquí
            // Por ejemplo, crea una serie de columnas
            Series series = new Series
            {
                Name = "Cantidad",
                ChartType = SeriesChartType.Column
            };

            // Configura los ejes
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Provincia";
            chartArea.AxisY.Title = "Cantidad de Empresas";

            // Limpia las series existentes antes de agregar la nueva
            chartEmpresasProv.Series.Clear();

            // Asigna la serie y el área del gráfico
            chartEmpresasProv.Series.Add(series);
            chartEmpresasProv.ChartAreas.Add(chartArea);

            // Agrega un título al gráfico
            chartEmpresasProv.Titles.Add("Empresas por Provincias");  // Cambia "Mi Título" al título que desees
            chartEmpresasProv.Font = new Font("Arial", 14, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias

            // Establece el formato de la serie
            series.Font = new Font("Arial", 10, FontStyle.Bold); // Cambia el nombre de la fuente, tamaño y estilo según tus preferencias



            CargarDatosDesdeBDEmpxProv();
        }
        private void CargarDatosDesdeBDEmpxProv()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            DataTable dt1001 = oEstadisticaBC.ContEmpresasprovBC();

            // Limpia los datos existentes en el gráfico
            chartEmpresasProv.Series[0].Points.Clear();

            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1001.Rows)
            {
                string provincia = row["Provincia"].ToString();
                int cantidadEmpresas = Convert.ToInt32(row["CantidadEmpresas"]);

                // Agrega un punto a la serie para cada provincia
                chartEmpresasProv.Series[0].Points.AddXY(provincia, cantidadEmpresas);
            }
        }


        private void TotalMetodo_Click(object sender, EventArgs e)
        {

        }
    }
}
