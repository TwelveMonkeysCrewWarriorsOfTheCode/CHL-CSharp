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

        public static bool IsFileExist(string filename) // Test if a file exist in the current directory
        {
            if (!File.Exists(filename)) return false;
            return true;            
        }
    }
}

