using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TF.WIN
{
    public partial class frmInformes : Form
    {
        public frmInformes()
        {
            InitializeComponent();

        }

        private void btnAdmProy_Click(object sender, EventArgs e)
        {
            // Nombre del recurso que contiene el PDF en los recursos del proyecto
            string nombreRecursoPDF = "CarpetaIntegradoraAdmProy1"; // Reemplaza "NombreDelArchivoPDF" con el nombre real de tu archivo PDF

            // Obtener el flujo del recurso PDF
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(nombreRecursoPDF))
            {
                if (stream != null)
                {
                    // Crear una copia temporal del archivo PDF
                    string tempFilePath = Path.GetTempFileName();
                    using (var fileStream = File.Create(tempFilePath))
                    {
                        stream.CopyTo(fileStream);
                    }

                    // Abrir el PDF con el visor predeterminado
                    Process.Start(tempFilePath);
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el recurso del PDF.");
                }
            }
        }
    }
}
