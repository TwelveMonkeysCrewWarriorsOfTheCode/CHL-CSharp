using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ProjectFractionBLL
{
    /// <summary>
    /// Class To Manage Fractions
    /// </summary>
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
        /// <summary>
        /// Constructor To Build a Fraction From A String Numerator/Denominator
        /// </summary>
        /// <param name="pFraction"></param>
        public Fraction(string pFraction)
        {
            string[] fractionElements = pFraction.Split('/');
            Numerator = long.Parse(fractionElements[0]);
            Denominator = long.Parse(fractionElements[1]);
            Simplify();
        }
        /// <summary>
        /// Constructor To Build a Fraction From Long Numerator And Denominator
        /// </summary>
        /// <param name="pNumerator">Numerator</param>
        /// <param name="pDenominator">Denominator</param>
        public Fraction(long pNumerator, long pDenominator)
        {
            Numerator = pNumerator;
            Denominator = pDenominator;
            Simplify();
        }
        /// <summary>
        /// Constructor To Build a Fraction From Long Number
        /// </summary>
        /// <param name="pNumerator">Number</param>
        public Fraction(long pNumber)
        {
            Numerator = pNumber;
            Denominator = 1;
            Simplify();
        }
        #endregion

        #region Operators
        /// <summary>
        /// Overload Operator + For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
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
        /// <summary>
        /// Overload Operator - For Fraction (Negative)
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static Fraction operator -(Fraction pFraction1)
        {
            return new Fraction(-pFraction1.Numerator, pFraction1.Denominator);
        }
        /// <summary>
        /// Overload Operator - For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static Fraction operator -(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1 + -pFraction2;
        }
        /// <summary>
        /// Overload Operator * For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static Fraction operator *(Fraction pFraction1, Fraction pFraction2)
        {
            // Swap numerators and denominators to simplify.
            Fraction result1 = new Fraction(pFraction1.Numerator, pFraction2.Denominator);
            Fraction result2 = new Fraction(pFraction2.Numerator, pFraction1.Denominator);

            return new Fraction(
                result1.Numerator * result2.Numerator,
                result1.Denominator * result2.Denominator);
        }
        /// <summary>
        /// Overload Operator / For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static Fraction operator /(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1 * new Fraction(pFraction2.Denominator, pFraction2.Numerator);
        }
        /// <summary>
        /// Overload Compare < For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static bool operator <(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1.Numerator * pFraction2.Denominator < pFraction1.Denominator * pFraction2.Numerator;
        }
        /// <summary>
        /// Overload Compare > For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static bool operator >(Fraction pFraction1, Fraction pFraction2)
        {
            return pFraction1.Numerator * pFraction2.Denominator > pFraction1.Denominator * pFraction2.Numerator;
        }
        /// <summary>
        /// Overload Compare = For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static bool operator ==(Fraction pFraction1, Fraction pFraction2)
        {

            return (pFraction1.Numerator == pFraction2.Numerator && pFraction1.Denominator == pFraction2.Denominator);
            //return EqualityComparer<Fraction>.Default.Equals(pFraction1, pFraction2);
        }
        /// <summary>
        /// Overload Compare != For Fraction
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <param name="pFraction2">Fraction1</param>
        /// <returns>Return Fraction</returns>
        public static bool operator !=(Fraction pFraction1, Fraction pFraction2)
        {
            return !(pFraction1 == pFraction2);
        }
        /// <summary>
        /// Overload Compare != For Fraction
        /// </summary>
        /// <param name="pFraction">Fraction</param>
        /// <returns>Return Result</returns>
        public override bool Equals(object other) => this.Equals(other as Fraction);
        /// <summary>
        /// Overload GetHashCode For Fraction
        /// </summary>
        /// <returns>Return HashCode</returns>
        public override int GetHashCode() => (int)this;
        /// <summary>
        /// Equals For Fraction
        /// </summary>
        /// <returns>Return Result</returns>
        public bool Equals(Fraction other) => (other != null) && (int)this == (int)other;
        /// <summary>
        /// CompareTo For Fraction
        /// </summary>
        /// <returns>Return Result</returns>
        public int CompareTo([AllowNull] Fraction other) => (other == null) ? 1 : (int)this - (int)other;
        /// <summary>
        /// Overload Conversion A Fraction To Decimal
        /// </summary>
        /// <param name="pFraction1">Fraction1</param>
        /// <returns>Return Decimal</returns>
        public static implicit operator decimal(Fraction pFraction1)
        {
            return (decimal)pFraction1.Numerator / pFraction1.Denominator;
        }
        /// <summary>
        /// Overload Conversion A Decimal To Fraction
        /// </summary>
        /// <param name="pNumber">Fraction1</param>
        /// <returns>Return Fraction</returns>
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
        /// <summary>
        /// Simplify The Fraction
        /// </summary>
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
        /// <summary>
        /// Get The Greatest Common Divisor (GCD)
        /// </summary>
        /// <param name="pDenominator1">Denominator1</param>
        /// <param name="pDenominator2">Denominator2</param>
        /// <returns>Return Greatest Common Divisor</returns>
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
        /// <summary>
        /// Get The Least Common Multiple Of pA And pB
        /// </summary>
        /// <param name="pA">Number1</param>
        /// <param name="pB">Number2</param>
        /// <returns>Return Least Common Multiple</returns>
        private static long LeastCommonMultiple(long pA, long pB)
        {
            long greatestCommonDivisor = GetGreatestCommonDivisor(pA, pB);
            return ((pA / greatestCommonDivisor) * (pB / greatestCommonDivisor)) * greatestCommonDivisor;
        }
        #endregion

        #region Public Methods
        // Return the fraction's value as a string.
        /*public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }*/
        /// <summary>
        /// Overload Of ToString For Fraction
        /// </summary>
        /// <returns>Return Result</returns>
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
        /// <returns>Return List</returns>
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
