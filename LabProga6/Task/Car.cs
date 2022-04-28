using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public abstract class Car
    {
        protected int Mass;
        protected int CountOfGears;
        protected int MaxSpeed;
        protected int PowerOfEngine;
        
        public Car(int Mass, int CountOfGears, int MaxSpeed, int PowerOfEngine)
        {
            this.Mass = Mass;
            this.CountOfGears = CountOfGears;
            this.MaxSpeed = MaxSpeed;
            this.PowerOfEngine = PowerOfEngine;
            Console.WriteLine("Конструктор родителя вызван.");
        }


        public void ChangeStatsOfCar(int Mass, int CountOfGears, int MaxSpeed, int PowerOfEngine)
        {
            this.Mass = Mass;
            this.CountOfGears = CountOfGears;
            this.MaxSpeed = MaxSpeed;
            this.PowerOfEngine = PowerOfEngine;
        }

        public double GetAntiPerfomanceRatio()
        {
            double PerfomanceRatio;
            PerfomanceRatio = (double)Mass / (double)MaxSpeed * (double)CountOfGears * (double)CountOfGears / (double)PowerOfEngine;
            return PerfomanceRatio;
        }

        protected virtual int ReturnCountOfWheels()
        {
            return 4;
        }

        public abstract void Move();
    }
}
