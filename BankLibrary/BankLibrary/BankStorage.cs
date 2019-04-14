using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace BankLibrary
{
    public class BankStorage
    {
        private static BankStorage instance;
        private static string filename = "db.txt";
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

        public void SaveDataToFile()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<Account>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                serializer.WriteObject(fs, this.accounts);
            }
        }

        public List<Account> LoadDataFromFile()
        {
            var deserializer = new DataContractJsonSerializer(typeof(List<Account>));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                this.accounts = (List<Account>)deserializer.ReadObject(fs);
            }
            return this.accounts;
        }
    }
}
