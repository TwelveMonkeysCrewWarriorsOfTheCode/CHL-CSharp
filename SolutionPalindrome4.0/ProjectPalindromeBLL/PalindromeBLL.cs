using System;
using System.Text;
using ProjectUtilsLibraryHelper;
using ProjectPalindromeDAL;
using System.Collections.Generic;

namespace ProjectPalindromeBLL
{
    /// <summary>
    /// Class to check palindrome
    /// </summary>
    public class PalindromeBLL
    {
        /// <summary>
        /// Test if text is palindrome
        /// </summary>
        /// <param name="pTextToTest">String to test palindrome</param>
        /// <returns>Return true/false</returns>
        public static bool IsPalindrome(String pTextToTest) // A voir la méthode Array.Reverse et comparer les deux
        {
            if (pTextToTest.Length < 2) return false;
            string inputlow = pTextToTest.ToLower(); // Convert minus
            string strtotest = UtilsStringsHelper.RemoveAllSpaceFromString(inputlow); // Delete spaces
            string laststrtotest = PalindromeBLL.RemoveSpecificChar(strtotest); // Delete specific char
            char[] chars = laststrtotest.ToCharArray(); // Copies the characters in this instance to a Unicode character array 
            // Boucle a double indices i va du premier vers la fin et j va de la fin vers le premier
            // Donc, on compare le premier et le dernier puis le deuxième et l'avant dernier
            // Si il y a une différence, on stop, pas un palindrome
            // Si la boucle va jusqu'au bout, tout les char sont identiques = palindrome
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--) // 
            {
                if (chars[i] != chars[j]) return false;
            }
            return true;
        }

        /// <summary>
        /// Remove accent, specific characters from text
        /// </summary>
        /// <param name="pTextSpecific">String to remove specific characters</param>
        /// <returns>Return a string without specific characters</returns>
        public static string RemoveSpecificChar(string pTextSpecific) // A voir la méthode RemoveDiacritics pour améliorer ou non
        {
            // Returns a new string whose textual value is the same as this string, but whose binary representation is in the specified Unicode normalization form.
            // Indicates that a Unicode string is normalized using full canonical decomposition
            // Canonical ordering
            // ------------------
            // The canonical ordering is mainly concerned with the ordering of a sequence of combining characters.For the examples in this section we assume these characters to be diacritics,
            // even though in general some diacritics are not combining characters, and some combining characters are not diacritics.
            // Unicode assigns each character a combining class, which is identified by a numerical value.
            // Non-combining characters have class number 0, while combining characters have a positive combining class value. To obtain the canonical ordering,
            // every substring of characters having non-zero combining class value must be sorted by the combining class value using a stable sorting algorithm.Stable
            // sorting is required because combining characters with the same class value are assumed to interact typographically, thus the two possible orders are not considered equivalent.
            // For example, the character U+1EBF(ế), used in Vietnamese,
            // has both an acute and a circumflex accent.Its canonical decomposition is the three-character sequence U+0065 (e) U+0302 (circumflex accent) U+0301 (acute accent).
            // The combining classes for the two accents are both 230, thus U+1EBF is not equivalent to U+0065 U+0301 U+0302.
            // Since not all combining sequences have a precomposed equivalent (the last one in the previous example can only be reduced to U+00E9 U+0302),
            // even the normal form NFC is affected by combining characters' behavior.
            string textConverted = pTextSpecific.Normalize(NormalizationForm.FormD);
            string cleanText = "";

            for (int i = 0; i < textConverted.Length; i++)
            {
                bool isLetter = Char.IsLetter(textConverted[i]); // Indicates whether a Unicode character is categorized as a Unicode letter.

                if (isLetter)
                {
                    cleanText += textConverted[i];
                }
            }
            return cleanText;
        }

        /// <summary>
        /// Test if text is compliant and test palindrome
        /// </summary>
        /// <param name="pTextToCheck">String to check validity and palindrome</param>
        /// <returns>Return status</returns>
        public static ResultBLL ValidEntryTextAndCheckPalindrome(string pTextToCheck) // Check the text validity and palindrome
        {
            if (!string.IsNullOrWhiteSpace(pTextToCheck) && pTextToCheck.Length > 1) // We don't accept null text or only spaces text or 1 char
            {
                bool resultpal = PalindromeBLL.IsPalindrome(pTextToCheck); // Palindrome test
                if (resultpal)
                {
                    ResultBLL result = new ResultBLL(Status.ispalindrome, "", "");
                    return result;
                }
                else
                {
                    ResultBLL result = new ResultBLL(Status.isnotpalindrome, "", "");
                    return result;
                }
            }
            else
            {
                ResultBLL result = new ResultBLL(Status.error, "Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", "");
                return result;
            }
        }

        /// <summary>
        /// Return Records from file
        /// </summary>
        /// <param name="pFilename">File name</param>
        /// <returns>Return records</returns>
        public static Records GetPalindromeFromFile(string pFilename)
        {
            Records records = PalindromeDAL.ReadRecords(pFilename);
            return records;
        }

        /// <summary>
        /// Fill the liste with text
        /// </summary>
        public static List<string> FillListPalindrome()
        {
           List<string> textsToCheck = new List<string>()
           {
               "radar",
               "palindrome",
               "rotor",
               "kayak",
               "été",
               "ici",
               "tôt",
               "rêver",
               "réifier",
               "ressasser",
               "La mariée ira mal",
               "À révéler mon nom, mon nom relèvera",
               "Eh ! ça va, la vache ?",
               "L'ami naturel ? Le rut animal.",
               "Ta bête te bat.",
               "Engage le jeu que je le gagne",
               "Noël a trop par rapport à Léon",
               "À l'étape, épate-la !",
               "La mère Gide digère mal",
               "Léon, émir cornu, d'un roc rime Noël",
               "Élu par cette crapule",
               "Ésope reste ici et se repose",
               "Luc notre valet alla te laver ton cul",
               "Tâte l'État ! ",
               "rue Verlaine gela le génial rêveur",
               "Elle dira hélas à la sale haridelle",
               "Et la marine va venir à Malte",
               "caser vite ce palindrome ne mord ni lape cet ivre sac",
               "ni palindrome ne mord ni lapin"
           };
           return textsToCheck;
        }
    }
}

