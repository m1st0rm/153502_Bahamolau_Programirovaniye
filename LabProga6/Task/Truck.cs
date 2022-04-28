using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public sealed class Truck : Car
    {
        public Truck(int Mass, int CountOfGears, int MaxSpeed, int PowerOfEngine) : base(Mass, CountOfGears, MaxSpeed, PowerOfEngine)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Грузовик поехал!");
        }

        protected override int ReturnCountOfWheels()
        {
            return 6;
        }

        public int GetCountOfWheels()
        {
            return ReturnCountOfWheels();
        }

        public double GetAntiPerfomanceRatio(int DegreeOfTruckBigness)
        {
            return 1;
        }
    }
}
