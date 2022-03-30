using System;

namespace task3
{
    class Program
    {
        static int ChoiceInput()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || (a!=1 && a!=2))
            {
                Console.WriteLine("Ошибка ввода! Введите корректный номер действия : ");
            }
            return a;
        }
        static string DateInput()
        {
            string a;
            DateTime date;
            bool Check;
        error:
            a = Console.ReadLine();
            Check = DateTime.TryParse(a, out date);
            if (Check)
            {
                return a;
            }
            else
            {
                Console.WriteLine("Дата введена неправильно! Попробуйте ещё раз : ");
                goto error;
            }
        }
        static int SpanAndDateByIntsInput()
        {
            int year;
            int month;
            int day;
            int span;
            Console.WriteLine("Введите год (от 1 до 9999) : ");
            while (!int.TryParse(Console.ReadLine(), out year) || year<1 || year>9999)
            {
                Console.WriteLine("Ошибка ввода! Введите корректный год (от 1 до 9999) : ");
            }
            if ((year % 4) == 0)
            {
                Console.WriteLine("Введите месяц (от 1 до 12) : ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка ввода! Введите корректный месяц (от 1 до 12) : ");
                }
                if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("Введите день (от 1 до 31) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 31) : ");
                    }
                }
                else if(month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("Введите день (от 1 до 30) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 30)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 30) : ");
                    }
                }
                else
                {
                    Console.WriteLine("Введите день (от 1 до 29) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 29)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 29) : ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Введите месяц (от 1 до 12) : ");
                while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
                {
                    Console.WriteLine("Ошибка ввода! Введите корректный месяц (от 1 до 12) : ");
                }
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    Console.WriteLine("Введите день (от 1 до 31) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 31) : ");
                    }
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    Console.WriteLine("Введите день (от 1 до 30) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 30)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 30) : ");
                    }
                }
                else
                {
                    Console.WriteLine("Введите день (от 1 до 28) : ");
                    while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 28)
                    {
                        Console.WriteLine("Ошибка ввода! Введите корректный день (от 1 до 28) : ");
                    }
                }
            }
            span = DateService.DaysBetweenDates(year, month, day);
            return span;
        }
        static void Main()
        {
            Console.WriteLine("Программа имеет следующие возможности : \n");
            Console.WriteLine("1. Определить день недели по введённой дате. \n");
            Console.WriteLine("2. Определить количество дней между текущей и введённой датами. \n");
            int Choice, GoNext;
            string [] DaysOfTheWeek  = { "воскресенье", "понедельник", "вторник", "среда", "четверг", "пятница", "суббота" };
            do
            {
                Console.WriteLine("Выберите номер действия, которое вы хотите выполнить : ");
                Choice = ChoiceInput();
                if (Choice == 1)
                {
                    Console.WriteLine("Введите дату в формате дд.мм.гггг (дд/мм/гггг) : ");
                    string Date = DateInput();
                    int DayOfTheWeek = DateService.GetDayOfTheWeek(Date);
                    Console.WriteLine($"Это {DaysOfTheWeek[DayOfTheWeek]}.\n");
                }
                else
                {
                    int Span = SpanAndDateByIntsInput();
                    Console.WriteLine($"Количество между текущей и нынешней датой : {Span}.\n");
                }
                Console.WriteLine("Желаете продолжить работу? Введите 1 для продолжения или 2 для остановки работы программы : ");
                GoNext = ChoiceInput();
            } while (GoNext == 1);
        }
    }
}