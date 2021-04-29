using System;


namespace Exercise1
{
    class Program
    {
        public enum AccountType { Cheking, Deposit = 1000, Withdraw = 500}

        static void Main(string[] args)
        {
            AccountType deposit = AccountType.Deposit;
            AccountType withdraw = AccountType.Withdraw;

            Console.WriteLine("Пополнение счета на сумму "+ deposit.GetHashCode());
            Console.WriteLine("Снятие со счета на сумму " + withdraw.GetHashCode());

            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
