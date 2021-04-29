using System;

namespace LabWorking1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, res;
            try
            {
                Console.WriteLine("Введите первое число");
                i = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nВведите второе число");
                j = Int32.Parse(Console.ReadLine());

                res = i / j;
                Console.WriteLine("Результат деления {0} на {1} равен {2}", i, j, res);
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка при вычеслении: {0}", e);

            }

            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
