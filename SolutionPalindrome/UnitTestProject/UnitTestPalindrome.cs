using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPalindromeBLL;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPalindrome
    {
        [TestMethod]
        [DataRow("radar", true, DisplayName = "radar est un palindrome")]
        [DataRow("palindrome", false, DisplayName = "palindrome n'est pas un palindrome !!!")]
        public void TestMethodPalindrome(string ptesttexte, bool pExpectedValue)
        {
            bool result = Palindrome.IsPalindrome(ptesttexte);
            Assert.AreEqual(pExpectedValue, result);
        }
    }
}
