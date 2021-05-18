using System;
using System.IO;

namespace Exercise3.CopyFileUpper
{
    class CopyFileUpper
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Доброго врмени суток! Введите полный путь к файлу:");
                string path1 = Console.ReadLine();
                Console.WriteLine("Введите полный путь куда Вы хотите сохранить фаил:");
                string path2 = Console.ReadLine();
                using (StreamReader streamReader = new StreamReader(path1, System.Text.Encoding.Default))
                {
                    using (StreamWriter streamWriter = new StreamWriter(path2))
                    {
                        while (streamReader.Peek() != -1)
                            streamWriter.WriteLine(streamReader.ReadLine().ToUpper());
                    }
                }
                Console.WriteLine("Перевод в верхний регистр успешно выполнен!!");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}