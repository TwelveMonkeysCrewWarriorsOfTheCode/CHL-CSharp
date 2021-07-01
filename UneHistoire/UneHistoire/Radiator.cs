using System;
using System.Collections.Generic;
using System.Text;

namespace UneHistoire
{
    public class Radiator //: IAvertissable
    {
        protected string m_Number;

        public Radiator(string pNumber)
        {
            if (pNumber == null) throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(pNumber)) throw new ArgumentOutOfRangeException();
            this.m_Number = pNumber.Trim();
        }

        public int WorkCompleted()
        {
            Console.WriteLine($"Radiator {m_Number} dit : Je suis réparé");
            return 10; //grade
        }

        public void WorkProgressing()
        {
            Console.WriteLine($"Radiator {m_Number} dit : Je suis en train d'être réparé");
        }

        public void WorkStarted()
        {
            Console.WriteLine($"Radiator {m_Number} dit : Je commence à être réparé");
        }
    }
}
