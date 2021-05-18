using System;
using System.IO;
using System.Collections;

namespace Exercise3.BankAccountDispose
{
    public enum AccountStatus { Cheking, Deposit, Withdraw, Create, Change }
    class BankAccount : IDisposable
    {

        private Queue tranQueue = new Queue();
        private string accLogin;
        private long accNumber;
        private decimal accBalance;
        private bool disposed = false;
        public AccountStatus accStatus;

        public Queue Transactions() => this.tranQueue;
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
            this.tranQueue.Enqueue(new BankTransaction(amount, "Банкомат", this.accLogin));
        }

        public bool Withdraw(decimal amount, string accLogFrom)
        {
            bool flag = this.accBalance >= amount;
            this.accStatus = AccountStatus.Withdraw;
            if (flag)
            {
                this.accBalance -= amount;
                this.tranQueue.Enqueue(new BankTransaction(-amount, this.accLogin, accLogFrom));
            }
            return flag;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                using (StreamWriter streamWriter = File.AppendText("Transactions.dat"))
                {
                    foreach (BankTransaction tran in tranQueue)
                        streamWriter.WriteLine("Дата операции: {0}\tСумма: {1}\tОт кого: {2}\tКому: {3}", tran.dateWhen, tran.howMoney, tran.logFrom, tran.logTo);
                }
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~BankAccount()
        {
            this.Dispose();
        }

    }
}