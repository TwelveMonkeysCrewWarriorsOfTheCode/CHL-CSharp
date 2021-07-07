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
            //Time timeResult = Time.AddTime(time1, time2);
            Time timeResult = time1 + time2; // Idem ligne précédente
            Console.WriteLine($"(Add)timeresult={timeResult}");
            time1.Hour = 21;
            time1.Minute = 10;
            time2.Hour = 6;
            time2.Minute = 59;
            Console.WriteLine($"(Sub)time1={time1.ToString()}");
            Console.WriteLine($"(Sub)time2={time2.ToString()}");
            //timeResult = Time.SubTime(time1, time2);
            timeResult = time1 - time2; // Idem ligne précédente
            Console.WriteLine($"(Sub)timeresult={timeResult}");
            time1.Hour = 18;
            time1.Minute = 10;
            multiplicator = 6;
            Console.WriteLine($"(Mul)time1={time1.ToString()}");
            Console.WriteLine($"(Mul)multiplicateur={multiplicator}");
            //timeResult = Time.MulTime(time1, multiplicator);
            timeResult = time1 * multiplicator; // Idem ligne précédente
            Console.WriteLine($"(Mul)timeresult={timeResult}");
            time1.Hour = 20;
            time1.Minute = 10;
            divisor = 2;
            Console.WriteLine($"(Div)time1={time1.ToString()}");
            Console.WriteLine($"(Div)diviseur={divisor}");
            //timeResult = Time.DivTime(time1, divisor);
            timeResult = time1 / divisor; // Idem ligne précédente
            Console.WriteLine($"(Div)timeresult={timeResult}");
            float floatconversion = 2.50f;
            Time timeconversion;
            timeconversion = floatconversion;
            Console.WriteLine($"float={floatconversion},time={timeconversion.Hour}:{timeconversion.Minute}");
            timeconversion.Hour = 2;
            timeconversion.Minute = 30;
            floatconversion = timeconversion;
            Console.WriteLine($"time={timeconversion.Hour}:{timeconversion.Minute},float={floatconversion}");
            int intconversion = 2;
            timeconversion = intconversion;
            Console.WriteLine($"int={intconversion},time={timeconversion.Hour}:{timeconversion.Minute}");
            timeconversion.Hour = 2;
            timeconversion.Minute = 0;
            intconversion = timeconversion;
            Console.WriteLine($"time={timeconversion.Hour}:{timeconversion.Minute},int={intconversion}");
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
