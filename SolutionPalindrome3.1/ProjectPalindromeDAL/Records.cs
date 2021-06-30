using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPalindromeDAL
{
    /// <summary>
    /// Class to return status and records
    /// </summary>
    public class Records
    {
        private bool m_status; // Status of method
        private string m_messageDev; // Error message from developper
        private string m_messageExc; // Error message from exception
        private IEnumerable<string> m_records; // Records

        /// <summary>
        /// Constructor To Return Result And Records
        /// </summary>
        /// <param name="pStatus"></param>
        /// <param name="pMessageDev"></param>
        /// <param name="pMessageExc"></param>
        /// <param name="pRecords"></param>
        public Records(bool pStatus, string pMessageDev, string pMessageExc, IEnumerable<string> pRecords)
        {
            m_status = pStatus;
            m_messageDev = pMessageDev;
            m_messageExc = pMessageExc;
            m_records = pRecords;
        }

        public bool PStatus
        {
            get => m_status;
            private set => m_status = value;
        }

        public string PMessageDev
        {
            get => m_messageDev;
            private set => m_messageDev = value;
        }

        public string PMessageExc
        {
            get => m_messageExc;
            private set => m_messageExc = value;
        }

        public IEnumerable<string> PRecords
        {
            get => m_records;
            private set => m_records = value;
        }
    }
}
