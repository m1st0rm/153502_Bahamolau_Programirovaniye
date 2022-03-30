using System;
using Xunit;
using task3;

namespace task2_tests
{
    public class DataServiceTests
    {
        [Fact]
        public void DataServiceTest1()
        {
            Assert.Equal(3, DateService.GetDayOfTheWeek("30.03.2022"));
        }
        [Fact]
        public void DataServiceTest2()
        {
            Assert.Equal(4, DateService.GetDayOfTheWeek("31/03/2022"));
        }
        [Fact]
        public void DataServiceTest3()
        {
            Assert.Equal(5, DateService.GetDayOfTheWeek("01.04/2022"));
        }
    }
}