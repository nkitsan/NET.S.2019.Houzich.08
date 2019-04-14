using System;
using System.Runtime.Serialization;

namespace BankLibrary
{
    [DataContract(Name = "Gold")]
    public class GoldCard : AbstractCard
    {
        private static decimal smallAmmount = 1000;
        private static decimal averageAmmount = 3000;
        private static decimal bigAmmount = 5000;
        private static int percentageDivider = 10000;

        public GoldCard(decimal ammount)
        {
            if (ammount < 0)
            {
                throw new ArgumentOutOfRangeException("An ammount to deposit on a card should be equal or greater than zero");
            }

            this.Ammount = ammount;
            this.Bonus += CountBonus(ammount);
            this.IsActive = true;
        }

        public override void Deposit(decimal ammount)
        {
            this.Ammount += ammount;
            this.Bonus += CountBonus(ammount);
        }

        public override void Withdraw(decimal ammount)
        {
            this.Ammount -= ammount;
            this.Bonus += CountBonus(ammount);
        }

        private decimal CountBonus(decimal ammount)
        {
            if (ammount < smallAmmount)
            {
                return ammount * smallAmmount / percentageDivider;
            }
            else if (ammount < averageAmmount)
            {
                return ammount * averageAmmount / percentageDivider;
            }
            return ammount * bigAmmount / percentageDivider;
        }
    }
}
