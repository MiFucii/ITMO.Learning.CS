using System;

namespace Exercise1.BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Доброго времени суток! Введите логин: ");
                string accountName = Console.ReadLine();

                Console.WriteLine("Введите номер счета: ");
                long accountNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("Введите баланс: ");
                decimal accountBalance = decimal.Parse(Console.ReadLine());

                BankAccount fred = new BankAccount();
                fred.Сompletion(accountName, accountBalance, accountNumber);

                Console.WriteLine("Статус: " + fred.accStatus);
                Console.WriteLine("...................");
                Console.WriteLine("Ваши данные: Логин: {0}; Номер счета: {1}; Баланс: {2};", fred.accountLogin, fred.accountNumber, fred.accountBalance);
                Console.Read();
            }
            catch (FormatException fError)
            {
                Console.WriteLine(fError.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
