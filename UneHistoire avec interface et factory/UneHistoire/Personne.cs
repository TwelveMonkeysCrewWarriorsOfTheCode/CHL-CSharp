using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    public class Personne
    {
        private DateTime m_DateNaissance;

        protected string m_Nom;

        private string m_Prenom;

        public DateTime DateNaissance
        {
            get { return m_DateNaissance; }
            set
            {
                // Si value trop loin alors date bonne throw
                m_DateNaissance = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.Prenom + " " + this.m_Nom; // Prénom appel get défini et nom c'est la variable car pas de get défini
            }
        }

        public string Prenom
        {
            get
            {
                return m_Prenom;
            }
            set
            {
                // Test de garde pour avoir un prenom correct (A faire)
                m_Prenom = value.Trim();
            }
        }

        public string GetNom()
        {
            return this.m_Nom.ToUpper();
        }
        /*
        public virtual int WorkCompleted()
        {
            return -1;
        }

        public virtual void WorkProgressing()
        {

        }

        public virtual void WorkStarted()
        {

        }*/
    }
}