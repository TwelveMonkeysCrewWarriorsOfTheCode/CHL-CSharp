using ProjectPalindromeBLL;
using UtilsClassLibrary;
using System;

namespace ConsolePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Palindrome 1.0");
            Console.WriteLine("==============");
            Console.WriteLine("\nCe programme teste si le mot/phrase entré est un palindrome");
            Console.Write("\nEntrez un mot a tester (q=Quit) : ");
            string input = Console.ReadLine();
            string inputlow = input.ToLower();
            try
            {
                while (inputlow != "q" && !string.IsNullOrWhiteSpace(inputlow))
                {
                    string strtotest = Utils.RemoveSpace(inputlow); // Delete spaces
                    string laststrtotest = Palindrome.RemoveSpecificChar(strtotest); // Delete specific char
                    //Console.WriteLine(laststrtotest);
                    bool result = Palindrome.IsPalindrome(laststrtotest);
                    if (result)
                    {
                        Console.WriteLine($"\n{input} est un palindrome");
                    }
                    else
                    {
                        Console.WriteLine($"\n{input} n'est pas un palindrome !!!");
                    }
                    Console.WriteLine("\nCe programme teste si le mot/phrase entré est un palindrome");
                    Console.Write("\nEntrez un mot a tester (q=Quit) : ");
                    input = Console.ReadLine();
                    inputlow = input.ToLower();
                }
            }
            catch (Exception Exceptiontype)
            {
                Console.WriteLine($"Une Erreur de type {Exceptiontype}, appelez le help desk");
            }
            //Console.ReadKey();
        }
    }
}

