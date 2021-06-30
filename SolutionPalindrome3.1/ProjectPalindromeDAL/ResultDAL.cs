using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPalindromeDAL
{
    /// <summary>
    /// Class to return the status
    /// </summary>
    public class ResultDAL
    {
        private bool m_status; // Status of method
        private string m_messageDev; // Error message from developper
        private string m_messageExc; // Error message from exception
        private string m_filename; // Filename

        /// <summary>
        /// Constructor To Return Result
        /// </summary>
        /// <param name="pStatus"></param>
        /// <param name="pMessageDev"></param>
        /// <param name="pMessageExc"></param>
        /// <param name="pFilename"></param>
        public ResultDAL(bool pStatus, string pMessageDev, string pMessageExc, string pFilename)
        {
            m_status = pStatus;
            m_messageDev = pMessageDev;
            m_messageExc = pMessageExc;
            m_filename = pFilename;
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

        public string PFilename
        {
            get => m_filename;
            private set => m_filename = value;
        }
    }
}
