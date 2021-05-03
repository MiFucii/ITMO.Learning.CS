using System;
using System.Collections;


namespace Exercise1
{
    enum MonthName { Января, Февраля, Марта, Апреля, Мая, Июня, Июля, Августа, Сентября, Октября, Ноября, Декабря }


    class WhatDay1
    {
        static ICollection DaysInMonths = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго времени суток! Введите число в промежутке между 1 и 365:");
            int dayNumber = int.Parse(Console.ReadLine());
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

            //if (dayNumber <= 31) goto End; // Январь
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 28) goto End; // Февраль
            //else
            //{
            //    dayNumber -= 28;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Март
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 30) goto End; // Апрель
            //else
            //{
            //    dayNumber -= 30;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Май
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 30) goto End; // Июнь
            //else
            //{
            //    dayNumber -= 30;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Июль
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Август
            //else
            //{ 
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 30) goto End; // Сентябрь
            //else
            //{
            //    dayNumber -= 30;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Октябрь
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 30) goto End; // Ноябрь
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //if (dayNumber <= 31) goto End; // Декабрь
            //else
            //{
            //    dayNumber -= 31;
            //    monthNumber++;
            //}

            //End:

            //switch (monthNumber)
            //{
            //    case 0:
            //        monthName = "Января"; break;
            //    case 1:
            //        monthName = "Февраля"; break;
            //    case 2:
            //        monthName = "Марта"; break;
            //    case 3:
            //        monthName = "Апреля"; break;
            //    case 4:
            //        monthName = "Мая"; break;
            //    case 5:
            //        monthName = "Июня"; break;
            //    case 6:
            //        monthName = "Июля"; break;
            //    case 7:
            //        monthName = "Августа"; break;
            //    case 8:
            //        monthName = "Сентября"; break;
            //    case 9:
            //        monthName = "Октября"; break;
            //    case 10:
            //        monthName = "Ноября"; break;
            //    case 11:
            //        monthName = "Декабря"; break;
            //    default:
            //        monthName = "Месяц не найден!"; break;
            //}
        }
    }
}
