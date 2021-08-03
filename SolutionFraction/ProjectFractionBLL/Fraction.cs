using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectFractionBLL
{
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        const int VAL1 = 1;
        #region Properties
        private long m_numerator;
        private long m_denominator;
        public long Numerator
        {
            get => m_numerator;
            set => m_numerator = value;
        }
        public long Denominator
        {
            get
            {
                return this.m_denominator;
            }
            set
            {
                if (value == 0) throw new ArgumentException("Denominator cannot be 0");
                this.m_denominator = value;
            }
        }
        #endregion

        #region Constructors
        // Initialize the fraction from a string numerator/denominator
        public Fraction(string pFraction)
        {
            string[] fractionElements = pFraction.Split('/');
            Numerator = long.Parse(fractionElements[0]);
            Denominator = long.Parse(fractionElements[1]);
            Simplify();
        }
        // Initialize the fraction from long numerator and denominator.
        public Fraction(long pNumerator, long pDenominator)
        {
            Numerator = pNumerator;
            Denominator = pDenominator;
            Simplify();
        }
        // Initialize the fraction from a long
        public Fraction(long pNumber)
        {
            Numerator = pNumber;
            Denominator = 1;
            Simplify();
        }
        #endregion

        #region Operators
        // Return fraction1 + fraction2
        public static Fraction operator +(Fraction pFraction1, Fraction pFraction2)
        {
            // Get the denominators' greatest common divisor.
            long greatestCommonDivisor = GetGreatestCommonDivisor(pFraction1.Denominator, pFraction2.Denominator);

            long numererator =
                pFraction1.Numerator * (pFraction2.Denominator / greatestCommonDivisor) +
                pFraction2.Numerator * (pFraction1.Denominator / greatestCommonDivisor);
            long denominator =
                pFraction1.Denominator * (pFraction2.Denominator / greatestCommonDivisor);
            return new Fraction(numererator, denominator);
        }
        // Return -Fraction1
        public static Fraction operator -(Fraction pFraction1)
        {
            return new Fraction(-pFraction1.Numerator, pFraction1.Denominator);
        }
        // Return Fraction1 - Fraction2
        public static Fraction operator -(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1 + -pFraction2;
        }
        // Return Fraction1 * Fraction2
        public static Fraction operator *(Fraction pFraction1, Fraction pFraction2)
        {
            // Swap numerators and denominators to simplify.
            Fraction result1 = new Fraction(pFraction1.Numerator, pFraction2.Denominator);
            Fraction result2 = new Fraction(pFraction2.Numerator, pFraction1.Denominator);

            return new Fraction(
                result1.Numerator * result2.Numerator,
                result1.Denominator * result2.Denominator);
        }
        // Return Fraction1 / Fraction2
        public static Fraction operator /(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1 * new Fraction(pFraction2.Denominator, pFraction2.Numerator);
        }
        // Compare 2 fractions <
        public static bool operator <(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1.Numerator * pFraction2.Denominator < pFraction1.Denominator * pFraction2.Numerator;
        }
        // Compare 2 fractions >
        public static bool operator >(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1.Numerator * pFraction2.Denominator > pFraction1.Denominator * pFraction2.Numerator;
        }
        public static bool operator ==(Fraction pFraction1, Fraction pFraction2)
        {

            return (pFraction1.Numerator == pFraction2.Numerator && pFraction1.Denominator == pFraction2.Denominator);
            //return EqualityComparer<Fraction>.Default.Equals(pFraction1, pFraction2);
        }
        public static bool operator !=(Fraction pFraction1, Fraction pFraction2)
        {
            return !(pFraction1 == pFraction2);
        }
        public override bool Equals(object other) => this.Equals(other as Fraction);

        public override int GetHashCode() => (int)this;
        public bool Equals(Fraction other) => (other != null) && (int)this == (int)other;

        public int CompareTo([AllowNull] Fraction other) => (other == null) ? 1 : (int)this - (int)other;

        // Convert a fraction to a decimal
        public static implicit operator decimal(Fraction pFraction1)
        {
            return (decimal)pFraction1.Numerator / pFraction1.Denominator;
        }
        // Convert a decimal to a fraction
        public static implicit operator Fraction(decimal pNumber)
        {
            decimal accuracy = 4;
            int sign = pNumber < 0 ? -1 : 1;
            pNumber = pNumber < 0 ? -pNumber : pNumber;
            int integerpart = (int)pNumber;
            pNumber -= integerpart;
            decimal minimalvalue = pNumber - accuracy;
            if (minimalvalue < (decimal)0.0) return new Fraction(sign * integerpart, 1);
            decimal maximumvalue = pNumber + accuracy;
            if (maximumvalue > (decimal)1.0) return new Fraction(sign * (integerpart + 1), 1);
            int a = 0;
            int b = 1;
            int c = 1;
            int d = (int)(1 / maximumvalue);
            while (true)
                {
                    int n = (int)((b * minimalvalue - a) / (c - d * minimalvalue));
                    if (n == 0) break;
                    a += n * c;
                    b += n * d;
                    n = (int)((c - d * maximumvalue) / (b * maximumvalue - a));
                    if (n == 0) break;
                    c += n * a;
                    d += n * b;
                }
            int denominator = b + d;
            return new Fraction(sign * (integerpart * denominator + (a + c)), denominator);           
        }
        #endregion

        #region Private Methods
        // Simplify the fraction.
        private void Simplify()
        {
            // Simplify the sign.
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }

            // Factor out the greatest common divisor of the numerator and the denominator
            long greatestCommonDivisor = GetGreatestCommonDivisor(Numerator, Denominator);
            Numerator = Numerator / greatestCommonDivisor;
            Denominator = Denominator / greatestCommonDivisor;
        }
        // Return the greatest common divisor (GCD) of denominator1 and denominator1
        private static long GetGreatestCommonDivisor(long pDenominator1, long pDenominator2)
        {
            // Make pDenominator1 >= pDenominator2.
            pDenominator1 = Math.Abs(pDenominator1);
            pDenominator2 = Math.Abs(pDenominator2);
            if (pDenominator1 < pDenominator2)
            {
                long tmp = pDenominator1;
                pDenominator1 = pDenominator2;
                pDenominator2 = tmp;
            }

            // Pull out remainders.
            for (; ; )
            {
                long remainder = pDenominator1 % pDenominator2;
                if (remainder == 0) return pDenominator2;
                pDenominator1 = pDenominator2;
                pDenominator2 = remainder;
            }
        }
        // Return the least common multiple of a and b.
        private static long LeastCommonMultiple(long a, long b)
        {
            long greatestCommonDivisor = GetGreatestCommonDivisor(a, b);
            return ((a / greatestCommonDivisor) * (b / greatestCommonDivisor)) * greatestCommonDivisor;
        }
        #endregion

        #region Public Methods
        // Return the fraction's value as a string.
        /*public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }*/
        public override string ToString()
        {
            if (Denominator < Numerator)
            {
                long resultlong = Numerator / Denominator;
                long resultrest = Numerator % Denominator;
                return resultlong.ToString() + " " + resultrest.ToString() + "/" + Denominator.ToString();
            }
            else if (Denominator == VAL1)
            {
                return Numerator.ToString();
            }
            else if (Numerator == Denominator)
            {
                return VAL1.ToString();
            }
            else
            { 
                return Numerator.ToString() + "/" + Denominator.ToString();
            }
        }
        /// <summary>
        /// Fill the liste with text
        /// </summary>
        public static List<string> FillListOperator()
        {
            List<string> lstOperator = new List<string>()
            {
               "+",
               "-",
               "*",
               "/"
            };
            return lstOperator;
        }
        #endregion
    }
}
