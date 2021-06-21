using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectPalindromeBLL;
using UtilsClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestPalindrome
    {
        [TestMethod]
        [DataRow("radar", true, DisplayName = "radar (palindrome)")]
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
        public void TestMethodPalindrome(string ptesttext, bool pExpectedValue)
        {
            string ptesttextlow = ptesttext.ToLower();
            string strtotest = Utils.RemoveSpace(ptesttextlow); // Delete spaces
            string laststrtotest = Palindrome.RemoveSpecificChar(strtotest); // Delete specific char

            bool result = Palindrome.IsPalindrome(laststrtotest); // Test if a palindrom
            Assert.AreEqual(pExpectedValue, result);
        }
    }
}
