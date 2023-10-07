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

            // Puntuación de Brazo
            cboH.Items.Add(new ComboBoxOption("1", 1));
            cboH.Items.Add(new ComboBoxOption("2", 2));
            cboH.Items.Add(new ComboBoxOption("3", 3));
            cboH.Items.Add(new ComboBoxOption("4", 4));
            cboH.Items.Add(new ComboBoxOption("5", 5));
            cboH.Items.Add(new ComboBoxOption("6", 6));
            cboH.Items.Add(new ComboBoxOption("7", 7));
            cboH.Items.Add(new ComboBoxOption("8", 8));
            cboH.Items.Add(new ComboBoxOption("9", 9));
            cboH.Items.Add(new ComboBoxOption("10", 10));
            cboH.Items.Add(new ComboBoxOption("11", 11));
            cboH.Items.Add(new ComboBoxOption("12", 12));
            cboH.Items.Add(new ComboBoxOption("13", 13));
            cboH.Items.Add(new ComboBoxOption("14", 14));
            cboH.Items.Add(new ComboBoxOption("15", 15));
            cboH.Items.Add(new ComboBoxOption("16", 16));
            cboH.Items.Add(new ComboBoxOption("17", 17));
            cboH.Items.Add(new ComboBoxOption("18", 18));
            cboH.Items.Add(new ComboBoxOption("19", 19));
            cboH.Items.Add(new ComboBoxOption("20", 20));
            cboH.Items.Add(new ComboBoxOption("21", 21));
            cboH.Items.Add(new ComboBoxOption("22", 22));
            cboH.Items.Add(new ComboBoxOption("23", 23));
            cboH.Items.Add(new ComboBoxOption("24", 24));
            cboH.Items.Add(new ComboBoxOption("25", 25));
            cboH.Items.Add(new ComboBoxOption("26", 26));
            cboH.Items.Add(new ComboBoxOption("27", 27));
            cboH.Items.Add(new ComboBoxOption("28", 28));
            cboH.Items.Add(new ComboBoxOption("29", 29));
            cboH.Items.Add(new ComboBoxOption("30", 30));
            cboH.Items.Add(new ComboBoxOption("31", 31));
            cboH.Items.Add(new ComboBoxOption("32", 32));
            cboH.Items.Add(new ComboBoxOption("33", 33));
            cboH.Items.Add(new ComboBoxOption("34", 34));
            cboH.Items.Add(new ComboBoxOption("35", 35));
            cboH.Items.Add(new ComboBoxOption("36", 36));
            cboH.Items.Add(new ComboBoxOption("37", 37));
            cboH.Items.Add(new ComboBoxOption("38", 38));
            cboH.Items.Add(new ComboBoxOption("39", 39));
            cboH.Items.Add(new ComboBoxOption("40", 40));
            cboH.Items.Add(new ComboBoxOption("41", 41));
            cboH.Items.Add(new ComboBoxOption("42", 42));
            cboH.Items.Add(new ComboBoxOption("43", 43));
            cboH.Items.Add(new ComboBoxOption("44", 44));
            cboH.Items.Add(new ComboBoxOption("45", 45));
            cboH.Items.Add(new ComboBoxOption("46", 46));
            cboH.Items.Add(new ComboBoxOption("47", 47));
            cboH.Items.Add(new ComboBoxOption("48", 48));
            cboH.Items.Add(new ComboBoxOption("49", 49));
            cboH.Items.Add(new ComboBoxOption("50", 50));
            cboH.Items.Add(new ComboBoxOption("51", 51));
            cboH.Items.Add(new ComboBoxOption("52", 52));
            cboH.Items.Add(new ComboBoxOption("53", 53));
            cboH.Items.Add(new ComboBoxOption("54", 54));
            cboH.Items.Add(new ComboBoxOption("55", 55));
            cboH.Items.Add(new ComboBoxOption("56", 56));
            cboH.Items.Add(new ComboBoxOption("57", 57));
            cboH.Items.Add(new ComboBoxOption("58", 58));
            cboH.Items.Add(new ComboBoxOption("59", 59));
            cboH.Items.Add(new ComboBoxOption("60", 60));
            cboH.Items.Add(new ComboBoxOption("61", 61));
            cboH.Items.Add(new ComboBoxOption("62", 62));
            cboH.Items.Add(new ComboBoxOption("63", 63));
            cboH.Items.Add(new ComboBoxOption("64", 64));
            cboH.Items.Add(new ComboBoxOption("65", 65));
            cboH.Items.Add(new ComboBoxOption("66", 66));
            cboH.Items.Add(new ComboBoxOption("67", 67));
            cboH.Items.Add(new ComboBoxOption("68", 68));
            cboH.Items.Add(new ComboBoxOption("69", 69));
            cboH.Items.Add(new ComboBoxOption("70", 70));
            cboH.Items.Add(new ComboBoxOption("71", 71));
            cboH.Items.Add(new ComboBoxOption("72", 72));
            cboH.Items.Add(new ComboBoxOption("73", 73));
            cboH.Items.Add(new ComboBoxOption("74", 74));
            cboH.Items.Add(new ComboBoxOption("75", 75));
            cboH.Items.Add(new ComboBoxOption("76", 76));
            cboH.Items.Add(new ComboBoxOption("77", 77));
            cboH.Items.Add(new ComboBoxOption("78", 78));
            cboH.Items.Add(new ComboBoxOption("79", 79));
            cboH.Items.Add(new ComboBoxOption("80", 80));
            cboH.Items.Add(new ComboBoxOption("81", 81));
            cboH.Items.Add(new ComboBoxOption("82", 82));
            cboH.Items.Add(new ComboBoxOption("83", 83));
            cboH.Items.Add(new ComboBoxOption("84", 84));
            cboH.Items.Add(new ComboBoxOption("85", 85));
            cboH.Items.Add(new ComboBoxOption("86", 86));
            cboH.Items.Add(new ComboBoxOption("87", 87));
            cboH.Items.Add(new ComboBoxOption("88", 88));
            cboH.Items.Add(new ComboBoxOption("89", 89));
            cboH.Items.Add(new ComboBoxOption("90", 90));
            cboH.Items.Add(new ComboBoxOption("91", 91));
            cboH.Items.Add(new ComboBoxOption("92", 92));
            cboH.Items.Add(new ComboBoxOption("93", 93));
            cboH.Items.Add(new ComboBoxOption("94", 94));
            cboH.Items.Add(new ComboBoxOption("95", 95));
            cboH.Items.Add(new ComboBoxOption("96", 96));
            cboH.Items.Add(new ComboBoxOption("97", 97));
            cboH.Items.Add(new ComboBoxOption("98", 98));
            cboH.Items.Add(new ComboBoxOption("99", 99));
            cboH.Items.Add(new ComboBoxOption("100", 100));
            cboH.Items.Add(new ComboBoxOption("101", 101));
            cboH.Items.Add(new ComboBoxOption("102", 102));
            cboH.Items.Add(new ComboBoxOption("103", 103));
            cboH.Items.Add(new ComboBoxOption("104", 104));
            cboH.Items.Add(new ComboBoxOption("105", 105));
            cboH.Items.Add(new ComboBoxOption("106", 106));
            cboH.Items.Add(new ComboBoxOption("107", 107));
            cboH.Items.Add(new ComboBoxOption("108", 108));
            cboH.Items.Add(new ComboBoxOption("109", 109));
            cboH.Items.Add(new ComboBoxOption("110", 110));
            cboH.Items.Add(new ComboBoxOption("111", 111));
            cboH.Items.Add(new ComboBoxOption("112", 112));
            cboH.Items.Add(new ComboBoxOption("113", 113));
            cboH.Items.Add(new ComboBoxOption("114", 114));
            cboH.Items.Add(new ComboBoxOption("115", 115));
            cboH.Items.Add(new ComboBoxOption("116", 116));
            cboH.Items.Add(new ComboBoxOption("117", 117));
            cboH.Items.Add(new ComboBoxOption("118", 118));
            cboH.Items.Add(new ComboBoxOption("119", 119));
            cboH.Items.Add(new ComboBoxOption("120", 120));
            cboH.Items.Add(new ComboBoxOption("121", 121));
            cboH.Items.Add(new ComboBoxOption("122", 122));
            cboH.Items.Add(new ComboBoxOption("123", 123));
            cboH.Items.Add(new ComboBoxOption("124", 124));
            cboH.Items.Add(new ComboBoxOption("125", 125));
            cboH.Items.Add(new ComboBoxOption("126", 126));
            cboH.Items.Add(new ComboBoxOption("127", 127));
            cboH.Items.Add(new ComboBoxOption("128", 128));
            cboH.Items.Add(new ComboBoxOption("129", 129));
            cboH.Items.Add(new ComboBoxOption("130", 130));
            cboH.Items.Add(new ComboBoxOption("131", 131));
            cboH.Items.Add(new ComboBoxOption("132", 132));
            cboH.Items.Add(new ComboBoxOption("133", 133));
            cboH.Items.Add(new ComboBoxOption("134", 134));
            cboH.Items.Add(new ComboBoxOption("135", 135));
            cboH.Items.Add(new ComboBoxOption("136", 136));
            cboH.Items.Add(new ComboBoxOption("137", 137));
            cboH.Items.Add(new ComboBoxOption("138", 138));
            cboH.Items.Add(new ComboBoxOption("139", 139));
            cboH.Items.Add(new ComboBoxOption("140", 140));
            cboH.Items.Add(new ComboBoxOption("141", 141));
            cboH.Items.Add(new ComboBoxOption("142", 142));
            cboH.Items.Add(new ComboBoxOption("143", 143));
            cboH.Items.Add(new ComboBoxOption("144", 144));
            cboH.Items.Add(new ComboBoxOption("145", 145));
            cboH.Items.Add(new ComboBoxOption("146", 146));
            cboH.Items.Add(new ComboBoxOption("147", 147));
            cboH.Items.Add(new ComboBoxOption("148", 148));
            cboH.Items.Add(new ComboBoxOption("149", 149));
            cboH.Items.Add(new ComboBoxOption("150", 150));
            cboH.Items.Add(new ComboBoxOption("151", 151));
            cboH.Items.Add(new ComboBoxOption("152", 152));
            cboH.Items.Add(new ComboBoxOption("153", 153));
            cboH.Items.Add(new ComboBoxOption("154", 154));
            cboH.Items.Add(new ComboBoxOption("155", 155));
            cboH.Items.Add(new ComboBoxOption("156", 156));
            cboH.Items.Add(new ComboBoxOption("157", 157));
            cboH.Items.Add(new ComboBoxOption("158", 158));
            cboH.Items.Add(new ComboBoxOption("159", 159));
            cboH.Items.Add(new ComboBoxOption("160", 160));
            cboH.Items.Add(new ComboBoxOption("161", 161));
            cboH.Items.Add(new ComboBoxOption("162", 162));
            cboH.Items.Add(new ComboBoxOption("163", 163));
            cboH.Items.Add(new ComboBoxOption("164", 164));
            cboH.Items.Add(new ComboBoxOption("165", 165));
            cboH.Items.Add(new ComboBoxOption("166", 166));
            cboH.Items.Add(new ComboBoxOption("167", 167));
            cboH.Items.Add(new ComboBoxOption("168", 168));
            cboH.Items.Add(new ComboBoxOption("169", 169));
            cboH.Items.Add(new ComboBoxOption("170", 170));
            cboH.Items.Add(new ComboBoxOption("171", 171));
            cboH.Items.Add(new ComboBoxOption("172", 172));
            cboH.Items.Add(new ComboBoxOption("173", 173));
            cboH.Items.Add(new ComboBoxOption("174", 174));
            cboH.Items.Add(new ComboBoxOption("175", 175));



















            cboHi.Items.Add(new ComboBoxOption("1", 1));
            cboHi.Items.Add(new ComboBoxOption("2", 2));
            cboHi.Items.Add(new ComboBoxOption("3", 3));
            cboHi.Items.Add(new ComboBoxOption("4", 4));
            cboHi.Items.Add(new ComboBoxOption("5", 5));
            cboHi.Items.Add(new ComboBoxOption("6", 6));
            cboHi.Items.Add(new ComboBoxOption("7", 7));
            cboHi.Items.Add(new ComboBoxOption("8", 8));
            cboHi.Items.Add(new ComboBoxOption("9", 9));
            cboHi.Items.Add(new ComboBoxOption("10", 10));
            cboHi.Items.Add(new ComboBoxOption("11", 11));
            cboHi.Items.Add(new ComboBoxOption("12", 12));
            cboHi.Items.Add(new ComboBoxOption("13", 13));
            cboHi.Items.Add(new ComboBoxOption("14", 14));
            cboHi.Items.Add(new ComboBoxOption("15", 15));
            cboHi.Items.Add(new ComboBoxOption("16", 16));
            cboHi.Items.Add(new ComboBoxOption("17", 17));
            cboHi.Items.Add(new ComboBoxOption("18", 18));
            cboHi.Items.Add(new ComboBoxOption("19", 19));
            cboHi.Items.Add(new ComboBoxOption("20", 20));
            cboHi.Items.Add(new ComboBoxOption("21", 21));
            cboHi.Items.Add(new ComboBoxOption("22", 22));
            cboHi.Items.Add(new ComboBoxOption("23", 23));
            cboHi.Items.Add(new ComboBoxOption("24", 24));
            cboHi.Items.Add(new ComboBoxOption("25", 25));
            cboHi.Items.Add(new ComboBoxOption("26", 26));
            cboHi.Items.Add(new ComboBoxOption("27", 27));
            cboHi.Items.Add(new ComboBoxOption("28", 28));
            cboHi.Items.Add(new ComboBoxOption("29", 29));
            cboHi.Items.Add(new ComboBoxOption("30", 30));
            cboHi.Items.Add(new ComboBoxOption("31", 31));
            cboHi.Items.Add(new ComboBoxOption("32", 32));
            cboHi.Items.Add(new ComboBoxOption("33", 33));
            cboHi.Items.Add(new ComboBoxOption("34", 34));
            cboHi.Items.Add(new ComboBoxOption("35", 35));
            cboHi.Items.Add(new ComboBoxOption("36", 36));
            cboHi.Items.Add(new ComboBoxOption("37", 37));
            cboHi.Items.Add(new ComboBoxOption("38", 38));
            cboHi.Items.Add(new ComboBoxOption("39", 39));
            cboHi.Items.Add(new ComboBoxOption("40", 40));
            cboHi.Items.Add(new ComboBoxOption("41", 41));
            cboHi.Items.Add(new ComboBoxOption("42", 42));
            cboHi.Items.Add(new ComboBoxOption("43", 43));
            cboHi.Items.Add(new ComboBoxOption("44", 44));
            cboHi.Items.Add(new ComboBoxOption("45", 45));
            cboHi.Items.Add(new ComboBoxOption("46", 46));
            cboHi.Items.Add(new ComboBoxOption("47", 47));
            cboHi.Items.Add(new ComboBoxOption("48", 48));
            cboHi.Items.Add(new ComboBoxOption("49", 49));
            cboHi.Items.Add(new ComboBoxOption("50", 50));
            cboHi.Items.Add(new ComboBoxOption("51", 51));
            cboHi.Items.Add(new ComboBoxOption("52", 52));
            cboHi.Items.Add(new ComboBoxOption("53", 53));
            cboHi.Items.Add(new ComboBoxOption("54", 54));
            cboHi.Items.Add(new ComboBoxOption("55", 55));
            cboHi.Items.Add(new ComboBoxOption("56", 56));
            cboHi.Items.Add(new ComboBoxOption("57", 57));
            cboHi.Items.Add(new ComboBoxOption("58", 58));
            cboHi.Items.Add(new ComboBoxOption("59", 59));
            cboHi.Items.Add(new ComboBoxOption("60", 60));
            cboHi.Items.Add(new ComboBoxOption("61", 61));
            cboHi.Items.Add(new ComboBoxOption("62", 62));
            cboHi.Items.Add(new ComboBoxOption("63", 63));
            cboHi.Items.Add(new ComboBoxOption("64", 64));
            cboHi.Items.Add(new ComboBoxOption("65", 65));
            cboHi.Items.Add(new ComboBoxOption("66", 66));
            cboHi.Items.Add(new ComboBoxOption("67", 67));
            cboHi.Items.Add(new ComboBoxOption("68", 68));
            cboHi.Items.Add(new ComboBoxOption("69", 69));
            cboHi.Items.Add(new ComboBoxOption("70", 70));
            cboHi.Items.Add(new ComboBoxOption("71", 71));
            cboHi.Items.Add(new ComboBoxOption("72", 72));
            cboHi.Items.Add(new ComboBoxOption("73", 73));
            cboHi.Items.Add(new ComboBoxOption("74", 74));
            cboHi.Items.Add(new ComboBoxOption("75", 75));
            cboHi.Items.Add(new ComboBoxOption("76", 76));
            cboHi.Items.Add(new ComboBoxOption("77", 77));
            cboHi.Items.Add(new ComboBoxOption("78", 78));
            cboHi.Items.Add(new ComboBoxOption("79", 79));
            cboHi.Items.Add(new ComboBoxOption("80", 80));
            cboHi.Items.Add(new ComboBoxOption("81", 81));
            cboHi.Items.Add(new ComboBoxOption("82", 82));
            cboHi.Items.Add(new ComboBoxOption("83", 83));
            cboHi.Items.Add(new ComboBoxOption("84", 84));
            cboHi.Items.Add(new ComboBoxOption("85", 85));
            cboHi.Items.Add(new ComboBoxOption("86", 86));
            cboHi.Items.Add(new ComboBoxOption("87", 87));
            cboHi.Items.Add(new ComboBoxOption("88", 88));
            cboHi.Items.Add(new ComboBoxOption("89", 89));
            cboHi.Items.Add(new ComboBoxOption("90", 90));
            cboHi.Items.Add(new ComboBoxOption("91", 91));
            cboHi.Items.Add(new ComboBoxOption("92", 92));
            cboHi.Items.Add(new ComboBoxOption("93", 93));
            cboHi.Items.Add(new ComboBoxOption("94", 94));
            cboHi.Items.Add(new ComboBoxOption("95", 95));
            cboHi.Items.Add(new ComboBoxOption("96", 96));
            cboHi.Items.Add(new ComboBoxOption("97", 97));
            cboHi.Items.Add(new ComboBoxOption("98", 98));
            cboHi.Items.Add(new ComboBoxOption("99", 99));
            cboHi.Items.Add(new ComboBoxOption("100", 100));
            cboHi.Items.Add(new ComboBoxOption("101", 101));
            cboHi.Items.Add(new ComboBoxOption("102", 102));
            cboHi.Items.Add(new ComboBoxOption("103", 103));
            cboHi.Items.Add(new ComboBoxOption("104", 104));
            cboHi.Items.Add(new ComboBoxOption("105", 105));
            cboHi.Items.Add(new ComboBoxOption("106", 106));
            cboHi.Items.Add(new ComboBoxOption("107", 107));
            cboHi.Items.Add(new ComboBoxOption("108", 108));
            cboHi.Items.Add(new ComboBoxOption("109", 109));
            cboHi.Items.Add(new ComboBoxOption("110", 110));
            cboHi.Items.Add(new ComboBoxOption("111", 111));
            cboHi.Items.Add(new ComboBoxOption("112", 112));
            cboHi.Items.Add(new ComboBoxOption("113", 113));
            cboHi.Items.Add(new ComboBoxOption("114", 114));
            cboHi.Items.Add(new ComboBoxOption("115", 115));
            cboHi.Items.Add(new ComboBoxOption("116", 116));
            cboHi.Items.Add(new ComboBoxOption("117", 117));
            cboHi.Items.Add(new ComboBoxOption("118", 118));
            cboHi.Items.Add(new ComboBoxOption("119", 119));
            cboHi.Items.Add(new ComboBoxOption("120", 120));
            cboHi.Items.Add(new ComboBoxOption("121", 121));
            cboHi.Items.Add(new ComboBoxOption("122", 122));
            cboHi.Items.Add(new ComboBoxOption("123", 123));
            cboHi.Items.Add(new ComboBoxOption("124", 124));
            cboHi.Items.Add(new ComboBoxOption("125", 125));
            cboHi.Items.Add(new ComboBoxOption("126", 126));
            cboHi.Items.Add(new ComboBoxOption("127", 127));
            cboHi.Items.Add(new ComboBoxOption("128", 128));
            cboHi.Items.Add(new ComboBoxOption("129", 129));
            cboHi.Items.Add(new ComboBoxOption("130", 130));
            cboHi.Items.Add(new ComboBoxOption("131", 131));
            cboHi.Items.Add(new ComboBoxOption("132", 132));
            cboHi.Items.Add(new ComboBoxOption("133", 133));
            cboHi.Items.Add(new ComboBoxOption("134", 134));
            cboHi.Items.Add(new ComboBoxOption("135", 135));
            cboHi.Items.Add(new ComboBoxOption("136", 136));
            cboHi.Items.Add(new ComboBoxOption("137", 137));
            cboHi.Items.Add(new ComboBoxOption("138", 138));
            cboHi.Items.Add(new ComboBoxOption("139", 139));
            cboHi.Items.Add(new ComboBoxOption("140", 140));
            cboHi.Items.Add(new ComboBoxOption("141", 141));
            cboHi.Items.Add(new ComboBoxOption("142", 142));
            cboHi.Items.Add(new ComboBoxOption("143", 143));
            cboHi.Items.Add(new ComboBoxOption("144", 144));
            cboHi.Items.Add(new ComboBoxOption("145", 145));
            cboHi.Items.Add(new ComboBoxOption("146", 146));
            cboHi.Items.Add(new ComboBoxOption("147", 147));
            cboHi.Items.Add(new ComboBoxOption("148", 148));
            cboHi.Items.Add(new ComboBoxOption("149", 149));
            cboHi.Items.Add(new ComboBoxOption("150", 150));
            cboHi.Items.Add(new ComboBoxOption("151", 151));
            cboHi.Items.Add(new ComboBoxOption("152", 152));
            cboHi.Items.Add(new ComboBoxOption("153", 153));
            cboHi.Items.Add(new ComboBoxOption("154", 154));
            cboHi.Items.Add(new ComboBoxOption("155", 155));
            cboHi.Items.Add(new ComboBoxOption("156", 156));
            cboHi.Items.Add(new ComboBoxOption("157", 157));
            cboHi.Items.Add(new ComboBoxOption("158", 158));
            cboHi.Items.Add(new ComboBoxOption("159", 159));
            cboHi.Items.Add(new ComboBoxOption("160", 160));
            cboHi.Items.Add(new ComboBoxOption("161", 161));
            cboHi.Items.Add(new ComboBoxOption("162", 162));
            cboHi.Items.Add(new ComboBoxOption("163", 163));
            cboHi.Items.Add(new ComboBoxOption("164", 164));
            cboHi.Items.Add(new ComboBoxOption("165", 165));
            cboHi.Items.Add(new ComboBoxOption("166", 166));
            cboHi.Items.Add(new ComboBoxOption("167", 167));
            cboHi.Items.Add(new ComboBoxOption("168", 168));
            cboHi.Items.Add(new ComboBoxOption("169", 169));
            cboHi.Items.Add(new ComboBoxOption("170", 170));
            cboHi.Items.Add(new ComboBoxOption("171", 171));
            cboHi.Items.Add(new ComboBoxOption("172", 172));
            cboHi.Items.Add(new ComboBoxOption("173", 173));
            cboHi.Items.Add(new ComboBoxOption("174", 174));
            cboHi.Items.Add(new ComboBoxOption("175", 175));



















































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
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia) && frecuencia == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75){txtFN.Text = "1";}
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia1) && frecuencia1 == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75){txtFN.Text = "1";}
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia2) && frecuencia2 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75){txtFN.Text = "0.95";}
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia3) && frecuencia3 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75){txtFN.Text = "0.95";}
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia4) && frecuencia4 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75){txtFN.Text = "0.85";}
            if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia5) && frecuencia5 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.85"; }
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
        private void ResultadoH()
        {
            int resultadoh = 25 / ObtenerNumeroSeleccionado(cboH);

            txtHM.Text = resultadoh.ToString();
        }

        private int ObtenerNumeroSeleccionado(MaterialComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                ComboBoxOption selectedOption = comboBox.SelectedItem as ComboBoxOption;

                if (selectedOption != null)
                {
                    return selectedOption.Numero;
                }
            }

            return 0;
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
