using iTextSharp.tool.xml.html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.COMMON.Cache;
using TF.ENTITIES;
using TF.WIN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TF.WIN
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }
        private void CargaEmpresa_Load(object sender, EventArgs e)
        {
            RolesCargo();
            Listar();
            Limpiar();
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtcuitconsultacuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && txtTelefono.MaxLength == 10)
                e.Handled = true;
            //else MessageBox.Show("Debe ingresar 10 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Empresas oemp = new Empresas();
            EmpresasBC oempresaBC = new EmpresasBC();

            if (txtCUIT.Text != string.Empty)
            {
                if (txtCUIT.Text.Length == 11)
                {
                    if (txtNombreEmpresa.Text != string.Empty)
                    {
                        if (cboCondFiscal.Text != string.Empty)
                        {
                            if (txtActEmpr.Text != string.Empty)
                            {
                                if (txtDireccion.Text != string.Empty)
                                {
                                    if (cboLocalidad.Text != string.Empty)
                                    {
                                        if (cboProvincia.Text != string.Empty)
                                        {
                                            if (txtTelefono.Text != string.Empty)
                                            {
                                                if (txtTelefono.Text.Length == 10)
                                                {
                                                    if (txtWeb.Text != string.Empty)
                                                     {
                                                        if (txtCorreo.Text != string.Empty)
                                                        {
                                                            if (ValidarCorreo.ValidarEmail(txtCorreo.Text))
                                                            {
                                                                 try
                                                                 {
                                                                    oemp.CUIT = txtCUIT.Text;
                                                                    oemp.Nombre = txtNombreEmpresa.Text;
                                                                    oemp.Condicion_Fiscal = cboCondFiscal.Text;
                                                                    oemp.Actividad_Empresarial = txtActEmpr.Text;
                                                                    oemp.Direccion = txtDireccion.Text;
                                                                    oemp.Localidad = cboLocalidad.Text;
                                                                    oemp.Provincia = cboProvincia.Text;
                                                                    oemp.Telefono = txtTelefono.Text;
                                                                    oemp.Correo = txtCorreo.Text;
                                                                    oemp.Web = txtWeb.Text;
                                                                    var res = oempresaBC.Insertempresa(oemp);
                                                                    MessageBox.Show("Empresa cargada exitosamente");
                                                                    Limpiar();
                                                                    Listar();
                                                                  }
                                                                catch (Exception ex)
                                                                 {
                                                                    MessageBox.Show(ex.Message);
                                                                    Limpiar();
                                                                 }
                                                            }
                                                    else MessageBox.Show("El formato del Correo es inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else MessageBox.Show("Debe ingresar el correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else MessageBox.Show("Debe ingresar el Sitio Web de la Empresa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else MessageBox.Show("Debe ingresar 10 digitos en el Teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                         }
                                                   else MessageBox.Show("Debe ingresar el número de teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                 }
                                             else MessageBox.Show("Debe ingresar la Provincia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           }
                                       else MessageBox.Show("Debe ingresar la Localidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                  else MessageBox.Show("Debe ingresar la dirección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            else MessageBox.Show("Debe ingresar la Actividad Empresarial", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Debe ingresar la Condición Fiscal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Debe ingresar la Razón Social", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
                else MessageBox.Show("Debe ingresar 11 digitos en el CUIT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe ingresar el número de CUIT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Listar()
        {
            try
            {
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.GetAll();
                dgvCargaEmpresas.DataSource = null;
                dgvCargaEmpresas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtCUIT.Text = string.Empty;
            txtCUIT.ReadOnly = false;
            txtCUIT.Focus();
            txtNombreEmpresa.Text = string.Empty;
            cboCondFiscal.SelectedIndex = 0;
            txtActEmpr.SelectedIndex = 0;
            txtDireccion.Text = string.Empty;
            //cboLocalidad.SelectedIndex = 0;
            //cboProvincia.SelectedIndex = 0;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtWeb.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empresas oemp = new Empresas();
            oemp.CUIT = txtcuitconsultacuit.Text;

            EmpresasBC oEmpresasBC = new EmpresasBC();
            DataTable dt = oEmpresasBC.ConsultarEmpresas(oemp);

            dgvCargaEmpresas.DataSource = null;
            dgvCargaEmpresas.DataSource = dt;
            dgvCargaEmpresas.Columns[0].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar esta Empresa?", "Realizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    Empresas oemp = new Empresas();
                    oemp.CUIT = txtCUIT.Text;
                    oemp.Nombre = txtNombreEmpresa.Text;
                    oemp.Condicion_Fiscal = cboCondFiscal.Text;
                    oemp.Actividad_Empresarial = txtActEmpr.Text;
                    oemp.Direccion = txtDireccion.Text;
                    oemp.Localidad = cboLocalidad.Text;
                    oemp.Provincia = cboProvincia.Text;
                    oemp.Telefono = txtTelefono.Text;
                    oemp.Correo = txtCorreo.Text;
                    oemp.Web = txtWeb.Text;

                    EmpresasBC oempresaBC = new EmpresasBC();
                    var res = oempresaBC.updateempresa(oemp);
                    MessageBox.Show(" Empresa Modificada con exito");

                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCargaEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txtCUIT.Text = dgvCargaEmpresas.CurrentRow.Cells[0].Value.ToString();
                txtCUIT.ReadOnly = true;
                txtNombreEmpresa.Text = dgvCargaEmpresas.CurrentRow.Cells[1].Value.ToString();
                cboCondFiscal.Text = dgvCargaEmpresas.CurrentRow.Cells[2].Value.ToString();
                txtActEmpr.Text = dgvCargaEmpresas.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvCargaEmpresas.CurrentRow.Cells[4].Value.ToString();
                cboProvincia.Text = dgvCargaEmpresas.CurrentRow.Cells[5].Value.ToString();
                cboLocalidad.Text = dgvCargaEmpresas.CurrentRow.Cells[6].Value.ToString();
                txtTelefono.Text = dgvCargaEmpresas.CurrentRow.Cells[7].Value.ToString();
                txtCorreo.Text = dgvCargaEmpresas.CurrentRow.Cells[8].Value.ToString();
                txtWeb.Text = dgvCargaEmpresas.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que deseas eliminar esta Empresa?", "Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {

                    DataTable dt = new DataTable();
                    Empresas oemp = new Empresas();
                    EmpresasBC oempresaBC = new EmpresasBC();
                    oemp.CUIT = txtCUIT.Text;

                    var res = oempresaBC.deleteempresas(oemp);
                    MessageBox.Show("Empresa Eliminada");
                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnBuscartodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnCargar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ciudades Buenos Aires
            DataTable CiudadBsAs = new DataTable();
            CiudadBsAs.Columns.Add("Ciudad");
            DataRow RowLP = CiudadBsAs.NewRow();
            RowLP["Ciudad"] = "La Plata";
            CiudadBsAs.Rows.Add(RowLP);
            DataRow RowMdP = CiudadBsAs.NewRow();
            RowMdP["Ciudad"] = "Mar del Plata";
            CiudadBsAs.Rows.Add(RowMdP);
            DataRow RowBB = CiudadBsAs.NewRow();
            RowBB["Ciudad"] = "Bahía Blanca";
            CiudadBsAs.Rows.Add(RowBB);
            DataRow RowLZ = CiudadBsAs.NewRow();
            RowLZ["Ciudad"] = "Lomas de Zamora";
            CiudadBsAs.Rows.Add(RowLZ);
            DataRow RowQu = CiudadBsAs.NewRow();
            RowQu["Ciudad"] = "Quilmes";
            CiudadBsAs.Rows.Add(RowQu);
            DataRow RowAv = CiudadBsAs.NewRow();
            RowAv["Ciudad"] = "Avellaneda";
            CiudadBsAs.Rows.Add(RowAv);
            DataRow RowLa = CiudadBsAs.NewRow();
            RowLa["Ciudad"] = "Lanús";
            CiudadBsAs.Rows.Add(RowLa);
            DataRow RowSI = CiudadBsAs.NewRow();
            RowSI["Ciudad"] = "San Isidro";
            CiudadBsAs.Rows.Add(RowSI);
            DataRow RowTa = CiudadBsAs.NewRow();
            RowTa["Ciudad"] = "Tandil";
            CiudadBsAs.Rows.Add(RowTa);
            DataRow RowOl = CiudadBsAs.NewRow();
            RowOl["Ciudad"] = "Olavarría";
            CiudadBsAs.Rows.Add(RowOl);
            DataRow RowSNA = CiudadBsAs.NewRow();
            RowSNA["Ciudad"] = "San Nicolás de los Arroyos";
            CiudadBsAs.Rows.Add(RowSNA);
            DataRow RowPe = CiudadBsAs.NewRow();
            RowPe["Ciudad"] = "Pergamino";
            CiudadBsAs.Rows.Add(RowPe);
            DataRow RowMe = CiudadBsAs.NewRow();
            RowMe["Ciudad"] = "Mercedes";
            CiudadBsAs.Rows.Add(RowMe);
            DataRow RowZa = CiudadBsAs.NewRow();
            RowZa["Ciudad"] = "Zarate";
            CiudadBsAs.Rows.Add(RowZa);
            DataRow RowJu = CiudadBsAs.NewRow();
            RowJu["Ciudad"] = "Junín";
            CiudadBsAs.Rows.Add(RowJu);
            DataRow RowNe = CiudadBsAs.NewRow();
            RowNe["Ciudad"] = "Necochea";
            CiudadBsAs.Rows.Add(RowNe);
            DataRow RowAz = CiudadBsAs.NewRow();
            RowAz["Ciudad"] = "Azul";
            CiudadBsAs.Rows.Add(RowAz);
            DataRow RowCam = CiudadBsAs.NewRow();
            RowCam["Ciudad"] = "Campana";
            CiudadBsAs.Rows.Add(RowCam);
            DataRow RowMor = CiudadBsAs.NewRow();
            RowMor["Ciudad"] = "Morón";
            CiudadBsAs.Rows.Add(RowMor);
            DataRow RowItu = CiudadBsAs.NewRow();
            RowItu["Ciudad"] = "Ituzaingó";
            CiudadBsAs.Rows.Add(RowItu);

            //Ciudad Autonoma de Buenos Aires
            DataTable CiudadAutBsAs = new DataTable();
            CiudadAutBsAs.Columns.Add("Ciudad");
            DataRow RowBA = CiudadAutBsAs.NewRow();
            RowBA["Ciudad"] = "Buenos Aires (Ciudad)";
            CiudadAutBsAs.Rows.Add(RowBA);

            //Ciudades Catamarca
            DataTable CiudadCat = new DataTable();
            CiudadCat.Columns.Add("Ciudad");
            DataRow RowSFVC = CiudadCat.NewRow();
            RowSFVC["Ciudad"] = "San Fernando del Valle de Catamarca";
            CiudadCat.Rows.Add(RowSFVC);
            DataRow RowBe = CiudadCat.NewRow();
            RowBe["Ciudad"] = "Belén";
            CiudadCat.Rows.Add(RowBe);
            DataRow RowAnd = CiudadCat.NewRow();
            RowAnd["Ciudad"] = "Andalgalá";
            CiudadCat.Rows.Add(RowAnd);
            DataRow RowSM = CiudadCat.NewRow();
            RowSM["Ciudad"] = "Santa María";
            CiudadCat.Rows.Add(RowSM);
            DataRow RowRec = CiudadCat.NewRow();
            RowRec["Ciudad"] = "Recreo";
            CiudadCat.Rows.Add(RowRec);
            DataRow RowTin = CiudadCat.NewRow();
            RowTin["Ciudad"] = "Tinogasta";
            CiudadCat.Rows.Add(RowTin);
            DataRow RowFME = CiudadCat.NewRow();
            RowFME["Ciudad"] = "Fray Mamerto Esquiú";
            CiudadCat.Rows.Add(RowFME);
            DataRow RowSJo = CiudadCat.NewRow();
            RowSJo["Ciudad"] = "San José";
            CiudadCat.Rows.Add(RowSJo);
            DataRow RowFia = CiudadCat.NewRow();
            RowFia["Ciudad"] = "Fiambalá";
            CiudadCat.Rows.Add(RowFia);
            DataRow RowLPu = CiudadCat.NewRow();
            RowLPu["Ciudad"] = "La Puerta";
            CiudadCat.Rows.Add(RowLPu);

            //Ciudades Chaco
            DataTable CiudadCha = new DataTable();
            CiudadCha.Columns.Add("Ciudad");
            DataRow RowRes = CiudadCha.NewRow();
            RowRes["Ciudad"] = "Resistencia";
            CiudadCha.Rows.Add(RowRes);
            DataRow RowSPe = CiudadCha.NewRow();
            RowSPe["Ciudad"] = "Sáenz Peña";
            CiudadCha.Rows.Add(RowSPe);
            DataRow RowVAn = CiudadCha.NewRow();
            RowVAn["Ciudad"] = "Villa Ángela";
            CiudadCha.Rows.Add(RowVAn);
            DataRow RowBar = CiudadCha.NewRow();
            RowBar["Ciudad"] = "Barranqueras";
            CiudadCha.Rows.Add(RowBar);
            DataRow RowPRZP = CiudadCha.NewRow();
            RowPRZP["Ciudad"] = "Presidencia Roque Sáenz Peña";
            CiudadCha.Rows.Add(RowPRZP);
            DataRow RowCha = CiudadCha.NewRow();
            RowCha["Ciudad"] = "Charata";
            CiudadCha.Rows.Add(RowCha);
            DataRow RowMac = CiudadCha.NewRow();
            RowMac["Ciudad"] = "Machagai";
            CiudadCha.Rows.Add(RowMac);
            DataRow RowJJC = CiudadCha.NewRow();
            RowJJC["Ciudad"] = "Juan José Castelli";
            CiudadCha.Rows.Add(RowJJC);
            DataRow RowFon = CiudadCha.NewRow();
            RowFon["Ciudad"] = "Fontana";
            CiudadCha.Rows.Add(RowFon);
            DataRow RowGPi = CiudadCha.NewRow();
            RowGPi["Ciudad"] = "General Pinedo";
            CiudadCha.Rows.Add(RowGPi);

            // Ciudades Chubut
            DataTable CiudadChu = new DataTable();
            CiudadChu.Columns.Add("Ciudad");
            DataRow RowRaw = CiudadChu.NewRow();
            RowRaw["Ciudad"] = "Rawson";
            CiudadChu.Rows.Add(RowRaw);
            DataRow RowCRi = CiudadChu.NewRow();
            RowCRi["Ciudad"] = "Comodoro Rivadavia";
            CiudadChu.Rows.Add(RowCRi);
            DataRow RowTre = CiudadChu.NewRow();
            RowTre["Ciudad"] = "Trelew";
            CiudadChu.Rows.Add(RowTre);
            DataRow RowPMa = CiudadChu.NewRow();
            RowPMa["Ciudad"] = "Puerto Madryn";
            CiudadChu.Rows.Add(RowPMa);
            DataRow RowEsq = CiudadChu.NewRow();
            RowEsq["Ciudad"] = "Esquel";
            CiudadChu.Rows.Add(RowEsq);
            DataRow RowSar = CiudadChu.NewRow();
            RowSar["Ciudad"] = "Sarmiento";
            CiudadChu.Rows.Add(RowSar);
            DataRow RowGai = CiudadChu.NewRow();
            RowGai["Ciudad"] = "Gaiman";
            CiudadChu.Rows.Add(RowGai);
            DataRow RowDol = CiudadChu.NewRow();
            RowDol["Ciudad"] = "Dolavon";
            CiudadChu.Rows.Add(RowDol);
            DataRow RowLHe = CiudadChu.NewRow();
            RowLHe["Ciudad"] = "Las Heras";
            CiudadChu.Rows.Add(RowLHe);
            DataRow RowCama = CiudadChu.NewRow();
            RowCama["Ciudad"] = "Camarones";
            CiudadChu.Rows.Add(RowCama);

            //Ciudades Córdoba
            DataTable CiudadCor = new DataTable();
            CiudadCor.Columns.Add("Ciudad");
            DataRow RowCor = CiudadCor.NewRow();
            RowCor["Ciudad"] = "Córdoba (Ciudad)";
            CiudadCor.Rows.Add(RowCor);
            DataRow RowVMa = CiudadCor.NewRow();
            RowVMa["Ciudad"] = "Villa María";
            CiudadCor.Rows.Add(RowVMa);
            DataRow RowRCu = CiudadCor.NewRow();
            RowRCu["Ciudad"] = "Río Cuarto";
            CiudadCor.Rows.Add(RowRCu);
            DataRow RowSFr = CiudadCor.NewRow();
            RowSFr["Ciudad"] = "San Francisco";
            CiudadCor.Rows.Add(RowSFr);
            DataRow RowJMa = CiudadCor.NewRow();
            RowJMa["Ciudad"] = "Jesús María";
            CiudadCor.Rows.Add(RowJMa);
            DataRow RowVCP = CiudadCor.NewRow();
            RowVCP["Ciudad"] = "Villa Carlos Paz";
            CiudadCor.Rows.Add(RowVCP);
            DataRow RowAGr = CiudadCor.NewRow();
            RowAGr["Ciudad"] = "Alta Gracia";
            CiudadCor.Rows.Add(RowAGr);
            DataRow RowLCa = CiudadCor.NewRow();
            RowLCa["Ciudad"] = "La Calera";
            CiudadCor.Rows.Add(RowLCa);
            DataRow RowCos = CiudadCor.NewRow();
            RowCos["Ciudad"] = "Cosquín";
            CiudadCor.Rows.Add(RowCos);
            DataRow RowBVi = CiudadCor.NewRow();
            RowBVi["Ciudad"] = "Bell Ville";
            CiudadCor.Rows.Add(RowBVi);

            //Ciudades Corrientes
            DataTable CiudadCorr = new DataTable();
            CiudadCorr.Columns.Add("Ciudad");
            DataRow RowCorr = CiudadCorr.NewRow();
            RowCorr["Ciudad"] = "Corrientes (Ciudad)";
            CiudadCorr.Rows.Add(RowCorr);
            DataRow RowGoy = CiudadCorr.NewRow();
            RowGoy["Ciudad"] = "Goya";
            CiudadCorr.Rows.Add(RowGoy);
            DataRow RowPLi = CiudadCorr.NewRow();
            RowPLi["Ciudad"] = "Paso de los Libres";
            CiudadCorr.Rows.Add(RowPLi);
            DataRow RowMer = CiudadCorr.NewRow();
            RowMer["Ciudad"] = "Mercedes";
            CiudadCorr.Rows.Add(RowMer);
            DataRow RowCCu = CiudadCorr.NewRow();
            RowCCu["Ciudad"] = "Curuzú Cuatiá";
            CiudadCorr.Rows.Add(RowCCu);
            DataRow RowSTo = CiudadCorr.NewRow();
            RowSTo["Ciudad"] = "Santo Tomé";
            CiudadCorr.Rows.Add(RowSTo);
            DataRow RowEsqu = CiudadCorr.NewRow();
            RowEsqu["Ciudad"] = "Esquina";
            CiudadCorr.Rows.Add(RowEsqu);
            DataRow RowBeV = CiudadCorr.NewRow();
            RowBeV["Ciudad"] = "Bella Vista";
            CiudadCorr.Rows.Add(RowBeV);
            DataRow RowItuz = CiudadCorr.NewRow();
            RowItuz["Ciudad"] = "Ituzaingó";
            CiudadCorr.Rows.Add(RowItuz);
            DataRow RowMCa = CiudadCorr.NewRow();
            RowMCa["Ciudad"] = "Monte Caseros";
            CiudadCorr.Rows.Add(RowMCa);

            //Ciudades Entre Ríos
            DataTable CiudadER = new DataTable();
            CiudadER.Columns.Add("Ciudad");
            DataRow RowPar = CiudadER.NewRow();
            RowPar["Ciudad"] = "Paraná";
            CiudadER.Rows.Add(RowPar);
            DataRow RowCon = CiudadER.NewRow();
            RowCon["Ciudad"] = "Concordia";
            CiudadER.Rows.Add(RowCon);
            DataRow RowGua = CiudadER.NewRow();
            RowGua["Ciudad"] = "Gualeguaychú";
            CiudadER.Rows.Add(RowGua);
            DataRow RowCUr = CiudadER.NewRow();
            RowCUr["Ciudad"] = "Concepción del Uruguay";
            CiudadER.Rows.Add(RowCUr);
            DataRow RowVil = CiudadER.NewRow();
            RowVil["Ciudad"] = "Villaguay";
            CiudadER.Rows.Add(RowVil);
            DataRow RowFed = CiudadER.NewRow();
            RowFed["Ciudad"] = "Federación";
            CiudadER.Rows.Add(RowFed);
            DataRow RowChaj = CiudadER.NewRow();
            RowChaj["Ciudad"] = "Chajarí";
            CiudadER.Rows.Add(RowChaj);
            DataRow RowCol = CiudadER.NewRow();
            RowCol["Ciudad"] = "Colón";
            CiudadER.Rows.Add(RowCol);
            DataRow RowGual = CiudadER.NewRow();
            RowGual["Ciudad"] = "Gualeguay";
            CiudadER.Rows.Add(RowGual);
            DataRow RowCre = CiudadER.NewRow();
            RowCre["Ciudad"] = "Crespo";
            CiudadER.Rows.Add(RowCre);

            //Ciudades Formosa
            DataTable CiudadFor = new DataTable();
            CiudadFor.Columns.Add("Ciudad");
            DataRow RowFor = CiudadFor.NewRow();
            RowFor["Ciudad"] = "Formosa (Ciudad)";
            CiudadFor.Rows.Add(RowFor);
            DataRow RowClo = CiudadFor.NewRow();
            RowClo["Ciudad"] = "Clorinda";
            CiudadFor.Rows.Add(RowClo);
            DataRow RowPir = CiudadFor.NewRow();
            RowPir["Ciudad"] = "Pirané";
            CiudadFor.Rows.Add(RowPir);
            DataRow RowLLo = CiudadFor.NewRow();
            RowLLo["Ciudad"] = "Las Lomitas";
            CiudadFor.Rows.Add(RowLLo);
            DataRow RowECo = CiudadFor.NewRow();
            RowECo["Ciudad"] = "El Colorado";
            CiudadFor.Rows.Add(RowECo);
            DataRow RowIJu = CiudadFor.NewRow();
            RowIJu["Ciudad"] = "Ingeniero Juárez";
            CiudadFor.Rows.Add(RowIJu);
            DataRow RowHer = CiudadFor.NewRow();
            RowHer["Ciudad"] = "Herradura";
            CiudadFor.Rows.Add(RowHer);
            DataRow RowLBl = CiudadFor.NewRow();
            RowLBl["Ciudad"] = "Laguna Blanca";
            CiudadFor.Rows.Add(RowLBl);
            DataRow RowPSa = CiudadFor.NewRow();
            RowPSa["Ciudad"] = "Palo Santo";
            CiudadFor.Rows.Add(RowPSa);
            DataRow RowVEs = CiudadFor.NewRow();
            RowVEs["Ciudad"] = "Villa Escolar";
            CiudadFor.Rows.Add(RowVEs);

            //Ciudades de Jujuy
            DataTable CiudadJu = new DataTable();
            CiudadJu.Columns.Add("Ciudad");
            DataRow RowSSJ = CiudadJu.NewRow();
            RowSSJ["Ciudad"] = "San Salvador de Jujuy";
            CiudadJu.Rows.Add(RowSSJ);
            DataRow RowPal = CiudadJu.NewRow();
            RowPal["Ciudad"] = "Palpalá";
            CiudadJu.Rows.Add(RowPal);
            DataRow RowLQu = CiudadJu.NewRow();
            RowLQu["Ciudad"] = "La Quiaca";
            CiudadJu.Rows.Add(RowLQu);
            DataRow RowHum = CiudadJu.NewRow();
            RowHum["Ciudad"] = "Humahuaca";
            CiudadJu.Rows.Add(RowHum);
            DataRow RowSaPe = CiudadJu.NewRow();
            RowSaPe["Ciudad"] = "San Pedro";
            CiudadJu.Rows.Add(RowSaPe);
            DataRow RowLGSM = CiudadJu.NewRow();
            RowLGSM["Ciudad"] = "Libertador General San Martín";
            CiudadJu.Rows.Add(RowLGSM);
            DataRow RowPer = CiudadJu.NewRow();
            RowPer["Ciudad"] = "Perico";
            CiudadJu.Rows.Add(RowPer);
            DataRow RowTil = CiudadJu.NewRow();
            RowTil["Ciudad"] = "Tilcara";
            CiudadJu.Rows.Add(RowTil);
            DataRow RowAPa = CiudadJu.NewRow();
            RowAPa["Ciudad"] = "Abra Pampa";
            CiudadJu.Rows.Add(RowAPa);
            DataRow RowPur = CiudadJu.NewRow();
            RowPur["Ciudad"] = "Purmamarca";
            CiudadJu.Rows.Add(RowPur);

            //Ciudades La Pampa
            DataTable CiudadLPa = new DataTable();
            CiudadLPa.Columns.Add("Ciudad");
            DataRow RowSRo = CiudadLPa.NewRow();
            RowSRo["Ciudad"] = "Santa Rosa";
            CiudadLPa.Rows.Add(RowSRo);
            DataRow RowGePi = CiudadLPa.NewRow();
            RowGePi["Ciudad"] = "General Pico";
            CiudadLPa.Rows.Add(RowGePi);
            DataRow RowToa = CiudadLPa.NewRow();
            RowToa["Ciudad"] = "Toay";
            CiudadLPa.Rows.Add(RowToa);
            DataRow RowECa = CiudadLPa.NewRow();
            RowECa["Ciudad"] = "Eduardo Castex";
            CiudadLPa.Rows.Add(RowECa);
            DataRow RowRea = CiudadLPa.NewRow();
            RowRea["Ciudad"] = "Realicó";
            CiudadLPa.Rows.Add(RowRea);
            DataRow RowGAc = CiudadLPa.NewRow();
            RowGAc["Ciudad"] = "General Acha";
            CiudadLPa.Rows.Add(RowGAc);
            DataRow RowVic = CiudadLPa.NewRow();
            RowVic["Ciudad"] = "Victorica";
            CiudadLPa.Rows.Add(RowVic);
            DataRow RowJAr = CiudadLPa.NewRow();
            RowJAr["Ciudad"] = "Jacinto Arauz";
            CiudadLPa.Rows.Add(RowJAr);
            DataRow RowSIs = CiudadLPa.NewRow();
            RowSIs["Ciudad"] = "Santa Isabel";
            CiudadLPa.Rows.Add(RowSIs);
            DataRow RowQue = CiudadLPa.NewRow();
            RowQue["Ciudad"] = "Quemú Quemú";
            CiudadLPa.Rows.Add(RowQue);

            //Ciudad La Rioja
            DataTable CiudadLRi = new DataTable();
            CiudadLRi.Columns.Add("Ciudad");
            DataRow RowLRi = CiudadLRi.NewRow();
            RowLRi["Ciudad"] = "La Rioja (Ciudad)";
            CiudadLRi.Rows.Add(RowLRi);
            DataRow RowChi = CiudadLRi.NewRow();
            RowChi["Ciudad"] = "Chilecito";
            CiudadLRi.Rows.Add(RowChi);
            DataRow RowAim = CiudadLRi.NewRow();
            RowAim["Ciudad"] = "Aimogasta";
            CiudadLRi.Rows.Add(RowAim);
            DataRow RowCham = CiudadLRi.NewRow();
            RowCham["Ciudad"] = "Chamical";
            CiudadLRi.Rows.Add(RowCham);
            DataRow RowChe = CiudadLRi.NewRow();
            RowChe["Ciudad"] = "Chepes";
            CiudadLRi.Rows.Add(RowChe);
            DataRow RowVUn = CiudadLRi.NewRow();
            RowVUn["Ciudad"] = "Villa Unión";
            CiudadLRi.Rows.Add(RowVUn);
            DataRow RowFar = CiudadLRi.NewRow();
            RowFar["Ciudad"] = "Farmatina";
            CiudadLRi.Rows.Add(RowFar);
            DataRow RowVCa = CiudadLRi.NewRow();
            RowVCa["Ciudad"] = "Villa Castelli";
            CiudadLRi.Rows.Add(RowVCa);
            DataRow RowAni = CiudadLRi.NewRow();
            RowAni["Ciudad"] = "Anillaco";
            CiudadLRi.Rows.Add(RowAni);
            DataRow RowVSR = CiudadLRi.NewRow();
            RowVSR["Ciudad"] = "Villa Santa Rica de Catuna";
            CiudadLRi.Rows.Add(RowVSR);

            //Ciudades de Mendoza
            DataTable CiudadMen = new DataTable();
            CiudadMen.Columns.Add("Ciudad");
            DataRow RowMen = CiudadMen.NewRow();
            RowMen["Ciudad"] = "Mendoza (Ciudad)";
            CiudadMen.Rows.Add(RowMen);
            DataRow RowSRa = CiudadMen.NewRow();
            RowSRa["Ciudad"] = "San Rafael";
            CiudadMen.Rows.Add(RowSRa);
            DataRow RowGCr = CiudadMen.NewRow();
            RowGCr["Ciudad"] = "Godoy Cruz";
            CiudadMen.Rows.Add(RowGCr);
            DataRow RowMai = CiudadMen.NewRow();
            RowMai["Ciudad"] = "Maipú";
            CiudadMen.Rows.Add(RowMai);
            DataRow RowLCu = CiudadMen.NewRow();
            RowLCu["Ciudad"] = "Luján de Cuyo";
            CiudadMen.Rows.Add(RowLCu);
            DataRow RowSMa = CiudadMen.NewRow();
            RowSMa["Ciudad"] = "San Martín";
            CiudadMen.Rows.Add(RowSMa);
            DataRow RowLaHe = CiudadMen.NewRow();
            RowLaHe["Ciudad"] = "Las Heras";
            CiudadMen.Rows.Add(RowLaHe);
            DataRow RowGuay = CiudadMen.NewRow();
            RowGuay["Ciudad"] = "Guaymallén";
            CiudadMen.Rows.Add(RowGuay);
            DataRow RowTun = CiudadMen.NewRow();
            RowTun["Ciudad"] = "Tunuyán";
            CiudadMen.Rows.Add(RowTun);
            DataRow RowMal = CiudadMen.NewRow();
            RowMal["Ciudad"] = "Malargüe";
            CiudadMen.Rows.Add(RowMal);

            //Ciudades de Misiones
            DataTable CiudadMis = new DataTable();
            CiudadMis.Columns.Add("Ciudad");
            DataRow RowPos = CiudadMis.NewRow();
            RowPos["Ciudad"] = "Posadas";
            CiudadMis.Rows.Add(RowPos);
            DataRow RowObe = CiudadMis.NewRow();
            RowObe["Ciudad"] = "Oberá";
            CiudadMis.Rows.Add(RowObe);
            DataRow RowEld = CiudadMis.NewRow();
            RowEld["Ciudad"] = "Eldorado";
            CiudadMis.Rows.Add(RowEld);
            DataRow RowPIg = CiudadMis.NewRow();
            RowPIg["Ciudad"] = "Puerto Iguazú";
            CiudadMis.Rows.Add(RowPIg);
            DataRow RowSVi = CiudadMis.NewRow();
            RowSVi["Ciudad"] = "San Vicente";
            CiudadMis.Rows.Add(RowSVi);
            DataRow RowApo = CiudadMis.NewRow();
            RowApo["Ciudad"] = "Apóstoles";
            CiudadMis.Rows.Add(RowApo);
            DataRow RowMon = CiudadMis.NewRow();
            RowMon["Ciudad"] = "Montecarlo";
            CiudadMis.Rows.Add(RowMon);
            DataRow RowPRi = CiudadMis.NewRow();
            RowPRi["Ciudad"] = "Puerto Rico";
            CiudadMis.Rows.Add(RowPRi);
            DataRow RowAV = CiudadMis.NewRow();
            RowAV["Ciudad"] = "Aristóbulo del Valle";
            CiudadMis.Rows.Add(RowAV);
            DataRow RowWa = CiudadMis.NewRow();
            RowWa["Ciudad"] = "Wanda";
            CiudadMis.Rows.Add(RowWa);


            if (cboProvincia.SelectedIndex == 0)
            {
                cboLocalidad.DataSource = null;
            }
            else if (cboProvincia.SelectedIndex == 1)
            {
                cboLocalidad.DataSource = CiudadBsAs;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 2)
            {
                cboLocalidad.DataSource = CiudadAutBsAs;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 3)
            {
                cboLocalidad.DataSource = CiudadCat;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 4)
            {
                cboLocalidad.DataSource = CiudadCha;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 5)
            {
                cboLocalidad.DataSource = CiudadChu;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 6)
            {
                cboLocalidad.DataSource = CiudadCor;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 7)
            {
                cboLocalidad.DataSource = CiudadCorr;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 8)
            {
                cboLocalidad.DataSource = CiudadER;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 9)
            {
                cboLocalidad.DataSource = CiudadFor;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 10)
            {
                cboLocalidad.DataSource = CiudadJu;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 11)
            {
                cboLocalidad.DataSource = CiudadLPa;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 12)
            {
                cboLocalidad.DataSource = CiudadLRi;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 13)
            {
                cboLocalidad.DataSource = CiudadMen;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 14)
            {
                cboLocalidad.DataSource = CiudadMis;
                cboLocalidad.DisplayMember = "Ciudad";
            }




        }
    }
}