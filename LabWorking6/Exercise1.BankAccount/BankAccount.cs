using System;


namespace Exercise1.BankAccount
{
    public enum AccountStatus { Cheking, Deposit, Withdraw }
    class BankAccount
    {
        private string accLogin;
        public string accountLogin => accLogin;

        private long accNumber;
        public long accountNumber => accNumber;

        private decimal accBalance;
        public decimal accountBalance => accBalance;

        public AccountStatus accStatus;

        public void Сompletion(string accLogin, decimal accBalance, long accNumber)
        {
            this.accLogin = accLogin;
            this.accBalance = accBalance;
            this.accNumber = accNumber;
            accStatus = AccountStatus.Cheking;
        }

    }
}
