using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFractionDTO;
using ProjectFractionDAL;

namespace ProjectFractionBLL
{
    /// <summary>
    /// Class To Send Data To DAL
    /// </summary>
    public class DataTransfertToDAL
    {
        /// <summary>
        /// Send Data To DAL
        /// </summary>
        /// <param name="pDataToSave">Object Data</param>
        /// <returns>Return Object Result</returns>
        public static ResultDTO SaveData(DataDTO pDataToSave)
        {
            ResultDTO result = new ResultDTO(false, "", "");
            DataTransfert datatransfert = new DataTransfert();
            result = datatransfert.Create(pDataToSave);
            return result;
        }
    }
}
