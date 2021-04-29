using System;


namespace Exercise2
{
    public enum AccountOperations { Deposit = 1, Withdraw = 2 }
    public enum AccountType { Silver, Gold, Diamond }

    public struct BankAccount
    {
        public string accName;
        public int accPassword;
        public decimal accBalance;
        public AccountType accType;

    }
    class EnumStruct
    {
        static void Main(string[] args)
        {
            BankAccount mifucii;
            mifucii.accName = "MiFucii";
            mifucii.accBalance = 32.000M;
            mifucii.accType = AccountType.Silver;
            Console.WriteLine("Введите ваш пароль: ");
            mifucii.accPassword = Int32.Parse(Console.ReadLine());
            Console.Clear();
            AccountInfoPrint(mifucii.accBalance, mifucii.accPassword, mifucii.accName, mifucii.accType);


        }

        static void AccountInfoPrint(decimal accBalance, int accPassword, string accName, AccountType accType)
        {
            AccountOperations deposit = AccountOperations.Deposit;
            AccountOperations withdraw = AccountOperations.Withdraw;

            Console.WriteLine("*** Accses account MiFucii ***");
            Console.WriteLine("Ваш Логин: " + accName);
            Console.WriteLine("Ваш пароль: " + accPassword);
            Console.WriteLine("Ваш статус: " + accType);
            Console.WriteLine("Ваш баланс {0}$", accBalance);
            Console.WriteLine("Пополнить баланс на 1000$ нажмите D; Снять 2000$ нажмите W. Для выхода нажмите E");
            int keyPress = Console.ReadKey().KeyChar;
            if (keyPress == 100)
            {
                accBalance += deposit.GetHashCode() + 0.00M;
                accType = AccountStatus(accBalance);
                Console.Clear();
                AccountInfoPrint(accBalance, accPassword, accName, accType);
            }
            if (keyPress == 119)
            {
                if (accBalance < 2)
                {
                    Console.WriteLine("Недостаточно средств!");
                    Console.Read();

                }
                else
                {
                    accBalance -= withdraw.GetHashCode() + 0.00M;
                    accType = AccountStatus(accBalance);
                }

                Console.Clear();
                AccountInfoPrint(accBalance, accPassword, accName, accType);
            }
            if (keyPress == 101)
            {
                return;
            }

            AccountType AccountStatus(decimal accBal)
            {

                if (accBal < 50 + 0.00M)
                {
                    return (AccountType.Silver);
                }
                else
                {
                    if ((accBal >= 50 + 0.00M) && (accBalance <= 100 + 0.00M))
                    {
                        return (AccountType.Gold);
                    }
                    else
                    {
                        return (AccountType.Diamond);
                    }
                }
            }
        }

    }
}
