using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectFractionDTO;

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
    }
}
