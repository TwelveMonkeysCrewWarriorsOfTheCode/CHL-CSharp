using System;
using System.Collections.Generic;
using System.Text;
using UtilsClassLibrary;

namespace ProjectPalindromeBLL
{
    public class Display
    {
        public static void Menu()
        {
            bool result = false;
            bool choiceDone = false;
            string input = "";


            Console.Clear();

            while (!choiceDone)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  =======================================================================================");
                Console.WriteLine("  | Palindrome 2.0                                                                      |");
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
                        if (!string.IsNullOrWhiteSpace(input)) // We don't accept null text or only spaces text
                        {
                            result = Palindrome.IsPalindrome(input); // Palindrome test
                            Display.Result(result, input, true); // Call Result method to diplay result
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces !!!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        choiceDone = true;
                        break;
                    case "2":
                        Console.Write("\n    Entrez un  mot ou un texte pour tester si c'est un palindrome : ");
                        input = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(input)) // We don't accept null text or only spaces text
                        {
                            result = Palindrome.IsPalindrome(input); // Palindrome test
                            FilesTxt.SaveFile(input); // Save to file
                            Display.Result(result, input, true); // Call Result method to diplay result
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n    Un texte ne peut pas être null ou ne contenir que des espaces !!!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                        choiceDone = true;
                        break;
                    case "3":
                        FilesTxt.ReadFile();
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
    }
}
