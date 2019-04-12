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
            this.FromAccount = fromAccount;
            this.ToAccount = toAccount;
            this.Ammount = ammount;
        }
    }
}
