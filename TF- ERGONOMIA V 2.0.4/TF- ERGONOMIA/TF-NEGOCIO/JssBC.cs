using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.DAC;
using TF.ENTITIES;

namespace TF.BC
{
    public class JssBC
    {
        public int InserJssPORTADABC(jss Ojss)
        {
            JssDAC oJssDAC = new JssDAC();
            return oJssDAC.InsertJSSPORTADADAC(Ojss);
        }
        public int UpdateJssBC(jss Ojss)
        {
            JssDAC oJssDAC = new JssDAC();
            return oJssDAC.UpdateJSSDAC(Ojss);
        }
        public DataTable JssMaxIDBC(jss Ojss)
        {
            JssDAC oJssDAC = new JssDAC();
            DataTable dt = oJssDAC.JssMaxIDDAC(Ojss);
            return dt;
        }
        public DataTable Jss_ResultadoBC(jss Ojss)
        {
            JssDAC oJssDAC = new JssDAC();
            DataTable dt = oJssDAC.Jss_ResultadoDAC(Ojss);
            return dt;
        }



    }
}
