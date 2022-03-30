using System;

namespace task1
{
    public class task1
    {
        static int InputNatural() {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a) || a<1)
            {
                Console.WriteLine("Ошибка ввода! Введите натуральное число : ");
            }
            return a;
        }
        static double InputDouble()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число : ");
            }
            return a;
        }
        static void Main()
        {
            Console.WriteLine("Программа вычисляет x^2/2 + x^4/4 + x^6/6 с помощью метода f(n,x).\n");
            Console.WriteLine("Где f(n,x) = x^n/n.\n");
            int Choice;
            int GoNext;
            Function Object = new Function();
            do
            {
                Console.WriteLine("Выберите вид использования программы : \n");
                Console.WriteLine("1. Вычисление x^2/2 + x^4/4 + x^6/6 для введённого x.\n");
                Console.WriteLine("2. Вычисление f(n,x) для введённых n и x.\n");
                Choice = InputNatural();
                while (Choice != 1 && Choice != 2)
                {
                    Console.WriteLine("Вы ввели номер несуществующего вида использования программы. Введите номер вида снова.\n");
                    Choice = InputNatural();
                }
                if (Choice == 1)
                {
                    Console.WriteLine("Введите x - вещественное число : ");
                    double x = InputDouble();
                    double Result = Object.Func(2, x) + Object.Func(4, x) + Object.Func(6, x);
                    Console.WriteLine($"Результат выражения x^2/2 + x^4/4 + x^6/6 для x = {x} равен : {Result}\n");
                }
                else
                {
                    Console.WriteLine("Введите n - натуральное число : ");
                    int n = InputNatural();
                    Console.WriteLine("Введите x - вещественное число : ");
                    double x = InputDouble();
                    double Result = Object.Func(n, x);
                    Console.WriteLine($"Результат выражения x^n/n для x = {x} и n = {n} равен : {Result}\n");
                }
                Console.WriteLine("Желаете продолжить работу? Введите 1 для продолжения или\nлюбое другое натуральное число для остановки работы программы : ");
                GoNext = InputNatural();
            } while (GoNext == 1);
        }
    }
}