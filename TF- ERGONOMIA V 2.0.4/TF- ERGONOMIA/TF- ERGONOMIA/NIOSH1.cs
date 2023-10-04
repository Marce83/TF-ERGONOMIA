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
using static iTextSharp.text.pdf.events.IndexEvents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class NIOSH1 : Form
    {
        public NIOSH1()
        {
            InitializeComponent();

        }



        private void btncerrarNiosh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NIOSH1_Load(object sender, EventArgs e)
        {

            double variableH = 0;
            double variableMH = 0;


            variableH = (25 / int.Parse(cboH.Text));

            if (variableH >= 1)
            {
                variableMH = 1;
                double resultadoHM = variableH + variableMH;
                txtHM.Text = resultadoHM.ToString();

            }

            else { 
                
                variableMH = 0;
                double resultadoHMb = variableH + variableMH;
                txtHM.Text = resultadoHMb.ToString();
                        
               }


            if (int.Parse(cboV.Text) > 175)
            {
                txtVM.Text = "0";
            }
            else {

                double resultadoVM = 1-0.003*(int.Parse(cboVi.Text) - 75);
                txtVM.Text = resultadoVM.ToString();
            }



            double variableD = int.Parse(cboDi.Text) - int.Parse(cboD.Text);


            if (variableD <= 25)
            {
                txtDMNiosh.Text = "0";
            }
            else
            {

                double resultadoDM = 0.82 + (4.5 / variableD);
                txtDMNiosh.Text = resultadoDM.ToString();
            }

            if (int.Parse(cboA.Text) > 135)
            {
                txtAM.Text = "0";
            }
            else
            {

                double resultadoAM =  1 - (0.0032 * int.Parse(cboV.Text));
                txtAM.Text = resultadoAM.ToString();
            }



            // Tabla de Frencuencias

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia) && frecuencia == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75)
            {
                txtFN.Text = "1";
            }

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia1) && frecuencia1 == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75)
            {
                txtFN.Text = "1";
            }

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia2) && frecuencia2 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75)
            {
                txtFN.Text = "0.95";
            }

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia3) && frecuencia3 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75)
            {
                txtFN.Text = "0.95";
            }

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia4) && frecuencia4 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75)
            {
                txtFN.Text = "0.85";
            }

            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia5) && frecuencia5 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75)
            {
                txtFN.Text = "0.85";
            }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia6) && frecuencia6 == 0.5M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.97"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia7) && frecuencia7 == 0.5M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.97"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia8) && frecuencia8 == 0.5M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.92"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia9) && frecuencia9 == 0.5M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.92"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia10) && frecuencia10 == 0.5M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.81"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia11) && frecuencia11 == 0.5M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.81"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia12) && frecuencia12 == 1 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.94"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia13) && frecuencia13 == 1 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.94"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia14) && frecuencia14 == 1 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.88"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia15) && frecuencia15 == 1 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.88"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia16) && frecuencia16 == 1 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.75"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia17) && frecuencia17 == 1 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.75"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia18) && frecuencia18 == 2 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.91"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia19) && frecuencia19 == 2 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.91"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia20) && frecuencia20 == 2 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.84"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia21) && frecuencia21 == 2 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.84"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia22) && frecuencia22 == 2 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.65"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia23) && frecuencia23 == 2 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.65"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia24) && frecuencia24 == 3 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.88"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia25) && frecuencia25 == 3 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.88"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia26) && frecuencia26 == 3 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.79"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia27) && frecuencia27 == 3 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.79"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia28) && frecuencia28 == 3 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.55"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia29) && frecuencia29 == 3 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.55"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia30) && frecuencia30 == 4 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.84"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia31) && frecuencia31 == 4 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.84"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia32) && frecuencia32 == 4 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.72"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia33) && frecuencia33 == 4 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.72"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia34) && frecuencia34 == 4 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.45"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia35) && frecuencia35 == 4 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.45"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia36) && frecuencia36 == 5 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.8"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia37) && frecuencia37 == 5 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.8"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia38) && frecuencia38 == 5 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.6"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia39) && frecuencia39 == 5 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.6"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia40) && frecuencia40 == 5 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.35"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia41) && frecuencia41 == 5 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.35"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia42) && frecuencia42 == 6 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.75"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia43) && frecuencia43 == 6 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.75"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia44) && frecuencia44 == 6 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.5"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia45) && frecuencia45 == 6 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.5"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia46) && frecuencia46 == 6 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.27"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia47) && frecuencia47 == 6 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.27"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia48) && frecuencia48 == 7 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.7"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia49) && frecuencia49 == 7 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.7"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia50) && frecuencia50 == 7 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.42"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia51) && frecuencia51 == 7 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.42"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia52) && frecuencia52 == 7 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.22"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia53) && frecuencia53 == 7 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.22"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia54) && frecuencia54 == 8 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.6"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia55) && frecuencia55 == 8 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.6"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia56) && frecuencia56 == 8 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.35"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia57) && frecuencia57 == 8 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.35"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia58) && frecuencia58 == 8 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.18"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia59) && frecuencia59 == 8 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.18"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia60) && frecuencia60 == 9 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.52"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia61) && frecuencia61 == 9 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.52"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia62) && frecuencia62 == 9 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.3"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia63) && frecuencia63 == 9 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.3"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia64) && frecuencia64 == 9 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia65) && frecuencia65 == 9 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.15"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia66) && frecuencia66 == 10 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.45"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia67) && frecuencia67 == 10 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.45"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia68) && frecuencia68 == 10 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.26"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia69) && frecuencia69 == 10 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.26"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia70) && frecuencia70 == 10 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia71) && frecuencia71 == 10 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.13"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia72) && frecuencia72 == 11 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.41"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia73) && frecuencia73 == 11 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.41"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia74) && frecuencia74 == 11 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia75) && frecuencia75 == 11 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.23"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia76) && frecuencia76 == 11 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia77) && frecuencia77 == 11 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia78) && frecuencia78 == 12 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.37"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia79) && frecuencia79 == 12 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.37"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia80) && frecuencia80 == 12 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia81) && frecuencia81 == 12 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.21"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia82) && frecuencia82 == 12 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia83) && frecuencia83 == 12 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia84) && frecuencia84 == 13 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia85) && frecuencia85 == 13 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.34"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia86) && frecuencia86 == 13 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia87) && frecuencia87 == 13 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia88) && frecuencia88 == 13 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia89) && frecuencia89 == 13 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia90) && frecuencia90 == 14 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia91) && frecuencia91 == 14 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.31"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia92) && frecuencia92 == 14 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia93) && frecuencia93 == 14 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia94) && frecuencia94 == 14 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia95) && frecuencia95 == 14 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia96) && frecuencia96 == 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia97) && frecuencia97 == 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.28"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia98) && frecuencia98 == 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia99) && frecuencia99 == 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia100) && frecuencia100 == 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia101) && frecuencia101 == 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia102) && frecuencia102 < 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia103) && frecuencia103 < 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia104) && frecuencia104 < 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia105) && frecuencia105 < 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia106) && frecuencia106 < 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia107) && frecuencia107 < 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }

        }


        private void btnGuardarNiosh1_Click(object sender, EventArgs e)
        {

            NioshBC oNioshBC = new NioshBC();
            Niosh oNiosh = new Niosh();

            oNiosh.cargaIdNiosh = int.Parse(txtcargaidniosh.Text);
            oNiosh.LCNiosh = int.Parse(txtLCN.Text);
            oNiosh.HMNiosh = int.Parse(txtHM.Text);
            oNiosh.VMNiosh = int.Parse(txtVM.Text);
            oNiosh.DMNiosh = int.Parse(txtDMNiosh.Text);
            oNiosh.AMNiosh = int.Parse(txtAM.Text);
            oNiosh.FMNiosh = int.Parse(cboFrecuencia.Text);
            oNiosh.CMRNiosh = int.Parse(cboCM.Text);
            oNiosh.Duraciontarea = cboDuraciontarea.Text;  // VER DE PONER UN TEXTBOX CON UN VALOR NUMERO//


            var res = oNioshBC.UpdateNiosh1BC(oNiosh);
            MessageBox.Show("Carga Guardada");




            NIOSHRESULTADO ONIOSHRESULTADO = new NIOSHRESULTADO();
            ONIOSHRESULTADO.Show();

        }






    }
}
