using System;

namespace UneHistoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            Boss b = new Boss("     Vador     ");
            b.Prenom = "Dark";
            //Console.WriteLine($"{b.Prenom}");
            Worker w = new Worker(b); // Aussi une associatio de classe mais avec un constructeur
            //w.Boss = b; // = Une association
            w.DoWork();
            Console.WriteLine("Fin du programme");
        }
    }
}
