using System;

namespace DTO
{
    public class BankAccountDTO
    {
        public string OwnerName { get; set; }
        public Gender Gender { get; set; }
        public AccountType Type { get; set; }
        public long AccountNumber { get; set; }

        public override string ToString()
        {
            return $"{this.OwnerName,-20}{this.Gender,-15}{this.Type,-10}";
        }
    }
}

