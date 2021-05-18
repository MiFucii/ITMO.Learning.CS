using System;

namespace Exercise3.BankAccountDispose
{
    class BankTransaction
    {
        private readonly DateTime when;
        private readonly decimal howManyMoney;
        private readonly string accLogFrom;
        private readonly string accLogTo;

        public DateTime dateWhen => this.when;

        public decimal howMoney => this.howManyMoney;

        public string logFrom => this.accLogFrom;

        public string logTo => this.accLogTo;

        public BankTransaction(decimal amount, string logFrom, string logTo)
        {
            this.when = DateTime.Now;
            this.howManyMoney = amount;
            this.accLogFrom = logFrom;
            this.accLogTo = logTo;
        }
    }
}
