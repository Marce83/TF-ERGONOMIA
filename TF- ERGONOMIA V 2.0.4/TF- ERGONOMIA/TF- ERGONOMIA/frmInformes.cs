using MaterialSkin;
using MaterialSkin.Controls;
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
            string nombreRecursoPDF = "CarpetaIntegradoraAdmProy1"; // Reemplaza "CarpetaIntegradoraAdmProy1.pdf" con el nombre real de tu archivo PDF

            // Verificar si el recurso está incrustado en los recursos del proyecto
            if (TF.WIN.Properties.Resources.ResourceManager.GetObject(nombreRecursoPDF) != null)
            {
                // Obtener los bytes del recurso
                byte[] pdfBytes = TF.WIN.Properties.Resources.ResourceManager.GetObject(nombreRecursoPDF) as byte[];
                if (pdfBytes != null)
                {
                    // Guardar los bytes del recurso en un archivo temporal
                    string tempFilePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempFilePath, pdfBytes);

                    // Abrir el PDF con el visor predeterminado
                    Process.Start(tempFilePath);
                }
                else
                {
                    MessageBox.Show("Error al obtener los bytes del recurso del PDF.");
                }
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el recurso del PDF en los recursos del proyecto.");
            }
        }
    }
}
