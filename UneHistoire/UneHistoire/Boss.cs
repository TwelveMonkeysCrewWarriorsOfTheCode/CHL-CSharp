using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Boss : Personne //, IAvertissable
    {
   
        public Boss(string pNom)
        {
            if (pNom == null) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(pNom)) throw new ArgumentOutOfRangeException();
            this.m_Nom = pNom.Trim();
        }

        public int WorkCompleted()
        {
            Console.WriteLine($"Boss {this.GetNom()} dit : Il est presque temps !!!");
            return 5; //grade
        }
    }
}
