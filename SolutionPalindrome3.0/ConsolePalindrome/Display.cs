using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;
using ProjectPalindromeDAL;
using UtilsClassLibraryHelper;

namespace ConsolePalindrome
{
    public class Display
    {
        const string VERSION = "3.0";

        public static void Menu() // Display Menu
        {
            bool choiceDone = false;
            string input = "";
            string filename = "";

            while (!choiceDone)
            {
                MenuHead();
                string choice = Console.ReadLine();
                choice = choice.ToLower(); // Convert minus
                switch (choice)
                {
                    case "q":
                        Environment.Exit(0); // Exit Program
                        break;
                    case "1":
                        input = EntryKeyboard("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : "); // Get text from keyboard
                        ResultBLL resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
                        if (resultpalindrome.status) // ok
                        { 
                            Display.Result(resultpalindrome.result, input, true); // Call Result method to diplay result
                            choiceDone = true;
                        }
                        else
                        {
                            DisplayMessage("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", ConsoleColor.Red);
                        }                        
                        break;
                    case "2":
                        input = EntryKeyboard("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : "); // Get text from keyboard
                        resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
                        if (resultpalindrome.status)
                        {
                            DisplayFilesList(); // Display Files list in the current directory
                            filename = EntryKeyboard("\n    Entrez le nom du fichier à enregistrer : "); // Get filename from keyboard
                            ResultDAL resultfilenameextension = FilesTxt.ValidAndSetExtensionFilename(filename); // Check the filename validity and add .txt if need
                            if (resultfilenameextension.status)
                            {
                                ResultDAL valid = PalindromeDAL.SaveRecords(input, resultfilenameextension.filename); // Save record to file in append mode
                                if (valid.status)
                                {
                                    Display.Result(resultpalindrome.result, input, true); // Call Result method to diplay result
                                    choiceDone = true;
                                }
                                else
                                {
                                    DisplayMessage(valid.message1, ConsoleColor.Red);
                                    DisplayMessage(valid.message2, ConsoleColor.Red);
                                }
                            } 
                            else
                            {
                                DisplayMessage(resultfilenameextension.message1, ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            DisplayMessage("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", ConsoleColor.Red);
                        }
                        break;
                    case "3":
                        DisplayFilesList(); // Display files list in the current directory
                        filename = EntryKeyboard("\n    Entrez le nom du fichier à lire : "); // Get filename from keyboard
                        ResultDAL resultfilename = FilesTxt.ValidFilename(filename); // Check if filename is not null and doesn't contains only spaces
                        if (resultfilename.status)
                        {
                            if (FilesTxt.IsFileExist(filename)) // File Exist ?
                            {
                                Records records = PalindromeDAL.ReadRecords(filename); // Read all lines (records) from file
                                if (records.status)
                                {
                                    // Afficher resultat
                                    DisplayRecordsAndCheckPalindrome(records); // Display Palindrome results
                                    choiceDone = true;
                                }
                                else
                                {
                                    DisplayMessage(records.message1, ConsoleColor.Red);
                                    DisplayMessage(records.message2, ConsoleColor.Red);
                                }
                            }
                            else
                            {
                                DisplayMessage("\n    Le fichier n'existe pas.", ConsoleColor.Red);
                            }
                        }
                        else
                        {
                            DisplayMessage(resultfilename.message1, ConsoleColor.Red);
                        }
                        break;

                    default:
                        DisplayMessage("\n    Votre choix n'est pas valide !!!", ConsoleColor.Red);
                        break;
                }
                Display.MenuReturn(); // Call method to display message
            }
        }

        private static void MenuHead() // Header of the menu
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  =======================================================================================");
            Console.WriteLine($"  | Palindrome {VERSION}                                                                      |");
            Console.WriteLine("  =======================================================================================");
            Console.WriteLine("  | Ce programme teste si le texte est un palindrome                                    |");
            Console.WriteLine("  =======================================================================================");
            Console.WriteLine("  | 1 : Tester en entrant un texte au clavier                                           |");
            Console.WriteLine("  | 2 : Tester en entrant un texte au clavier avec sauvegarde dans un fichier .txt      |");
            Console.WriteLine("  | 3 : Tester à partir d'un fichier .txt                                               |");
            Console.WriteLine("  |                                                                                     |");
            Console.WriteLine("  | Q : Quitter                                                                         |");
            Console.WriteLine("  =======================================================================================");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n    Faites votre choix : ");
            Console.ResetColor();
        }

        private static void Result(bool result, string strresult, bool opt) // Display result
        {

            if (result)
            {
                DisplayMessage($"\n    {strresult} est un palindrome", ConsoleColor.Yellow);
            }
            else
            {
                DisplayMessage($"\n    {strresult} n'est pas un palindrome !!!", ConsoleColor.Red);
            }
            Console.ResetColor();
            if (opt) MenuReturn(); // Call method to display message
        }


        private static void MenuReturn() // Display message and wait enter key
        {
            DisplayMessage("\n    Appuyez sur enter pour continuer\n", ConsoleColor.Cyan);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Menu(); // Re-call menu method
        }

        private static void DisplayFilesList() // Display files list in the current directory
        {
            string[] fileList = FilesTxt.CreateFileList(@".\");

            Console.WriteLine($"\n    Liste des fichiers");
            Console.WriteLine($"    ------------------");
            for (int i = 0; i < fileList.Length; i++)
            {
                Console.WriteLine($"    {Path.GetFileName(fileList[i])}");
            }
        }

        public static void DisplayMessage(string msg, ConsoleColor color) // Display a message to the console
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        private static void DisplayRecordsAndCheckPalindrome(Records records) // Display all lines (records) and palindrome result
        {
            foreach (string line in records.records)
            {
                if (!string.IsNullOrWhiteSpace(line)) // We don't accept null text or only spaces text
                {
                    bool result = PalindromeBLL.IsPalindrome(line); // Palindrome test
                    if (result)
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
                    DisplayMessage("\n    Un texte ne peut pas être null ou ne contenir que des espaces!!!", ConsoleColor.Red);
                }
            }
        }

        private static string EntryKeyboard(string Message) // Get text from keyboard
        {
            Console.Write(Message);
            return Console.ReadLine();
        }


    }
}

