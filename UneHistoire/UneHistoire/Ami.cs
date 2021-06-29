using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    public class Ami : Personne, IAvertissable
    {
        public Ami(string pNom)
        {
            if (pNom == null) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(pNom)) throw new ArgumentOutOfRangeException();
            this.m_Nom = pNom.Trim();
        }

        public int WorkCompleted()
        {
            Console.WriteLine($"Ami {this.GetNom()} dit : viens boire un verre");
            return 7; //grade
        }
        public void WorkProgressing()
        {

        }

        public void WorkStarted()
        {
            Console.WriteLine($"Ami {this.GetNom()} dit : Bon travail");
        }
    }
}