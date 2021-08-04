using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectFractionBLL;
using System;

namespace ProjectUnitTestFactions
{
    /// <summary>
    /// Tests Unit Class
    /// </summary>
    [TestClass]
    public class UnitTestFraction
    {
        /// <summary>
        /// Check Fraction Constructor String
        /// </summary>
        /// <param name="pFractions1">Fraction</param>
        /// <param name="pNumerator">Result Numerator</param>
        /// <param name="pDenominator">Result Denominator</param>
        [TestMethod]
        [DataRow("4/15", 4, 15, DisplayName = "Constructor string 4/15 = 4/15")]
        public void TestMethodConstructorString(string pFractions1, long pNumerator, long pDenominator)
        {
            Fraction fraction;
            fraction = new Fraction(pFractions1);
            Assert.AreEqual(pNumerator, fraction.Numerator);
            Assert.AreEqual(pDenominator, fraction.Denominator);
        }
        /// <summary>
        /// Check Fraction Constructor long long
        /// </summary>
        /// <param name="pNumerator">Numerator</param>
        /// <param name="pDenominator">Denominator</param>
        /// <param name="pNumerator">Result Numerator</param>
        /// <param name="pDenominator">Result Denominator</param>
        [TestMethod]
        [DataRow(4, 15, 4, 15, DisplayName = "Constructor 2ParametersLong 4/15 = 4/15")]
        public void TestMethodConstructor2ParametersLong(long pNumerator, long pDenominator, long pResultNumerator, long pResultDenominator)
        {
            Fraction fraction;
            fraction = new Fraction(pNumerator, pDenominator);
            Assert.AreEqual(pResultNumerator, fraction.Numerator);
            Assert.AreEqual(pResultDenominator, fraction.Denominator);
        }
        /// <summary>
        /// Check Fraction Constructor long
        /// </summary>
        /// <param name="pNumber">Numerator</param>
        /// <param name="pNumerator">Result Numerator</param>
        /// <param name="pDenominator">Result Denominator</param>
        [TestMethod]
        [DataRow(4, 4, 1, DisplayName = "Constructor 1ParametersLong 4 = 4/1")]
        public void TestMethodConstructor1ParametersLong(long pNumber, long pResultNumerator, long pResultDenominator)
        {
            Fraction fraction;
            fraction = new Fraction(pNumber, 1);
            Assert.AreEqual(pResultNumerator, fraction.Numerator);
            Assert.AreEqual(pResultDenominator, fraction.Denominator);
        }
        /// <summary>
        /// Check Addition Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", "2 11/30", DisplayName = "4/15 + 21/10 = 71/30 -> 2 11/30")]
        [DataRow("-4/15", "21/10", "1 5/6", DisplayName = "-4/15 + 21/10 = 11/6 -> 1 5/6")]
        [DataRow("-4/-15", "21/10", "2 11/30", DisplayName = "-4/-15 + 21/10 = 71/30 -> 2 11/30")]
        [DataRow("-4/15", "-21/10", "-71/30", DisplayName = "-4/-15 + -21/10 = -71/30")]
        [DataRow("4/0", "21/10", "", DisplayName = "4/0 + 21/10 = Denominator cannot be 0")]
        [DataRow("4/15", "21/0", "", DisplayName = "4/15 + 21/0 = Denominator cannot be 0")]
        [DataRow("A/15", "21/10", "", DisplayName = "A/15 + 21/10 = Input string was not in a correct format.")]
        [DataRow("4/B", "21/10", "", DisplayName = "4/B + 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "A/10", "", DisplayName = "4/15 + A/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21/B", "", DisplayName = "4/15 + 21/B = Input string was not in a correct format.")]
        [DataRow("A/B", "C/D", "", DisplayName = "A/B + C/D = Input string was not in a correct format.")]
        [DataRow("4 15", "21/10", "", DisplayName = "4 15 + 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21 10", "", DisplayName = "4/15 + 21 0 = Input string was not in a correct format.")]
        [DataRow("4 15", "21 10", "", DisplayName = "4 15 + 21 10 = Input string was not in a correct format.")]
        [DataRow("415", "2110", "", DisplayName = "415 + 2110 = Index was outside the bounds of the array.")]
        [DataRow("", "21/10", "", DisplayName = "null + 21/10 = Index was outside the bounds of the array.")]
        [DataRow("4/15", "", "", DisplayName = "4/15 + null = Index was outside the bounds of the array.")]
        [DataRow("", "", "", DisplayName = "null + null = Index was outside the bounds of the array.")]
        public void TestMethodAdd2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {
            try
            { 
            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a + b).ToString();
            Assert.AreEqual(pExpectedValue, result);
            }
            catch (Exception ex) 
            {
                if (ex.Message == "Denominator cannot be 0") Assert.AreEqual("Denominator cannot be 0", ex.Message);
                else if (ex.Message == "Input string was not in a correct format.") Assert.AreEqual("Input string was not in a correct format.", ex.Message);
                else if (ex.Message == "Index was outside the bounds of the array.") Assert.AreEqual("Index was outside the bounds of the array.", ex.Message);
                else Assert.Fail();
            }
        }
        /// <summary>
        /// Check Substraction Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", "-11/6", DisplayName = "4/15 - 21/10 = -11/6")]
        [DataRow("-4/15", "21/10", "-71/30", DisplayName = "-4/15 - 21/10 = -71/30")]
        [DataRow("-4/-15", "21/10", "-11/6", DisplayName = "-4/-15 - 21/10 = -11/6")]
        [DataRow("-4/15", "-21/10", "1 5/6", DisplayName = "-4/-15 - -21/10 = 11/6 -> 1 5/6")]
        [DataRow("4/0", "21/10", "", DisplayName = "4/0 - 21/10 = Denominator cannot be 0")]
        [DataRow("4/15", "21/0", "", DisplayName = "4/15 - 21/0 = Denominator cannot be 0")]
        [DataRow("A/15", "21/10", "", DisplayName = "A/15 - 21/10 = Input string was not in a correct format.")]
        [DataRow("4/B", "21/10", "", DisplayName = "4/B - 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "A/10", "", DisplayName = "4/15 - A/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21/B", "", DisplayName = "4/15 - 21/B = Input string was not in a correct format.")]
        [DataRow("A/B", "C/D", "", DisplayName = "A/B - C/D = Input string was not in a correct format.")]
        [DataRow("4 15", "21/10", "", DisplayName = "4 15 - 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21 10", "", DisplayName = "4/15 - 21 0 = Input string was not in a correct format.")]
        [DataRow("4 15", "21 10", "", DisplayName = "4 15 - 21 10 = Input string was not in a correct format.")]
        [DataRow("415", "2110", "", DisplayName = "415 - 2110 = Index was outside the bounds of the array.")]
        [DataRow("", "21/10", "", DisplayName = "null - 21/10 = Index was outside the bounds of the array.")]
        [DataRow("4/15", "", "", DisplayName = "4/15 - null = Index was outside the bounds of the array.")]
        [DataRow("", "", "", DisplayName = "null - null = Index was outside the bounds of the array.")]
        public void TestMethodSub2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {
            try
            {
            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a - b).ToString();
            Assert.AreEqual(pExpectedValue, result);
            }
            catch (Exception ex) 
            {
                if (ex.Message == "Denominator cannot be 0") Assert.AreEqual("Denominator cannot be 0", ex.Message);
                else if (ex.Message == "Input string was not in a correct format.") Assert.AreEqual("Input string was not in a correct format.", ex.Message);
                else if (ex.Message == "Index was outside the bounds of the array.") Assert.AreEqual("Index was outside the bounds of the array.", ex.Message);
                else Assert.Fail();
            }
        }
        /// <summary>
        /// Check Multiplication Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", "14/25", DisplayName = "4/15 * 21/10 = 14/25")]
        [DataRow("-4/15", "21/10", "-14/25", DisplayName = "-4/15 * 21/10 = -14/25")]
        [DataRow("-4/-15", "21/10", "14/25", DisplayName = "-4/-15 * 21/10 = 14/25")]
        [DataRow("-4/15", "-21/10", "14/25", DisplayName = "-4/-15 * -21/10 = 14/25")]
        [DataRow("4/0", "21/10", "", DisplayName = "4/0 * 21/10 = Denominator cannot be 0")]
        [DataRow("4/15", "21/0", "", DisplayName = "4/15 * 21/0 = Denominator cannot be 0")]
        [DataRow("A/15", "21/10", "", DisplayName = "A/15 * 21/10 = Input string was not in a correct format.")]
        [DataRow("4/B", "21/10", "", DisplayName = "4/B * 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "A/10", "", DisplayName = "4/15 * A/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21/B", "", DisplayName = "4/15 * 21/B = Input string was not in a correct format.")]
        [DataRow("A/B", "C/D", "", DisplayName = "A/B * C/D = Input string was not in a correct format.")]
        [DataRow("4 15", "21/10", "", DisplayName = "4 15 * 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21 10", "", DisplayName = "4/15 * 21 0 = Input string was not in a correct format.")]
        [DataRow("4 15", "21 10", "", DisplayName = "4 15 * 21 10 = Input string was not in a correct format.")]
        [DataRow("415", "2110", "", DisplayName = "415 * 2110 = Index was outside the bounds of the array.")]
        [DataRow("", "21/10", "", DisplayName = "null * 21/10 = Index was outside the bounds of the array.")]
        [DataRow("4/15", "", "", DisplayName = "4/15 * null = Index was outside the bounds of the array.")]
        [DataRow("", "", "", DisplayName = "null * null = Index was outside the bounds of the array.")]
        public void TestMethodMul2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {
            try
            {
            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a * b).ToString();
            Assert.AreEqual(pExpectedValue, result);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Denominator cannot be 0") Assert.AreEqual("Denominator cannot be 0", ex.Message);
                else if (ex.Message == "Input string was not in a correct format.") Assert.AreEqual("Input string was not in a correct format.", ex.Message);
                else if (ex.Message == "Index was outside the bounds of the array.") Assert.AreEqual("Index was outside the bounds of the array.", ex.Message);
                else Assert.Fail();
            }
        }
        /// <summary>
        /// Check Division Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", "8/63", DisplayName = "4/15 / 21/10 = 8/63")]
        [DataRow("-4/15", "21/10", "-8/63", DisplayName = "-4/15 / 21/10 = -8/63")]
        [DataRow("-4/-15", "21/10", "8/63", DisplayName = "-4/-15 / 21/10 = 8/63")]
        [DataRow("-4/15", "-21/10", "8/63", DisplayName = "-4/-15 / -21/10 = 8/63")]
        [DataRow("4/0", "21/10", "", DisplayName = "4/0 / 21/10 = Denominator cannot be 0")]
        [DataRow("4/15", "21/0", "", DisplayName = "4/15 / 21/0 = Denominator cannot be 0")]
        [DataRow("A/15", "21/10", "", DisplayName = "A/15 / 21/10 = Input string was not in a correct format.")]
        [DataRow("4/B", "21/10", "", DisplayName = "4/B / 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "A/10", "", DisplayName = "4/15 / A/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21/B", "", DisplayName = "4/15 / 21/B = Input string was not in a correct format.")]
        [DataRow("A/B", "C/D", "", DisplayName = "A/B / C/D = Input string was not in a correct format.")]
        [DataRow("4 15", "21/10", "", DisplayName = "4 15 / 21/10 = Input string was not in a correct format.")]
        [DataRow("4/15", "21 10", "", DisplayName = "4/15 / 21 0 = Input string was not in a correct format.")]
        [DataRow("4 15", "21 10", "", DisplayName = "4 15 / 21 10 = Input string was not in a correct format.")]
        [DataRow("415", "2110", "", DisplayName = "415 / 2110 = Index was outside the bounds of the array.")]
        [DataRow("", "21/10", "", DisplayName = "null / 21/10 = Index was outside the bounds of the array.")]
        [DataRow("4/15", "", "", DisplayName = "4/15 / null = Index was outside the bounds of the array.")]
        [DataRow("", "", "", DisplayName = "null / null = Index was outside the bounds of the array.")]
        public void TestMethodDiv2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {
            try
            {
            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a / b).ToString();
            Assert.AreEqual(pExpectedValue, result);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Denominator cannot be 0") Assert.AreEqual("Denominator cannot be 0", ex.Message);
                else if (ex.Message == "Input string was not in a correct format.") Assert.AreEqual("Input string was not in a correct format.", ex.Message);
                else if (ex.Message == "Index was outside the bounds of the array.") Assert.AreEqual("Index was outside the bounds of the array.", ex.Message);
                else Assert.Fail();
            }
        }
        /// <summary>
        /// Check Comparaison < Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", true, DisplayName = "4/15 < 21/10 = true")]
        [DataRow("21/10", "4/15", false, DisplayName = "21/10 < 4/15 = false")]
        public void TestMethodSmallerFractions(string pFractions1, string pFractions2, bool pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            bool result = a < b;
            Assert.AreEqual(pExpectedValue, result);
        }
        /// <summary>
        /// Check Comparaison > Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "21/10", false, DisplayName = "4/15 > 21/10 = false")]
        [DataRow("21/10", "4/15", true, DisplayName = "21/10 > 4/15 = true")]
        public void TestMethodBiggerFractions(string pFractions1, string pFractions2, bool pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            bool result = a > b;
            Assert.AreEqual(pExpectedValue, result);
        }
        /// <summary>
        /// Check Comparaison = Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "4/15", true, DisplayName = "4/15 = 4/15 = true")]
        [DataRow("4/15", "21/10", false, DisplayName = "4/15 = 21/10 = false")]
        public void TestMethodEqual2Fractions(string pFractions1, string pFractions2, bool pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            bool result = a == b;
            Assert.AreEqual(pExpectedValue, result);
        }
        /// <summary>
        /// Check Comparaison != Of 2 Fractions
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pFractions2">Fractions2</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "4/15", false, DisplayName = "4/15 = 4/15 = false")]
        [DataRow("4/15", "21/10", true, DisplayName = "4/15 = 21/10 = true")]
        public void TestMethodDiff2Fractions(string pFractions1, string pFractions2, bool pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            bool result = a != b;
            Assert.AreEqual(pExpectedValue, result);
        }
        /// <summary>
        /// Check Conversion Decimal To Fraction
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("4/15", "0,26", DisplayName = "Fraction 4/15 To Decimal = 0,26")]
        public void TestMethodConversionFractionToDecimal(string pFractions1, string pExpectedValue)
        {
            Fraction a = new Fraction(pFractions1);
            decimal result = ((decimal) a);
            string  resultstring = result.ToString();
            resultstring = resultstring.Substring(0, 4);
            Assert.AreEqual(pExpectedValue, resultstring);
        }
        /// <summary>
        /// Check Conversion Fraction To Decimal
        /// </summary>
        /// <param name="pFractions1">Fractions1</param>
        /// <param name="pExpectedValue">Result</param>
        [TestMethod]
        [DataRow("1.3125", "13125 0/1", DisplayName = "Decimal 1.3125 To Fraction = 13125/1 -> 13125 0/1")]
        public void TestMethodConversionDecimalToFraction(string pNumber, string pExpectedValue)
        {
            decimal convertDecimal = Convert.ToDecimal(pNumber);
            Fraction result = ((Fraction)convertDecimal);
            string resultstring = result.ToString();
            Assert.AreEqual(pExpectedValue, resultstring);
        }
    }
}
