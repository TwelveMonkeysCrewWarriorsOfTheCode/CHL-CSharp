using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        public static Result SaveRecords(string texttosave, string filename)
        {
            Result result = new Result();
            // Test if file exist
            if (!File.Exists(filename))
            {
                try
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(filename))
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                    }
                }
                catch (Exception e)
                {
                    result.status = false;
                    result.message1 = "\n    Le fichier n'a pas pu être écrit.";
                    result.message2 = "\n    Exception: " + e.Message;
                    return result;
                }
            }
            else
            {
                try
                {
                    // The file exist , append to
                    using (StreamWriter sw = File.AppendText(filename))
                    {
                        sw.WriteLine(texttosave); // Write to file
                        sw.Close(); // Close stream
                    }
                }
                catch (Exception e)
                {
                    result.status = false;
                    result.message1 = "\n    Le fichier n'a pas pu être écrit.";
                    result.message2 = "\n    Exception: " + e.Message;
                    return result;
                }
            }
            result.status = true;
            return result;
        }

        public static Result ReadRecords(string filename) // Read all line in the file and test if palindrome
        {
            Result result = new Result();
            // Test if file exist
            if (!File.Exists(filename))
            {
                result.status = false;
                result.message1 = "\n    Le fichier n'existe pas.";
                return result;
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        string line;
                        // Lire les lignes du fichier jusqu'à la fin.
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line)) // We don't accept null text or only spaces text
                            {
                                bool result1 = PalindromeBLL.IsPalindrome(line); // Palindrome test
                                if (result1)
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"\n    {line} est un palindrome");

                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"\n    {line} n'est pas un palindrome !!!");
                                }
                                Console.ResetColor();
                            }
                            else
                            {
                                result.status = false;
                                result.message1 = "\n    Un texte ne peut pas être null ou ne contenir que des espaces !!!";
                                return result;
                            }
                            //Console.WriteLine(line);
                        }
                        sr.Close(); // Close stream
                    }
                }
                catch (Exception e)
                {
                    result.status = false;
                    result.message1 = "\n    Le fichier n'a pas pu être lu.";
                    result.message2 = "\n    Exception: " + e.Message;
                    return result;
                }
                result.status = true;
                return result;
            }
        }
    }
}

