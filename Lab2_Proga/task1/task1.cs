//Вариант 16
using System;

namespace task1
{
    public class TriangleTask
    {
        public double InputDoubleAndCheckDouble() {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число : ");
            }
            return a;
        }
        public bool TriangleCheck(double a, double b, double c)
        {
            if (((b + c) > a) && ((a + b) > c) && ((a + c) > b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            double a, b, c,GoNext;
            Console.WriteLine("Программа определяет существует ли треугольник с длинами сторон a, b, c.\n");
            TriangleTask e = new TriangleTask();
            do
            {
                Console.WriteLine("Введите длину стороны a : ");
                a = e.InputDoubleAndCheckDouble();
                Console.WriteLine("Введите длину стороны b : ");
                b = e.InputDoubleAndCheckDouble();
                Console.WriteLine("Введите длину стороны c : ");
                c = e.InputDoubleAndCheckDouble();
                if (e.TriangleCheck(a, b, c))
                {
                    Console.WriteLine("Треугольник с данными сторонами существует.\n");
                }
                else
                {
                    Console.WriteLine("Треугольник с данными сторонами не существует.\n");
                }
                Console.WriteLine("Желаете продолжить работу программы? (1 или большее число - да, число меньшее 1 - нет)\n");
                GoNext = e.InputDoubleAndCheckDouble();
            } while (GoNext>=1);
        }
    }
}