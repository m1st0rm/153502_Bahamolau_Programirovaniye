//вариант 16
using System;

namespace task2
{
    public class CheckZoneTask
    {
        public double InputDoubleAndCheckDouble()
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ошибка ввода! Введите число : ");
            }
            return a;
        }
        public int IsDotInZoneOrOnBoard(double x, double y)
        {
            double StandartX = 10;
            double StandartY = 5;
            if (((x < StandartX)&&(x>0)) && ((y < StandartY)&&(y>0)))
            {
                return 1;
            }
            else if (((x <= StandartX)&&((y==0)||(y==5))) || ((y <= StandartY) && ((x == 0) || (x == 10))))
            {
                return 2;
            }
            else 
            {
                return 0;
            }
        }
        static void Main()
        {
            double x, y,GoNext;
            int IsDotInZone;
            Console.WriteLine("Программа определяет лежит ли точка в прямоугольнике, образованном точками (0,0) и (10,5), или же лежит на его границе.\n");
            CheckZoneTask e = new CheckZoneTask();
            do
            {
                Console.WriteLine("Введите координату x :");
                x = e.InputDoubleAndCheckDouble();
                Console.WriteLine("Введите координату y :");
                y = e.InputDoubleAndCheckDouble();
                IsDotInZone = e.IsDotInZoneOrOnBoard(x, y);
                if (IsDotInZone == 2)
                {
                    Console.WriteLine("Точка лежит на границе прямоугольника.");
                }
                else if (IsDotInZone == 1)
                {
                    Console.WriteLine("Точка лежит внутри прямоугольника.");
                }
                else if (IsDotInZone == 0)
                {
                    Console.WriteLine("Точка лежит за пределами прямоугольника.");
                }
                Console.WriteLine("Желаете продолжить работу программы? (1 или большее число - да, число меньшее 1 - нет)\n");
                GoNext = e.InputDoubleAndCheckDouble();
            } while (GoNext >= 1);
        }
    }
}