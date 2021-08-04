using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFractionDTO;

namespace ProjectFractionDAL
{
    /// <summary>
    /// Interface To Send Data To FILE ...
    /// </summary>
    public interface IData
    {
        /// <summary>
        /// Save Data To FILE ...
        /// </summary>
        /// <param name="pDataToSave">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Create(DataDTO pDataToSave);
        /// <summary>
        /// Read Data From FILE ...
        /// </summary>
        /// <param name="pDataToRead">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Read(DataDTO pDataToRead);
        /// <summary>
        /// Update Data To FILE ...
        /// </summary>
        /// <param name="pDataToUpdate">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Update(DataDTO pDataToUpdate);
        /// <summary>
        /// Delete Data To FILE ...
        /// </summary>
        /// <param name="pDataToDelete">Object Data</param>
        /// <returns>Return Object Result</returns>
        public ResultDTO Delete(DataDTO pDataToDelete);
    }
}
