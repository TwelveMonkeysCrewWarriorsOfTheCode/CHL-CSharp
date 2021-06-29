using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Worker
    {
        public Worker(IAvertissable pAvertissable)
        {
            if (pAvertissable == null) throw new ArgumentNullException();
            m_Avertissable = pAvertissable;
        }
        private IAvertissable m_Avertissable;
        //private Personne m_Personne;
        public void DoWork()
        {
            //Console.WriteLine($"Worker dit : {Boss.GetNom()} je démarre le travail");
            //Console.WriteLine($"Worker dit : {m_Personne.GetNom()} je démarre le travail");
            Console.WriteLine($"Worker dit : je démarre le travail");
            m_Avertissable.WorkStarted();

            //Console.WriteLine($"Worker dit : {m_Personne.FullName} je continue le travail");
            Console.WriteLine($"Worker dit : je continue le travail");
            m_Avertissable.WorkProgressing();

            //Console.WriteLine($"Worker dit : {m_Personne.Prenom} je termine le travail");
            Console.WriteLine($"Worker dit : je termine le travail");
            int grade = m_Avertissable.WorkCompleted();
            Console.WriteLine($"Le grade est {grade}");
        }
    }
}


