using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TextFileADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +System.Environment.CurrentDirectory + "\\;Extended Properties=\"text;HDR=yes;FMT=Delimited\"";
            OleDbDataAdapter da = new OleDbDataAdapter("select * from [quotes.txt]", connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
               Console.WriteLine((string)row["ID"] + ": " + (string) row["LastName"] + (string) row["quotation"]);

            Console.WriteLine("---SELECT * FROM [quotes.txt] WHERE LastName='Einstein'---------");

            OleDbDataAdapter da2 = new OleDbDataAdapter("select TOP 1 * from [quotes.txt] WHERE LastName='Einstein'", connectionString);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            Console.WriteLine((string)row["ID"] + ": " + (string)row["LastName"] + " " + (string)row["quotation"]);
            Console.WriteLine("Any key to quit.");
            Console.ReadLine();
        }
    }
}
