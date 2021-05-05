using System;

namespace Exercise3.Factorial
{
    [Serializable]
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base() { }
        public NegativeNumberException(string message) : base(message) { }
        public NegativeNumberException(string message, Exception inner) : base(message, inner) { }

        protected NegativeNumberException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число для расчета факториала: ");
                int x = int.Parse(Console.ReadLine());

                if (x < 0) throw new NegativeNumberException("Вы ввели отрицательное число!");

                int res;

                FMatch.FactorialCalculation(x, out res);
                Console.WriteLine("Факториал числа равен: {0}", res);
            }
            catch (NegativeNumberException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}
