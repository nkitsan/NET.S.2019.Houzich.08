using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class Transaction
    {
        public Account FromAccount { get; }
        public Account ToAccount { get; }
        public decimal Ammount { get; }

        public Transaction(Account fromAccount, Account toAccount, decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("An ammount to withdraw should be equal or greater than zero");
            }

            this.FromAccount = fromAccount;
            this.ToAccount = toAccount;
            this.Ammount = ammount;
        }
    }
}
