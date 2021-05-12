using System;

namespace Exercise2.MultiplyMatrix
{
    class MultiplyMatrix
    {
        static void Input(int[,] inputArray, int arSize, string arName)
        {
            try
            {
                Console.WriteLine("Заполните массив " + arName + " :");
                for (int i = 0; i < arSize; i++)
                {
                    for (int j = 0; j < arSize; j++)
                    {
                        Console.Write("Введите значение для [{0},{1}] : ", i, j);
                        inputArray[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добрый день! Введите размерность массива (не меньше 2): ");
                int arraySize = int.Parse(Console.ReadLine());
                if (arraySize > 1)
                {
                    int[,] a = new int[arraySize, arraySize], b = new int[arraySize, arraySize];
                    Input(a, arraySize, "a"); Input(b, arraySize, "b");

                    int[,] resultArray = new int[arraySize, arraySize];

                    for (int i = 0; i < arraySize; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            resultArray[i, j] += a[i, 0] * b[0, j] + a[i, 1] * b[1, j];

                        }
                    }

                    Output(resultArray);
                }
                else Console.WriteLine("Вы ввели число меньше 2!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        static void Output(int[,] resArray)
        {
            Console.WriteLine("Результат умножения двух массивов:");
            for (int i = 0; i < resArray.GetLength(0); i++)
            {
                for (int j = 0; j < resArray.GetLength(1); j++)
                {
                    Console.Write("{0} ", resArray[i, j]);
                }
                Console.Write('\n');
            }
        }
    }
}
