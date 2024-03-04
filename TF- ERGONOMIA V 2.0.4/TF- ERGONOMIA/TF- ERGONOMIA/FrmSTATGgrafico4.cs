using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class FrmSTATGgrafico4 : Form
    {
        public FrmSTATGgrafico4()
        {
            InitializeComponent();
            ConfigurarGraficoEmpxemp();

        }

        private void ConfigurarGraficoEmpxemp()
        {
           
            CargarDatosDesdeBDEmpxemp();
        }
        private void CargarDatosDesdeBDEmpxemp()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            DataTable dt1004 = oEstadisticaBC.ContEmpleadosempresaBC();

           // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt1004.Rows)
            {
                string Empleadosporempresas = row["Nombre"].ToString();
                int cantidadEmpleados1 = Convert.ToInt32(row["CantidadEmpleados"]);

                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(Empleadosporempresas, cantidadEmpleados1);
            }
        }



















    }
}
