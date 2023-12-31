using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            //----------------------

            double resultadoAM = 0;

            int Asimetriadestino = ObtenerNumeroSeleccionado(cboA);

            resultadoAM = 1 - (0.0032 * Asimetriadestino);
            txtAM.Text = resultadoAM.ToString();

            // formato de FN y posteriores

            cboDuraciontarea.Items.Add(new ComboBoxOption("Corta", 1));
            cboDuraciontarea.Items.Add(new ComboBoxOption("Media", 2));
            cboDuraciontarea.Items.Add(new ComboBoxOption("Larga", 3));

            cboFrecuencia.Items.Add(new ComboBoxOption("0.2", 1));
            cboFrecuencia.Items.Add(new ComboBoxOption("0.5", 2));
            cboFrecuencia.Items.Add(new ComboBoxOption("1", 3));
            cboFrecuencia.Items.Add(new ComboBoxOption("2", 4));
            cboFrecuencia.Items.Add(new ComboBoxOption("3", 5));
            cboFrecuencia.Items.Add(new ComboBoxOption("4", 6));
            cboFrecuencia.Items.Add(new ComboBoxOption("5", 7));
            cboFrecuencia.Items.Add(new ComboBoxOption("6", 8));
            cboFrecuencia.Items.Add(new ComboBoxOption("7", 9));
            cboFrecuencia.Items.Add(new ComboBoxOption("8", 10));
            cboFrecuencia.Items.Add(new ComboBoxOption("9", 11));
            cboFrecuencia.Items.Add(new ComboBoxOption("10", 12));
            cboFrecuencia.Items.Add(new ComboBoxOption("11", 13));
            cboFrecuencia.Items.Add(new ComboBoxOption("12", 14));
            cboFrecuencia.Items.Add(new ComboBoxOption("13", 15));
            cboFrecuencia.Items.Add(new ComboBoxOption("14", 16));
            cboFrecuencia.Items.Add(new ComboBoxOption("15", 17));
            cboFrecuencia.Items.Add(new ComboBoxOption("<15", 18));


            cboCM.Items.Add(new ComboBoxOption("Malo", 1));
            cboCM.Items.Add(new ComboBoxOption("Bueno", 2));
            cboCM.Items.Add(new ComboBoxOption("Bien", 3));

            cboCMi.Items.Add(new ComboBoxOption("Malo", 1));
            cboCMi.Items.Add(new ComboBoxOption("Bueno", 2));
            cboCMi.Items.Add(new ComboBoxOption("Bien", 3));



            //AM ORIGEN -- ANGULO DE ASIMETRIA //
            txtLCN.Items.Add(new ComboBoxOption("1", 1));
            txtLCN.Items.Add(new ComboBoxOption("2", 2));
            txtLCN.Items.Add(new ComboBoxOption("3", 3));
            txtLCN.Items.Add(new ComboBoxOption("4", 4));
            txtLCN.Items.Add(new ComboBoxOption("5", 5));
            txtLCN.Items.Add(new ComboBoxOption("6", 6));
            txtLCN.Items.Add(new ComboBoxOption("7", 7));
            txtLCN.Items.Add(new ComboBoxOption("8", 8));
            txtLCN.Items.Add(new ComboBoxOption("9", 9));
            txtLCN.Items.Add(new ComboBoxOption("10", 10));
            txtLCN.Items.Add(new ComboBoxOption("11", 11));
            txtLCN.Items.Add(new ComboBoxOption("12", 12));
            txtLCN.Items.Add(new ComboBoxOption("13", 13));
            txtLCN.Items.Add(new ComboBoxOption("14", 14));
            txtLCN.Items.Add(new ComboBoxOption("15", 15));
            txtLCN.Items.Add(new ComboBoxOption("16", 16));
            txtLCN.Items.Add(new ComboBoxOption("17", 17));
            txtLCN.Items.Add(new ComboBoxOption("18", 18));
            txtLCN.Items.Add(new ComboBoxOption("19", 19));
            txtLCN.Items.Add(new ComboBoxOption("20", 20));


            ObtenerMaximoIdNIOSH();


        }
        private void cboHresultado()
        {
            double alahm = ObtenerNumeroSeleccionado(cboH);
            double resultadoh = 0;
            double resultadoHM1 = 0;
            double resultadoHM2 = 0;
            double resultadoHM3 = 0;

            resultadoh = (25/alahm);

            if (resultadoh >= 1)
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


            txtHMD.Text = resultadoHM3.ToString();
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

            txtHMiI.Text = resultadoHMi3.ToString();
        }

        private void cboV_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboVresultado();
        }

        private void cboVresultado()
        {

            double VMD1 = ObtenerNumeroSeleccionado(cboV);

            double VMI2 = ObtenerNumeroSeleccionado(cboVi);

            double resultadoVMdestino1 = 0;

            resultadoVMdestino1 = 1 - (0.0032 * Math.Abs(ObtenerNumeroSeleccionado(cboV) - 75));
 
            txtVM.Text = resultadoVMdestino1.ToString();


            double variableDd = 0;
            double resultadoDMd = 0;

            variableDd = Math.Abs(VMI2 - VMD1);
            resultadoDMd = 0.82 + (4.5 / variableDd);

            if (Math.Abs(VMI2 - VMD1) < 25)
            {
                txtDMNiosh.Text = "1";
            }
            else txtDMNiosh.Text = resultadoDMd.ToString();


            
            if (ObtenerNumeroSeleccionado(cboV) < 75)
            {
                difvertd.Text = "1";
            }
            else difvertd.Text = "2";


        }

        private void cboVi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboViresultado();
        }

        private void cboViresultado()
        {
            double VMI2 = ObtenerNumeroSeleccionado(cboVi);


            double resultadoVMorigen1 = 0;

            resultadoVMorigen1 = 1 - (0.0032 * (Math.Abs(VMI2 - 75)));

            txtVMi.Text = resultadoVMorigen1.ToString();


            if (VMI2 < 75)
            {
                difvertint.Text = "1";
            }
            else difvertint.Text = "2";


        }

        private void btnGuardarNiosh1_Click(object sender, EventArgs e)
        {


            try
            {
                NioshBC oNioshBC = new NioshBC();
                Niosh oNiosh = new Niosh();

                oNiosh.cargaIdNiosh = int.Parse(txtcargaidniosh.Text);
                oNiosh.HMNioshD = double.Parse(txtHMD.Text);
                oNiosh.HMNioshI = double.Parse(txtHMiI.Text);
                oNiosh.VMNioshD = double.Parse(txtVM.Text);
                oNiosh.VMNioshI = double.Parse(txtVMi.Text);
                oNiosh.DMNioshD = double.Parse(txtDMNiosh.Text);
                oNiosh.AMNioshD = double.Parse(txtAM.Text);
                oNiosh.AMNioshI = double.Parse(txtAMi.Text);
                oNiosh.CMRNioshD = double.Parse(txtCMD.Text);
                oNiosh.CMRNioshI = double.Parse(txtCMI.Text);
                oNiosh.Duraciontarea = int.Parse(txtduracion.Text);
                oNiosh.CalidadAgarreD = int.Parse(txtCMD.Text);
                oNiosh.CalidadAgarreI = int.Parse(txtCMI.Text);
                oNiosh.LCNiosh = int.Parse(txtLCN.Text);
                oNiosh.FrecuenciaNiosh = int.Parse(txtfrecuencia.Text);
                oNiosh.DistanciaVerticalD = int.Parse(difvertd.Text);
                oNiosh.DistanciaVerticali = int.Parse(difvertint.Text);
                oNiosh.FMNioshDnumero = double.Parse(txtFND.Text);
                oNiosh.FMNioshInumero = double.Parse(txtFNI.Text);
                oNiosh.CMRNioshDnumero = double.Parse(txtCMDnumero.Text);
                oNiosh.CMRNioshInumero = double.Parse(txtCMInumero.Text);

                var res = oNioshBC.UpdateNiosh1BC(oNiosh);
                MessageBox.Show("Formulario de Carga guardado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique que tenga todas la Informacion Cargada");
            }

            NIOSHRESULTADO ONIOSHRESULTADO = new NIOSHRESULTADO();
            ONIOSHRESULTADO.Show();
            Close();

        }


        private void cboA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAresultado();
        }

        private void cboAresultado()
        {
            double Asimetriadestino = ObtenerNumeroSeleccionado(cboA);



            double resultadoAM = 0;

            resultadoAM = 1 - (0.0032 * Asimetriadestino);
            txtAM.Text = resultadoAM.ToString();


        }


        private void cboAi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboAiresultado();
        }

        private void cboAiresultado()
        {
            double Asimetriainicial = ObtenerNumeroSeleccionado(cboAi);

            double resultadoAMi = 0;

            resultadoAMi = 1 - (0.0032 * Asimetriainicial);
            txtAMi.Text = resultadoAMi.ToString();


        }


        // Resultado para la Busqueda en la Tabla



        private void cboDuraciontarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDuraciontarearesultado();
        }

        private void cboDuraciontarearesultado()
        {
            int cboDuraciontarea1 = ObtenerNumeroSeleccionado(cboDuraciontarea);

            txtduracion.Text = cboDuraciontarea1.ToString();


        }


        private void cboFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboFrecuenciarearesultado();
        }

        private void cboFrecuenciarearesultado()
        {
            int cboFrecuencia1 = ObtenerNumeroSeleccionado(cboFrecuencia);

            txtfrecuencia.Text = cboFrecuencia1.ToString();

        }


        private void cboCM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCMresultado();
        }

        private void cboCMresultado()
        {
            int cboCM1 = ObtenerNumeroSeleccionado(cboCM);

            txtCMD.Text = cboCM1.ToString();

        }

        private void cboCMi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCMiresultado();
        }

        private void cboCMiresultado()
        {
            int cboCMi1 = ObtenerNumeroSeleccionado(cboCMi);

            txtCMI.Text = cboCMi1.ToString();

        }

        public void ObtenerMaximoIdNIOSH()
        {
            NioshBC oNioshBC = new NioshBC();
            Niosh oNiosh = new Niosh();
            DataTable dt = oNioshBC.NioshMaxIDBC(oNiosh);

            if (dt.Rows.Count > 0)
            {
                int maxId = Convert.ToInt32(dt.Rows[0]["cargaIdNiosh"]);
                txtcargaidniosh.Text = maxId.ToString();
            }

        }

        public void NioshTablaADestino()
        {
            Niosh oNiosh = new Niosh();
            oNiosh.FrecuenciaFM = int.Parse(txtfrecuencia.Text);
            oNiosh.DuracionFM = int.Parse(txtduracion.Text);
            oNiosh.DistanciaVerticalFM = int.Parse(difvertd.Text);

            NioshBC oNioshBC = new NioshBC();
            DataTable dt77 = oNioshBC.NioshTablaADestinoBC(oNiosh);

            if (dt77.Rows.Count > 0)
            {
                string resultadoValorFND = dt77.Rows[0][0].ToString();
                txtFND.Text = resultadoValorFND.ToString();
            }

        }

        public void NioshTablaAINICIAL()
        {
            Niosh oNiosh = new Niosh();
            oNiosh.FrecuenciaFMi = int.Parse(txtfrecuencia.Text);
            oNiosh.DuracionFMi = int.Parse(txtduracion.Text);
            oNiosh.DistanciaVerticalFMi = int.Parse(difvertint.Text);

            NioshBC oNioshBC = new NioshBC();
            DataTable dt78 = oNioshBC.NioshTablaAInicialBC(oNiosh);

            if (dt78.Rows.Count > 0)
            {
                string resultadoVALORFNi = dt78.Rows[0][0].ToString();
                txtFNI.Text = resultadoVALORFNi.ToString();
            }

        }


        public void NioshTablaCMDestino()
        {
            Niosh oNiosh = new Niosh();
            oNiosh.CalidadAgarreD = int.Parse(txtCMD.Text);
            oNiosh.DistanciaVerticalFM = int.Parse(difvertd.Text);

            NioshBC oNioshBC = new NioshBC();
            DataTable dt101 = oNioshBC.NioshTablaCMDestinoBC(oNiosh);

            if (dt101.Rows.Count > 0)
            {
                string resultadoValorCMD = dt101.Rows[0][0].ToString();
                txtCMDnumero.Text = resultadoValorCMD.ToString();
            }

        }

        public void NioshTablaCMINICIAL()
        {
            Niosh oNiosh = new Niosh();
            oNiosh.CalidadAgarreI = int.Parse(txtCMI.Text);
            oNiosh.DistanciaVerticalFMi = int.Parse(difvertint.Text);

            NioshBC oNioshBC = new NioshBC();
            DataTable dt102 = oNioshBC.NioshTablaCMnicialBC(oNiosh);

            if (dt102.Rows.Count > 0)
            {
                string resultadoVALORCMi = dt102.Rows[0][0].ToString();
                txtCMInumero.Text = resultadoVALORCMi.ToString();
            }

        }

        private void btnObtenerFN_Click(object sender, EventArgs e)
        {
 
            NioshTablaADestino();

            NioshTablaAINICIAL();

            NioshTablaCMDestino();

            NioshTablaCMINICIAL();

            try
            {
                NioshBC oNioshBC = new NioshBC();
                Niosh oNiosh = new Niosh();

                oNiosh.cargaIdNiosh = int.Parse(txtcargaidniosh.Text);
                oNiosh.HMNioshD = double.Parse(txtHMD.Text);
                oNiosh.HMNioshI = double.Parse(txtHMiI.Text);
                oNiosh.VMNioshD = double.Parse(txtVM.Text);
                oNiosh.VMNioshI = double.Parse(txtVMi.Text);
                oNiosh.DMNioshD = double.Parse(txtDMNiosh.Text);
                oNiosh.AMNioshD = double.Parse(txtAM.Text);
                oNiosh.AMNioshI = double.Parse(txtAMi.Text);
                oNiosh.CMRNioshD = double.Parse(txtCMD.Text);
                oNiosh.CMRNioshI = double.Parse(txtCMI.Text);
                oNiosh.Duraciontarea = int.Parse(txtduracion.Text);
                oNiosh.CalidadAgarreD = int.Parse(txtCMD.Text);
                oNiosh.CalidadAgarreI = int.Parse(txtCMI.Text);
                oNiosh.LCNiosh = int.Parse(txtLCN.Text);
                oNiosh.FrecuenciaNiosh = int.Parse(txtfrecuencia.Text);
                oNiosh.DistanciaVerticalD = int.Parse(difvertd.Text);
                oNiosh.DistanciaVerticali = int.Parse(difvertint.Text);

                var res = oNioshBC.UpdateNiosh1BC(oNiosh);
                MessageBox.Show("CMD, CMI, FN y FNi fueron Calculados");

            }
            catch { }

        }
    }
}
