using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMathematiqueBLL;
using System.Numerics;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestFactorial
    {
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(3, 6)]
        [DataRow(8, 40320)]
        [DataTestMethod]
        public void TestMethodFactorial(int pNumber, long pExpectedValue)
        {
            // Arrangement
            int number = pNumber;
            long expectedValue = pExpectedValue;
            // Action
            BigInteger result = Factorial.Calculate(number);
            // Assert
            Assert.AreEqual(expectedValue, result);
        }
        [DataRow(13, 6227020800)]
        [TestMethod]
        public void TestBugFactorialTreize(int pNumber, long pExpectedValue)
        {
            // Arrangement
            int number = pNumber;
            BigInteger expectedValue = pExpectedValue;
            // Action
            BigInteger result = Factorial.Calculate(number);
            // Assert
            Assert.AreEqual(expectedValue, result);
        }
        //[DataRow(25, 15511210043330985984000000)]
        [TestMethod]
        public void TestBugFactorialVingtCinq() // int pNumber, BigInteger pExpectedValue
        {
            // Arrangement
            //int number = pNumber;
            int number = 25;
            //BigInteger expectedValue = pExpectedValue;
            BigInteger expectedValue = BigInteger.Parse("15511210043330985984000000");
            // Action
            BigInteger result = Factorial.Calculate(number);
            // Assert
            Assert.AreEqual(expectedValue, result);
        }

        [DataRow(0, "1", DisplayName = "Cas particulier : 0!")]
        [DataRow(1, "1", DisplayName = "Cas particulier : 1!")]
        [DataRow(3, "6", DisplayName = "Cas normal : 6")] // Cas normal
        [DataRow(8, "40320", DisplayName = "Cas normal : 40320")] // Cas normal
        [DataTestMethod]
        public void TestMethodFactorialRecursif(int pNumber, string pExpectedValue)
        {
            // Arrangement
            int number = pNumber;
            BigInteger expectedValue = BigInteger.Parse(pExpectedValue);
            // Action
            BigInteger result = Factorial.CalculateRecursiv(number);
            // Assert
            Assert.AreEqual(expectedValue, result);
        }
    }
}
