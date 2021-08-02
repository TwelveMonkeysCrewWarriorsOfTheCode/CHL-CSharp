using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BankBLL
    {
        public static List<BankAccountDTO> GetOwnersList()
        {
            return DatFilesManagerDAL.ReadOwnersList();
        }
    }
}
