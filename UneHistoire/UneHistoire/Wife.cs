using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    public class Wife : Personne, IAvertissable
    {
        public Wife(string pNom)
        {
            if (pNom == null) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(pNom)) throw new ArgumentOutOfRangeException();
            this.m_Nom = pNom.Trim();
        }

        public int WorkCompleted()
        {
            Console.WriteLine($"Wife {this.GetNom()} dit : tu a 10 min pour rentrer à la maison");
            return 2; //grade
        }

        public void WorkProgressing()
        {
            Console.WriteLine($"Wife {this.GetNom()} dit : Tu en a encore pour longtemps");
        }

        public void WorkStarted()
        {
            Console.WriteLine($"Wife {this.GetNom()} dit : Bon travail");
        }
    }
}