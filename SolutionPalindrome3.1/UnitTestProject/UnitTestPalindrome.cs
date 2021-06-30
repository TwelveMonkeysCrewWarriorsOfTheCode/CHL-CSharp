using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPalindromeBLL;
using ProjectPalindromeDAL;
using UtilsClassLibraryHelper;

namespace UnitTestProject
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
        /// <param name="ptesttext"></param>
        /// <param name="pExpectedValue"></param>
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
        public void TestMethodPalindrome(string ptesttext, bool pExpectedValue) // Check palindrome from string
        {
            string ptesttextlow = ptesttext.ToLower();
            string strtotest = UtilsStringsHelper.RemoveAllSpaceFromString(ptesttextlow); // Delete spaces
            string laststrtotest = PalindromeBLL.RemoveSpecificChar(strtotest); // Delete specific char

            bool result = PalindromeBLL.IsPalindrome(laststrtotest); // Test if a palindrom
            Assert.AreEqual(pExpectedValue, result);
        }

        /// <summary>
        /// Check Palindrome From File
        /// </summary>
        /// <param name="pfilename"></param>
        /// <param name="pExpectedValue"></param>
        [TestMethod]
        [DataRow("palindrome.txt",true, DisplayName = "Test fichier palindrome.txt")]
        public void TestMethodPalindromeFromFile(string pfilename, bool pExpectedValue) // Check palindrome from file
        {
            Records records = PalindromeDAL.ReadRecords(pfilename);
            if (records.PStatus)
            {
                foreach (string line in records.PRecords)
                {
                    string ptesttextlow = line.ToLower();
                    string strtotest = UtilsStringsHelper.RemoveAllSpaceFromString(ptesttextlow); // Delete spaces
                    string laststrtotest = PalindromeBLL.RemoveSpecificChar(strtotest); // Delete specific char
                    bool result = PalindromeBLL.IsPalindrome(laststrtotest); // Palindrome test
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
        }

    }
}
