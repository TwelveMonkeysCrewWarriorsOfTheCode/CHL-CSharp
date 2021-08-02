using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction //: IEquatable<Decimal>, IComparable<Decimal>
    {
        #region Properties
        private long m_numerator;
        private long m_denominator;
        #endregion

        #region Constructors
        // Initialize the fraction from a string numerator/denominator
        public Fraction(string pfraction)
        {
            string[] fractionElements = pfraction.Split('/');
            m_numerator = long.Parse(fractionElements[0]);
            m_denominator = long.Parse(fractionElements[1]);
            Simplify();
        }
        // Initialize the fraction from numerator and denominator.
        public Fraction(long numer, long denom)
        {
            Numerator = numer;
            Denominator = denom;
            Simplify();
        }
        #endregion

        #region Operators
        //public static Time operator +(Time pLeftTime, Time pRightTime) => new Time((int)pLeftTime + (int)pRightTime);
        #endregion


        public long Numerator, Denominator;
        
 
        // Return a + b.
        public static Fraction operator +(Fraction a, Fraction b)
        {
            // Get the denominators' greatest common divisor.
            long gcd_ab = GCD(a.Denominator, b.Denominator);

            long numer =
                a.Numerator * (b.Denominator / gcd_ab) +
                b.Numerator * (a.Denominator / gcd_ab);
            long denom =
                a.Denominator * (b.Denominator / gcd_ab);
            return new Fraction(numer, denom);
        }
        // Simplify the fraction.
        private void Simplify()
        {
            // Simplify the sign.
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }

            // Factor out the greatest common divisor of the
            // numerator and the denominator.
            long gcd_ab = GCD(Numerator, Denominator);
            Numerator = Numerator / gcd_ab;
            Denominator = Denominator / gcd_ab;
        }

        // Return the greatest common divisor (GCD) of a and b.
        public static long GCD(long a, long b)
        {
            // Make a >= b.
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }

            // Pull out remainders.
            for (; ; )
            {
                long remainder = a % b;
                if (remainder == 0) return b;
                a = b;
                b = remainder;
            }
        }

        // Return the least common multiple of a and b.
        public static long LCM(long a, long b)
        {
            long gcd_ab = GCD(a, b);
            return ((a / gcd_ab) * (b / gcd_ab)) * gcd_ab;
        }

        // Return the fraction's value as a string.
        public override string ToString()
        {
            return Numerator.ToString() + "/" + Denominator.ToString();
        }
    }
}
