using System;

namespace UneHistoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            Console.WriteLine("Quel est le type d'objet que vous voulez avertir ?");
            string typeAvertissable = Console.ReadLine();
            IAvertissable ia = IAvertissableFactory.Create(typeAvertissable,"18");
            //Personne b = new Boss("     Vador     ");
            //Boss b = new Boss("     Vador     ");
            //Personne b = new Ami("     Skywalker     ");
            //Personne b = new Wife("     Leia     ");
            IAvertissable b = new Wife("     Leia     ");
            //b.Prenom = "Princesse";
            //Console.WriteLine($"{b.Prenom}");
            //Worker w = new Worker(b); // Aussi une associatio de classe mais avec un constructeur
            Worker w = new Worker(ia);
            //w.Boss = b; // = Une association
            w.DoWork();
            Console.WriteLine("Fin du programme");
        }
    }
}
