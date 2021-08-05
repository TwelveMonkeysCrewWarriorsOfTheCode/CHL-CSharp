using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Fractions
{
    public class AdoNet
    {
        public static void DisplayFile(string pFilename)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Environment.CurrentDirectory + "\\;Extended Properties=\"text;HDR=yes;FMT=Delimited\"";
            OleDbDataAdapter da = new OleDbDataAdapter($"select * from [{pFilename}]", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    //if (i==0) Console.WriteLine((string)dt.ColumnName);
                    Console.WriteLine((string)row[i]);
                }
            }
        }
    }
}
