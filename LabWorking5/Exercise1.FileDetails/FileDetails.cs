using System;
using System.IO;

namespace Exercise1.FileDetails
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            try
            {
                string path = args[0] + ".txt";
                using (FileStream fs = File.OpenRead(path))
                {
                    using (StreamReader fr = new StreamReader(path, System.Text.Encoding.Default))
                    {
                        int size = (int)fs.Length;
                        char[] symbolArray = new char[size];
                        for (int i = 0; i < size; i++)
                        {
                            symbolArray[i] = (char)fr.Read();

                        }
                        Summarize(symbolArray);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        static void Summarize(char[] symbolArray)
        {
            int lineSum = 1, vowelsSumRus = 0, vowelsSumEn = 0, consonantalSumRus = 0, consonantalSumEn = 0, symbolSum = 0, numberSum = 0;
            foreach (char i in symbolArray)
            {
                if (char.IsLetter(i))
                {
                    symbolSum++;
                    if ("АИЕЁОУЫЭЮЯаиеёоуыэюя".IndexOf(i) != -1)
                    {
                        vowelsSumRus++;
                    }
                    else if ("AEIOUYaeiouy".IndexOf(i) != -1)
                    {
                        vowelsSumEn++;
                    }
                    else if ("BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".IndexOf(i) != -1)
                    {
                        consonantalSumEn++;
                    }
                    else
                    {
                        consonantalSumRus++;
                    }
                }
                if (char.IsDigit(i))
                {
                    symbolSum++;
                    numberSum++;
                }
                if (i == '\n') lineSum++;
            }

            Console.WriteLine("В выбраном файле находятся: Русских гласных букв: {0}; Русских согласных букв: {1};\nАнглийских гласных букв: {2}; " +
                "Английских согласных букв: {3}; \nВсего цифр в файле: {6};Всего строк в файле: {4}; Общее количество символов в файле: {5}.", vowelsSumRus, consonantalSumRus, vowelsSumEn, consonantalSumEn, lineSum, symbolSum, numberSum);
        }
    }
}
