using System;
using UsingGenerics;


namespace UsingParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(2, 50);
            Time t2 = new Time(2, 59);
            Console.WriteLine(t1.Equals(t2));
            Time t3 = t1;
            Console.WriteLine(t1.Equals(t3));
            Time t4 = null;
            Console.WriteLine(t1.Equals(t4));
            Console.WriteLine("**********");
            Console.WriteLine(t1.CompareTo(t2));
            Console.WriteLine(t1.CompareTo(t3));
            Console.WriteLine(t1.CompareTo(t4));

            Time[] times = 
            {
                new Time(125), new Time(185), new Time(3), new Time(42), null, new Time(-125)
            };
            try
            {
                Array.Sort(times);
            }
            catch(InvalidOperationException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }

            UsingGenerics.Range<Time> r = new UsingGenerics.Range<Time>(new Time(8, 30), new Time(17, 30));
            Console.WriteLine(r.IsIncluded(new Time(9,30)));

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
            time1 = new Time(4, 50);
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
            // Time -> float
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
            Console.WriteLine($"(Time->int)      {time1} = {intValue}");
            time1 = new Time(2, 30);
            intValue = (int)time1;
            Console.WriteLine($"(Time->int)      {time1} = {intValue}");

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
            Console.WriteLine($"(Time<=Time)     {time1} <= {time2} = {resultcomparison}");
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 <= time2;
            Console.WriteLine($"(Time<=Time)     {time1} <= {time2} = {resultcomparison}");
            time1 = new Time(3, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 <= time2;
            Console.WriteLine($"(Time<=Time)     {time1} <= {time2} = {resultcomparison}");

            // Time >= Time
            time1 = new Time(4, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)     {time1} >= {time2} = {resultcomparison}");
            time1 = new Time(2, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)     {time1} >= {time2} = {resultcomparison}");
            time1 = new Time(3, 15);
            time2 = new Time(3, 15);
            resultcomparison = time1 >= time2;
            Console.WriteLine($"(Time>=Time)     {time1} >= {time2} = {resultcomparison}");
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
