using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectFractionBLL;

namespace ProjectUnitTestFactions
{
    [TestClass]
    public class UnitTestFraction
    {
        [TestMethod]
        [DataRow("4/15", "21/10", "71/30", DisplayName = "4/15 + 21/10 = 71/30")]
        public void TestMethodAdd2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {
 
            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a + b).ToString();
            Assert.AreEqual(pExpectedValue, result);
        }
        [TestMethod]
        [DataRow("4/15", "21/10", "-11/6", DisplayName = "4/15 - 21/10 = -11/6")]
        public void TestMethodSub2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a - b).ToString();
            Assert.AreEqual(pExpectedValue, result);
        }
        [TestMethod]
        [DataRow("4/15", "21/10", "14/25", DisplayName = "4/15 * 21/10 = 14/25")]
        public void TestMethodMul2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a * b).ToString();
            Assert.AreEqual(pExpectedValue, result);
        }
        [TestMethod]
        [DataRow("4/15", "21/10", "8/63", DisplayName = "4/15 / 21/10 = 8/63")]
        public void TestMethodDiv2Fractions(string pFractions1, string pFractions2, string pExpectedValue)
        {

            Fraction a = new Fraction(pFractions1);
            Fraction b = new Fraction(pFractions2);
            string result = (a / b).ToString();
            Assert.AreEqual(pExpectedValue, result);
        }
    }
}
