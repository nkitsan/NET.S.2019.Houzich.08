using System;
using System.Runtime.Serialization;

namespace BankLibrary
{
    [DataContract]
    [KnownType(typeof(StandardCard))]
    [KnownType(typeof(GoldCard))]
    public class Account
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string SecondName { get; set; }

        [DataMember]
        public AbstractCard Card { get; set; }

        public Account(string id, string firstName, string secondName, AbstractCard card)
        {
            if (!ValidateName(firstName))
            {
                throw new ArgumentException("First name shoud contain only letters");
            }

            if (!ValidateName(secondName))
            {
                throw new ArgumentException("Second name shoud contain only letters");
            }

            this.Id = id;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Card = card;
        }

        private bool ValidateName(string name)
        {
            foreach (var c in name)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
