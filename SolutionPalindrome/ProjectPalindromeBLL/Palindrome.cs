using System;

namespace ProjectPalindromeBLL
{
    public class Palindrome
    {
        public static bool IsPalindrome(String texttotest) // A voir la méthode Array.Reverse et comparer les deux
        {
            char[] chars = texttotest.ToLower().ToCharArray(); // Copies the characters in this instance to a Unicode character array 
            // Boucle a double indices i va du premier vers la fin et j va de la fin vers le premier
            // Donc, on compare le premier et le dernier puis le deuxième et l'avant dernier
            // Si il y a une différence, on stop, pas un palindrome
            // Si la boucle va jusqu'au bout, tout les char sont identiques = palindrome
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--) // 
            { 
                if (chars[i] != chars[j]) return false;
            }
            return true;

            /*
            // Fonctionne pas avec ici, été, tôt
            int ind = 1;
            int strlen = texttotest.Length;
            Boolean result = false;

            for (ind = 1; ind < lenstr / 2; ind++)
            {
                if (texttotest[ind] == texttotest[lenstr - ind - 1])
                {
                    result = true;
                }
            }
            return result;*/
        }

        public static string RemoveSpecificChar(string textspecific) // A voir la méthode RemoveDiacritics pour améliorer ou non
        {
            textspecific = textspecific.Replace("?", string.Empty).Replace("!", string.Empty).Replace(".", string.Empty)
                                     .Replace(",", string.Empty).Replace(";", string.Empty).Replace(":", string.Empty).Replace("-", string.Empty).Replace("'", string.Empty);
            char[] textConverted = new char[textspecific.Length];
            for (int index = 0; index < textspecific.Length; index++)
            {
                textConverted[index] = textspecific[index];
            }
            for (int index2 = 0; index2 < textspecific.Length; index2++)
            {
                switch (textConverted[index2])
                {
                    case 'à':
                    case 'ä':
                    case 'â':
                    case 'ã':
                        textConverted[index2] = 'a';
                        break;
                    case 'é':
                    case 'è':
                    case 'ë':
                    case 'ê':
                        textConverted[index2] = 'e';
                        break;
                    case 'ï':
                    case 'î':
                    case 'ì':
                        textConverted[index2] = 'i';
                        break;
                    case 'ö':
                    case 'ô':
                    case 'õ':
                    case 'ò':
                        textConverted[index2] = 'o';
                        break;
                    case 'ü':
                    case 'û':
                    case 'ù':
                        textConverted[index2] = 'e';
                        break;
                    case 'ÿ':
                        textConverted[index2] = 'y';
                        break;
                    case 'ç':
                        textConverted[index2] = 'c';
                        break;
                    case 'ñ':
                        textConverted[index2] = 'n';
                        break;
                    default:
                        break;
                }

            }
            string lasttextConverted = new string(textConverted);
            return lasttextConverted;
        }
    }
}
