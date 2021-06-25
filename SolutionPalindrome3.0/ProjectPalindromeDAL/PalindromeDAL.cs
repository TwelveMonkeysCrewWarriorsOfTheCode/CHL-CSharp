using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;

namespace ProjectPalindromeDAL
{
    public class PalindromeDAL
    {
        public static void SaveFile(string texttosave, string filename) // Save Text into file
        {

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
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n    Le fichier n'a pas pu être écrit.");
                    Console.WriteLine("\n    Exception: " + e.Message);
                    Console.ReadKey();
                    Console.ResetColor();
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
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n    Le fichier n'a pas pu être écrit.");
                    Console.WriteLine("\n    Exception: " + e.Message);
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }
        }

        public static void ReadFile(ref string filename) // Read all line in the file and test if palindrome
        {
            // Test if file exist
            if (!File.Exists(filename))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n    Le fichier n'existe pas.");
                Console.ResetColor();
                Console.ReadKey();
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
                                bool result = PalindromeBLL.IsPalindrome(line); // Palindrome test
                                                                                //Display.Result(result, line, false); // Call Result method to diplay result
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces !!!");
                                Console.ResetColor();
                                Console.ReadKey();
                            }
                            //Console.WriteLine(line);
                        }
                        sr.Close(); // Close stream
                    }
                }
                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n    Le fichier n'a pas pu être lu.");
                    Console.WriteLine("\n    Exception: " + e.Message);
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            //Display.MenuReturn(); // Call method to display message
        }
    }
}

