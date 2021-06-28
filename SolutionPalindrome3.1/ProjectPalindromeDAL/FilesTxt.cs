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

        public static ResultDAL ValidAndSetExtensionFilename(string filename) // Check the filename validity and add .txt if need
        {
            ResultDAL result = new ResultDAL();
            if (!string.IsNullOrWhiteSpace(filename)) // We don't accept null text or only spaces text
            {
                if (filename.Length < 5) // Add .txt to filename id don't exist
                {
                    filename += ".txt";
                }
                else
                {
                    string ext = filename.Substring(filename.Length - 4);
                    if (ext != ".txt")
                    {
                        filename += ".txt";
                    }
                }
                result.status = true;
                result.filename = filename;
                return result;
            }
            else
            {
                result.status = false;
                result.message1 = "\n    Un nom de fichier ne peut pas être null ou ne contenir que des espaces !!!";
                return result;
            }
        }

        public static ResultDAL ValidFilename(string filename) // Check if filename is not null and doesn't contains only spaces
        {
            ResultDAL result = new ResultDAL();
            if (!string.IsNullOrWhiteSpace(filename)) // We don't accept null text or only spaces text
            {
                result.status = true;
                return result;
            }
            else
            {
                result.status = false;
                result.message1 = "\n    Un nom de fichier ne peut pas être null ou ne contenir que des espaces !!!";
                return result;
             }
        }
    }
}

