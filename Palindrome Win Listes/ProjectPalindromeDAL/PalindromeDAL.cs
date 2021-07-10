using System;
using System.IO;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        /// <summary>
        /// Read Records
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Records ReadRecords(string filename) // Read all line in the file and test if palindrome
        {
            try
            {
                Records records = new Records(true, "", "", File.ReadLines(filename)); // Read the text file by line and return IEnumerable<string>
                return records;
            }
            catch (Exception e)
            {
                Records records = new Records(false, "\n    Le fichier n'a pas pu être lu.", "\n    Exception: " + e.Message, null);
                return records;
            }
        }
    }
}
