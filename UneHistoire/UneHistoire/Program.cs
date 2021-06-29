using System;

namespace UneHistoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            //Personne b = new Boss("     Vador     ");
            //Personne b = new Ami("     Skywalker     ");
            //Personne b = new Wife("     Leia     ");
            IAvertissable b = new Wife("     Leia     ");
            //b.Prenom = "Princesse";
            //Console.WriteLine($"{b.Prenom}");
            Worker w = new Worker(b); // Aussi une associatio de classe mais avec un constructeur
            //w.Boss = b; // = Une association
            w.DoWork();
            Console.WriteLine("Fin du programme");
        }
    }
}
