using System;
using Xunit;
using task1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BaseOfNumbers Hotel = new BaseOfNumbers();
            Hotel.AddNumberWithDiscount("Luxe", 50, 50);
            Hotel.AddNumberWithoutDiscount("Standart", 10);
            Assert.Equal(17.5, Hotel.GetAverageCostOfLiving());
        }

        [Fact]
        public void Test2()
        {
            BaseOfNumbers Hotel = new BaseOfNumbers();
            Hotel.AddNumberWithDiscount("Luxe", 50, 50);
            Hotel.AddNumberWithDiscount("Standart", 10,50);
            Assert.Equal(15, Hotel.GetAverageCostOfLiving());
        }

        [Fact]
        public void Test3()
        {
            BaseOfNumbers Hotel = new BaseOfNumbers();
            Hotel.AddNumberWithoutDiscount("Luxe", 50);
            Hotel.AddNumberWithoutDiscount("Standart", 10);
            Assert.Equal(30, Hotel.GetAverageCostOfLiving());
        }
    }
}
