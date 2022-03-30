using System;

namespace task2.MathFunc
{
    public class MathFunc
    {
        public void Func(double z)
        {
            double x;
            if (z >= 0)
            {
                Console.WriteLine("Вычисления пошли по ветке номер 1.\n");
                x = 2 * z + 1;
            }
            else 
            {
                Console.WriteLine("Вычисления пошли по ветке номер 2.\n");
                double LogArgument = Math.Pow(z, 2) - z;
                x = Math.Log(LogArgument);            
            }
            double Result = Math.Pow(Math.Sin(x), 2) + Math.Pow(Math.Cos(Math.Pow(x, 3)), 5) + Math.Log(Math.Pow(x, 0.4));
            Console.WriteLine($"Значение выражения sin^2(x) + cos^5(x^3) + ln(x^0.4) равно : {Result}\n ");
        }
    }
}
