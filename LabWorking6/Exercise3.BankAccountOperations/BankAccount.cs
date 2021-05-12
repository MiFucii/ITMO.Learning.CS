using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.BankAccountOperations
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

        public void Сompletion(string accLogin, decimal accBalance)
        {
            var rnd = new Random();

            this.accLogin = accLogin;
            this.accBalance = accBalance;
            this.accNumber = rnd.Next(1000000, 9999999);
            accStatus = AccountStatus.Cheking;
        }

        public void Deposit(decimal amount)
        {
            accBalance += amount;
            accStatus = AccountStatus.Deposit;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBalance >= amount;
            accStatus = AccountStatus.Withdraw;
            if (sufficientFunds) accBalance -= amount;
            return sufficientFunds;
        }
    }
}
