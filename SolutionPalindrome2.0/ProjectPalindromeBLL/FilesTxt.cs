using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using UtilsClassLibrary;

namespace ProjectPalindromeBLL
{
    public class FilesTxt
    {
        public static void SaveFile(string texttosave) // Save Text into file
        {
            DisplayFilesList(); // Display Files list in the current directory
            Console.Write("\n    Entrez le nom du fichier à enregistrer : ");
            string fileName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(fileName)) // We don't accept null text or only spaces text
            {
                if (fileName.Length < 5) // Add .txt to filename id don't exist
                {
                    fileName += ".txt";
                }
                else
                {
                    string ext = fileName.Substring(fileName.Length - 4);
                    if (ext != ".txt")
                    {
                        fileName += ".txt";
                    }
                }
                // Test if file exist
                if (!File.Exists(fileName))
                {
                    try
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(fileName))
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
                        using (StreamWriter sw = File.AppendText(fileName))
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
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n    Un nom de fichier ne peut pas être null ou ne contenir que des espaces !!!");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        
        static string[] CreateFileList(string path) // Create list files in the current directory
        {
            string[] fileList = Directory.GetFiles(path, "*.txt");
            return fileList;
        }

        static void DisplayFilesList() // Display files list in the current directory
        {
            string[] fileList = CreateFileList(@".\");

            Console.WriteLine($"\n    Liste des fichiers");
            Console.WriteLine($"    ------------------");
            for (int i = 0; i < fileList.Length; i++)
            {
                Console.WriteLine($"    {Path.GetFileName(fileList[i])}");
            }
        }

        public static void ReadFile() // Read all line in the file and test if palindrome
        {
            DisplayFilesList(); // Display files list in the current directory
            Console.Write("\n    Entrez le nom du fichier à lire : ");
            string fileName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(fileName)) // We don't accept null text or only spaces text
            {
                // Test if file exist
                if (!File.Exists(fileName))
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
                       using (StreamReader sr = new StreamReader(fileName))
                       {
                          string line;
                          // Lire les lignes du fichier jusqu'à la fin.
                          while ((line = sr.ReadLine()) != null)
                          {
                              if (!string.IsNullOrWhiteSpace(line)) // We don't accept null text or only spaces text
                              {
                                  bool result = Palindrome.IsPalindrome(line); // Palindrome test
                                  Display.Result(result, line, false); // Call Result method to diplay result
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
 
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces !!!");
                Console.ResetColor();
                Console.ReadKey();
            }
            Display.MenuReturn(); // Call method to display message
        }
    }
}

