using System;

namespace UtilsLibraryHelper
{
    /// <summary>
    /// Class contains utility methods string
    /// </summary>
    public static class UtilsStringsHelper // Class contains utils method to re-use in all programs (dll)
    {
        /// <summary>
        /// Remove all spaces in a string
        /// </summary>
        /// <param name="textspace"> String to remove spaces</param>
        /// <returns>Return a string without spaces</returns>
        public static string RemoveAllSpaceFromString(string pTextSpace) // Remove all spaces in a string
        {
            return pTextSpace.Replace(" ", ""); // We replace space with null
        }
    }
}
