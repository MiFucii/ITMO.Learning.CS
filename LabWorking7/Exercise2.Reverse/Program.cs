using System;

namespace Exercise2.Reverse
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string revers = Console.ReadLine();
            Exercise2.Reverse.Reverse.ReversStrn(ref revers);
            Console.WriteLine("Вы ввели: {0}. Хорошего вам настроения!)", revers);
        }
    }
}
