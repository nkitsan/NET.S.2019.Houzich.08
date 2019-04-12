using System;
using System.Collections.Generic;
using System.Text;

namespace BankLibrary
{
    public class StandardCard : AbstractCard
    {
        public StandardCard(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("An ammount to deposit on a card should be equal or greater than zero");
            }

            this.Ammount = ammount;
            this.IsActive = true;
        }

        public override void Deposit(decimal ammount)
        {
            this.Ammount += ammount;
        }

        public override void Withdraw(decimal ammount)
        {
            this.Ammount -= ammount;
        }
    }
}
