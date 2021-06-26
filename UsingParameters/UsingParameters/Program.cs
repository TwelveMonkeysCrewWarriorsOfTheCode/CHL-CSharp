using System;

namespace UsingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemple de passage de paramètres avec des variables de type valeurs
            int value1, value2, multiplicator, divisor;
            value1 = 8;
            value2 = 2;
            int result = Add(ref value1, ref value2);
            string s = "Le resultat de l'addition des valeurs " + value1 + " et " + value2 + " est " + result;
            Console.WriteLine(s);
            Console.WriteLine($"Le resultat de l'addition des valeurs {value1} et {value2} est {result}");

            // Exemple de passage de paramètres avec des variables de type référence
            Time time1, time2;
            time1 = new Time();
            time1.Hour = 23;
            time1.Minute = 10;
            time2 = new Time();
            time2.Hour = 3;
            time2.Minute = 59;
            Console.WriteLine($"(Add)time1={time1.ToString()}");
            Console.WriteLine($"(Add)time2={time2.ToString()}");
            Time timeResult = Time.AddTime(time1, time2);
            Console.WriteLine($"(Add)timeresult={timeResult}");
            time1.Hour = 21;
            time1.Minute = 10;
            time2.Hour = 6;
            time2.Minute = 59;
            Console.WriteLine($"(Sub)time1={time1.ToString()}");
            Console.WriteLine($"(Sub)time2={time2.ToString()}");
            timeResult = Time.SubTime(time1, time2);
            Console.WriteLine($"(Sub)timeresult={timeResult}");
            time1.Hour = 18;
            time1.Minute = 10;
            multiplicator = 6;
            Console.WriteLine($"(Mul)time1={time1.ToString()}");
            Console.WriteLine($"(Mul)multiplicateur={multiplicator}");
            timeResult = Time.MulTime(time1, multiplicator);
            Console.WriteLine($"(Mul)timeresult={timeResult}");
            time1.Hour = 20;
            time1.Minute = 10;
            divisor = 2;
            Console.WriteLine($"(Div)time1={time1.ToString()}");
            Console.WriteLine($"(Div)diviseur={divisor}");
            timeResult = Time.DivTime(time1, divisor);
            Console.WriteLine($"(Div)timeresult={timeResult}");
        }

        private static int Add(ref int pLeftValue, ref int pRightValue)
        {
            pLeftValue = pLeftValue * 10;
            pRightValue *= 10;
            int result = pLeftValue + pRightValue;
            return result;
        }
    }
}
