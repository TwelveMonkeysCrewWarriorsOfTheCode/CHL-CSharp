using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;
using ProjectPalindromeDAL;
using UtilsClassLibraryHelper;

namespace ConsolePalindrome
{
    /// <summary>
    /// Class To Display in the console
    /// </summary>
    public class Display
    {
        const string VERSION = "3.1";

        /// <summary>
        /// Display Menu
        /// </summary>
        public static void DisplayMenu() // Display Menu
        {
            bool choiceDone = false;

            while (!choiceDone)
            {
                DisplayMenuHead();
                string choice = Console.ReadLine();
                choice = choice.ToLower(); // Convert minus
                switch (choice)
                {
                    case "q":
                        Environment.Exit(0); // Exit Program
                        break;
                    case "1":
                        if (TestPalindromeFromKeyboard())
                        {
                            choiceDone = true; 
                        }
                        break;
                    case "2":
                        if (TestPalindromeFromKeyboardAndSaveInFile())
                        {
                            choiceDone = true;
                        }
                        break;
                    case "3":
                        if (TestPalindromeFromFile())
                        {
                            choiceDone = true;
                        }
                        break;

                    default:
                        DisplayMessage("\n    Votre choix n'est pas valide !!!", ConsoleColor.Red);
                        break;
                }
                Display.DisplayMenuReturn(); // Call method to display message
            }
        }

        /// <summary>
        /// Display Menu Header
        /// </summary>
        private static void DisplayMenuHead() // Header of the menu
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

        /// <summary>
        /// Choice 1 : Test Palindrome From Keyboard
        /// </summary>
        /// <returns></returns>
        private static bool TestPalindromeFromKeyboard()
        {
            string input = "";
            input = EntryKeyboard("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : "); // Get text from keyboard
            ResultBLL resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
            if (resultpalindrome.PStatus != Status.error) // Not Error
            {
                if (resultpalindrome.PStatus == Status.ispalindrome)
                {
                    Display.DisplayResult(true, input); // Call Result method to diplay result
                }
                else
                {
                    Display.DisplayResult(false, input); // Call Result method to diplay result
                }
                return true;
            }
            else
            {
                DisplayMessage("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", ConsoleColor.Red);
            }
            return false;
        }

        /// <summary>
        /// Choice 2 : Test Palindrome From Keyboard And Save To File
        /// </summary>
        /// <returns></returns>
        private static bool TestPalindromeFromKeyboardAndSaveInFile()
        {
            string input = "";
            string filename = "";
            input = EntryKeyboard("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : "); // Get text from keyboard
            ResultBLL resultpalindrome = PalindromeBLL.ValidEntryTextAndCheckPalindrome(input); // Check the text validity and palindrome
            if (resultpalindrome.PStatus != Status.error) // Not Error
            {
                DisplayFilesList(); // Display Files list in the current directory
                filename = EntryKeyboard("\n    Entrez le nom du fichier à enregistrer : "); // Get filename from keyboard
                ResultDAL resultfilenameextension = FilesTxt.ValidAndSetExtensionFilename(filename); // Check the filename validity and add .txt if need
                if (resultfilenameextension.PStatus)
                {
                    ResultDAL valid = PalindromeDAL.SaveRecords(input, resultfilenameextension.PFilename); // Save record to file in append mode
                    if (valid.PStatus)
                    {
                        if (resultpalindrome.PStatus == Status.ispalindrome)
                        {
                            Display.DisplayResult(true, input); // Call Result method to diplay result
                        }
                        else
                        {
                            Display.DisplayResult(false, input); // Call Result method to diplay result
                        }
                        return true;
                    }
                    else
                    {
                        DisplayMessage(valid.PMessageDev, ConsoleColor.Red);
                        DisplayMessage(valid.PMessageExc, ConsoleColor.Red);
                    }
                }
                else
                {
                    DisplayMessage(resultfilenameextension.PMessageDev, ConsoleColor.Red);
                }
            }
            else
            {
                DisplayMessage("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", ConsoleColor.Red);
            }
            return false;
        }

        /// <summary>
        /// Choice 3 : Test Palindrome From File
        /// </summary>
        /// <returns></returns>
        private static bool TestPalindromeFromFile()
        {
            string filename = "";
            DisplayFilesList(); // Display files list in the current directory
            filename = EntryKeyboard("\n    Entrez le nom du fichier à lire : "); // Get filename from keyboard
            ResultDAL resultfilename = FilesTxt.ValidFilename(filename); // Check if filename is not null and doesn't contains only spaces
            if (resultfilename.PStatus)
            {
                if (FilesTxt.IsFileExist(filename)) // File Exist ?
                {
                    Records records = PalindromeDAL.ReadRecords(filename); // Read all lines (records) from file
                    if (records.PStatus)
                    {
                        // Afficher resultat
                        DisplayRecordsAndCheckPalindrome(records); // Display Palindrome results
                        return true;
                    }
                    else
                    {
                        DisplayMessage(records.PMessageDev, ConsoleColor.Red);
                        DisplayMessage(records.PMessageExc, ConsoleColor.Red);
                    }
                }
                else
                {
                    DisplayMessage("\n    Le fichier n'existe pas.", ConsoleColor.Red);
                }
            }
            else
            {
                DisplayMessage(resultfilename.PMessageDev, ConsoleColor.Red);
            }
            return false;
        }

        /// <summary>
        /// Display Test Palindrome Result
        /// </summary>
        /// <param name="result"></param>
        /// <param name="strresult"></param>
        private static void DisplayResult(bool result, string strresult) // Display result
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
            DisplayMenuReturn(); // Call method to display message
        }

        /// <summary>
        /// Display Message to Return Menu
        /// </summary>
        private static void DisplayMenuReturn() // Display message and wait enter key
        {
            DisplayMessage("\n    Appuyez sur enter pour continuer\n", ConsoleColor.Cyan);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            DisplayMenu(); // Re-call menu method
        }

        /// <summary>
        /// Display The Files List From Current Directory
        /// </summary>
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

        /// <summary>
        /// Display A Message To The Console
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="color"></param>
        public static void DisplayMessage(string msg, ConsoleColor color) // Display a message to the console
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        /// <summary>
        /// Display Test Palindrome Result From Files 
        /// </summary>
        /// <param name="records"></param>
        private static void DisplayRecordsAndCheckPalindrome(Records records) // Display all lines (records) and palindrome result
        {
            foreach (string line in records.PRecords)
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

        /// <summary>
        /// Get A Text From Keyboard
        /// </summary>
        /// <param name="Message"></param>
        /// <returns></returns>
        private static string EntryKeyboard(string Message) // Get text from keyboard
        {
            Console.Write(Message);
            return Console.ReadLine();
        }
    }
}


