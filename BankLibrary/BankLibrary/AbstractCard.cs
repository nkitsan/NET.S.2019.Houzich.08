using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public abstract class AbstractCard
    {
        public decimal Ammount { get; set; }
        public int Bonus { get; set; }
        public bool IsActive { get; set; }

        public abstract void WithDraw(decimal ammount);
        public abstract void Deposit(decimal ammount);
        public void Close()
        {
            this.IsActive = false;
        }
    }
}
