using System;
using BankLibrary;

namespace BankConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var storage = BankStorage.GetInstance();

            var account1 = new Account("jjisdkkkg", "Jon", "Smith", new StandardCard(25m));
            var account2 = new Account("dhtrhtrht", "Elizabeth", "White", new GoldCard(1000m));

            storage.AddAccount(account1);
            storage.AddAccount(account2);

            var transaction = new Transaction(account2, account1, 20m);
            if (TransactionApproveService.ApproveTransaction(transaction))
            {
                TransactionService.CompleteTransaction(transaction);
            }

            Console.WriteLine($"Ammount on account of {account1.SecondName}: {account1.Card.Ammount}.\n"
                                + $"Bonus: {account1.Card.Bonus}");
            Console.WriteLine($"Ammount on account of {account2.SecondName}: {account2.Card.Ammount}.\n"
                    + $"Bonus: {account2.Card.Bonus}");

            storage.SaveDataToFile();

            var accounts = storage.LoadDataFromFile();
            foreach (var a in accounts)
            {
                Console.WriteLine(a.FirstName);
            }

            Console.ReadKey();
        }
    }
}
