using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseOfNumbers Hotel = new BaseOfNumbers();
            Hotel.AddNumberWithDiscount("Luxe", 50, 50);
            Hotel.AddNumberWithoutDiscount("Standart", 10);
            Console.WriteLine(Hotel.GetAverageCostOfLiving());
        }
    }
}
