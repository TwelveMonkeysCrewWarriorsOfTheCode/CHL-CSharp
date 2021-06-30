using System;

namespace UtilsClassLibraryHelper
{
    /// <summary>
    /// Class contains utility methods string
    /// </summary>
    public static class UtilsStringsHelper // Class contains utils method to re-use in all programs (dll)
    {
        /// <summary>
        /// Remove All Spaces In A String
        /// </summary>
        /// <param name="textspace"></param>
        /// <returns></returns>
        public static string RemoveAllSpaceFromString(string textspace) // Remove all spaces in a string
        {
            return textspace.Replace(" ", ""); // We replace space with null
        }
    }
}
