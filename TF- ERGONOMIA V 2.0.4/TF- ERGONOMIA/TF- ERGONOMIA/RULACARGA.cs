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
using TF.BC;
using TF.ENTITIES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TF__ERGONOMIA
{
    public partial class RULACARGA : Form
    {

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        int SumaHE = 0;
        int SumaHB = 0;
        int SumaB = 0;
        int RestaHBaBap = 0;
        int RestaHBap = 0;
        int RestaBaBap = 0;
        int SumaAB = 0;
        int SumaABA = 0;
        int SumaABC = 0;
        int SumaABCD = 0;
        int SumaABMU = 0;
        public RULACARGA()
        {
            InitializeComponent();

            //    materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //    materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //    materialSkinManager.AddFormToManage(this);
            //    materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //    materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RULA2 oRULACARGA2 = new RULA2();
            oRULACARGA2.Show();
            Close();
        }

        public void RULACARGA_Load(object sender, EventArgs e)
        {
            Limpiar();






        }

        public void swhombroelevado_CheckedChanged(object sender, EventArgs e)
        {
            if (swBrazoAbducido.Checked)
            {
                SumaHB = SumaB + 1;
                txtBrazoFinal.Text = SumaHB.ToString();
                if (!unchecked(swHombroElevado.Checked)) // OFF
                {
                    SumaHE = Convert.ToInt32(cboBrazo.SelectedItem) + 1;
                    txtBrazoFinal.Text = SumaHE.ToString();
                }
            }
            else
            {
                if (swHombroElevado.Checked) // ON
                {
                    SumaHE = Convert.ToInt32(cboBrazo.SelectedItem) + 1;
                    txtBrazoFinal.Text = SumaHE.ToString();
                }
                else //OFF
                {
                    txtBrazoFinal.Text = Convert.ToInt32(cboBrazo.SelectedItem).ToString();
                }
            }

        }

        public void swhombroabducido_CheckedChanged(object sender, EventArgs e)
        {
            if (swBrazoAbducido.Checked) // ON
            {
                if (swHombroElevado.Checked) // ON
                {
                    SumaHB = SumaHE + 1;
                    txtBrazoFinal.Text = SumaHB.ToString();
                }
                else
                {
                    if (swBrazoAbducido.Checked)
                    {
                        SumaB = Convert.ToInt32(cboBrazo.SelectedItem) + 1;
                        txtBrazoFinal.Text = SumaB.ToString();
                    }
                    else
                        txtBrazoFinal.Text = SumaHB.ToString();
                }
            }
            else //OFF
            {
                if (swHombroElevado.Checked) // ON
                {
                    //Suma2 = Suma1 + 1;
                    txtBrazoFinal.Text = SumaHE.ToString();
                }
                else
                {
                    txtBrazoFinal.Text = Convert.ToInt32(cboBrazo.SelectedItem).ToString();
                }
            }
        }

        public void swhombroapoyado_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboBrazo.SelectedItem) == 1)
            {
                if (!unchecked(swHombroElevado.Checked))
                {
                    if (!unchecked(swBrazoAbducido.Checked))
                    {
                        txtBrazoFinal.Text = Convert.ToInt32(cboBrazo.SelectedItem).ToString();
                    }
                }
            }

            if (swBrazoAbducido.Checked) // ON
            {
                if (swHombroElevado.Checked) // ON
                {
                    RestaHBaBap = SumaHB - 1;
                    txtBrazoFinal.Text = RestaHBaBap.ToString();
                }
                else
                {
                    RestaBaBap = SumaB - 1;
                    txtBrazoFinal.Text = RestaBaBap.ToString();
                }
            }
            else
            {
                if (swHombroElevado.Checked) // ON
                {
                    RestaHBap = SumaHE - 1;
                    txtBrazoFinal.Text = RestaHBap.ToString();
                }
                else
                {
                    txtBrazoFinal.Text = Convert.ToInt32(cboBrazo.SelectedItem).ToString();
                }
            }
            if (!unchecked(swBrazoApoyado.Checked)) // ON if (!unchecked (swHombroElevado.Checked))
            {
                if (swBrazoAbducido.Checked) // ON
                {
                    if (swHombroElevado.Checked) // ON
                    {
                        txtBrazoFinal.Text = SumaHB.ToString();
                    }
                    else
                    {
                        if (swBrazoAbducido.Checked)
                        {
                            txtBrazoFinal.Text = SumaB.ToString();
                        }
                        else
                            txtBrazoFinal.Text = SumaHB.ToString();
                    }
                }
                else //OFF
                {
                    if (swHombroElevado.Checked) // ON
                    {
                        //Suma2 = Suma1 + 1;
                        txtBrazoFinal.Text = SumaHE.ToString();
                    }
                    else
                    {
                        txtBrazoFinal.Text = Convert.ToInt32(cboBrazo.SelectedItem).ToString();
                    }
                }
            }

        }

        private void cbobrazo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            int Res = cboBrazo.SelectedIndex + 1;
            txtBrazoFinal.Text = Res.ToString();
            swHombroElevado.Checked = false;
            swBrazoAbducido.Checked = false;
            swBrazoApoyado.Checked = false;
            SumaHE = 0;
            SumaHB = 0;
            SumaB = 0;
            RestaHBaBap = 0;
            RestaHBap = 0;
            RestaBaBap = 0;
        }

        private void swdespejadoantebrazo_CheckedChanged(object sender, EventArgs e)
        {
            
                if (swdespejadoantebrazo.Checked) // ON
                {
                    SumaAB = Convert.ToInt32(cboantebrazo1.SelectedItem) + 1;
                    txtantebrazofinal.Text = SumaAB.ToString();

                    if (swcruzaantebrazo.Checked) // ON
                    {
                        SumaABC = SumaAB + 1;
                        txtantebrazofinal.Text = SumaAB.ToString();
                    }
                    else
                    {
                        txtantebrazofinal.Text = Convert.ToInt32(cboantebrazo1.SelectedItem).ToString();
                    }


                }
            else
            {

                txtantebrazofinal.Text = SumaAB.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RULA2 oRULACARGA2 = new RULA2();
            oRULACARGA2.Show();
            Close();
        }

        private void swmunecadesviau_CheckedChanged(object sender, EventArgs e)
        {
            if (swmunecadesviau.Checked) // ON
            {
                SumaABMU = Convert.ToInt32(cbomuneca1.SelectedItem) + 1;
                txtmunecafinal.Text = SumaABMU.ToString();
            }

            else
            {
                txtmunecafinal.Text = Convert.ToInt32(cbomuneca1.SelectedItem).ToString();
            }



        }



    }
}








