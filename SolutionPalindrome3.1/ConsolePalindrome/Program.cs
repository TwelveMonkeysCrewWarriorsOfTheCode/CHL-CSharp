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
                Display.DisplayMenu(); // Call Menu method   
            }
            catch (Exception ExceptionMessage)
            {
                Display.DisplayMessage($"\n    Il y a une Erreur de type {ExceptionMessage.Message}, appelez le help desk", ConsoleColor.Red);
            }
        }
    }
}

