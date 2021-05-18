using System;

namespace Exercise1.BankAccountСonstructor
{
    public enum AccountStatus { Cheking, Deposit, Withdraw, Create, Change }
    class BankAccount
    {
        private string accLogin;
        private long accNumber;
        private decimal accBalance;
        public AccountStatus accStatus;

        public string accountLogin => this.accLogin;

        public long accountNumber => accNumber;
        
        public decimal accountBalance => this.accBalance;

        private void NewAccNumber() => this.accNumber = (long)new Random().Next(1000000, 9999999);

        private void NewAccLogin()
        {
            Random random = new Random();
            for (int index = 0; index < 6; index++)
                this.accLogin += ((char)random.Next(97, 122)).ToString();
        }

        public BankAccount()
        {
            this.NewAccNumber();
            this.NewAccLogin();
            this.accBalance = 0M;
            this.accStatus = AccountStatus.Create;
        }

        public BankAccount(decimal accBalance)
        {
            this.NewAccNumber();
            this.NewAccLogin();
            this.accBalance = accBalance;
            this.accStatus = AccountStatus.Create;
        }

        public BankAccount(decimal accBalance, string accLogin)
        {
            this.NewAccNumber();
            this.accBalance = accBalance;
            this.accLogin = accLogin;
            this.accStatus = AccountStatus.Create;
        }

        public BankAccount(string accLogin)
        {
            this.NewAccNumber();
            this.accBalance = 0M;
            this.accLogin = accLogin;
            this.accStatus = AccountStatus.Create;
        }

        public void Change(string accLogin, decimal accBalance)
        {
            this.accLogin = accLogin;
            this.accBalance = accBalance;
            this.accStatus = AccountStatus.Change;
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
            if (flag)
                this.accBalance -= amount;
            return flag;
        }
    }
}

