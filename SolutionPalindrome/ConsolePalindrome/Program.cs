using System;
using ProjectPalindromeBLL;
using UtilsClassLibraryHelper;

namespace ConsolePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {                
                Display.Menu(); // Call Menu method   
            }
            catch (Exception Exceptiontype)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n    Il y a une Erreur de type {Exceptiontype}, appelez le help desk");
                Console.ResetColor();
            }
            //Console.ReadKey();
        }
    }
}

