using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectPalindromeBLL;
using UtilsClassLibraryHelper;

namespace ProjectPalindromeDAL
{
    public class FilesTxt
    {
        public static string[] CreateFileList(string path) // Create list files in the current directory
        {
            string[] fileList = Directory.GetFiles(path, "*.txt");
            return fileList;
        }
    }
}

