using System;

namespace BLL
{
    public class BankAccount
    {
        #region Properties
        private string m_OwnerName;

        // Propriétés complète avec sa variable d'encapsulation
        public string OwnerName
        {
            //get { return m_OwnerName; }
            //set { m_OwnerName = value; }
            get => m_OwnerName;
            set => m_OwnerName = value;
        }

        // Propriété auto générée
        public Gender Sex { get; private set; }

        public AccountType Type { get; private set; }

        public decimal Balance { get; private set; }
        #endregion

        #region Constructors
        public BankAccount(string pOwnerName) : this(pOwnerName, Gender.Unknown)
        {
            /*if (pOwnerName == null) throw new ArgumentNullException();
            if (pOwnerName.Length < 3) throw new ArgumentException("Longueur du nom inférieure à 3 positions");
            this.OwnerName = pOwnerName;
            this.Type = AccountType.Current;
            this.Sex = Gender.Unknown;
            this.Balance = 0;*/
        }

        public BankAccount(string pOwnerName, Gender pSex, AccountType pType = AccountType.Current)
        {
            if (pOwnerName == null) throw new ArgumentNullException();
            if (pOwnerName.Length < 3) throw new ArgumentException("Longueur du nom inférieure à 3 positions");
            this.OwnerName = pOwnerName;
            this.Type = AccountType.Current;
            this.Sex = pSex;
            this.Balance = 0;

        } 
        #endregion

        public decimal Deposit(decimal pAmount)
        {
            this.Balance = this.Balance + pAmount;
            return this.Balance;
        }

        public bool Wthdraw(decimal pAmount)
        {
            // Règle de gestion, le solde ne peut pas passer en négatif
            if (pAmount > this.Balance) return false;
            this.Balance = this.Balance - pAmount;
            return true;
        }
    }
}
