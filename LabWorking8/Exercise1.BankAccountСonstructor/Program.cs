using System;
using System.Collections.Generic;

namespace Exercise1.BankAccountСonstructor
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<BankAccount> arrayList = new List<BankAccount>();
            arrayList.Add(new BankAccount());
            arrayList.Add(new BankAccount("ahly89"));
            arrayList.Add(new BankAccount(90M));
            arrayList.Add(new BankAccount(180M, "many37"));

            try
            {
                Console.WriteLine("Введите логин: ");
                string accLogin = Console.ReadLine();
                Console.WriteLine("Введите баланс: ");
                decimal accBalance = decimal.Parse(Console.ReadLine());
                arrayList.Add(new BankAccount(accBalance, accLogin));

                Console.Clear();
                Console.WriteLine("Доброго времени суток, {0}.", arrayList[4].accountLogin);
                Replay(arrayList);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Replay(List<BankAccount> arrayList)
        {
            try
            {
                Console.WriteLine("Меню:\nПополнить баланс нажмите D; \nДля снятия со счета нажмите W.\nВывести информацию нажмите I.\nДля перевода средств нажмите T\nДля выхода нажмите E\n");
                int keyChar = (int)Console.ReadKey().KeyChar;
                if (keyChar == 100 || keyChar == 68)
                {
                    Console.Clear();
                    Console.WriteLine("Введите сумму для пополнения:");
                    arrayList[1].Deposit(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("Статус: " + arrayList[4].accStatus.ToString());
                    Console.WriteLine("Средства успешно зачислены, ваш баланс: " + arrayList[4].accountBalance.ToString() + "$");
                }

                if (keyChar == 119 || keyChar == 87)
                {
                    Console.Clear();
                    Console.WriteLine("Введите сумму для снятия:");
                    bool flag = arrayList[4].Withdraw(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                    Console.WriteLine("Статус: " + arrayList[4].accStatus.ToString());
                    if (flag)
                        Console.WriteLine("Средства успешно сняты, ваш баланс: {0}$", arrayList[4].accountBalance);
                    else
                        Console.WriteLine("Операция отклонена, недостаточно средств на счете! Ваш баланс: {0}$",arrayList[4].accountBalance);
                }

                if (keyChar == 105 || keyChar == 73)
                {
                    Console.Clear();
                    arrayList[1].accStatus = AccountStatus.Cheking;
                    Console.WriteLine("Статус: " + arrayList[4].accStatus.ToString());
                    Console.WriteLine("...................");
                    Console.WriteLine("Ваши данные: Логин: {0}; Номер счета: {1}; Баланс: {2}$;", arrayList[4].accountLogin, arrayList[4].accountNumber, arrayList[4].accountBalance);
                }

                if (keyChar == 84 || keyChar == 116)
                {
                    Console.Clear();
                    foreach (BankAccount array in arrayList)
                    {
                        if(array.accountLogin != arrayList[4].accountLogin) Console.WriteLine("Счет: {0}, Логин: {1}", array.accountNumber.ToString(),array.accountLogin);
                    }
                    Console.WriteLine("Введите счет для перевода: ");
                    long num = long.Parse(Console.ReadLine());
                    if (num == arrayList[0].accountNumber || num == arrayList[1].accountNumber || num == arrayList[2].accountNumber || num == arrayList[3].accountNumber)
                    {
                        Console.WriteLine("Введите сумму: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        if (arrayList[4].Withdraw(amount))
                        {
                            arrayList[0].Deposit(amount);
                            Console.WriteLine("Средства успешно переведены, ваш баланс: {0}$", arrayList[4].accountBalance);
                        }
                        else
                            Console.WriteLine("Операция отклонена, недостаточно средств на счете! Ваш баланс: {0}$", arrayList[4].accountBalance);
                    }
                    else
                        Console.WriteLine("Операция отклонена, не верно введен счет получателя!");
                }

                if (keyChar == 101 || keyChar == 69) return;
                Replay(arrayList);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Replay(arrayList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Replay(arrayList);
            }
        }
    }
}