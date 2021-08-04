using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFractionDTO
{
    /// <summary>
    /// Class to return the status
    /// </summary>
    public class ResultDTO
    {
        #region Properties
        private bool m_status; // Status of method
        private string m_messageDev; // Error message from developper
        private string m_messageExc; // Error message from exception
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
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor To Return Result
        /// </summary>
        /// <param name="pStatus"></param>
        /// <param name="pMessageDev"></param>
        /// <param name="pMessageExc"></param>
        public ResultDTO(bool pStatus, string pMessageDev="", string pMessageExc="")
        {
            m_status = pStatus;
            m_messageDev = pMessageDev;
            m_messageExc = pMessageExc;
        }
        #endregion
    }
}
