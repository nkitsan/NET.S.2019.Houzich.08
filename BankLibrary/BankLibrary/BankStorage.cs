using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class BankStorage
    {
        private static BankStorage instance;
        private List<Account> accounts;

        public static BankStorage GetInstance()
        {
            if (instance == null)
            {
                instance = new BankStorage();
            }
            return instance;
        }

        private BankStorage()
        {
            this.accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            this.accounts.Add(account);
        }
    }
}
