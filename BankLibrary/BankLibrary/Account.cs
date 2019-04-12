using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class Account
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public AbstractCard Card { get; set; }
    }
}
