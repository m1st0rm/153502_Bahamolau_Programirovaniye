using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Hatchback : Car
    {
        public Hatchback(int Mass, int CountOfGears, int MaxSpeed, int PowerOfEngine) : base(Mass, CountOfGears, MaxSpeed, PowerOfEngine)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Хэтчбек поехал!");
        }

        public int GetCountOfWheels()
        {
            return ReturnCountOfWheels();
        }
    }
}
