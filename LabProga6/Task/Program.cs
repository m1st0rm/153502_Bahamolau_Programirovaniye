using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan FirstCar = new Sedan(2000,6,190,250);
            Hatchback SecondCar = new Hatchback(1200, 6, 250, 220);
            Truck ThirdCar = new Truck(4000, 12, 130, 400);
            FirstCar.Move();
            SecondCar.Move();
            ThirdCar.Move();
            Console.WriteLine($"Количество колес у седана : {FirstCar.GetCountOfWheels()}");
            Console.WriteLine($"Количество колес у хэтчбека : {SecondCar.GetCountOfWheels()}");
            Console.WriteLine($"Количество колес у грузовика : {ThirdCar.GetCountOfWheels()}");
            Console.WriteLine($"Коэффициент антипроизводительности седана : {FirstCar.GetAntiPerfomanceRatio()}");
            Console.WriteLine($"Коэффициент антипроизводительности хэтчбека : {SecondCar.GetAntiPerfomanceRatio()}");
            Console.WriteLine($"Коэффициент антипроизводительности грузовика : {ThirdCar.GetAntiPerfomanceRatio(1)}");
            FirstCar.ChangeStatsOfCar(1900, 5, 180, 240);
            Console.WriteLine($"Обновлённый коэффициент антипроизводительности седана : {FirstCar.GetAntiPerfomanceRatio()}");
        }
    }
}
