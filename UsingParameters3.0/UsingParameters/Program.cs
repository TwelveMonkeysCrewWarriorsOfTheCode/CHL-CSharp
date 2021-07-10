using System;

namespace UsingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemple de passage de paramètres avec des variables de type valeurs
            int value1, value2;
            value1 = 8;
            value2 = 2;
            int result = Add(ref value1, ref value2);
            string s = "Le resultat de l'addition des valeurs " + value1 + " et " + value2 + " est " + result;
            Console.WriteLine(s);
            Console.WriteLine($"Le resultat de l'addition des valeurs {value1} et {value2} est {result}");
 
            Time time1, time2, timeResult;
            int multiplicator, divisor, intValue;
            float floatValue;
            bool resultcomparison;

            // +
            time1 = new Time(4, 50, 0);
            time2 = new Time(3, 25);
            timeResult = time1 + time2;
            Console.WriteLine($"(Addition)       {time1} + {time2} = {timeResult}");
            time1 = new Time(23, 10);
            time2 = new Time(3, 59);
            timeResult = time1 + time2;
            Console.WriteLine($"(Addition)       {time1} + {time2} = {timeResult}");

            // -
            time1 = new Time(4, 50);
            time2 = new Time(3, 25);
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");
            time1 = new Time(4, 50);
            time2 = new Time(2, 55);
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");
            time1 = new Time(3, 25);
            time2 = new Time(4, 50);
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");
            time1 = new Time(21, 10);
            time2 = new Time(6, 59);
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");

            // *
            time1 = new Time(3, 25);
            multiplicator = 3;
            timeResult = time1 * multiplicator;
            Console.WriteLine($"(Multiplication) {time1} * {multiplicator} = {timeResult}");
            time1 = new Time(18, 10);
            multiplicator = 6;
            timeResult = time1 * multiplicator;
            Console.WriteLine($"(Multiplication) {time1} * {multiplicator} = {timeResult}");

            // /
            time1 = new Time(10, 15);
            divisor = 3;
            timeResult = time1 / divisor;
            Console.WriteLine($"(Division)       {time1} / {divisor} = {timeResult}");
            time1 = new Time(40, 0);
            divisor = 3;
            timeResult = time1 / divisor;
            Console.WriteLine($"(Division)       {time1} / {divisor} = {timeResult}");
            time1 = new Time(40, 30);
            divisor = 3;
            timeResult = time1 / divisor;
            Console.WriteLine($"(Division)       {time1} / {divisor} = {timeResult}");
            time1 = new Time(20, 10);
            divisor = 2;
            timeResult = time1 / divisor;
            Console.WriteLine($"(Division)       {time1} / {divisor} = {timeResult}");

            // float -> Time
            floatValue = 3.16666f;
            time1 = (Time)floatValue;
            Console.WriteLine($"(float->Time)    {floatValue}f = {time1}");
            floatValue = 2.50f;
            time1 = (Time)floatValue;
            Console.WriteLine($"(float->Time)    {floatValue}f = {time1}");

            // Time -> float
            time1 = new Time(3, 45);
            floatValue = (float)time1;
            Console.WriteLine($"(Time->float)    {time1} = {floatValue}f");
            time1 = new Time(2, 30);
            floatValue = (float)time1;
            Console.WriteLine($"(Time->float)    {time1} = {floatValue}f");

            // int -> Time
            intValue = 150;
            time1 = (Time)intValue;
            Console.WriteLine($"(int->Time)      {intValue} = {time1}");

            // Time -> int
            time1 = new Time(3, 15);
            intValue = (int)time1;
            Console.WriteLine($"(Time->int)      {time1} => {intValue}");
            time1 = new Time(2, 30);
            intValue = (int)time1;
            Console.WriteLine($"(Time->int)      {time1} => {intValue}");

            // Time < Time
            time1 = new Time(2, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 < time2;
            Console.WriteLine($"(Time<Time)      {time1} < {time2} = {resultcomparison}");
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 < time2;
            Console.WriteLine($"(Time<Time)      {time1} < {time2} = {resultcomparison}");

            // Time > Time
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 > time2;
            Console.WriteLine($"(Time>Time)      {time1} > {time2} = {resultcomparison}");
            time1 = new Time(2, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 > time2;
            Console.WriteLine($"(Time>Time)      {time1} > {time2} = {resultcomparison}");

            // Time <= Time
            time1 = new Time(2, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 <= time2;
            Console.WriteLine($"(Time<=Time)      {time1} <= {time2} = {resultcomparison}");
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 <= time2;
            Console.WriteLine($"(Time<=Time)      {time1} <= {time2} = {resultcomparison}");
            time1 = new Time(3, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 <= time2;
            Console.WriteLine($"(Time<=Time)      {time1} <= {time2} = {resultcomparison}");

            // Time >= Time
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)      {time1} >= {time2} = {resultcomparison}");
            time1 = new Time(2, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)      {time1} >= {time2} = {resultcomparison}");
            time1 = new Time(3, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)      {time1} >= {time2} = {resultcomparison}");


            // Essai
            /*int maxsec = 9837;
            int heure = Math.Abs(maxsec) / 3600;
            int reste1 = Math.Abs(maxsec) % 3600;
            int minute = Math.Abs(reste1) / 60;
            int seconde = Math.Abs(reste1) % 60;
            Console.WriteLine($"{maxsec} secondes={heure}:{minute}:{seconde}");

            heure = 2;
            minute = 43;
            seconde = 57;
            maxsec = (heure * 3600) + (minute * 60) + seconde;
            Console.WriteLine($"{heure}:{minute}:{seconde}={maxsec} secondes");
            */
            // + with seconds
            time1 = new Time(2, 43, 57);
            time2 = new Time(3, 25);
            timeResult = time1 + time2;
            Console.WriteLine($"(Addition)       {time1} + {time2} = {timeResult}");
            time1 = new Time(2, 43, 57);
            time2 = new Time(3, 25, 16);
            timeResult = time1 + time2;
            Console.WriteLine($"(Addition)       {time1} + {time2} = {timeResult}");

            // - with seconds
            time1 = new Time(4, 50, 12);
            time2 = new Time(3, 25, 45);
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");
            time1 = new Time(3, 25, 2);
            time2 = new Time(4, 50, 12 );
            timeResult = time1 - time2;
            Console.WriteLine($"(Substraction)   {time1} - {time2} = {timeResult}");

            // * with seconds
            time1 = new Time(3, 25, 32);
            multiplicator = 3;
            timeResult = time1 * multiplicator;
            Console.WriteLine($"(Multiplication) {time1} * {multiplicator} = {timeResult}");

            // /
            time1 = new Time(10, 15, 7);
            divisor = 3;
            timeResult = time1 / divisor;
            Console.WriteLine($"(Division)       {time1} / {divisor} = {timeResult}");

            // float -> Time
            floatValue = 2.57f;
            time1 = (Time)floatValue;
            Console.WriteLine($"(float->Time)    {floatValue}f = {time1}");

            // Time -> float
            time1 = new Time(2, 34, 12);
            floatValue = (float)time1;
            Console.WriteLine($"(Time->float)    {time1} = {floatValue}f");
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
