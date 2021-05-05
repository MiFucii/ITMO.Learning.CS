using System;

namespace Exercise1.MaxValue
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

                int res = FindingValue.Max(frstNumber, scndNumber);

                Console.WriteLine("Наибольшее число: " + res);
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
