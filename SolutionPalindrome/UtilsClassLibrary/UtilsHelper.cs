using System;

namespace UtilsClassLibraryHelper
{
    public class UtilsHelper // Class contains utils method to re-use in all programs (dll)
    {
        public static string RemoveAllSpaceFromString(string textspace) // Remove all spaces in a string
        {
            return textspace.Replace(" ", ""); // We replace space with null
        }
    }
}
