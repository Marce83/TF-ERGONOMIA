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

            // HM DESTINO
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


            //HM INICIAL
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



            //VM DESTINO
            cboV.Items.Add(new ComboBoxOption("1", 1));
            cboV.Items.Add(new ComboBoxOption("2", 2));
            cboV.Items.Add(new ComboBoxOption("3", 3));
            cboV.Items.Add(new ComboBoxOption("4", 4));
            cboV.Items.Add(new ComboBoxOption("5", 5));
            cboV.Items.Add(new ComboBoxOption("6", 6));
            cboV.Items.Add(new ComboBoxOption("7", 7));
            cboV.Items.Add(new ComboBoxOption("8", 8));
            cboV.Items.Add(new ComboBoxOption("9", 9));
            cboV.Items.Add(new ComboBoxOption("10", 10));
            cboV.Items.Add(new ComboBoxOption("11", 11));
            cboV.Items.Add(new ComboBoxOption("12", 12));
            cboV.Items.Add(new ComboBoxOption("13", 13));
            cboV.Items.Add(new ComboBoxOption("14", 14));
            cboV.Items.Add(new ComboBoxOption("15", 15));
            cboV.Items.Add(new ComboBoxOption("16", 16));
            cboV.Items.Add(new ComboBoxOption("17", 17));
            cboV.Items.Add(new ComboBoxOption("18", 18));
            cboV.Items.Add(new ComboBoxOption("19", 19));
            cboV.Items.Add(new ComboBoxOption("20", 20));
            cboV.Items.Add(new ComboBoxOption("21", 21));
            cboV.Items.Add(new ComboBoxOption("22", 22));
            cboV.Items.Add(new ComboBoxOption("23", 23));
            cboV.Items.Add(new ComboBoxOption("24", 24));
            cboV.Items.Add(new ComboBoxOption("25", 25));
            cboV.Items.Add(new ComboBoxOption("26", 26));
            cboV.Items.Add(new ComboBoxOption("27", 27));
            cboV.Items.Add(new ComboBoxOption("28", 28));
            cboV.Items.Add(new ComboBoxOption("29", 29));
            cboV.Items.Add(new ComboBoxOption("30", 30));
            cboV.Items.Add(new ComboBoxOption("31", 31));
            cboV.Items.Add(new ComboBoxOption("32", 32));
            cboV.Items.Add(new ComboBoxOption("33", 33));
            cboV.Items.Add(new ComboBoxOption("34", 34));
            cboV.Items.Add(new ComboBoxOption("35", 35));
            cboV.Items.Add(new ComboBoxOption("36", 36));
            cboV.Items.Add(new ComboBoxOption("37", 37));
            cboV.Items.Add(new ComboBoxOption("38", 38));
            cboV.Items.Add(new ComboBoxOption("39", 39));
            cboV.Items.Add(new ComboBoxOption("40", 40));
            cboV.Items.Add(new ComboBoxOption("41", 41));
            cboV.Items.Add(new ComboBoxOption("42", 42));
            cboV.Items.Add(new ComboBoxOption("43", 43));
            cboV.Items.Add(new ComboBoxOption("44", 44));
            cboV.Items.Add(new ComboBoxOption("45", 45));
            cboV.Items.Add(new ComboBoxOption("46", 46));
            cboV.Items.Add(new ComboBoxOption("47", 47));
            cboV.Items.Add(new ComboBoxOption("48", 48));
            cboV.Items.Add(new ComboBoxOption("49", 49));
            cboV.Items.Add(new ComboBoxOption("50", 50));
            cboV.Items.Add(new ComboBoxOption("51", 51));
            cboV.Items.Add(new ComboBoxOption("52", 52));
            cboV.Items.Add(new ComboBoxOption("53", 53));
            cboV.Items.Add(new ComboBoxOption("54", 54));
            cboV.Items.Add(new ComboBoxOption("55", 55));
            cboV.Items.Add(new ComboBoxOption("56", 56));
            cboV.Items.Add(new ComboBoxOption("57", 57));
            cboV.Items.Add(new ComboBoxOption("58", 58));
            cboV.Items.Add(new ComboBoxOption("59", 59));
            cboV.Items.Add(new ComboBoxOption("60", 60));
            cboV.Items.Add(new ComboBoxOption("61", 61));
            cboV.Items.Add(new ComboBoxOption("62", 62));
            cboV.Items.Add(new ComboBoxOption("63", 63));
            cboV.Items.Add(new ComboBoxOption("64", 64));
            cboV.Items.Add(new ComboBoxOption("65", 65));
            cboV.Items.Add(new ComboBoxOption("66", 66));
            cboV.Items.Add(new ComboBoxOption("67", 67));
            cboV.Items.Add(new ComboBoxOption("68", 68));
            cboV.Items.Add(new ComboBoxOption("69", 69));
            cboV.Items.Add(new ComboBoxOption("70", 70));
            cboV.Items.Add(new ComboBoxOption("71", 71));
            cboV.Items.Add(new ComboBoxOption("72", 72));
            cboV.Items.Add(new ComboBoxOption("73", 73));
            cboV.Items.Add(new ComboBoxOption("74", 74));
            cboV.Items.Add(new ComboBoxOption("75", 75));
            cboV.Items.Add(new ComboBoxOption("76", 76));
            cboV.Items.Add(new ComboBoxOption("77", 77));
            cboV.Items.Add(new ComboBoxOption("78", 78));
            cboV.Items.Add(new ComboBoxOption("79", 79));
            cboV.Items.Add(new ComboBoxOption("80", 80));
            cboV.Items.Add(new ComboBoxOption("81", 81));
            cboV.Items.Add(new ComboBoxOption("82", 82));
            cboV.Items.Add(new ComboBoxOption("83", 83));
            cboV.Items.Add(new ComboBoxOption("84", 84));
            cboV.Items.Add(new ComboBoxOption("85", 85));
            cboV.Items.Add(new ComboBoxOption("86", 86));
            cboV.Items.Add(new ComboBoxOption("87", 87));
            cboV.Items.Add(new ComboBoxOption("88", 88));
            cboV.Items.Add(new ComboBoxOption("89", 89));
            cboV.Items.Add(new ComboBoxOption("90", 90));
            cboV.Items.Add(new ComboBoxOption("91", 91));
            cboV.Items.Add(new ComboBoxOption("92", 92));
            cboV.Items.Add(new ComboBoxOption("93", 93));
            cboV.Items.Add(new ComboBoxOption("94", 94));
            cboV.Items.Add(new ComboBoxOption("95", 95));
            cboV.Items.Add(new ComboBoxOption("96", 96));
            cboV.Items.Add(new ComboBoxOption("97", 97));
            cboV.Items.Add(new ComboBoxOption("98", 98));
            cboV.Items.Add(new ComboBoxOption("99", 99));
            cboV.Items.Add(new ComboBoxOption("100", 100));
            cboV.Items.Add(new ComboBoxOption("101", 101));
            cboV.Items.Add(new ComboBoxOption("102", 102));
            cboV.Items.Add(new ComboBoxOption("103", 103));
            cboV.Items.Add(new ComboBoxOption("104", 104));
            cboV.Items.Add(new ComboBoxOption("105", 105));
            cboV.Items.Add(new ComboBoxOption("106", 106));
            cboV.Items.Add(new ComboBoxOption("107", 107));
            cboV.Items.Add(new ComboBoxOption("108", 108));
            cboV.Items.Add(new ComboBoxOption("109", 109));
            cboV.Items.Add(new ComboBoxOption("110", 110));
            cboV.Items.Add(new ComboBoxOption("111", 111));
            cboV.Items.Add(new ComboBoxOption("112", 112));
            cboV.Items.Add(new ComboBoxOption("113", 113));
            cboV.Items.Add(new ComboBoxOption("114", 114));
            cboV.Items.Add(new ComboBoxOption("115", 115));
            cboV.Items.Add(new ComboBoxOption("116", 116));
            cboV.Items.Add(new ComboBoxOption("117", 117));
            cboV.Items.Add(new ComboBoxOption("118", 118));
            cboV.Items.Add(new ComboBoxOption("119", 119));
            cboV.Items.Add(new ComboBoxOption("120", 120));
            cboV.Items.Add(new ComboBoxOption("121", 121));
            cboV.Items.Add(new ComboBoxOption("122", 122));
            cboV.Items.Add(new ComboBoxOption("123", 123));
            cboV.Items.Add(new ComboBoxOption("124", 124));
            cboV.Items.Add(new ComboBoxOption("125", 125));
            cboV.Items.Add(new ComboBoxOption("126", 126));
            cboV.Items.Add(new ComboBoxOption("127", 127));
            cboV.Items.Add(new ComboBoxOption("128", 128));
            cboV.Items.Add(new ComboBoxOption("129", 129));
            cboV.Items.Add(new ComboBoxOption("130", 130));
            cboV.Items.Add(new ComboBoxOption("131", 131));
            cboV.Items.Add(new ComboBoxOption("132", 132));
            cboV.Items.Add(new ComboBoxOption("133", 133));
            cboV.Items.Add(new ComboBoxOption("134", 134));
            cboV.Items.Add(new ComboBoxOption("135", 135));
            cboV.Items.Add(new ComboBoxOption("136", 136));
            cboV.Items.Add(new ComboBoxOption("137", 137));
            cboV.Items.Add(new ComboBoxOption("138", 138));
            cboV.Items.Add(new ComboBoxOption("139", 139));
            cboV.Items.Add(new ComboBoxOption("140", 140));
            cboV.Items.Add(new ComboBoxOption("141", 141));
            cboV.Items.Add(new ComboBoxOption("142", 142));
            cboV.Items.Add(new ComboBoxOption("143", 143));
            cboV.Items.Add(new ComboBoxOption("144", 144));
            cboV.Items.Add(new ComboBoxOption("145", 145));
            cboV.Items.Add(new ComboBoxOption("146", 146));
            cboV.Items.Add(new ComboBoxOption("147", 147));
            cboV.Items.Add(new ComboBoxOption("148", 148));
            cboV.Items.Add(new ComboBoxOption("149", 149));
            cboV.Items.Add(new ComboBoxOption("150", 150));
            cboV.Items.Add(new ComboBoxOption("151", 151));
            cboV.Items.Add(new ComboBoxOption("152", 152));
            cboV.Items.Add(new ComboBoxOption("153", 153));
            cboV.Items.Add(new ComboBoxOption("154", 154));
            cboV.Items.Add(new ComboBoxOption("155", 155));
            cboV.Items.Add(new ComboBoxOption("156", 156));
            cboV.Items.Add(new ComboBoxOption("157", 157));
            cboV.Items.Add(new ComboBoxOption("158", 158));
            cboV.Items.Add(new ComboBoxOption("159", 159));
            cboV.Items.Add(new ComboBoxOption("160", 160));
            cboV.Items.Add(new ComboBoxOption("161", 161));
            cboV.Items.Add(new ComboBoxOption("162", 162));
            cboV.Items.Add(new ComboBoxOption("163", 163));
            cboV.Items.Add(new ComboBoxOption("164", 164));
            cboV.Items.Add(new ComboBoxOption("165", 165));
            cboV.Items.Add(new ComboBoxOption("166", 166));
            cboV.Items.Add(new ComboBoxOption("167", 167));
            cboV.Items.Add(new ComboBoxOption("168", 168));
            cboV.Items.Add(new ComboBoxOption("169", 169));
            cboV.Items.Add(new ComboBoxOption("170", 170));
            cboV.Items.Add(new ComboBoxOption("171", 171));
            cboV.Items.Add(new ComboBoxOption("172", 172));
            cboV.Items.Add(new ComboBoxOption("173", 173));
            cboV.Items.Add(new ComboBoxOption("174", 174));
            cboV.Items.Add(new ComboBoxOption("175", 175));

            //VM ORIGEN
            cboVi.Items.Add(new ComboBoxOption("1", 1));
            cboVi.Items.Add(new ComboBoxOption("2", 2));
            cboVi.Items.Add(new ComboBoxOption("3", 3));
            cboVi.Items.Add(new ComboBoxOption("4", 4));
            cboVi.Items.Add(new ComboBoxOption("5", 5));
            cboVi.Items.Add(new ComboBoxOption("6", 6));
            cboVi.Items.Add(new ComboBoxOption("7", 7));
            cboVi.Items.Add(new ComboBoxOption("8", 8));
            cboVi.Items.Add(new ComboBoxOption("9", 9));
            cboVi.Items.Add(new ComboBoxOption("10", 10));
            cboVi.Items.Add(new ComboBoxOption("11", 11));
            cboVi.Items.Add(new ComboBoxOption("12", 12));
            cboVi.Items.Add(new ComboBoxOption("13", 13));
            cboVi.Items.Add(new ComboBoxOption("14", 14));
            cboVi.Items.Add(new ComboBoxOption("15", 15));
            cboVi.Items.Add(new ComboBoxOption("16", 16));
            cboVi.Items.Add(new ComboBoxOption("17", 17));
            cboVi.Items.Add(new ComboBoxOption("18", 18));
            cboVi.Items.Add(new ComboBoxOption("19", 19));
            cboVi.Items.Add(new ComboBoxOption("20", 20));
            cboVi.Items.Add(new ComboBoxOption("21", 21));
            cboVi.Items.Add(new ComboBoxOption("22", 22));
            cboVi.Items.Add(new ComboBoxOption("23", 23));
            cboVi.Items.Add(new ComboBoxOption("24", 24));
            cboVi.Items.Add(new ComboBoxOption("25", 25));
            cboVi.Items.Add(new ComboBoxOption("26", 26));
            cboVi.Items.Add(new ComboBoxOption("27", 27));
            cboVi.Items.Add(new ComboBoxOption("28", 28));
            cboVi.Items.Add(new ComboBoxOption("29", 29));
            cboVi.Items.Add(new ComboBoxOption("30", 30));
            cboVi.Items.Add(new ComboBoxOption("31", 31));
            cboVi.Items.Add(new ComboBoxOption("32", 32));
            cboVi.Items.Add(new ComboBoxOption("33", 33));
            cboVi.Items.Add(new ComboBoxOption("34", 34));
            cboVi.Items.Add(new ComboBoxOption("35", 35));
            cboVi.Items.Add(new ComboBoxOption("36", 36));
            cboVi.Items.Add(new ComboBoxOption("37", 37));
            cboVi.Items.Add(new ComboBoxOption("38", 38));
            cboVi.Items.Add(new ComboBoxOption("39", 39));
            cboVi.Items.Add(new ComboBoxOption("40", 40));
            cboVi.Items.Add(new ComboBoxOption("41", 41));
            cboVi.Items.Add(new ComboBoxOption("42", 42));
            cboVi.Items.Add(new ComboBoxOption("43", 43));
            cboVi.Items.Add(new ComboBoxOption("44", 44));
            cboVi.Items.Add(new ComboBoxOption("45", 45));
            cboVi.Items.Add(new ComboBoxOption("46", 46));
            cboVi.Items.Add(new ComboBoxOption("47", 47));
            cboVi.Items.Add(new ComboBoxOption("48", 48));
            cboVi.Items.Add(new ComboBoxOption("49", 49));
            cboVi.Items.Add(new ComboBoxOption("50", 50));
            cboVi.Items.Add(new ComboBoxOption("51", 51));
            cboVi.Items.Add(new ComboBoxOption("52", 52));
            cboVi.Items.Add(new ComboBoxOption("53", 53));
            cboVi.Items.Add(new ComboBoxOption("54", 54));
            cboVi.Items.Add(new ComboBoxOption("55", 55));
            cboVi.Items.Add(new ComboBoxOption("56", 56));
            cboVi.Items.Add(new ComboBoxOption("57", 57));
            cboVi.Items.Add(new ComboBoxOption("58", 58));
            cboVi.Items.Add(new ComboBoxOption("59", 59));
            cboVi.Items.Add(new ComboBoxOption("60", 60));
            cboVi.Items.Add(new ComboBoxOption("61", 61));
            cboVi.Items.Add(new ComboBoxOption("62", 62));
            cboVi.Items.Add(new ComboBoxOption("63", 63));
            cboVi.Items.Add(new ComboBoxOption("64", 64));
            cboVi.Items.Add(new ComboBoxOption("65", 65));
            cboVi.Items.Add(new ComboBoxOption("66", 66));
            cboVi.Items.Add(new ComboBoxOption("67", 67));
            cboVi.Items.Add(new ComboBoxOption("68", 68));
            cboVi.Items.Add(new ComboBoxOption("69", 69));
            cboVi.Items.Add(new ComboBoxOption("70", 70));
            cboVi.Items.Add(new ComboBoxOption("71", 71));
            cboVi.Items.Add(new ComboBoxOption("72", 72));
            cboVi.Items.Add(new ComboBoxOption("73", 73));
            cboVi.Items.Add(new ComboBoxOption("74", 74));
            cboVi.Items.Add(new ComboBoxOption("75", 75));
            cboVi.Items.Add(new ComboBoxOption("76", 76));
            cboVi.Items.Add(new ComboBoxOption("77", 77));
            cboVi.Items.Add(new ComboBoxOption("78", 78));
            cboVi.Items.Add(new ComboBoxOption("79", 79));
            cboVi.Items.Add(new ComboBoxOption("80", 80));
            cboVi.Items.Add(new ComboBoxOption("81", 81));
            cboVi.Items.Add(new ComboBoxOption("82", 82));
            cboVi.Items.Add(new ComboBoxOption("83", 83));
            cboVi.Items.Add(new ComboBoxOption("84", 84));
            cboVi.Items.Add(new ComboBoxOption("85", 85));
            cboVi.Items.Add(new ComboBoxOption("86", 86));
            cboVi.Items.Add(new ComboBoxOption("87", 87));
            cboVi.Items.Add(new ComboBoxOption("88", 88));
            cboVi.Items.Add(new ComboBoxOption("89", 89));
            cboVi.Items.Add(new ComboBoxOption("90", 90));
            cboVi.Items.Add(new ComboBoxOption("91", 91));
            cboVi.Items.Add(new ComboBoxOption("92", 92));
            cboVi.Items.Add(new ComboBoxOption("93", 93));
            cboVi.Items.Add(new ComboBoxOption("94", 94));
            cboVi.Items.Add(new ComboBoxOption("95", 95));
            cboVi.Items.Add(new ComboBoxOption("96", 96));
            cboVi.Items.Add(new ComboBoxOption("97", 97));
            cboVi.Items.Add(new ComboBoxOption("98", 98));
            cboVi.Items.Add(new ComboBoxOption("99", 99));
            cboVi.Items.Add(new ComboBoxOption("100", 100));
            cboVi.Items.Add(new ComboBoxOption("101", 101));
            cboVi.Items.Add(new ComboBoxOption("102", 102));
            cboVi.Items.Add(new ComboBoxOption("103", 103));
            cboVi.Items.Add(new ComboBoxOption("104", 104));
            cboVi.Items.Add(new ComboBoxOption("105", 105));
            cboVi.Items.Add(new ComboBoxOption("106", 106));
            cboVi.Items.Add(new ComboBoxOption("107", 107));
            cboVi.Items.Add(new ComboBoxOption("108", 108));
            cboVi.Items.Add(new ComboBoxOption("109", 109));
            cboVi.Items.Add(new ComboBoxOption("110", 110));
            cboVi.Items.Add(new ComboBoxOption("111", 111));
            cboVi.Items.Add(new ComboBoxOption("112", 112));
            cboVi.Items.Add(new ComboBoxOption("113", 113));
            cboVi.Items.Add(new ComboBoxOption("114", 114));
            cboVi.Items.Add(new ComboBoxOption("115", 115));
            cboVi.Items.Add(new ComboBoxOption("116", 116));
            cboVi.Items.Add(new ComboBoxOption("117", 117));
            cboVi.Items.Add(new ComboBoxOption("118", 118));
            cboVi.Items.Add(new ComboBoxOption("119", 119));
            cboVi.Items.Add(new ComboBoxOption("120", 120));
            cboVi.Items.Add(new ComboBoxOption("121", 121));
            cboVi.Items.Add(new ComboBoxOption("122", 122));
            cboVi.Items.Add(new ComboBoxOption("123", 123));
            cboVi.Items.Add(new ComboBoxOption("124", 124));
            cboVi.Items.Add(new ComboBoxOption("125", 125));
            cboVi.Items.Add(new ComboBoxOption("126", 126));
            cboVi.Items.Add(new ComboBoxOption("127", 127));
            cboVi.Items.Add(new ComboBoxOption("128", 128));
            cboVi.Items.Add(new ComboBoxOption("129", 129));
            cboVi.Items.Add(new ComboBoxOption("130", 130));
            cboVi.Items.Add(new ComboBoxOption("131", 131));
            cboVi.Items.Add(new ComboBoxOption("132", 132));
            cboVi.Items.Add(new ComboBoxOption("133", 133));
            cboVi.Items.Add(new ComboBoxOption("134", 134));
            cboVi.Items.Add(new ComboBoxOption("135", 135));
            cboVi.Items.Add(new ComboBoxOption("136", 136));
            cboVi.Items.Add(new ComboBoxOption("137", 137));
            cboVi.Items.Add(new ComboBoxOption("138", 138));
            cboVi.Items.Add(new ComboBoxOption("139", 139));
            cboVi.Items.Add(new ComboBoxOption("140", 140));
            cboVi.Items.Add(new ComboBoxOption("141", 141));
            cboVi.Items.Add(new ComboBoxOption("142", 142));
            cboVi.Items.Add(new ComboBoxOption("143", 143));
            cboVi.Items.Add(new ComboBoxOption("144", 144));
            cboVi.Items.Add(new ComboBoxOption("145", 145));
            cboVi.Items.Add(new ComboBoxOption("146", 146));
            cboVi.Items.Add(new ComboBoxOption("147", 147));
            cboVi.Items.Add(new ComboBoxOption("148", 148));
            cboVi.Items.Add(new ComboBoxOption("149", 149));
            cboVi.Items.Add(new ComboBoxOption("150", 150));
            cboVi.Items.Add(new ComboBoxOption("151", 151));
            cboVi.Items.Add(new ComboBoxOption("152", 152));
            cboVi.Items.Add(new ComboBoxOption("153", 153));
            cboVi.Items.Add(new ComboBoxOption("154", 154));
            cboVi.Items.Add(new ComboBoxOption("155", 155));
            cboVi.Items.Add(new ComboBoxOption("156", 156));
            cboVi.Items.Add(new ComboBoxOption("157", 157));
            cboVi.Items.Add(new ComboBoxOption("158", 158));
            cboVi.Items.Add(new ComboBoxOption("159", 159));
            cboVi.Items.Add(new ComboBoxOption("160", 160));
            cboVi.Items.Add(new ComboBoxOption("161", 161));
            cboVi.Items.Add(new ComboBoxOption("162", 162));
            cboVi.Items.Add(new ComboBoxOption("163", 163));
            cboVi.Items.Add(new ComboBoxOption("164", 164));
            cboVi.Items.Add(new ComboBoxOption("165", 165));
            cboVi.Items.Add(new ComboBoxOption("166", 166));
            cboVi.Items.Add(new ComboBoxOption("167", 167));
            cboVi.Items.Add(new ComboBoxOption("168", 168));
            cboVi.Items.Add(new ComboBoxOption("169", 169));
            cboVi.Items.Add(new ComboBoxOption("170", 170));
            cboVi.Items.Add(new ComboBoxOption("171", 171));
            cboVi.Items.Add(new ComboBoxOption("172", 172));
            cboVi.Items.Add(new ComboBoxOption("173", 173));
            cboVi.Items.Add(new ComboBoxOption("174", 174));
            cboVi.Items.Add(new ComboBoxOption("175", 175));


            //AM DESTINO -- ANGULO DE ASIMETRIA //
            cboA.Items.Add(new ComboBoxOption("1", 1));
            cboA.Items.Add(new ComboBoxOption("2", 2));
            cboA.Items.Add(new ComboBoxOption("3", 3));
            cboA.Items.Add(new ComboBoxOption("4", 4));
            cboA.Items.Add(new ComboBoxOption("5", 5));
            cboA.Items.Add(new ComboBoxOption("6", 6));
            cboA.Items.Add(new ComboBoxOption("7", 7));
            cboA.Items.Add(new ComboBoxOption("8", 8));
            cboA.Items.Add(new ComboBoxOption("9", 9));
            cboA.Items.Add(new ComboBoxOption("10", 10));
            cboA.Items.Add(new ComboBoxOption("11", 11));
            cboA.Items.Add(new ComboBoxOption("12", 12));
            cboA.Items.Add(new ComboBoxOption("13", 13));
            cboA.Items.Add(new ComboBoxOption("14", 14));
            cboA.Items.Add(new ComboBoxOption("15", 15));
            cboA.Items.Add(new ComboBoxOption("16", 16));
            cboA.Items.Add(new ComboBoxOption("17", 17));
            cboA.Items.Add(new ComboBoxOption("18", 18));
            cboA.Items.Add(new ComboBoxOption("19", 19));
            cboA.Items.Add(new ComboBoxOption("20", 20));
            cboA.Items.Add(new ComboBoxOption("21", 21));
            cboA.Items.Add(new ComboBoxOption("22", 22));
            cboA.Items.Add(new ComboBoxOption("23", 23));
            cboA.Items.Add(new ComboBoxOption("24", 24));
            cboA.Items.Add(new ComboBoxOption("25", 25));
            cboA.Items.Add(new ComboBoxOption("26", 26));
            cboA.Items.Add(new ComboBoxOption("27", 27));
            cboA.Items.Add(new ComboBoxOption("28", 28));
            cboA.Items.Add(new ComboBoxOption("29", 29));
            cboA.Items.Add(new ComboBoxOption("30", 30));
            cboA.Items.Add(new ComboBoxOption("31", 31));
            cboA.Items.Add(new ComboBoxOption("32", 32));
            cboA.Items.Add(new ComboBoxOption("33", 33));
            cboA.Items.Add(new ComboBoxOption("34", 34));
            cboA.Items.Add(new ComboBoxOption("35", 35));
            cboA.Items.Add(new ComboBoxOption("36", 36));
            cboA.Items.Add(new ComboBoxOption("37", 37));
            cboA.Items.Add(new ComboBoxOption("38", 38));
            cboA.Items.Add(new ComboBoxOption("39", 39));
            cboA.Items.Add(new ComboBoxOption("40", 40));
            cboA.Items.Add(new ComboBoxOption("41", 41));
            cboA.Items.Add(new ComboBoxOption("42", 42));
            cboA.Items.Add(new ComboBoxOption("43", 43));
            cboA.Items.Add(new ComboBoxOption("44", 44));
            cboA.Items.Add(new ComboBoxOption("45", 45));
            cboA.Items.Add(new ComboBoxOption("46", 46));
            cboA.Items.Add(new ComboBoxOption("47", 47));
            cboA.Items.Add(new ComboBoxOption("48", 48));
            cboA.Items.Add(new ComboBoxOption("49", 49));
            cboA.Items.Add(new ComboBoxOption("50", 50));
            cboA.Items.Add(new ComboBoxOption("51", 51));
            cboA.Items.Add(new ComboBoxOption("52", 52));
            cboA.Items.Add(new ComboBoxOption("53", 53));
            cboA.Items.Add(new ComboBoxOption("54", 54));
            cboA.Items.Add(new ComboBoxOption("55", 55));
            cboA.Items.Add(new ComboBoxOption("56", 56));
            cboA.Items.Add(new ComboBoxOption("57", 57));
            cboA.Items.Add(new ComboBoxOption("58", 58));
            cboA.Items.Add(new ComboBoxOption("59", 59));
            cboA.Items.Add(new ComboBoxOption("60", 60));
            cboA.Items.Add(new ComboBoxOption("61", 61));
            cboA.Items.Add(new ComboBoxOption("62", 62));
            cboA.Items.Add(new ComboBoxOption("63", 63));
            cboA.Items.Add(new ComboBoxOption("64", 64));
            cboA.Items.Add(new ComboBoxOption("65", 65));
            cboA.Items.Add(new ComboBoxOption("66", 66));
            cboA.Items.Add(new ComboBoxOption("67", 67));
            cboA.Items.Add(new ComboBoxOption("68", 68));
            cboA.Items.Add(new ComboBoxOption("69", 69));
            cboA.Items.Add(new ComboBoxOption("70", 70));
            cboA.Items.Add(new ComboBoxOption("71", 71));
            cboA.Items.Add(new ComboBoxOption("72", 72));
            cboA.Items.Add(new ComboBoxOption("73", 73));
            cboA.Items.Add(new ComboBoxOption("74", 74));
            cboA.Items.Add(new ComboBoxOption("75", 75));
            cboA.Items.Add(new ComboBoxOption("76", 76));
            cboA.Items.Add(new ComboBoxOption("77", 77));
            cboA.Items.Add(new ComboBoxOption("78", 78));
            cboA.Items.Add(new ComboBoxOption("79", 79));
            cboA.Items.Add(new ComboBoxOption("80", 80));
            cboA.Items.Add(new ComboBoxOption("81", 81));
            cboA.Items.Add(new ComboBoxOption("82", 82));
            cboA.Items.Add(new ComboBoxOption("83", 83));
            cboA.Items.Add(new ComboBoxOption("84", 84));
            cboA.Items.Add(new ComboBoxOption("85", 85));
            cboA.Items.Add(new ComboBoxOption("86", 86));
            cboA.Items.Add(new ComboBoxOption("87", 87));
            cboA.Items.Add(new ComboBoxOption("88", 88));
            cboA.Items.Add(new ComboBoxOption("89", 89));
            cboA.Items.Add(new ComboBoxOption("90", 90));
            cboA.Items.Add(new ComboBoxOption("91", 91));
            cboA.Items.Add(new ComboBoxOption("92", 92));
            cboA.Items.Add(new ComboBoxOption("93", 93));
            cboA.Items.Add(new ComboBoxOption("94", 94));
            cboA.Items.Add(new ComboBoxOption("95", 95));
            cboA.Items.Add(new ComboBoxOption("96", 96));
            cboA.Items.Add(new ComboBoxOption("97", 97));
            cboA.Items.Add(new ComboBoxOption("98", 98));
            cboA.Items.Add(new ComboBoxOption("99", 99));
            cboA.Items.Add(new ComboBoxOption("100", 100));
            cboA.Items.Add(new ComboBoxOption("101", 101));
            cboA.Items.Add(new ComboBoxOption("102", 102));
            cboA.Items.Add(new ComboBoxOption("103", 103));
            cboA.Items.Add(new ComboBoxOption("104", 104));
            cboA.Items.Add(new ComboBoxOption("105", 105));
            cboA.Items.Add(new ComboBoxOption("106", 106));
            cboA.Items.Add(new ComboBoxOption("107", 107));
            cboA.Items.Add(new ComboBoxOption("108", 108));
            cboA.Items.Add(new ComboBoxOption("109", 109));
            cboA.Items.Add(new ComboBoxOption("110", 110));
            cboA.Items.Add(new ComboBoxOption("111", 111));
            cboA.Items.Add(new ComboBoxOption("112", 112));
            cboA.Items.Add(new ComboBoxOption("113", 113));
            cboA.Items.Add(new ComboBoxOption("114", 114));
            cboA.Items.Add(new ComboBoxOption("115", 115));
            cboA.Items.Add(new ComboBoxOption("116", 116));
            cboA.Items.Add(new ComboBoxOption("117", 117));
            cboA.Items.Add(new ComboBoxOption("118", 118));
            cboA.Items.Add(new ComboBoxOption("119", 119));
            cboA.Items.Add(new ComboBoxOption("120", 120));
            cboA.Items.Add(new ComboBoxOption("121", 121));
            cboA.Items.Add(new ComboBoxOption("122", 122));
            cboA.Items.Add(new ComboBoxOption("123", 123));
            cboA.Items.Add(new ComboBoxOption("124", 124));
            cboA.Items.Add(new ComboBoxOption("125", 125));
            cboA.Items.Add(new ComboBoxOption("126", 126));
            cboA.Items.Add(new ComboBoxOption("127", 127));
            cboA.Items.Add(new ComboBoxOption("128", 128));
            cboA.Items.Add(new ComboBoxOption("129", 129));
            cboA.Items.Add(new ComboBoxOption("130", 130));
            cboA.Items.Add(new ComboBoxOption("131", 131));
            cboA.Items.Add(new ComboBoxOption("132", 132));
            cboA.Items.Add(new ComboBoxOption("133", 133));
            cboA.Items.Add(new ComboBoxOption("134", 134));
            cboA.Items.Add(new ComboBoxOption("135", 135));

            //AM ORIGEN -- ANGULO DE ASIMETRIA //
            cboAi.Items.Add(new ComboBoxOption("1", 1));
            cboAi.Items.Add(new ComboBoxOption("2", 2));
            cboAi.Items.Add(new ComboBoxOption("3", 3));
            cboAi.Items.Add(new ComboBoxOption("4", 4));
            cboAi.Items.Add(new ComboBoxOption("5", 5));
            cboAi.Items.Add(new ComboBoxOption("6", 6));
            cboAi.Items.Add(new ComboBoxOption("7", 7));
            cboAi.Items.Add(new ComboBoxOption("8", 8));
            cboAi.Items.Add(new ComboBoxOption("9", 9));
            cboAi.Items.Add(new ComboBoxOption("10", 10));
            cboAi.Items.Add(new ComboBoxOption("11", 11));
            cboAi.Items.Add(new ComboBoxOption("12", 12));
            cboAi.Items.Add(new ComboBoxOption("13", 13));
            cboAi.Items.Add(new ComboBoxOption("14", 14));
            cboAi.Items.Add(new ComboBoxOption("15", 15));
            cboAi.Items.Add(new ComboBoxOption("16", 16));
            cboAi.Items.Add(new ComboBoxOption("17", 17));
            cboAi.Items.Add(new ComboBoxOption("18", 18));
            cboAi.Items.Add(new ComboBoxOption("19", 19));
            cboAi.Items.Add(new ComboBoxOption("20", 20));
            cboAi.Items.Add(new ComboBoxOption("21", 21));
            cboAi.Items.Add(new ComboBoxOption("22", 22));
            cboAi.Items.Add(new ComboBoxOption("23", 23));
            cboAi.Items.Add(new ComboBoxOption("24", 24));
            cboAi.Items.Add(new ComboBoxOption("25", 25));
            cboAi.Items.Add(new ComboBoxOption("26", 26));
            cboAi.Items.Add(new ComboBoxOption("27", 27));
            cboAi.Items.Add(new ComboBoxOption("28", 28));
            cboAi.Items.Add(new ComboBoxOption("29", 29));
            cboAi.Items.Add(new ComboBoxOption("30", 30));
            cboAi.Items.Add(new ComboBoxOption("31", 31));
            cboAi.Items.Add(new ComboBoxOption("32", 32));
            cboAi.Items.Add(new ComboBoxOption("33", 33));
            cboAi.Items.Add(new ComboBoxOption("34", 34));
            cboAi.Items.Add(new ComboBoxOption("35", 35));
            cboAi.Items.Add(new ComboBoxOption("36", 36));
            cboAi.Items.Add(new ComboBoxOption("37", 37));
            cboAi.Items.Add(new ComboBoxOption("38", 38));
            cboAi.Items.Add(new ComboBoxOption("39", 39));
            cboAi.Items.Add(new ComboBoxOption("40", 40));
            cboAi.Items.Add(new ComboBoxOption("41", 41));
            cboAi.Items.Add(new ComboBoxOption("42", 42));
            cboAi.Items.Add(new ComboBoxOption("43", 43));
            cboAi.Items.Add(new ComboBoxOption("44", 44));
            cboAi.Items.Add(new ComboBoxOption("45", 45));
            cboAi.Items.Add(new ComboBoxOption("46", 46));
            cboAi.Items.Add(new ComboBoxOption("47", 47));
            cboAi.Items.Add(new ComboBoxOption("48", 48));
            cboAi.Items.Add(new ComboBoxOption("49", 49));
            cboAi.Items.Add(new ComboBoxOption("50", 50));
            cboAi.Items.Add(new ComboBoxOption("51", 51));
            cboAi.Items.Add(new ComboBoxOption("52", 52));
            cboAi.Items.Add(new ComboBoxOption("53", 53));
            cboAi.Items.Add(new ComboBoxOption("54", 54));
            cboAi.Items.Add(new ComboBoxOption("55", 55));
            cboAi.Items.Add(new ComboBoxOption("56", 56));
            cboAi.Items.Add(new ComboBoxOption("57", 57));
            cboAi.Items.Add(new ComboBoxOption("58", 58));
            cboAi.Items.Add(new ComboBoxOption("59", 59));
            cboAi.Items.Add(new ComboBoxOption("60", 60));
            cboAi.Items.Add(new ComboBoxOption("61", 61));
            cboAi.Items.Add(new ComboBoxOption("62", 62));
            cboAi.Items.Add(new ComboBoxOption("63", 63));
            cboAi.Items.Add(new ComboBoxOption("64", 64));
            cboAi.Items.Add(new ComboBoxOption("65", 65));
            cboAi.Items.Add(new ComboBoxOption("66", 66));
            cboAi.Items.Add(new ComboBoxOption("67", 67));
            cboAi.Items.Add(new ComboBoxOption("68", 68));
            cboAi.Items.Add(new ComboBoxOption("69", 69));
            cboAi.Items.Add(new ComboBoxOption("70", 70));
            cboAi.Items.Add(new ComboBoxOption("71", 71));
            cboAi.Items.Add(new ComboBoxOption("72", 72));
            cboAi.Items.Add(new ComboBoxOption("73", 73));
            cboAi.Items.Add(new ComboBoxOption("74", 74));
            cboAi.Items.Add(new ComboBoxOption("75", 75));
            cboAi.Items.Add(new ComboBoxOption("76", 76));
            cboAi.Items.Add(new ComboBoxOption("77", 77));
            cboAi.Items.Add(new ComboBoxOption("78", 78));
            cboAi.Items.Add(new ComboBoxOption("79", 79));
            cboAi.Items.Add(new ComboBoxOption("80", 80));
            cboAi.Items.Add(new ComboBoxOption("81", 81));
            cboAi.Items.Add(new ComboBoxOption("82", 82));
            cboAi.Items.Add(new ComboBoxOption("83", 83));
            cboAi.Items.Add(new ComboBoxOption("84", 84));
            cboAi.Items.Add(new ComboBoxOption("85", 85));
            cboAi.Items.Add(new ComboBoxOption("86", 86));
            cboAi.Items.Add(new ComboBoxOption("87", 87));
            cboAi.Items.Add(new ComboBoxOption("88", 88));
            cboAi.Items.Add(new ComboBoxOption("89", 89));
            cboAi.Items.Add(new ComboBoxOption("90", 90));
            cboAi.Items.Add(new ComboBoxOption("91", 91));
            cboAi.Items.Add(new ComboBoxOption("92", 92));
            cboAi.Items.Add(new ComboBoxOption("93", 93));
            cboAi.Items.Add(new ComboBoxOption("94", 94));
            cboAi.Items.Add(new ComboBoxOption("95", 95));
            cboAi.Items.Add(new ComboBoxOption("96", 96));
            cboAi.Items.Add(new ComboBoxOption("97", 97));
            cboAi.Items.Add(new ComboBoxOption("98", 98));
            cboAi.Items.Add(new ComboBoxOption("99", 99));
            cboAi.Items.Add(new ComboBoxOption("100", 100));
            cboAi.Items.Add(new ComboBoxOption("101", 101));
            cboAi.Items.Add(new ComboBoxOption("102", 102));
            cboAi.Items.Add(new ComboBoxOption("103", 103));
            cboAi.Items.Add(new ComboBoxOption("104", 104));
            cboAi.Items.Add(new ComboBoxOption("105", 105));
            cboAi.Items.Add(new ComboBoxOption("106", 106));
            cboAi.Items.Add(new ComboBoxOption("107", 107));
            cboAi.Items.Add(new ComboBoxOption("108", 108));
            cboAi.Items.Add(new ComboBoxOption("109", 109));
            cboAi.Items.Add(new ComboBoxOption("110", 110));
            cboAi.Items.Add(new ComboBoxOption("111", 111));
            cboAi.Items.Add(new ComboBoxOption("112", 112));
            cboAi.Items.Add(new ComboBoxOption("113", 113));
            cboAi.Items.Add(new ComboBoxOption("114", 114));
            cboAi.Items.Add(new ComboBoxOption("115", 115));
            cboAi.Items.Add(new ComboBoxOption("116", 116));
            cboAi.Items.Add(new ComboBoxOption("117", 117));
            cboAi.Items.Add(new ComboBoxOption("118", 118));
            cboAi.Items.Add(new ComboBoxOption("119", 119));
            cboAi.Items.Add(new ComboBoxOption("120", 120));
            cboAi.Items.Add(new ComboBoxOption("121", 121));
            cboAi.Items.Add(new ComboBoxOption("122", 122));
            cboAi.Items.Add(new ComboBoxOption("123", 123));
            cboAi.Items.Add(new ComboBoxOption("124", 124));
            cboAi.Items.Add(new ComboBoxOption("125", 125));
            cboAi.Items.Add(new ComboBoxOption("126", 126));
            cboAi.Items.Add(new ComboBoxOption("127", 127));
            cboAi.Items.Add(new ComboBoxOption("128", 128));
            cboAi.Items.Add(new ComboBoxOption("129", 129));
            cboAi.Items.Add(new ComboBoxOption("130", 130));
            cboAi.Items.Add(new ComboBoxOption("131", 131));
            cboAi.Items.Add(new ComboBoxOption("132", 132));
            cboAi.Items.Add(new ComboBoxOption("133", 133));
            cboAi.Items.Add(new ComboBoxOption("134", 134));
            cboAi.Items.Add(new ComboBoxOption("135", 135));




            //------------------------------

            double variableDd = 0;
            double resultadoDMd = 0;

            variableDd = ObtenerNumeroSeleccionado(cboVi) - ObtenerNumeroSeleccionado(cboV);
            resultadoDMd = 0.82 + 4.5 / variableDd;

            txtDMNiosh.Text = resultadoDMd.ToString();


            //----------------------

            double resultadoAM = 0;

            resultadoAM = 1 - (0.0032 * (ObtenerNumeroSeleccionado(cboV)));
            txtAM.Text = resultadoAM.ToString();






            //// Tabla de Frencuencias
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia) && frecuencia == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75){txtFN.Text = "1";}
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia1) && frecuencia1 == 0.2M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75){txtFN.Text = "1";}
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia2) && frecuencia2 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75){txtFN.Text = "0.95";}
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia3) && frecuencia3 == 0.2M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75){txtFN.Text = "0.95";}
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia4) && frecuencia4 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75){txtFN.Text = "0.85";}
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia5) && frecuencia5 == 0.2M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.85"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia6) && frecuencia6 == 0.5M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.97"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia7) && frecuencia7 == 0.5M && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.97"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia8) && frecuencia8 == 0.5M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.92"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia9) && frecuencia9 == 0.5M && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.92"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia10) && frecuencia10 == 0.5M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.81"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia11) && frecuencia11 == 0.5M && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.81"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia12) && frecuencia12 == 1 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.94"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia13) && frecuencia13 == 1 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.94"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia14) && frecuencia14 == 1 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.88"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia15) && frecuencia15 == 1 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.88"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia16) && frecuencia16 == 1 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.75"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia17) && frecuencia17 == 1 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.75"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia18) && frecuencia18 == 2 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.91"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia19) && frecuencia19 == 2 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.91"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia20) && frecuencia20 == 2 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.84"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia21) && frecuencia21 == 2 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.84"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia22) && frecuencia22 == 2 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.65"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia23) && frecuencia23 == 2 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.65"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia24) && frecuencia24 == 3 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.88"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia25) && frecuencia25 == 3 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.88"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia26) && frecuencia26 == 3 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.79"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia27) && frecuencia27 == 3 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.79"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia28) && frecuencia28 == 3 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.55"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia29) && frecuencia29 == 3 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.55"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia30) && frecuencia30 == 4 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.84"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia31) && frecuencia31 == 4 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.84"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia32) && frecuencia32 == 4 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.72"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia33) && frecuencia33 == 4 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.72"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia34) && frecuencia34 == 4 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.45"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia35) && frecuencia35 == 4 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.45"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia36) && frecuencia36 == 5 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.8"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia37) && frecuencia37 == 5 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.8"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia38) && frecuencia38 == 5 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.6"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia39) && frecuencia39 == 5 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.6"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia40) && frecuencia40 == 5 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.35"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia41) && frecuencia41 == 5 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.35"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia42) && frecuencia42 == 6 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.75"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia43) && frecuencia43 == 6 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.75"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia44) && frecuencia44 == 6 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.5"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia45) && frecuencia45 == 6 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.5"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia46) && frecuencia46 == 6 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.27"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia47) && frecuencia47 == 6 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.27"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia48) && frecuencia48 == 7 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.7"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia49) && frecuencia49 == 7 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.7"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia50) && frecuencia50 == 7 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.42"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia51) && frecuencia51 == 7 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.42"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia52) && frecuencia52 == 7 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.22"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia53) && frecuencia53 == 7 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.22"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia54) && frecuencia54 == 8 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.6"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia55) && frecuencia55 == 8 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.6"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia56) && frecuencia56 == 8 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.35"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia57) && frecuencia57 == 8 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.35"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia58) && frecuencia58 == 8 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.18"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia59) && frecuencia59 == 8 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.18"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia60) && frecuencia60 == 9 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.52"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia61) && frecuencia61 == 9 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.52"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia62) && frecuencia62 == 9 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.3"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia63) && frecuencia63 == 9 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.3"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia64) && frecuencia64 == 9 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia65) && frecuencia65 == 9 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.15"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia66) && frecuencia66 == 10 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.45"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia67) && frecuencia67 == 10 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.45"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia68) && frecuencia68 == 10 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.26"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia69) && frecuencia69 == 10 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.26"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia70) && frecuencia70 == 10 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia71) && frecuencia71 == 10 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.13"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia72) && frecuencia72 == 11 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.41"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia73) && frecuencia73 == 11 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.41"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia74) && frecuencia74 == 11 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia75) && frecuencia75 == 11 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.23"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia76) && frecuencia76 == 11 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia77) && frecuencia77 == 11 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia78) && frecuencia78 == 12 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0.37"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia79) && frecuencia79 == 12 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.37"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia80) && frecuencia80 == 12 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia81) && frecuencia81 == 12 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.21"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia82) && frecuencia82 == 12 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia83) && frecuencia83 == 12 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia84) && frecuencia84 == 13 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia85) && frecuencia85 == 13 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.34"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia86) && frecuencia86 == 13 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia87) && frecuencia87 == 13 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia88) && frecuencia88 == 13 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia89) && frecuencia89 == 13 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia90) && frecuencia90 == 14 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia91) && frecuencia91 == 14 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.31"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia92) && frecuencia92 == 14 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia93) && frecuencia93 == 14 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia94) && frecuencia94 == 14 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia95) && frecuencia95 == 14 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia96) && frecuencia96 == 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia97) && frecuencia97 == 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0.28"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia98) && frecuencia98 == 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia99) && frecuencia99 == 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia100) && frecuencia100 == 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia101) && frecuencia101 == 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia102) && frecuencia102 < 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia103) && frecuencia103 < 15 && cboDuraciontarea.Text == "Menos 1 Hora" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia104) && frecuencia104 < 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia105) && frecuencia105 < 15 && cboDuraciontarea.Text == "Entre 1 y 2 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia106) && frecuencia106 < 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) < 75) { txtFN.Text = "0"; }
            //  if (decimal.TryParse(cboFrecuencia.Text, out decimal frecuencia107) && frecuencia107 < 15 && cboDuraciontarea.Text == "Entre 2 y 8 Horas" && int.Parse(cboD.Text) >= 75) { txtFN.Text = "0"; }

        }
        private void cboHresultado()
        {
            double alahm = ObtenerNumeroSeleccionado(cboH);
            double resultadoh = 0;
            double resultadoHM1 = 0;
            double resultadoHM2 = 0;
            double resultadoHM3 = 0;

            resultadoh = (25/alahm);

            if (resultadoh > 1)
            {
                resultadoHM1 = 1;
            }
            else resultadoHM1 = 0;

            if (resultadoh < 1 && resultadoh >= 0.3968254)
             {
                resultadoHM2 = resultadoh;
            }
            else resultadoHM2 = 0;


            resultadoHM3 = resultadoHM1 + resultadoHM2;


            txtHM.Text = resultadoHM3.ToString();
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

        private void cboH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHresultado();
        }

        private void cboHi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboHiresultado();
        }

        private void cboHiresultado()
        {
            double alahmi = ObtenerNumeroSeleccionado(cboHi);
            double resultadohi = 0;
            double resultadoHMi1 = 0;
            double resultadoHMi2 = 0;
            double resultadoHMi3 = 0;

            resultadohi = (25 / alahmi);

            if (resultadohi > 1)
            {
                resultadoHMi1 = 1;
            }
            else resultadoHMi1 = 0;

            if (resultadohi < 1 && resultadohi >= 0.3968254)
            {
                resultadoHMi2 = resultadohi;
            }
            else resultadoHMi2 = 0;


            resultadoHMi3 = resultadoHMi1 + resultadoHMi2;

    
        }


        private void cboV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboVresultado();
        }

        private void cboVresultado()
        {

            double VMD1 = ObtenerNumeroSeleccionado(cboV);

            double resultadoVMdestino1 = 0;

            resultadoVMdestino1 = 1 -(-1*(0.0032 * (ObtenerNumeroSeleccionado(cboV) - 75)));
 
            txtVM.Text = resultadoVMdestino1.ToString();

        }


        private void cboVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboViresultado();
        }

        private void cboViresultado()
        {
            double VMI1 = ObtenerNumeroSeleccionado(cboVi);

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
