using System;

namespace UtilsClassLibrary
{
    public class Utils
    {
        public static string RemoveSpace(string textspace) // Remove all spaces in a string
        {
            return textspace.Replace(" ", "");
        }
    }
}
