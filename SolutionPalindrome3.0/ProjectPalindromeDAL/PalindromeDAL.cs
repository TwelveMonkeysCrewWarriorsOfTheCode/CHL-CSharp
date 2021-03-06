using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        public static ResultDAL SaveRecords(string texttosave, string filename) // Save a text to file in append mode
        {
            ResultDAL result = new ResultDAL();
            // Test if file exist
            try
            {

                if (!FilesTxt.IsFileExist(filename)) // File Exist ?
                {                   
                    using (StreamWriter sw = File.CreateText(filename)) // Create a file to write to.
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                    }
                }
                else
                {                
                    using (StreamWriter sw = File.AppendText(filename)) // The file exist , append to
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                    }
                }
            }
            catch (Exception e)
            {
                result.status = false;
                result.message1 = "\n    Le fichier n'a pas pu être écrit.";
                result.message2 = "\n    Exception: " + e.Message;
                return result;
            }
            result.status = true;
            return result;
        }

        public static Records ReadRecords(string filename) // Read all line in the file and test if palindrome
        {
            Records records = new Records();

            try
            {
                records.records = System.IO.File.ReadAllLines(filename); // Read the text file by line and return a array of strings

            }
            catch (Exception e)
            {
                records.status = false;
                records.message1 = "\n    Le fichier n'a pas pu être lu.";
                records.message2 = "\n    Exception: " + e.Message;
                return records;
            }
            records.status = true;
            return records;
        }
    }
}

