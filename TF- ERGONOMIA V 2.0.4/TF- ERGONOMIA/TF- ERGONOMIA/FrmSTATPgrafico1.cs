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
    public partial class FrmSTATPgrafico1 : Form
    {
        public FrmSTATPgrafico1()
        {
            InitializeComponent();
            GraficoPastelRula();
        }

        public void GraficoPastelRula()
        {
            try
            {
                GraficoPastelRulaDATOS();
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
        }

        private void GraficoPastelRulaDATOS()
        {
            try
            {
                // Accede a los valores del formulario frmEstadisticas2
                frmEstadisticas2 frmEstadisticas2 = new frmEstadisticas2();

                string cuit = frmEstadisticas2.ObtenerCUIT();
                string fechaDesde = frmEstadisticas2.ObtenerFechaDesde();
                string fechaHasta = frmEstadisticas2.ObtenerFechaHasta();

                // Utiliza la instancia de EstadisticaBC para obtener los datos
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();

                // Asigna los valores obtenidos al objeto EstadisticasPersonales
                oEstadisticasPersonales.CuitRula = cuit;
                oEstadisticasPersonales.FechaCargaRula = fechaDesde;
                oEstadisticasPersonales.FechaCarga2Rula = fechaHasta;

                // Obtiene los datos de la base de datos
                DataTable dt1200 = oEstadisticaBC.PastelRulaPersonBC(oEstadisticasPersonales);


                // Agrega los nuevos datos desde el DataTable
                foreach (DataRow row in dt1200.Rows)
                {
                    string nivelRiesgo = row["NivelRiesgo"].ToString();
                    int cantidadRiesgo = Convert.ToInt32(row["CantidadRiesgo"]);

                    // Agrega un punto a la serie para cada nivel de riesgo
                    chart1.Series[0].Points.AddXY(nivelRiesgo, cantidadRiesgo);
                }


            }
            catch (Exception ex)
            {
                // Manejo de excepciones
            }
        }
    }
}
