using System;
using System.Numerics;

namespace ProjectMathematiqueBLL
{
    public class Factorial
    {
        public static BigInteger Calculate(int pNombre)
        {
            if (pNombre <= 1)
            {
                return 1;
            }
            else
            {
                BigInteger accumulateur = 1;
                for (int valeurCourante = 2; valeurCourante <= pNombre; valeurCourante++)
                {
                    accumulateur = accumulateur * valeurCourante;
                }
                return accumulateur;
            }          
        }

        public static BigInteger CalculateRecursiv(int number)
        {
            // Pout tout entier n >0, n! = (n - 1)! * n
            /*if (number > 0)
            {
                return CalculateRecursiv(number - 1) * number;
            }
            else
            {
                return 1;
            }*/
            return (number > 0) ? CalculateRecursiv(number - 1) * number : 1;
        }
    }
}