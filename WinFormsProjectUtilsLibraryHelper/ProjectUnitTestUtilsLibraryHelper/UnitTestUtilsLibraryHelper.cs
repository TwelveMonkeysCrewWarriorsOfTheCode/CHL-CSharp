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
    }
}
