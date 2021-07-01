using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Worker
    {
        public event WorkStartedDelegate DlgWorkStarted; // Event
        public event WorkProgressingDelegate DlgWorkProgressing;
        public event WorkCompletedDelegate DlgWorkCompleted;

        public void DoWork()
        {
            //Console.WriteLine($"Worker dit : {Boss.GetNom()} je démarre le travail");
            //Console.WriteLine($"Worker dit : {m_Personne.GetNom()} je démarre le travail");
            Console.WriteLine($"Worker dit : je démarre le travail");
            if (DlgWorkStarted != null) DlgWorkStarted(); // appel du délégué
            //DlgWorkStarted?.Invoke(); // Idem que la ligne précédente

            //Console.WriteLine($"Worker dit : {m_Personne.FullName} je continue le travail");
            Console.WriteLine($"Worker dit : je continue le travail");
            if (DlgWorkProgressing != null) DlgWorkProgressing();

            //Console.WriteLine($"Worker dit : {m_Personne.Prenom} je termine le travail");
            Console.WriteLine($"Worker dit : je termine le travail");
            foreach (WorkCompletedDelegate methode in DlgWorkCompleted.GetInvocationList())
            {
                int grade = 0;
                if (DlgWorkCompleted != null)
                {
                    grade = methode();
                }
                Console.WriteLine($"Le grade est {grade}");
            }
        }
    }
}


