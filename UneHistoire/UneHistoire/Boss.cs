using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Boss
    {
        private string m_Nom;

        // Début propriété
        private string m_prenom;
        //public string Prenom { get => m_prenom; set => m_prenom = value; }
        public string Prenom
        {
            get
            {
                return m_prenom;
            }
            set
            {
                // Test de garde pour avoir un prenom correct (A faire)
                m_prenom = value.Trim();
            }
        }
        // Fin propriété
        
        // Début propriété
        private DateTime m_DateNaissance;

        public DateTime DateNaissance
        {
            get { return m_DateNaissance; }
            set {
                // Si value trop loin alors date bonne throw
                m_DateNaissance = value;
                }
        }
        // Fin propriété

        // Propriété calculée
        public string FullName
        {
            get
            {
                return this.Prenom + " " + this.m_Nom; // Prénom appel get défini et nom c'est la variable car pas de get défini
            }
        }

        public Boss(string pNom)
        {
            if (pNom == null) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(pNom)) throw new ArgumentOutOfRangeException();
            this.m_Nom = pNom.Trim();
        }
        public int WorkCompleted()
        {
            Console.WriteLine($"Boss {this.m_Nom} dit : Il est presque temps !!!");
            return 3; //grade
        }

        public void WorkProgressing()
        {

        }

        public void WorkStarted()
        {

        }

        // GetNom fournit a l'extérieur le contenu de la variable encapsulé dans l'objet
        public string GetNom()
        {
            return this.m_Nom.ToUpper();
        }

        // SetPrenom permet à l'extérieur d'assigner le contenu de la variable encapsulé dans l'objet
        /*public void SetPrenom(string pPrenom)
        {
            // Test de garde pour avoir un prenom correct (A faire)
            this.Prenom = pPrenom.Trim();
        }*/
    }
}
