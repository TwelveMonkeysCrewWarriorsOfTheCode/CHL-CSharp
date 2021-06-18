using ProjectPalindromeBLL;
using System;

namespace ConsolePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Palindrome 1.0");
            Console.WriteLine("==============");
            Console.WriteLine("Ce programme teste si le mot/phrase entré est un palindrome");
            Console.Write("Entrez un mot a tester (q=Quit) : ");
            String input = Console.ReadLine();
            try
            {
                //string userEntryDeleted = testPalindrome.DeleteBlanks(userEntry);
                while (input != "q" && input != "Q")
                {
                    bool result = Palindrome.IsPalindrome(input);
                    if (result)
                    {
                        Console.WriteLine("{input} est un palindrome");
                    }
                    else
                    {
                        Console.WriteLine("{input} n'est pas un palindrome !!!");
                    }
                }
            }
            catch (Exception Exceptiontype)
            {
                Console.WriteLine("Une Erreur de type {Exceptiontype}, appelez le help desk");
            }
            Console.ReadKey();
        }
    }
}

