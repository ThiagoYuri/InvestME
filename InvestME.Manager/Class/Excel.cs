using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InvestME.Manager.Class
{
    public static class Excel
    {
        public static DataTable GetInvestiments(string dic)
        {
            var plan = "SELECT * FROM [Stock_Screener_20221102$]";
            var strConn = @$"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={dic};Extended Properties='Excel 12.0 Xml;HDR=YES;'";

            var dt = new DataTable();

            using(OleDbConnection con = new OleDbConnection(strConn))
            {
                using (OleDbDataAdapter da = new OleDbDataAdapter(plan, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
            
    }
}
