using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public static class TransactionService
    {
        public static void CompleteTransaction(Transaction transaction)
        {
            transaction.FromAccount.Card.WithDraw(transaction.Ammount);
            transaction.ToAccount.Card.Deposit(transaction.Ammount);
        }
    }
}
