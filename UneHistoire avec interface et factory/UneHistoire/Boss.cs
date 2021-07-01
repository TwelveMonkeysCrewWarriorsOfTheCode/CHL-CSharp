using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Boss : Personne, IAvertissable
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

        public void WorkProgressing()
        {

        }

        public void WorkStarted()
        {

        }

        // SetPrenom permet à l'extérieur d'assigner le contenu de la variable encapsulé dans l'objet
        /*public void SetPrenom(string pPrenom)
        {
            // Test de garde pour avoir un prenom correct (A faire)
            this.Prenom = pPrenom.Trim();
        }*/
    }
}
