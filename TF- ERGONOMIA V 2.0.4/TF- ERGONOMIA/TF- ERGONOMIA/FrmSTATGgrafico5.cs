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
    public partial class FrmSTATGgrafico5 : Form
    {
        public FrmSTATGgrafico5()
        {
            InitializeComponent();
            ContEmpleadosSexo();
        }
        private void ContEmpleadosSexo()
        {
            try
            {
                DatosBDEmpleadosSexo();
            }
            catch (Exception ex)
            {

            }
        }
        private void DatosBDEmpleadosSexo()
        {
            // Utiliza la instancia de EstadisticaBC para obtener los datos
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
            DataTable dt6999 = oEstadisticaBC.ContEmpleadosSexoBC();
            // Limpia los datos existentes en el gráfico
           
            // Agrega los nuevos datos desde el DataTable
            foreach (DataRow row in dt6999.Rows)
            {
                string NivelRiesgo = row["Genero"].ToString();
                int CantidadRiesgo = Convert.ToInt32(row["CantidadTipo"]);

                // Agrega un punto a la serie para cada provincia
                chart1.Series[0].Points.AddXY(NivelRiesgo, CantidadRiesgo);
            }
          
        }






    }
}
