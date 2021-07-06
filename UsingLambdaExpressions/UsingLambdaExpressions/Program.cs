using System;
using System.Linq;
using System.Collections.Generic;

namespace UsingLambdaExpressions
{
    public delegate double MathDelegate(double value1, double value2);
    public delegate int PowerDelegate(int value1);

    class Program
    {
        static void Main(string[] args)
        {
            // Cas 1 utilisation d'une méthode nommée Add
            // Abonnement
            MathDelegate mathDelegate = Add;
            // Invocation du délégué
            var result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // Cas 2 utilisation d'une méthode non nommée
            // Abonnement
            mathDelegate = delegate(double value1, double value2)
            {
                double diff = value1 - value2;
                return diff;
            };
            // Invocation du délégué
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // Cas 3 utilisation d'une méthode non nommée simplifiée
            // Abonnement
            mathDelegate = (value1, value2) =>
            {
                double diff = value1 * value2;
                return diff;
            };
            // Invocation du délégué
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // Cas 4 utilisation d'une méthode non nommée en tant que lambda expression
            // Abonnement
            mathDelegate = (value1, value2) => value1 / value2;
            // Invocation du délégué
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // Cas 5 utilisation d'une méthode non nommée avec 1 paramètre en tant que lambda expression
            // Abonnement
            PowerDelegate  power = value1 => value1 * value1;
            // Invocation du délégué
            result = power(5);
            Console.WriteLine(result);
            // linq
            int[] num = { 2, 5, 8, 1, 3, 6, 9, 7, 4 };
            foreach (var item in num)
            {
                // IsEven se sera une méthode d'extension
                if (item > 5 && item.IsEven())
                {
                    Console.WriteLine(item);
                }
            }
            // n => n > 5 utilisation d'un lambda en linq
            IEnumerable<int> sequence = num.Where(n => n > 5).OrderBy(n => n);
            Console.WriteLine("---------------Linq");
            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }


        }

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
    }
}
