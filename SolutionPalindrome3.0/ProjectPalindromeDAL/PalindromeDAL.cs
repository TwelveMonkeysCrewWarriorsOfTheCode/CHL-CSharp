using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        public static ResultDAL SaveRecords(string texttosave, string filename)
        {
            ResultDAL result = new ResultDAL();
            // Test if file exist
            try
            {

                if (!FilesTxt.IsFileExist(filename))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                    }
                }
                else
                {
                    // The file exist , append to
                    using (StreamWriter sw = File.AppendText(filename))
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
                records.records = System.IO.File.ReadAllLines(filename);

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

