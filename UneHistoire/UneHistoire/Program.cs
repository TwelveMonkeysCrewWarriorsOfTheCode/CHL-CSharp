using System;

namespace UneHistoire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            //Personne b = new Boss("     Vador     ");
            Boss b = new Boss("     Vador     ");
            //Personne b = new Ami("     Skywalker     ");
            //Personne b = new Wife("     Leia     ");
            //IAvertissable b = new Wife("     Leia     ");
            b.Prenom = "Princesse";
            Ami a = new Ami("Bob l'éponge");
            //Console.WriteLine($"{b.Prenom}");
            //Worker w = new Worker(b); // Aussi une associatio de classe mais avec un constructeur
            Worker w = new Worker();
            w.DlgWorkStarted += a.WorkStarted;
            w.DlgWorkCompleted += a.BoireUnVerre;
            //w.DlgWorkCompleted = new WorkCompletedDelegate(b.WorkCompleted); // Abonnement old school
            //System.Threading.Thread.Sleep(3000); // Sleep
            w.DlgWorkCompleted += b.WorkCompleted; // Abonnement new school
            //w.Boss = b; // = Une association
            //w.DlgWorkCompleted(); // Invocation de l'exécution du délégué (pas bon)
            w.DoWork();
            Console.WriteLine("Fin du programme");
        }
    }
}
