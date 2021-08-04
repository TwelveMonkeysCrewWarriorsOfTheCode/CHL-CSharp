using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFractionDTO
{
    /// <summary>
    /// Class To Transfert Data
    /// </summary>
    public class DataDTO
    {
        #region Properties
        private IEnumerable<string> m_records; // Records
        private string m_filename; // Filename
        private int m_destination; // Destination to save data : 0=file
        public IEnumerable<string> PRecords
        {
            get => m_records;
            private set => m_records = value;
        }
        public string Filename
        {
            get => m_filename;
            private set => m_filename = value;
        }
        public int Destination
        {
            get => m_destination;
            private set => m_destination = value;
        }
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor To Build a Data Object
        /// </summary>
        /// <param name="pFraction"></param>
        public DataDTO(IEnumerable<string> pRecords, int pDestination, string pFilename = "")
        {
            m_records = pRecords;
            m_filename = pFilename;
            m_destination = pDestination;
        }
        #endregion
    }
}
