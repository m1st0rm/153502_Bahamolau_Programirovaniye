using System;

namespace _153502_Bahamolau
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.Write("Программа осуществляет деление двух чисел. \n");
            Console.Write("Введите число a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число b : ");
            b = Convert.ToInt32(Console.ReadLine());
            double c, d;
            c = a / b;
            d = b / a;
            Console.Write($"Частное от деления числа a на число b равен {c} \n");
            Console.Write($"Частное от деления числа b на число a равен {d} \n");
            Console.Write("Нажмите любую клавишу для завершения программы \n");
            Console.ReadKey();
        }
    }
}