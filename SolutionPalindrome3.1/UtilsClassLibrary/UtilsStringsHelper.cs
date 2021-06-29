using System;

namespace UtilsClassLibraryHelper
{
    /// <summary>
    /// Class contains utility methods string
    /// </summary>
    public static class UtilsStringsHelper // Class contains utils method to re-use in all programs (dll)
    {
        public static string RemoveAllSpaceFromString(string textspace) // Remove all spaces in a string
        {
            return textspace.Replace(" ", ""); // We replace space with null
        }
    }
}
