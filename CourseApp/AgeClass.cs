using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class AgeClass
    {
        public static string Age()
        {
            Console.WriteLine("Введите год своего рождения:");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения:");
            int months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день своего рождения:");
            int days = Convert.ToInt32(Console.ReadLine());
            DateTime result = DateCompare(new DateTime(years, months, days), DateTime.Now);
            return $"Вам {result.Year - 1} лет, {result.Month - 1} месяцев и {result.Day - 1} дня";
        }

        public static string Age(int days, int months, int years)
        {
            DateTime result = DateCompare(new DateTime(years, months, days), DateTime.Now);
            return $"Вам {result.Day - 1} дня, {result.Month - 1} месяцев и {result.Year - 1} лет";
        }

        public static DateTime DateCompare(DateTime date1, DateTime date2)
        {
            if (date1.Ticks < date2.Ticks)
            {
                DateTime res = new DateTime(date2.Ticks - date1.Ticks);
                return res;
            }

            throw new Exception();
        }

        public static string Age(DateTime date)
        {
            var dateCompar = DateCompare(date, DateTime.Now);
            return $"Вам {dateCompar.Day - 1} дня, {dateCompar.Month - 1} месяцев и {dateCompar.Year - 1} лет";
        }
    }
}