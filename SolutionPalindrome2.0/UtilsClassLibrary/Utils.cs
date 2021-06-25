using System;

namespace UtilsClassLibrary
{
    public class Utils // Class contains utils method to re-use in all programs (dll)
    {
        public static string RemoveSpace(string textspace) // Remove all spaces in a string
        {
            return textspace.Replace(" ", ""); // We replace space with null
        }
    }
}
