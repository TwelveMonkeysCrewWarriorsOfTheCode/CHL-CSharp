using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;

namespace ProjectPalindromeDAL
{
    /// <summary>
    /// Class to manage records
    /// </summary>
    public class PalindromeDAL
    {
        /// <summary>
        /// Save Records
        /// </summary>
        /// <param name="texttosave"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static ResultDAL SaveRecords(string texttosave, string filename) // Save a text to file in append mode
        {
            // Test if file exist
            try
            {

                if (!FilesTxt.IsFileExist(filename)) // File Exist ?
                {                   
                    using (StreamWriter sw = File.CreateText(filename)) // Create a file to write to.
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                        ResultDAL result = new ResultDAL(true, "", "", filename);
                        return result;
                    }
                }
                else
                {                
                    using (StreamWriter sw = File.AppendText(filename)) // The file exist , append to
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                        ResultDAL result = new ResultDAL(true, "", "", filename);
                        return result;
                    }
                }
            }
            catch (Exception e)
            {
                ResultDAL result = new ResultDAL(false, "\n    Le fichier n'a pas pu être écrit.", "\n    Exception: " + e.Message, "");
                return result;
            }
        }

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

