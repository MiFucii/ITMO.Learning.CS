using System;
using System.Collections;

namespace Exercise3.WhatDay3
{
    enum MonthName { Января, Февраля, Марта, Апреля, Мая, Июня, Июля, Августа, Сентября, Октября, Ноября, Декабря }

    class WhatDay3
    {

        static void Main(string[] args)
        {
            try
            {
                int[] daysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                Console.WriteLine("Доброго времени суток! Введите год:");
                int yearNumber = int.Parse(Console.ReadLine());

                bool isLeapYear = (yearNumber % 4 == 0) && (yearNumber % 100 != 0) || (yearNumber % 400 == 0);

                int maxDayNumber;
                if (isLeapYear)
                {
                    maxDayNumber = 366;
                    daysInMonths[1] = 29;
                }
                else
                {
                    maxDayNumber = 365;
                }

                Console.WriteLine("Доброго времени суток! Введите число в промежутке между 1 и {0}:", maxDayNumber);
                int dayNumber = int.Parse(Console.ReadLine());
                if (dayNumber < 1 || dayNumber > maxDayNumber) throw new ArgumentOutOfRangeException("Введенное число должно быть в заданном диапазоне!");

                int monthNumber = 0;

                foreach (int daysInMonth in daysInMonths)
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
