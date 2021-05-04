using System;
using System.Collections;

namespace Exercise2.WhatDay2
{
    enum MonthName { Января, Февраля, Марта, Апреля, Мая, Июня, Июля, Августа, Сентября, Октября, Ноября, Декабря }

    class WhatDay2
    {
        static ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Доброго времени суток! Введите число в промежутке между 1 и 365:");
                int dayNumber = int.Parse(Console.ReadLine());
                if (dayNumber < 1 || dayNumber > 365) throw new ArgumentOutOfRangeException("Введенное число должно быть в заданном диапазоне!");
                int monthNumber = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNumber <= daysInMonth) break;
                    else
                    {
                        dayNumber -= daysInMonth;
                        monthNumber++;
                    }
                }

                string monthName;
                MonthName tempMonthName = (MonthName)monthNumber;
                monthName = tempMonthName.ToString();

                Console.WriteLine("Это: {0} {1}", dayNumber, monthName);
                Console.Read();
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                Console.WriteLine(outOfRange.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
