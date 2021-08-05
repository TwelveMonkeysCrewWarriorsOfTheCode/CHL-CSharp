using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFractionDTO;
using System.Data;
using System.Data.OleDb;


namespace ProjectFractionDAL
{
    /// <summary>
    /// Class To Save To File
    /// </summary>
    public class CsvFiles
    {
        /// <summary>
        /// Save Data To File
        /// </summary>
        /// <param name="pDataToSave">Object Data</param>
        /// <returns>Return Object Result</returns>
        internal static ResultDTO SaveToFile(DataDTO pDataToSave)
        {
            try
            {
                if (!IsFileExist(pDataToSave.Filename)) // File Exist ?
                {
                    using (StreamWriter sw = File.AppendText(pDataToSave.Filename))
                    {
                        sw.WriteLine(pDataToSave.Header); // Write Header
                        sw.Close(); // Close stream
                    }
                }
                using (StreamWriter sw = File.AppendText(pDataToSave.Filename)) // The file exist , append to File
                {
                    foreach (string line in pDataToSave.PRecords)
                    {
                    sw.WriteLine(line); // Write to file
                    }
                    sw.Close(); // Close stream
                    ResultDTO result = new ResultDTO(true, "", "");
                    return result;
                }
            }
            catch (Exception e)
            {
                ResultDTO result = new ResultDTO(false, "The file could not be written", "Exception: " + e.Message);
                return result;
            }
        }
        /// <summary>
        /// Create List Files In The Current Directory
        /// </summary>
        /// <param name="pPath">Path File</param>
        /// <returns>Return Files List</returns>
        private static string[] CreateFileList(string pPath)
        {
            string[] fileList = Directory.GetFiles(pPath, "*.csv");
            return fileList;
        }
        /// <summary>
        /// Get If File Exist In List Files
        /// </summary>
        /// <param name="pFilename">Filename</param>
        /// <returns>Return Result</returns>
        public static bool IsFileExist(string pFilename)
        {
            if (!File.Exists(pFilename)) return false;
            return true;
        }
    }
}
