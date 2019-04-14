using System.Runtime.Serialization;

namespace BankLibrary
{
    [DataContract]
    public abstract class AbstractCard
    {
        [DataMember]
        public decimal Ammount { get; set; }

        [DataMember]
        public decimal Bonus { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        public abstract void Withdraw(decimal ammount);
        public abstract void Deposit(decimal ammount);
        public void Close()
        {
            this.IsActive = false;
        }
    }
}
