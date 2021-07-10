using System;
using DTO;
using System.IO;

namespace DAL
{
    public class BankAccountDAL
    {
        public bool SaveToFile(BankAccountDTO pAccountToSave)
        {
            try
            {
                string textToSave;
                textToSave = DateTime.UtcNow.ToString() + "|" + pAccountToSave.OwnerName + "|" + pAccountToSave.Type + "|" + pAccountToSave.Gender + "***";
                File.AppendAllText(@".\AccountsFile.dat", textToSave);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
