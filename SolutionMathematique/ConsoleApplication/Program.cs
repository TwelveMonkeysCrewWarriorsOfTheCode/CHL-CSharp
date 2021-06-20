using ProjectMathematiqueBLL;
using System;
using System.Diagnostics;
using System.Numerics;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            System.Console.Write("Tapez le nombre désiré : ");
            String reponse = Console.ReadLine();
            try
            {
                int nombre = int.Parse(reponse);
                sw.Start();
                BigInteger resultat = Factorial.CalculateRecursiv(nombre);
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);
                Console.WriteLine($"Le resultat de la factorielle de {nombre} est egal à {resultat}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Veuillez taper unniquement des chiffres");
            }
            catch(Exception)
            {
                Console.WriteLine("Erreur Inconnue, appelez le help desk");
            }
            Console.ReadKey();
        }
    }
}

