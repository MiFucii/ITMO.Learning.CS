using System;

namespace Exercise2.Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число: ");
                int frstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число: ");
                int scndNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Вы ввели первое число {0} и второе число {1}", frstNumber, scndNumber);
                Replacement.Swap(ref frstNumber, ref scndNumber);
                Console.WriteLine("Мы поменяли их местами и у вас получилось первое число {0} и второе число {1}", frstNumber, scndNumber);
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
