using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    class Worker
    {
        public Worker(Boss pBoss)
        {
            if (pBoss == null) throw new ArgumentNullException();
            Boss = pBoss;
        }
        private Boss Boss;
        public void DoWork()
        {
            //Console.WriteLine($"Worker dit : {Boss.GetNom()} je démarre le travail");
            Console.WriteLine($"Worker dit : {Boss.GetNom()} je démarre le travail");
            Boss.WorkStarted();

            Console.WriteLine($"Worker dit : {Boss.FullName} je continue le travail");
            Boss.WorkProgressing();

            Console.WriteLine($"Worker dit : {Boss.Prenom} je termine le travail");
            int grade = Boss.WorkCompleted();
            Console.WriteLine($"Le grade est {grade}");
        }
    }
}


