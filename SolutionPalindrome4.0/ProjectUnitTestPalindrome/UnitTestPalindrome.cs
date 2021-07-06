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
        [DataRow("été", true, DisplayName = "été (palindrome)")]
        [DataRow("ici", true, DisplayName = "ici (palindrome)")]
        [DataRow("tôt", true, DisplayName = "tôt (palindrome)")]
        [DataRow("rêver", true, DisplayName = "rêver (palindrome)")]
        [DataRow("réifier", true, DisplayName = "réifier (palindrome)")]
        [DataRow("ressasser", true, DisplayName = "ressasser (palindrome)")]
        [DataRow("La mariée ira mal", true, DisplayName = "La mariée ira mal est un palindrome")]
        [DataRow("À révéler mon nom, mon nom relèvera", true, DisplayName = "À révéler mon nom, mon nom relèvera (palindrome)")]
        [DataRow("Eh ! ça va, la vache ?", true, DisplayName = "Eh ! ça va, la vache ? (palindrome)")]
        [DataRow("L'ami naturel ? Le rut animal.", true, DisplayName = "L'ami naturel ? Le rut animal. (palindrome)")]
        [DataRow("Ta bête te bat.", true, DisplayName = "Ta bête te bat. (palindrome)")]
        [DataRow("Engage le jeu que je le gagne", true, DisplayName = "Engage le jeu que je le gagne (palindrome)")]
        [DataRow("Noël a trop par rapport à Léon", true, DisplayName = "Noël a trop par rapport à Léon (palindrome)")]
        [DataRow("À l'étape, épate-la !", true, DisplayName = "À l'étape, épate-la ! (palindrome)")]
        [DataRow("La mère Gide digère mal", true, DisplayName = "La mère Gide digère mal (palindrome)")]
        [DataRow("Léon, émir cornu, d'un roc rime Noël", true, DisplayName = "Léon, émir cornu, d'un roc rime Noël (palindrome)")]
        [DataRow("Élu par cette crapule", true, DisplayName = "Élu par cette crapule (palindrome)")]
        [DataRow("Ésope reste ici et se repose", true, DisplayName = "Ésope reste ici et se repose (palindrome)")]
        [DataRow("Luc notre valet alla te laver ton cul", true, DisplayName = "Luc notre valet alla te laver ton cul (palindrome)")]
        [DataRow("Tâte l'État ! ", true, DisplayName = "Tâte l'État !  (palindrome)")]
        [DataRow("rue Verlaine gela le génial rêveur", true, DisplayName = "rue Verlaine gela le génial rêveur (palindrome)")]
        [DataRow("Elle dira hélas à la sale haridelle", true, DisplayName = "Elle dira hélas à la sale haridelle (palindrome)")]
        [DataRow("Et la marine va venir à Malte", true, DisplayName = "Et la marine va venir à Malte (palindrome)")]
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
