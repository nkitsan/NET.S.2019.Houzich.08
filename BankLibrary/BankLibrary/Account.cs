using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account
    {
        public string Id { get; }
        public string FirstName { get; }
        public string SecondName { get; }
        public AbstractCard Card { get; }

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
            this.Card = Card;
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
