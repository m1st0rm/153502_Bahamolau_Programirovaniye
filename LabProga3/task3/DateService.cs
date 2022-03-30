using System;

namespace task3
{
    public class DateService
    {
        public static int GetDayOfTheWeek(string DateFromString)
        {
            DateTime Date = DateTime.Parse(DateFromString);
            return (int)Date.DayOfWeek;
        }
        public static int DaysBetweenDates(int year, int month, int day)
        {
            DateTime NowDate = DateTime.UtcNow;
            DateTime DateToCompare = new DateTime(year, month, day);
            TimeSpan Span;
            if (DateToCompare > NowDate)
            {
                Span = DateToCompare - NowDate;
                return Span.Days + 1;
            }
            else
            {
                Span = NowDate - DateToCompare;
                return Span.Days;
            }
        }
    }
}