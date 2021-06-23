using System;

namespace UsingEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            Color palette;
            palette = Color.Blue;
            Console.WriteLine((int)palette);
            Console.WriteLine(palette.ToString());

            JourSemaine jo = JourSemaine.Mercredi;
            Console.WriteLine(jo);

            EtatCivil ec = EtatCivil.Concubin;
            Console.WriteLine(ec);

            ec = EtatCivil.Marié;
            Console.WriteLine(ec);
            ec = (EtatCivil)25;
            Console.WriteLine(ec);
            if (ec == EtatCivil.Concubin) // 25 c'est marié
            {
                Console.WriteLine("Vit en couple");
            }
            else
            {
                Console.WriteLine("Vit seul");
            }

            Console.WriteLine("--------Liste des noms d'état civil--------");
            string [] noms = Enum.GetNames(typeof(EtatCivil));
            foreach (string item in noms)
            {
                Console.WriteLine(item);
            }
        }
    }
}
