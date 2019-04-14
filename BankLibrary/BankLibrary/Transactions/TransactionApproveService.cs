using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public static class TransactionApproveService
    {
        public static bool ApproveTransaction(Transaction transaction)
        {
            if (transaction.FromAccount.Card.IsActive &&
                transaction.ToAccount.Card.IsActive &&
                transaction.FromAccount.Card.Ammount > transaction.Ammount)
            {
                return true;
            }

            return false;
        }
    }
}
