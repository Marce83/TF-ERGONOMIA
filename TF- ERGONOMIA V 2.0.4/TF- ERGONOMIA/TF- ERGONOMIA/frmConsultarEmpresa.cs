using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.COMMON.Cache;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmConsultarEmpresa : Form
    {
        public frmConsultarEmpresa()
        {
            InitializeComponent();
        }

        Empresas oemp = new Empresas();

        private void frmConsultarEmpresa_Load(object sender, EventArgs e)
        {
            RolesCargo();
            Listar();
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           if(cboBuscadorDinamico.Text == "CUIT")
            {
                oemp.CUIT = txtBuscador.Text;

                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.ConsultarEmpresas(oemp);

                dgvCargaEmpresas.DataSource = null;
                dgvCargaEmpresas.DataSource = dt;
                //dgvCargaEmpresas.Columns[0].Visible = false;
            }
           else
                if(cboBuscadorDinamico.Text == "Razón Social")
            {
                oemp.Nombre = txtBuscador.Text;
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.ConsultarNombreEmpresa(oemp);

                dgvCargaEmpresas.DataSource = null;
                dgvCargaEmpresas.DataSource = dt;
            }
           if(txtBuscador.Text == String.Empty)
            {
                Listar();
            }

        }

        private void dgvCargaEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCUIT.Text = dgvCargaEmpresas.CurrentRow.Cells[0].Value.ToString();
            //txtCUIT.ReadOnly = true;
            txtNombreEmpresa.Text = dgvCargaEmpresas.CurrentRow.Cells[1].Value.ToString();
            cboCondFiscal.Text = dgvCargaEmpresas.CurrentRow.Cells[2].Value.ToString();
            cboActEmpr.Text = dgvCargaEmpresas.CurrentRow.Cells[3].Value.ToString();
            txtCalle.Text = dgvCargaEmpresas.CurrentRow.Cells[4].Value.ToString();
            cboProvincia.Text = dgvCargaEmpresas.CurrentRow.Cells[5].Value.ToString();
            cboLocalidad.Text = dgvCargaEmpresas.CurrentRow.Cells[6].Value.ToString();
            txtTelefono.Text = dgvCargaEmpresas.CurrentRow.Cells[7].Value.ToString();
            txtCorreo.Text = dgvCargaEmpresas.CurrentRow.Cells[8].Value.ToString();
            txtWeb.Text = dgvCargaEmpresas.CurrentRow.Cells[9].Value.ToString();
            dtpFechaAlta.Text = dgvCargaEmpresas.CurrentRow.Cells[10].Value.ToString();

        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                //btnCargar.Enabled = false;
                btnModificar.Enabled = false;
                btnBaja.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {
                btnBaja.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnBaja.Enabled = false;
            }
        }

        private void Limpiar()
        {
            //txtCUIT.Text = string.Empty;
            //txtCUIT.ReadOnly = false;
            //txtCUIT.Focus();
            txtNombreEmpresa.Text = string.Empty;
            cboCondFiscal.SelectedIndex = 0;
            cboActEmpr.SelectedIndex = 0;
            txtCalle.Text = string.Empty;
            //cboLocalidad.SelectedIndex = 0;
            //cboProvincia.SelectedIndex = 0;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtWeb.Text = string.Empty;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar esta Empresa?", "Realizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    Empresas oemp = new Empresas();
                    oemp.CUIT = dgvCargaEmpresas.CurrentRow.Cells[0].Value.ToString();
                    oemp.Nombre = txtNombreEmpresa.Text;
                    oemp.Condicion_Fiscal = cboCondFiscal.Text;
                    oemp.Actividad_Empresarial = cboActEmpr.Text;
                    oemp.Direccion = txtCalle.Text;
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que deseas eliminar esta Empresa?", "Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {

                    DataTable dt = new DataTable();
                    Empresas oemp = new Empresas();
                    EmpresasBC oempresaBC = new EmpresasBC();
                    oemp.CUIT = dgvCargaEmpresas.CurrentRow.Cells[0].Value.ToString();

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

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Ciudades
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

            //Ciudades de Neuquén
            DataTable CiudadNeu = new DataTable();
            CiudadNeu.Columns.Add("Ciudad");
            DataRow RowNeu = CiudadNeu.NewRow();
            RowNeu["Ciudad"] = "Neuquén (Ciudad)";
            CiudadNeu.Rows.Add(RowNeu);
            DataRow RowCut = CiudadNeu.NewRow();
            RowCut["Ciudad"] = "Cutral Có";
            CiudadNeu.Rows.Add(RowCut);
            DataRow RowZap = CiudadNeu.NewRow();
            RowZap["Ciudad"] = "Zapala";
            CiudadNeu.Rows.Add(RowZap);
            DataRow RowPlo = CiudadNeu.NewRow();
            RowPlo["Ciudad"] = "Plottier";
            CiudadNeu.Rows.Add(RowPlo);
            DataRow RowCen = CiudadNeu.NewRow();
            RowCen["Ciudad"] = "Centenario";
            CiudadNeu.Rows.Add(RowCen);
            DataRow RowJA = CiudadNeu.NewRow();
            RowJA["Ciudad"] = "Junín de los Andes";
            CiudadNeu.Rows.Add(RowJA);
            DataRow RowSMA = CiudadNeu.NewRow();
            RowSMA["Ciudad"] = "San Martín de los Andes";
            CiudadNeu.Rows.Add(RowSMA);
            DataRow RowRS = CiudadNeu.NewRow();
            RowRS["Ciudad"] = "Rincón de los Sauces";
            CiudadNeu.Rows.Add(RowRS);
            DataRow RowVA = CiudadNeu.NewRow();
            RowVA["Ciudad"] = "Villa La Angostura";
            CiudadNeu.Rows.Add(RowVA);
            DataRow RowCM = CiudadNeu.NewRow();
            RowCM["Ciudad"] = "Chos Malal";
            CiudadNeu.Rows.Add(RowCM);

            //Ciudades de Río Negro
            DataTable CiudadRN = new DataTable();
            CiudadRN.Columns.Add("Ciudad");
            DataRow RowVie = CiudadRN.NewRow();
            RowVie["Ciudad"] = "Viedma";
            CiudadRN.Rows.Add(RowVie);
            DataRow RowGR = CiudadRN.NewRow();
            RowGR["Ciudad"] = "General Roca";
            CiudadRN.Rows.Add(RowGR);
            DataRow RowBari = CiudadRN.NewRow();
            RowBari["Ciudad"] = "San Carlos de Bariloche";
            CiudadRN.Rows.Add(RowBari);
            DataRow RowCip = CiudadRN.NewRow();
            RowCip["Ciudad"] = "Cipolletti";
            CiudadRN.Rows.Add(RowCip);
            DataRow RowAl = CiudadRN.NewRow();
            RowAl["Ciudad"] = "Allen";
            CiudadRN.Rows.Add(RowAl);
            DataRow RowRC = CiudadRN.NewRow();
            RowRC["Ciudad"] = "Río Colorado";
            CiudadRN.Rows.Add(RowRC);
            DataRow RowVRe = CiudadRN.NewRow();
            RowVRe["Ciudad"] = "Villa Regina";
            CiudadRN.Rows.Add(RowVRe);
            DataRow RowCho = CiudadRN.NewRow();
            RowCho["Ciudad"] = "Choele Choe";
            CiudadRN.Rows.Add(RowCho);
            DataRow RowLam = CiudadRN.NewRow();
            RowLam["Ciudad"] = "Lamarque";
            CiudadRN.Rows.Add(RowLam);
            DataRow RowSG = CiudadRN.NewRow();
            RowSG["Ciudad"] = "Sierra Grande";
            CiudadRN.Rows.Add(RowSG);

            //Ciudades de Salta
            DataTable CiudadSal = new DataTable();
            CiudadSal.Columns.Add("Ciudad");
            DataRow RowSal = CiudadSal.NewRow();
            RowSal["Ciudad"] = "Salta (Ciudad)";
            CiudadSal.Rows.Add(RowSal);
            DataRow RowEmb = CiudadSal.NewRow();
            RowEmb["Ciudad"] = "Embarcación";
            CiudadSal.Rows.Add(RowEmb);
            DataRow RowTar = CiudadSal.NewRow();
            RowTar["Ciudad"] = "Tartagal";
            CiudadSal.Rows.Add(RowTar);
            DataRow RowOr = CiudadSal.NewRow();
            RowOr["Ciudad"] = "Orán";
            CiudadSal.Rows.Add(RowOr);
            DataRow RowCaf = CiudadSal.NewRow();
            RowCaf["Ciudad"] = "Cafayate";
            CiudadSal.Rows.Add(RowCaf);
            DataRow RowMet = CiudadSal.NewRow();
            RowMet["Ciudad"] = "Metán";
            CiudadSal.Rows.Add(RowMet);
            DataRow RowJVG = CiudadSal.NewRow();
            RowJVG["Ciudad"] = "Joaquín V. González";
            CiudadSal.Rows.Add(RowJVG);
            DataRow RowRF = CiudadSal.NewRow();
            RowRF["Ciudad"] = "Rosario de la Frontera";
            CiudadSal.Rows.Add(RowRF);
            DataRow RowGG = CiudadSal.NewRow();
            RowGG["Ciudad"] = "General Güemes";
            CiudadSal.Rows.Add(RowGG);
            DataRow RowCer = CiudadSal.NewRow();
            RowCer["Ciudad"] = "Cerrillos";
            CiudadSal.Rows.Add(RowCer);

            //Ciudades de San Juan
            DataTable CiudadSJ = new DataTable();
            CiudadSJ.Columns.Add("Ciudad");
            DataRow RowSJ = CiudadSJ.NewRow();
            RowSJ["Ciudad"] = "San Juan (Ciudad)";
            CiudadSJ.Rows.Add(RowSJ);
            DataRow RowRaws = CiudadSJ.NewRow();
            RowRaws["Ciudad"] = "Rawson";
            CiudadSJ.Rows.Add(RowRaws);
            DataRow RowPoc = CiudadSJ.NewRow();
            RowPoc["Ciudad"] = "Pocito";
            CiudadSJ.Rows.Add(RowPoc);
            DataRow RowChim = CiudadSJ.NewRow();
            RowChim["Ciudad"] = "Chimbas";
            CiudadSJ.Rows.Add(RowChim);
            DataRow RowCau = CiudadSJ.NewRow();
            RowCau["Ciudad"] = "Caucete";
            CiudadSJ.Rows.Add(RowCau);
            DataRow RowRiv = CiudadSJ.NewRow();
            RowRiv["Ciudad"] = "Rivadavia";
            CiudadSJ.Rows.Add(RowRiv);
            DataRow RowSJJ = CiudadSJ.NewRow();
            RowSJJ["Ciudad"] = "San José de Jáchal";
            CiudadSJ.Rows.Add(RowSJJ);
            DataRow RowSL = CiudadSJ.NewRow();
            RowSL["Ciudad"] = "Santa Lucía";
            CiudadSJ.Rows.Add(RowSL);
            DataRow RowAlb = CiudadSJ.NewRow();
            RowAlb["Ciudad"] = "Albardón";
            CiudadSJ.Rows.Add(RowAlb);
            DataRow Row9J = CiudadSJ.NewRow();
            Row9J["Ciudad"] = "9 de Julio";
            CiudadSJ.Rows.Add(Row9J);

            //Ciudades de San Luis
            DataTable CiudadSL = new DataTable();
            CiudadSL.Columns.Add("Ciudad");
            DataRow RowSLu = CiudadSL.NewRow();
            RowSLu["Ciudad"] = "San Luis (Ciudad)";
            CiudadSL.Rows.Add(RowSLu);
            DataRow RowVMe = CiudadSL.NewRow();
            RowVMe["Ciudad"] = "Villa Mercedes";
            CiudadSL.Rows.Add(RowVMe);
            DataRow RowMerl = CiudadSL.NewRow();
            RowMerl["Ciudad"] = "Merlo";
            CiudadSL.Rows.Add(RowMerl);
            DataRow RowJK = CiudadSL.NewRow();
            RowJK["Ciudad"] = "Juana Koslay";
            CiudadSL.Rows.Add(RowJK);
            DataRow RowLT = CiudadSL.NewRow();
            RowLT["Ciudad"] = "La Toma";
            CiudadSL.Rows.Add(RowLT);
            DataRow RowConc = CiudadSL.NewRow();
            RowConc["Ciudad"] = "Concarán";
            CiudadSL.Rows.Add(RowConc);
            DataRow RowSRC = CiudadSL.NewRow();
            RowSRC["Ciudad"] = "Santa Rosa del Conlara";
            CiudadSL.Rows.Add(RowSRC);
            DataRow RowLPun = CiudadSL.NewRow();
            RowLPun["Ciudad"] = "La Punta";
            CiudadSL.Rows.Add(RowLPun);
            DataRow RowQui = CiudadSL.NewRow();
            RowQui["Ciudad"] = "Quines";
            CiudadSL.Rows.Add(RowQui);
            DataRow RowTi = CiudadSL.NewRow();
            RowTi["Ciudad"] = "Tilisarao";
            CiudadSL.Rows.Add(RowTi);

            //Ciudades de Santa Cruz
            DataTable CiudadSC = new DataTable();
            CiudadSC.Columns.Add("Ciudad");
            DataRow RowRG = CiudadSC.NewRow();
            RowRG["Ciudad"] = "Río Gallegos";
            CiudadSC.Rows.Add(RowRG);
            DataRow RowCO = CiudadSC.NewRow();
            RowCO["Ciudad"] = "Caleta Olivia";
            CiudadSC.Rows.Add(RowCO);
            DataRow RowRT = CiudadSC.NewRow();
            RowRT["Ciudad"] = "Río Turbio";
            CiudadSC.Rows.Add(RowRT);
            DataRow RowPD = CiudadSC.NewRow();
            RowPD["Ciudad"] = "Puerto Deseado";
            CiudadSC.Rows.Add(RowPD);
            DataRow RowEC = CiudadSC.NewRow();
            RowEC["Ciudad"] = "El Calafate";
            CiudadSC.Rows.Add(RowEC);
            DataRow RowPT = CiudadSC.NewRow();
            RowPT["Ciudad"] = "Pico Truncado";
            CiudadSC.Rows.Add(RowPT);
            DataRow RowLH = CiudadSC.NewRow();
            RowLH["Ciudad"] = "Las Heras";
            CiudadSC.Rows.Add(RowLH);
            DataRow Row28 = CiudadSC.NewRow();
            Row28["Ciudad"] = "28 de Noviembre";
            CiudadSC.Rows.Add(Row28);
            DataRow RowGGr = CiudadSC.NewRow();
            RowGGr["Ciudad"] = "Gobernador Gregores";
            CiudadSC.Rows.Add(RowGGr);
            DataRow RowPM = CiudadSC.NewRow();
            RowPM["Ciudad"] = "Perito Moreno";
            CiudadSC.Rows.Add(RowPM);

            //Ciudades de Santa Fe
            DataTable CiudadSF = new DataTable();
            CiudadSF.Columns.Add("Ciudad");
            DataRow RowSF = CiudadSF.NewRow();
            RowSF["Ciudad"] = "Santa Fe (Ciudad)";
            CiudadSF.Rows.Add(RowSF);
            DataRow RowRo = CiudadSF.NewRow();
            RowRo["Ciudad"] = "Rosario";
            CiudadSF.Rows.Add(RowRo);
            DataRow RowRa = CiudadSF.NewRow();
            RowRa["Ciudad"] = "Rafaela";
            CiudadSF.Rows.Add(RowRa);
            DataRow RowVT = CiudadSF.NewRow();
            RowVT["Ciudad"] = "Venado Tuerto";
            CiudadSF.Rows.Add(RowVT);
            DataRow RowRe = CiudadSF.NewRow();
            RowRe["Ciudad"] = "Reconquista";
            CiudadSF.Rows.Add(RowRe);
            DataRow RowST = CiudadSF.NewRow();
            RowST["Ciudad"] = "Santo Tomé";
            CiudadSF.Rows.Add(RowST);
            DataRow RowGB = CiudadSF.NewRow();
            RowGB["Ciudad"] = "Granadero Baigorria";
            CiudadSF.Rows.Add(RowGB);
            DataRow RowFu = CiudadSF.NewRow();
            RowFu["Ciudad"] = "Funes";
            CiudadSF.Rows.Add(RowFu);
            DataRow RowVGG = CiudadSF.NewRow();
            RowVGG["Ciudad"] = "Villa Gobernador Gálvez";
            CiudadSF.Rows.Add(RowVGG);
            DataRow RowSLo = CiudadSF.NewRow();
            RowSLo["Ciudad"] = "San Lorenzo";
            CiudadSF.Rows.Add(RowSLo);

            //Ciudades de Santiago del Estero
            DataTable CiudadSE = new DataTable();
            CiudadSE.Columns.Add("Ciudad");
            DataRow RowSE = CiudadSE.NewRow();
            RowSE["Ciudad"] = "Santiago del Estero (Ciudad)";
            CiudadSE.Rows.Add(RowSE);
            DataRow RowLB = CiudadSE.NewRow();
            RowLB["Ciudad"] = "La Banda";
            CiudadSE.Rows.Add(RowLB);
            DataRow RowTRH = CiudadSE.NewRow();
            RowTRH["Ciudad"] = "Termas de Río Hondo";
            CiudadSE.Rows.Add(RowTRH);
            DataRow RowAñ = CiudadSE.NewRow();
            RowAñ["Ciudad"] = "Añatuya";
            CiudadSE.Rows.Add(RowAñ);
            DataRow RowFer = CiudadSE.NewRow();
            RowFer["Ciudad"] = "Fernández";
            CiudadSE.Rows.Add(RowFer);
            DataRow RowFr = CiudadSE.NewRow();
            RowFr["Ciudad"] = "Frías";
            CiudadSE.Rows.Add(RowFr);
            DataRow RowSC = CiudadSE.NewRow();
            RowSC["Ciudad"] = "Suncho Corral";
            CiudadSE.Rows.Add(RowSC);
            DataRow RowBa = CiudadSE.NewRow();
            RowBa["Ciudad"] = "Bandera";
            CiudadSE.Rows.Add(RowBa);
            DataRow RowCl = CiudadSE.NewRow();
            RowCl["Ciudad"] = "Clodomira";
            CiudadSE.Rows.Add(RowCl);
            DataRow RowLo = CiudadSE.NewRow();
            RowLo["Ciudad"] = "Loreto";
            CiudadSE.Rows.Add(RowLo);

            //Ciudades de Tierra del Fuego
            DataTable CiudadTF = new DataTable();
            CiudadTF.Columns.Add("Ciudad");
            DataRow RowUs = CiudadTF.NewRow();
            RowUs["Ciudad"] = "Ushuaia";
            CiudadTF.Rows.Add(RowUs);
            DataRow RowRGr = CiudadTF.NewRow();
            RowRGr["Ciudad"] = "Río Grande";
            CiudadTF.Rows.Add(RowRGr);
            DataRow RowTo = CiudadTF.NewRow();
            RowTo["Ciudad"] = "Tolhuin";
            CiudadTF.Rows.Add(RowTo);

            //Ciudades de Tucumán
            DataTable CiudadTu = new DataTable();
            CiudadTu.Columns.Add("Ciudad");
            DataRow RowSMT = CiudadTu.NewRow();
            RowSMT["Ciudad"] = "San Miguel de Tucumán";
            CiudadTu.Rows.Add(RowSMT);
            DataRow RowConce = CiudadTu.NewRow();
            RowConce["Ciudad"] = "Concepción";
            CiudadTu.Rows.Add(RowConce);
            DataRow RowTV = CiudadTu.NewRow();
            RowTV["Ciudad"] = "Tafí Viejo";
            CiudadTu.Rows.Add(RowTV);
            DataRow RowBRS = CiudadTu.NewRow();
            RowBRS["Ciudad"] = "Banda del Río Salí";
            CiudadTu.Rows.Add(RowBRS);
            DataRow RowYB = CiudadTu.NewRow();
            RowYB["Ciudad"] = "Yerba Buena";
            CiudadTu.Rows.Add(RowYB);
            DataRow RowAg = CiudadTu.NewRow();
            RowAg["Ciudad"] = "Aguilares";
            CiudadTu.Rows.Add(RowAg);
            DataRow RowMo = CiudadTu.NewRow();
            RowMo["Ciudad"] = "Monteros";
            CiudadTu.Rows.Add(RowMo);
            DataRow RowFa = CiudadTu.NewRow();
            RowFa["Ciudad"] = "Famaillá";
            CiudadTu.Rows.Add(RowFa);
            DataRow RowLu = CiudadTu.NewRow();
            RowLu["Ciudad"] = "Lules";
            CiudadTu.Rows.Add(RowLu);
            DataRow RowAld = CiudadTu.NewRow();
            RowAld["Ciudad"] = "Alderetes";
            CiudadTu.Rows.Add(RowAld);
            #endregion
            #region Provincias
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
            else if (cboProvincia.SelectedIndex == 15)
            {
                cboLocalidad.DataSource = CiudadNeu;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 16)
            {
                cboLocalidad.DataSource = CiudadRN;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 17)
            {
                cboLocalidad.DataSource = CiudadSal;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 18)
            {
                cboLocalidad.DataSource = CiudadSJ;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 19)
            {
                cboLocalidad.DataSource = CiudadSL;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 20)
            {
                cboLocalidad.DataSource = CiudadSC;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 21)
            {
                cboLocalidad.DataSource = CiudadSF;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 22)
            {
                cboLocalidad.DataSource = CiudadSE;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 23)
            {
                cboLocalidad.DataSource = CiudadTF;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            else if (cboProvincia.SelectedIndex == 24)
            {
                cboLocalidad.DataSource = CiudadTu;
                cboLocalidad.DisplayMember = "Ciudad";
            }
            #endregion
        }
    }
}
