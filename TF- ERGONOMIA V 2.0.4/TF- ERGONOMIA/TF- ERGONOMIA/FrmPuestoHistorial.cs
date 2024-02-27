using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;
using TF.COMMON.Cache;

namespace TF.WIN
{
    public partial class FrmPuestoHistorial : Form
    {

        public PuestoTrabajo PersonaSeleccionada { get; set; }


        public FrmPuestoHistorial()
        {
            InitializeComponent();

            DtpFechadesde.Value = DateTime.Now;
            DtpFechahasta.Value = DateTime.Now;
            LoadUserData();
        }
        private void LoadUserData()
        {
            userlabel1.Text = UserLoginCache.Nombre + ' ' + UserLoginCache.Apellido;
            userlabel2.Text = UserLoginCache.Cargo;
        }
        private void button1_Click(object sender, EventArgs e)
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

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
            oFrm.ShowDialog();

            if (oFrm.PersonaSeleccionada != null)
            {
                txtNombreEmpleado.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();
                //txtNombrePuesto.Text = oFrm.PuestoSeleccionada.NombrePuesto.ToString();
            }

        }

        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {
            try
            {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                oPuestoTrabajo.NombreEmpleado = txtNombreEmpleado.Text;

                // Verificar si la conversión de la fecha de inicio es exitosa
                if (DateTime.TryParse(DtpFechadesde.Text, out DateTime fechaInicio))
                {
                    oPuestoTrabajo.FechaIngreso = fechaInicio;

                    // Verificar si la conversión de la fecha de fin es exitosa
                    if (DateTime.TryParse(DtpFechahasta.Text, out DateTime fechaFin))
                    {
                        oPuestoTrabajo.FechaIngreso2 = fechaFin;

                        DataTable dt = oPuestoTrabajoBC.PuestoEmpleadoVerRecienteBC(oPuestoTrabajo);

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            DgvPuestosRecientes.DataSource = null;
                            DgvPuestosRecientes.DataSource = dt;
                            DgvPuestosRecientes.AutoResizeColumns();
                            AdjustColumnSizes(DgvPuestosRecientes);
                            DgvPuestosRecientes.Columns[0].HeaderText = "Nombre del Empleado";
                            DgvPuestosRecientes.Columns[1].HeaderText = "DNI";
                            DgvPuestosRecientes.Columns[2].HeaderText = "Puesto";
                            DgvPuestosRecientes.Columns[3].HeaderText = "Fecha de Ingreso";
                            DgvPuestosRecientes.Columns[4].HeaderText = "Fecha de Egreso";
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron resultados.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de fecha de fin no válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha de inicio no válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private void AdjustColumnSizes(DataGridView dataGridView)
        {
            int totalWidth = dataGridView.Width - dataGridView.RowHeadersWidth;
            int totalColumns = dataGridView.Columns.Count;

            // Calcular el ancho para cada columna
            int columnWidth = totalWidth / totalColumns;

            // Ajustar el tamaño de las columnas
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void BtnBuscarempresa_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                TxtCuitEmpresa.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                TxtNombreEmpresa.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = GetUniqueFileName("Informe");

                // Configurar el cuadro de diálogo para guardar como PDF
                guardar.DefaultExt = "pdf";
                guardar.Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4.Rotate(), 100, 30, 25, 50);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                            pdfDoc.Open();
                            pdfDoc.Add(new Phrase(""));

                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(TF.WIN.Properties.Resources.ergo, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(90, 90);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 50);
                            pdfDoc.Add(img);

                        // Convertir DataGridView a HTML
                        string tablaHtml = ConvertirDataGridViewAHtml(DgvPuestosRecientes);

                        // Reemplazos en el HTML
                        string paginahtml_texto = TF.WIN.Properties.Resources.plantillaconsultaPuestosEmpleado.ToString();

                            paginahtml_texto = paginahtml_texto.Replace("@TxtCuitEmpresa", TxtCuitEmpresa.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@TxtNombreEmpresa", TxtNombreEmpresa.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@txtNombreEmpleado", txtNombreEmpleado.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@Fecha", DateTime.Now.ToString("G"));
                            paginahtml_texto = paginahtml_texto.Replace("@DtpFechadesde", DtpFechadesde.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@DtpFechahasta", DtpFechahasta.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@DgvPuestosRecientes", tablaHtml);
                            paginahtml_texto = paginahtml_texto.Replace("@lblUsuario", userlabel1.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@TxtEmpresapresentar", TxtEmpresapresentar.Text);
                            paginahtml_texto = paginahtml_texto.Replace("@TxtCuit", TxtCuit.Text);

                        // Agregar más reemplazos para los campos adicionales según tus necesidades...

                        using (StringReader sr = new StringReader(paginahtml_texto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            stream.Close();

                            MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
        }

        public string ConvertirDataGridViewAHtml(DataGridView dataGridView)
        {
            StringBuilder htmlBuilder = new StringBuilder();

            // Comienza la tabla HTML
            htmlBuilder.Append("<table border='1'>");

            // Encabezados de columna
            htmlBuilder.Append("<tr>");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                htmlBuilder.Append("<th>").Append(column.HeaderText).Append("</th>");
            }
            htmlBuilder.Append("</tr>");

            // Filas y celdas
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                htmlBuilder.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    htmlBuilder.Append("<td>").Append(cell.Value).Append("</td>");
                }
                htmlBuilder.Append("</tr>");
            }

            // Finaliza la tabla HTML
            htmlBuilder.Append("</table>");

            return htmlBuilder.ToString();
        }

        private string GetUniqueFileName(string baseFileName)
        {
            string fileName = $"{baseFileName}{fileCounter}.pdf";
            fileCounter++;
            return fileName;
        }

        private int fileCounter = 0;

    }
}
