using System;
namespace task2
{
    class task2
    {
        static double InputDouble()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число : ");
            }
            return a;
        }

        static int InputNatural()
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1)
            {
                Console.WriteLine("Ошибка ввода! Введите натуральное число : ");
            }
            return a;
        }

        static void Main()
        {
            MathFunc.MathFunc Object = new MathFunc.MathFunc();
            Console.WriteLine("Программа вычисляет значение выражения sin^2(x) + cos^5(x^3) + ln(x^0.4).\n");
            Console.WriteLine("x зависит от значения z, введённого пользователем.\n");
            Console.WriteLine("1-ая ветка : x = 2*z + 1, если z >= 0.\n");
            Console.WriteLine("2-ая ветка : x = ln(z^2 - z), если z < 0.\n");
            double z;
            int GoNext;
            do
            {
                Console.WriteLine("Введите z : ");
                z = InputDouble();
                Object.Func(z);
                Console.WriteLine("Желаете продолжить работу? Введите 1 для продолжения или\nлюбое другое натуральное число для остановки работы программы : ");
                GoNext = InputNatural();
            } while (GoNext == 1);
        }
    }
}