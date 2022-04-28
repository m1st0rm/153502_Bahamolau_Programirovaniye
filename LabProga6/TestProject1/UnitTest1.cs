using System;
using Xunit;
using Task;

namespace TestProject1
{
    public class UnitTest1
    {
        Sedan Object1 = new Sedan(2000, 5, 180, 250);
        Truck Object2 = new Truck(4000, 12, 130, 400);
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, Object1.GetCountOfWheels());
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(6, Object2.GetCountOfWheels());
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(1, Object2.GetAntiPerfomanceRatio(1));
        }

        [Fact]
        public void Test4()
        {
            Object1.ChangeStatsOfCar(1, 1, 1, 1);
            Assert.Equal(1, Object1.GetAntiPerfomanceRatio());
        }
    }
}