using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectUtilsLibraryHelper;

namespace ProjectUnitTestUtilsLibraryHelper
{
    [TestClass]
    public class UnitTestUtilsLibraryHelper
    {
        /// <summary>
        /// Test remove all spaces from string
        /// </summary>
        /// <param name="pText">Strint to remove spaces</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow(" Le rouge est mieux que le blanc ", true, DisplayName = "Test remove all spaces from string")]
        public void TestRemoveAllSpaceFromString(string pText, bool pExpectedValue)
        {
            string textresult = UtilsStringsHelper.RemoveAllSpaceFromString(pText);
            if (textresult == "Lerougeestmieuxqueleblanc")
            {
                Assert.AreEqual(pExpectedValue, true);
            }
            else
            {
                Assert.AreEqual(pExpectedValue, false);
            }
        }

        /// <summary>
        /// Test Addition of 2 times
        /// </summary>
        [TestMethod]
        public void TestAdd2Times()
        {
            UtilsDateTimeHelper time1, time2, timeResult;

            time1 = new UtilsDateTimeHelper(2, 43, 57);
            time2 = new UtilsDateTimeHelper(3, 25);
            timeResult = time1 + time2;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 06:08:57", sResult);
        }

        /// <summary>
        /// Test Substraction of 2 times with positive result
        /// </summary>
        [TestMethod]
        public void TestSub2TimesPositive()
        {
            UtilsDateTimeHelper time1, time2, timeResult;

            time1 = new UtilsDateTimeHelper(4, 50, 12);
            time2 = new UtilsDateTimeHelper(3, 25, 45);
            timeResult = time1 - time2;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 01:24:27", sResult);
        }

        /// <summary>
        /// Test Substraction of 2 times with negative result
        /// </summary>
        [TestMethod]
        public void TestSub2TimesNegative()
        {
            UtilsDateTimeHelper time1, time2, timeResult;

            time1 = new UtilsDateTimeHelper(3, 25, 02);
            time2 = new UtilsDateTimeHelper(4, 50, 12);
            timeResult = time1 - time2;
            string sResult = timeResult.ToString();
            Assert.AreEqual("-01:25:10", sResult);
        }

        /// <summary>
        /// Test Multiplication of 1 time by a multiplicator
        /// </summary>
        [TestMethod]
        public void TestMulTimesByMultiplicator()
        {
            UtilsDateTimeHelper time1, time2, timeResult;
            int multiplicator = 3;

            time1 = new UtilsDateTimeHelper(3, 25, 32);
            timeResult = time1 * multiplicator;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 10:16:36", sResult);
        }

        /// <summary>
        /// Test Division of 1 time by a divisor
        /// </summary>
        [TestMethod]
        public void TestDivTimesByDivisor()
        {
            UtilsDateTimeHelper time1, time2, timeResult;
            int divisor = 3;

            time1 = new UtilsDateTimeHelper(10, 15, 07);
            timeResult = time1 / divisor;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 03:25:02", sResult);
        }

        /// <summary>
        /// Test Conversion float to time
        /// </summary>
        [TestMethod]
        public void TestConvFloatToTime()
        {
            UtilsDateTimeHelper timeResult;
            float floatValue = 2.57f;

            timeResult = (UtilsDateTimeHelper)floatValue;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 02:34:12", sResult);
        }

        /// <summary>
        /// Test Conversion time to float
        /// </summary>
        [TestMethod]
        public void TestConvTimeToFloat()
        {
            UtilsDateTimeHelper time1;
            float floatValue;

            time1 = new UtilsDateTimeHelper(2, 34, 12);
            floatValue = (float)time1;
            Assert.AreEqual(2.57f, floatValue);
        }

        /// <summary>
        /// Test Conversion int to time
        /// </summary>
        [TestMethod]
        public void TestConvIntToTime()
        {
            UtilsDateTimeHelper timeResult;
            int intValue = 9012;

            timeResult = (UtilsDateTimeHelper)intValue;
            string sResult = timeResult.ToString();
            Assert.AreEqual(" 02:30:12", sResult);
        }

        /// <summary>
        /// Test Conversion time to int
        /// </summary>
        [TestMethod]
        public void TestConvTimeToInt()
        {
            UtilsDateTimeHelper time1;
            int intValue;

            time1 = new UtilsDateTimeHelper(2, 30, 12);
            intValue = (int)time1;
            Assert.AreEqual(9012, intValue);
        }

        /// <summary>
        /// Test Comparaison < of 2 times true
        /// </summary>
        [TestMethod]
        public void TestComp2TimesLessThanTrue()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(2, 15, 44);
            time2 = new UtilsDateTimeHelper(2, 15, 45);
            resultcomparison = time1 < time2;
            Assert.AreEqual(true, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison < of 2 times false
        /// </summary>
        [TestMethod]
        public void TestComp2TimesLessThanFalse()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(4, 15, 37);
            time2 = new UtilsDateTimeHelper(3, 15, 12);
            resultcomparison = time1 < time2;
            Assert.AreEqual(false, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison > of 2 times true
        /// </summary>
        [TestMethod]
        public void TestComp2TimesGreaterThanTrue()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(3, 15, 45);
            time2 = new UtilsDateTimeHelper(3, 15, 44);
            resultcomparison = time1 > time2;
            Assert.AreEqual(true, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison > of 2 times false
        /// </summary>
        [TestMethod]
        public void TestComp2TimesGreaterThanFalse()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(2, 15, 12);
            time2 = new UtilsDateTimeHelper(3, 15, 08);
            resultcomparison = time1 > time2;
            Assert.AreEqual(false, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison <= of 2 times true
        /// </summary>
        [TestMethod]
        public void TestComp2TimesLessThanEqualTrue()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(2, 15, 44);
            time2 = new UtilsDateTimeHelper(2, 15, 45);
            resultcomparison = time1 <= time2;
            Assert.AreEqual(true, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison <= of 2 times false
        /// </summary>
        [TestMethod]
        public void TestComp2TimesLessThanEqualFalse()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(4, 15, 32);
            time2 = new UtilsDateTimeHelper(3, 15, 14);
            resultcomparison = time1 <= time2;
            Assert.AreEqual(false, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison <= of 2 times true equal
        /// </summary>
        [TestMethod]
        public void TestComp2TimesLessThanEqualTrueEqual()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(3, 15, 12);
            time2 = new UtilsDateTimeHelper(3, 15, 12);
            resultcomparison = time1 <= time2;
            Assert.AreEqual(true, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison >= of 2 times true
        /// </summary>
        [TestMethod]
        public void TestComp2TimesGreaterThanEqualTrue()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(4, 15, 12);
            time2 = new UtilsDateTimeHelper(4, 15, 11);
            resultcomparison = time1 >= time2;
            Assert.AreEqual(true, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison >= of 2 times false
        /// </summary>
        [TestMethod]
        public void TestComp2TimesGreaterThanEqualFalse()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(3, 15, 11);
            time2 = new UtilsDateTimeHelper(3, 15, 12);
            resultcomparison = time1 >= time2;
            Assert.AreEqual(false, resultcomparison);
        }

        /// <summary>
        /// Test Comparaison >= of 2 times true equal
        /// </summary>
        [TestMethod]
        public void TestComp2TimesGreaterThanEqualTrueEqual()
        {
            UtilsDateTimeHelper time1, time2;
            bool resultcomparison;

            time1 = new UtilsDateTimeHelper(3, 15, 12);
            time2 = new UtilsDateTimeHelper(3, 15, 12);
            resultcomparison = time1 >= time2;
            Assert.AreEqual(true, resultcomparison);
        }
    }
}
