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
        public static void Menu()
        {
            bool result = false;
            bool choiceDone = false;
            string input = "";
            string filename = "";

            Console.Clear();

            while (!choiceDone)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  =======================================================================================");
                Console.WriteLine("  | Palindrome 2.1                                                                      |");
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
                string choice = Console.ReadLine();
                choice = choice.ToLower(); // Convert minus
                switch (choice)
                {
                    case "q":
                        Environment.Exit(0); // Exit Program
                        break;
                    case "1":
                        Console.Write("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : ");
                        input = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(input) && input.Length > 1) // We don't accept null text or only spaces text or 1 char
                        {
                            result = PalindromeBLL.IsPalindrome(input); // Palindrome test
                            Display.Result(result, input, true); // Call Result method to diplay result
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        choiceDone = true;
                        break;
                    case "2":
                        Console.Write("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : ");
                        input = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(input) && input.Length > 1) // We don't accept null text or only spaces text or 1 char
                        {
                            result = PalindromeBLL.IsPalindrome(input); // Palindrome test
                            DisplayFilesList(); // Display Files list in the current directory
                            Console.Write("\n    Entrez le nom du fichier à enregistrer : ");
                            filename = Console.ReadLine();
                            if (ValidAndSetExtensionFilename(ref filename))
                            {
                                PalindromeDAL.SaveFile(input, filename); // Save to file
                                Display.Result(result, input, true); // Call Result method to diplay result
                            }
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        choiceDone = true;
                        break;
                    case "3":
                        DisplayFilesList(); // Display files list in the current directory
                        Console.Write("\n    Entrez le nom du fichier à lire : ");
                         filename = Console.ReadLine();
                        if (ValidFilename(ref filename))
                        {
                            PalindromeDAL.ReadFile(ref filename);
                            Display.MenuReturn(); // Call method to display message
                        }
                        choiceDone = true;
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n    Votre choix n'est pas valide !!!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void Result(bool result, string strresult, bool opt) // Display result
        {
            
            if (result)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n    {strresult} est un palindrome");

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n    {strresult} n'est pas un palindrome !!!");
            }
            Console.ResetColor();
            if (opt) MenuReturn(); // Call method to display message
        }

        
        public static void MenuReturn()
        {
           
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n    Appuyez sur enter pour continuer\n");
            Console.ResetColor();
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Menu(); // Re-call menu method
        }

        static void DisplayFilesList() // Display files list in the current directory
        {
            string[] fileList = FilesTxt.CreateFileList(@".\");

            Console.WriteLine($"\n    Liste des fichiers");
            Console.WriteLine($"    ------------------");
            for (int i = 0; i < fileList.Length; i++)
            {
                Console.WriteLine($"    {Path.GetFileName(fileList[i])}");
            }
        }

        static bool ValidAndSetExtensionFilename(ref string filename)
        { 

            if (!string.IsNullOrWhiteSpace(filename)) // We don't accept null text or only spaces text
            {
                if (filename.Length< 5) // Add .txt to filename id don't exist
                {
                    filename += ".txt";
                }
                else
                {
                    string ext = filename.Substring(filename.Length - 4);
                    if (ext != ".txt")
                    {
                        filename += ".txt";
                    }
                }
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n    Un nom de fichier ne peut pas être null ou ne contenir que des espaces !!!");
                Console.ResetColor();
                Console.ReadKey();
                return false;
            }
        }

        static bool ValidFilename(ref string filename)
        {

            if (!string.IsNullOrWhiteSpace(filename)) // We don't accept null text or only spaces text
            {
                return true;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n    Un nom de fichier ne peut pas être null ou ne contenir que des espaces !!!");
                Console.ResetColor();
                Console.ReadKey();
                return false;
            }
        }

        public static void SetForegroundColor()
        {

            /*
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            foreach (var color in colors)
            {
                if (color == (ConsoleColor)"Cyan")
                {

                }
            }
            */
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
