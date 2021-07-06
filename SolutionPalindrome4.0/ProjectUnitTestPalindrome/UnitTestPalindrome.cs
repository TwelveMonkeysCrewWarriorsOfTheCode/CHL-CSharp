using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPalindromeBLL;
using ProjectPalindromeDAL;
using UtilsLibraryHelper;

namespace ProjectUnitTestPalindrome
{
    /// <summary>
    /// Tests Unit Class
    /// </summary>
    [TestClass]
    public class UnitTestPalindrome
    {
        /// <summary>
        /// Check Palindrome From String
        /// </summary>
        /// <param name="pTestText">String to test palindrome</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow("radar", true, DisplayName = "radar (palindrome)")]
        [DataRow("a", false, DisplayName = "a (pas palindrome)")]
        [DataRow("palindrome", false, DisplayName = "palindrome (pas palindrome)")]
        [DataRow("rotor", true, DisplayName = "rotor (palindrome)")]
        [DataRow("kayak", true, DisplayName = "kayak (palindrome)")]
        [DataRow("�t�", true, DisplayName = "�t� (palindrome)")]
        [DataRow("ici", true, DisplayName = "ici (palindrome)")]
        [DataRow("t�t", true, DisplayName = "t�t (palindrome)")]
        [DataRow("r�ver", true, DisplayName = "r�ver (palindrome)")]
        [DataRow("r�ifier", true, DisplayName = "r�ifier (palindrome)")]
        [DataRow("ressasser", true, DisplayName = "ressasser (palindrome)")]
        [DataRow("La mari�e ira mal", true, DisplayName = "La mari�e ira mal est un palindrome")]
        [DataRow("� r�v�ler mon nom, mon nom rel�vera", true, DisplayName = "� r�v�ler mon nom, mon nom rel�vera (palindrome)")]
        [DataRow("Eh ! �a va, la vache ?", true, DisplayName = "Eh ! �a va, la vache ? (palindrome)")]
        [DataRow("L'ami naturel ? Le rut animal.", true, DisplayName = "L'ami naturel ? Le rut animal. (palindrome)")]
        [DataRow("Ta b�te te bat.", true, DisplayName = "Ta b�te te bat. (palindrome)")]
        [DataRow("Engage le jeu que je le gagne", true, DisplayName = "Engage le jeu que je le gagne (palindrome)")]
        [DataRow("No�l a trop par rapport � L�on", true, DisplayName = "No�l a trop par rapport � L�on (palindrome)")]
        [DataRow("� l'�tape, �pate-la !", true, DisplayName = "� l'�tape, �pate-la ! (palindrome)")]
        [DataRow("La m�re Gide dig�re mal", true, DisplayName = "La m�re Gide dig�re mal (palindrome)")]
        [DataRow("L�on, �mir cornu, d'un roc rime No�l", true, DisplayName = "L�on, �mir cornu, d'un roc rime No�l (palindrome)")]
        [DataRow("�lu par cette crapule", true, DisplayName = "�lu par cette crapule (palindrome)")]
        [DataRow("�sope reste ici et se repose", true, DisplayName = "�sope reste ici et se repose (palindrome)")]
        [DataRow("Luc notre valet alla te laver ton cul", true, DisplayName = "Luc notre valet alla te laver ton cul (palindrome)")]
        [DataRow("T�te l'�tat ! ", true, DisplayName = "T�te l'�tat !  (palindrome)")]
        [DataRow("rue Verlaine gela le g�nial r�veur", true, DisplayName = "rue Verlaine gela le g�nial r�veur (palindrome)")]
        [DataRow("Elle dira h�las � la sale haridelle", true, DisplayName = "Elle dira h�las � la sale haridelle (palindrome)")]
        [DataRow("Et la marine va venir � Malte", true, DisplayName = "Et la marine va venir � Malte (palindrome)")]
        [DataRow("caser vite ce palindrome ne mord ni lape cet ivre sac", true, DisplayName = "caser vite ce palindrome ne mord ni lape cet ivre sac (palindrome)")]
        [DataRow("ni palindrome ne mord ni lapin", true, DisplayName = "ni palindrome ne mord ni lapin (palindrome)")]
        public void TestMethodPalindrome(string pTestText, bool pExpectedValue) // Check palindrome from string
        {
            string ptesttextlow = pTestText.ToLower();
            string strtotest = UtilsStringsHelper.RemoveAllSpaceFromString(ptesttextlow); // Delete spaces
            string laststrtotest = PalindromeBLL.RemoveSpecificChar(strtotest); // Delete specific char

            bool result = PalindromeBLL.IsPalindrome(laststrtotest); // Test if a palindrom
            Assert.AreEqual(pExpectedValue, result);
        }

        /// <summary>
        /// Check Palindrome From File
        /// </summary>
        /// <param name="pFilename">File name</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow("palindrome.txt", true, DisplayName = "Test fichier palindrome.txt")]
        public void TestMethodPalindromeFromFile(string pFilename, bool pExpectedValue) // Check palindrome from file
        {
            bool result = false;
            Records records = PalindromeDAL.ReadRecords(pFilename);
            if (records.PStatus)
            {
                foreach (string line in records.PRecords)
                {
                    string ptesttextlow = line.ToLower();
                    string strtotest = UtilsStringsHelper.RemoveAllSpaceFromString(ptesttextlow); // Delete spaces
                    string laststrtotest = PalindromeBLL.RemoveSpecificChar(strtotest); // Delete specific char
                    result = PalindromeBLL.IsPalindrome(laststrtotest); // Palindrome test
                    if (result)
                    {
                        Assert.AreEqual(pExpectedValue, result);
                    }
                    else
                    {
                        Assert.AreEqual(false, result);
                    }
                }
            }
            else
            {
                Assert.AreEqual(pExpectedValue, result);
            }
        }

        /// <summary>
        /// Save records
        /// </summary>
        /// <param name="pTestText">String to save</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow("ni palindrome ne mord ni lapin", true, DisplayName = "Test save record")]
        public void TestSaveRecords(string pTestText, bool pExpectedValue)
        {
            ResultDAL records = PalindromeDAL.SaveRecords(pTestText, "UnitTest.txt");
            if (records.PStatus)
            {
                Assert.AreEqual(pExpectedValue, true);
            }
            else
            {
                Assert.AreEqual(pExpectedValue, false);
            }
        }

        /// <summary>
        /// Test validity and palindrome
        /// </summary>
        /// <param name="pTestText">String to test</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow("ni palindrome ne mord ni lapin", true, DisplayName = "Test validity and palindrome")]
        public void TestValidEntryTextAndCheckPalindrome(string pTestText, bool pExpectedValue)
        {
            ResultBLL result = PalindromeBLL.ValidEntryTextAndCheckPalindrome(pTestText);
            if (result.PStatus != Status.error)
            {
                Assert.AreEqual(pExpectedValue, true);
            }
            else
            {
                Assert.AreEqual(pExpectedValue, false);
            }
        }

        /// <summary>
        /// Test read records from file
        /// </summary>
        /// <param name="pFileName">File name</param>
        /// <param name="pExpectedValue">Value expected true/false</param>
        [TestMethod]
        [DataRow("palindrome.txt", true, DisplayName = "Test read records from file")]
        public void TestGetPalindromeFromFile(string pFileName, bool pExpectedValue)
        {
            Records records = PalindromeBLL.GetPalindromeFromFile(pFileName);
            if (records.PStatus)
            {
                Assert.AreEqual(pExpectedValue, true);
            }
            else
            {
                Assert.AreEqual(pExpectedValue, false);
            }
        }

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
