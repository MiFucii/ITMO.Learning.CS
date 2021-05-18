using System;

namespace Exercise1.BankAccountTransfer
{
    public enum AccountStatus  { Cheking, Deposit, Withdraw }
    class BankAccount
    {
        private string accLogin;
        private long accNumber;
        private decimal accBalance;
        public AccountStatus accStatus;

        public string accountLogin => this.accLogin;

        public long accountNumber => this.accNumber;

        public decimal accountBalance => this.accBalance;

        public void Сompletion(string accLogin, decimal accBalance)
        {
            Random random = new Random();
            this.accLogin = accLogin;
            this.accBalance = accBalance;
            this.accNumber = (long)random.Next(1000000, 9999999);
            this.accStatus = AccountStatus.Cheking;
        }

        public void Deposit(decimal amount)
        {
            this.accBalance += amount;
            this.accStatus = AccountStatus.Deposit;
        }

        public bool Withdraw(decimal amount)
        {
            bool flag = this.accBalance >= amount;
            this.accStatus = AccountStatus.Withdraw;
            if (flag) this.accBalance -= amount;
            return flag;
        }
    }
}

