using System;
using DTO;
using System.IO;
using System.Collections.Generic;

namespace DAL
{
    public class DatFilesManagerDAL
    {
        private const string ACCOUNT_FILE_PATH = @".\AccountsFile.dat";

        public bool SaveToFile(BankAccountDTO pAccountToSave)
        {
            try
            {
                string textToSave;
                textToSave = DateTime.UtcNow.ToString() + "|" + pAccountToSave.OwnerName + "|" + pAccountToSave.Type + "|" + pAccountToSave.Gender + "|" + pAccountToSave.AccountNumber + "***" + Environment.NewLine;
                File.AppendAllText(ACCOUNT_FILE_PATH, textToSave);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<BankAccountDTO> ReadOwnersList()
        {
            // Lire le fichier ligne à ligne
            // pour chaque créer un BankAccountDTO
            // ajouter à la liste
            IEnumerable<string> LinesReaded = File.ReadLines(ACCOUNT_FILE_PATH);
            List<BankAccountDTO> myList = new List<BankAccountDTO>();
            foreach(var line in LinesReaded)
            {
                BankAccountDTO baDto = ConvertStringToBankAccountDTO(line);
                myList.Add(baDto);
            }
            return myList;
        }

        private static BankAccountDTO ConvertStringToBankAccountDTO( string line)
        {
            string[] splitted = line.Replace("***", "").Split('|', StringSplitOptions.None);
            string ownerName = splitted[1];
            AccountType type = (AccountType)Enum.Parse(typeof(AccountType), splitted[2]);
            Gender gender = (Gender)Enum.Parse(typeof(Gender), splitted[3]);
            long accountNumber = long.Parse(splitted[4]);
            BankAccountDTO baDto = new BankAccountDTO { Gender = gender, OwnerName = ownerName, Type = type, AccountNumber = accountNumber };
            return baDto;
        }
    }
}
