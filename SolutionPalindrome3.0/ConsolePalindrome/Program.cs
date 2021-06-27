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
                Display.DisplayMessage($"\n    Il y a une Erreur de type {Exceptiontype}, appelez le help desk", ConsoleColor.Red);
            }
        }
    }
}

