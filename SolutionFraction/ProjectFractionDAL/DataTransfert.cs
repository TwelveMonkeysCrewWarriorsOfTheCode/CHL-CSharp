using System;
using System.IO;
using ProjectFractionDTO;

namespace ProjectFractionDAL
{
    /// <summary>
    /// Class To Send Data To FILE ...
    /// </summary>
    public class DataTransfert : IData
    {
        /// <summary>
        /// Save Data To FILE ...
        /// </summary>
        /// <param name="pDataToSave">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Create(DataDTO pDataToSave)
        {
            ResultDTO result = new ResultDTO(false, "", "");
            switch (pDataToSave.Destination)
            {
                case 0: // File                   
                    result = CsvFiles.SaveToFile(pDataToSave);
                    break;
                default: // File
                    result = CsvFiles.SaveToFile(pDataToSave);
                    break;
            }
            return result;
        }
        /// <summary>
        /// Read Data From FILE ...
        /// </summary>
        /// <param name="pDataToRead">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Read(DataDTO pDataToRead)
        {
            ResultDTO result = new ResultDTO(false, "The method is not yet implemented");
            return result;
        }
        /// <summary>
        /// Update Data To FILE ...
        /// </summary>
        /// <param name="pDataToUpdate">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Update(DataDTO pDataToUpdate)
        {
            ResultDTO result = new ResultDTO(false, "The method is not yet implemented");
            return result;
        }
        /// <summary>
        /// Delete Data To FILE ...
        /// </summary>
        /// <param name="pDataToDelete">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Delete(DataDTO pDataToDelete)
        {
            ResultDTO result = new ResultDTO(false, "The method is not yet implemented");
            return result;
        }
    }
}
