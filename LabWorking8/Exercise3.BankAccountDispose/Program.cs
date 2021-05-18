using System;
using System.Collections.Generic;

namespace Exercise3.BankAccountDispose
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<BankAccount> arrayList = new List<BankAccount>();

            arrayList.Add(new BankAccount());
            arrayList[0].Сompletion("Ted23o", 200M);

            try
            {
                Console.WriteLine("Введите логин: ");
                string accLogin = Console.ReadLine();
                Console.WriteLine("Введите баланс: ");
                decimal accBalance = decimal.Parse(Console.ReadLine());

                arrayList.Add(new BankAccount());
                arrayList[1].Сompletion(accLogin, accBalance);

                Console.Clear();
                Console.WriteLine("Доброго времени суток, {0}.", arrayList[1].accountLogin);
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
                    Console.WriteLine("Статус: " + arrayList[1].accStatus.ToString());
                    Console.WriteLine("Средства успешно зачислены, ваш баланс: " + arrayList[1].accountBalance.ToString() + "$");
                }
                if (keyChar == 119 || keyChar == 87)
                {
                    Console.Clear();
                    Console.WriteLine("Введите сумму для снятия:");
                    bool flag = arrayList[1].Withdraw(decimal.Parse(Console.ReadLine()), "Банкомат");
                    Console.Clear();
                    Console.WriteLine("Статус: " + arrayList[1].accStatus.ToString());
                    if (flag)
                        Console.WriteLine("Средства успешно сняты, ваш баланс: {0}$", arrayList[1].accountBalance);
                    else
                        Console.WriteLine("Операция отклонена, недостаточно средств на счете! Ваш баланс: {0}$", arrayList[1].accountBalance);
                }
                if (keyChar == 105 || keyChar == 73)
                {
                    Console.Clear();
                    arrayList[1].accStatus = AccountStatus.Cheking;
                    Console.WriteLine("Статус: " + arrayList[1].accStatus.ToString());
                    Console.WriteLine("...................");
                    Console.WriteLine("Ваши данные: Логин: {0}; Номер счета: {1}; Баланс: {2}$;", arrayList[1].accountLogin, arrayList[1].accountNumber, arrayList[1].accountBalance);
                    Console.WriteLine("Последние операции на аккаунте:");
                    foreach (BankTransaction transaction in arrayList[1].Transactions())
                        Console.WriteLine("Дата операции: {0}\tСумма: {1}\tОт кого: {2}\tКому: {3}", new object[4]
                        {
                            transaction.dateWhen,
                            transaction.howMoney,
                            transaction.logFrom,
                            transaction.logTo
                        });
                }
                if (keyChar == 84 || keyChar == 116)
                {
                    Console.Clear();
                    Console.WriteLine("Доступные счета для перевода: {0}, {1}", arrayList[0].accountNumber.ToString(), arrayList[0].accountLogin);
                    Console.WriteLine("Введите счет для перевода: ");
                    if (long.Parse(Console.ReadLine()) == arrayList[0].accountNumber)
                    {
                        Console.WriteLine("Введите сумму: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        if (arrayList[1].Withdraw(amount, arrayList[0].accountLogin))
                        {
                            arrayList[0].Deposit(amount);
                            Console.WriteLine("Средства успешно переведены, ваш баланс: {0}$", arrayList[1].accountBalance);
                        }
                        else
                            Console.WriteLine("Операция отклонена, недостаточно средств на счете! Ваш баланс: {0}$", arrayList[1].accountBalance);
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