using System;
using System.Text;
using UtilsClassLibraryHelper;

namespace ProjectPalindromeBLL
{
    /// <summary>
    /// Class to check palindrome
    /// </summary>
    public class PalindromeBLL
    {
        /// <summary>
        /// Test If Text Is Palindrome
        /// </summary>
        /// <param name="texttotest"></param>
        /// <returns></returns>
        public static bool IsPalindrome(String texttotest) // A voir la méthode Array.Reverse et comparer les deux
        {
            if (texttotest.Length < 2) return false;
            string inputlow = texttotest.ToLower(); // Convert minus
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
        /// Remove Accent, Specific Characters From Text
        /// </summary>
        /// <param name="textspecific"></param>
        /// <returns></returns>
        public static string RemoveSpecificChar(string textspecific) // A voir la méthode RemoveDiacritics pour améliorer ou non
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
            string textConverted = textspecific.Normalize(NormalizationForm.FormD);
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
        /// Test If Text Is Compliant And Test Palindrome
        /// </summary>
        /// <param name="texttocheck"></param>
        /// <returns></returns>
        public static ResultBLL ValidEntryTextAndCheckPalindrome(string texttocheck) // Check the text validity and palindrome
        {
            if (!string.IsNullOrWhiteSpace(texttocheck) && texttocheck.Length > 1) // We don't accept null text or only spaces text or 1 char
            {
                bool resultpal = PalindromeBLL.IsPalindrome(texttocheck); // Palindrome test
                if (resultpal)
                {
                    ResultBLL result = new ResultBLL(Status.ispalindrome,"","");
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
                ResultBLL result = new ResultBLL(Status.error, "\n    Un texte ne peut pas être null ou ne contenir que des espaces et doit avoir au moins 2 caractères !!!", "");
                return result;
            }
        }
    }
}
