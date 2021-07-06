using System;
using System.IO;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        /// <summary>
        /// Read Records
        /// </summary>
        /// <param name="pFilename">File name</param>
        /// <returns>Return records</returns>
        public static Records ReadRecords(string pFilename) // Read all line in the file and test if palindrome
        {
            try
            {
                Records records = new Records(true, "", "", File.ReadLines(pFilename)); // Read the text file by line and return IEnumerable<string>
                return records;
            }
            catch (Exception e)
            {
                Records records = new Records(false, "Le fichier n'a pas pu être lu.", "Exception: " + e.Message, null);
                return records;
            }
        }

        /// <summary>
        /// Save Records
        /// </summary>
        /// <param name="pTextToSave">String to save</param>
        /// <param name="pFilename">File name</param>
        /// <returns>Return status</returns>
        public static ResultDAL SaveRecords(string pTextToSave, string pFilename) // Save a text to file in append mode
        {
            try
            {
                    using (StreamWriter sw = File.AppendText(pFilename)) // The file exist , append to
                    {
                        sw.WriteLine(pTextToSave); // Write to file
                        sw.Close(); // Close stream
                        ResultDAL result = new ResultDAL(true, "", "", pFilename);
                        return result;
                    }
            }
            catch (Exception e)
            {
                ResultDAL result = new ResultDAL(false, "Le fichier n'a pas pu être écrit.", "Exception: " + e.Message, "");
                return result;
            }
        }
    }
}
