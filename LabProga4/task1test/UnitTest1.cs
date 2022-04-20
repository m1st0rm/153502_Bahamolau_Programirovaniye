using System;
using Xunit;
using task;

namespace task1test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            OtdelKadrov Company = OtdelKadrov.GetInstance("Comp",20,600,100);
            Assert.Equal(1044000, Company.SalarySum());
        }
        [Fact]
        public void Test2()
        {
            OtdelKadrov Company = OtdelKadrov.GetInstance("Comp", 20, 600, 100);
            Assert.Equal(0, Company.SalarySum(1));
        }
        [Fact]
        public void Test3()
        {
            OtdelKadrov Company = OtdelKadrov.GetInstance("Comp", 20, 600, 100);
            Company.SetHours(350);
            Assert.Equal(350, Company.GetHours());
        }
    }
}