using System;


namespace LabWorking1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameRequest;

            Console.WriteLine("Введите ваше имя: ");
            nameRequest = Console.ReadLine();

            Console.WriteLine("\nДоброго времени суток: "+ nameRequest);

            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
