using System;

namespace Exercise3.BankAccountOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите логин: ");
                string accountName = Console.ReadLine();

                Console.WriteLine("Введите баланс: ");
                decimal accountBalance = decimal.Parse(Console.ReadLine());

                BankAccount fred = new BankAccount();
                fred.Сompletion(accountName, accountBalance);

                Console.Clear();
                Console.WriteLine("Доброго времени суток, " + fred.accountLogin + ".");
 
                Replay(fred);
                
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

        static void Replay(BankAccount accLogin)
        {
            try
            {
                Console.WriteLine("Пополнить баланс нажмите D; Для снятия со счета нажмите W. Вывести информацию нажмите I. Для выхода нажмите E");
                int keyPress = Console.ReadKey().KeyChar;
                if (keyPress == 100)
                {
                    Console.Clear();
                    Console.WriteLine("Введите сумму для пополнения:");
                    accLogin.Deposit(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("Статус: " + accLogin.accStatus);
                    Console.WriteLine("Средства успешно зачислены, ваш баланс: " + accLogin.accountBalance + "$");
                }
                if (keyPress == 119)
                {
                    Console.Clear();
                    Console.WriteLine("Введите сумму для снятия:");
                    bool withdrComplite = accLogin.Withdraw(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("Статус: " + accLogin.accStatus);
                    if (withdrComplite) Console.WriteLine("Средства успешно сняты, ваш баланс: " + accLogin.accountBalance + "$");
                    else Console.WriteLine("Операция отклонена, недостаточно средств на счете! Ваш баланс: " + accLogin.accountBalance);
                }
                if (keyPress == 105)
                {
                    Console.Clear();
                    Console.WriteLine("Статус: " + accLogin.accStatus);
                    Console.WriteLine("...................");
                    Console.WriteLine("Ваши данные: Логин: {0}; Номер счета: {1}; Баланс: {2}$;", accLogin.accountLogin, accLogin.accountNumber, accLogin.accountBalance);
                }
                if (keyPress == 101)
                {
                    return;
                }
                Replay(accLogin);
            }
            catch (FormatException fError)
            { Console.WriteLine(fError.Message);  }
            catch (Exception error)
            { Console.WriteLine(error.Message);   }
        }
    }
}
