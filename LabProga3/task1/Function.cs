using System;

namespace task1
{
    public class Function
    {
        public double Func(int n, double x)
        {
            double Result = Math.Pow(x, (double)n) / (double)n;
            return Result;
        }
    }
}