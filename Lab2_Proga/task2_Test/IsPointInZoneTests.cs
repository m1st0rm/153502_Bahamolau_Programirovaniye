using System;
using Xunit;
using task2;

namespace task2_Test
{
    public class IsPointInZoneTests
    {
        [Fact]
        public void IsPointInZoneTest1()
        {
            var e = new CheckZoneTask();
            Assert.Equal(2, e.IsDotInZoneOrOnBoard(10, 5));
        }
        [Fact]
        public void IsPointInZoneTest2()
        {
            var e = new CheckZoneTask();
            Assert.Equal(1, e.IsDotInZoneOrOnBoard(9, 4));
        }
        [Fact]
        public void IsPointInZoneTest3()
        {
            var e = new CheckZoneTask();
            Assert.Equal(0, e.IsDotInZoneOrOnBoard(3, 6));
        }
        [Fact]
        public void IsPointInZoneTest4()
        {
            var e = new CheckZoneTask();
            Assert.Equal(2, e.IsDotInZoneOrOnBoard(0, 0));
        }
        [Fact]
        public void IsPointInZoneTest5()
        {
            var e = new CheckZoneTask();
            Assert.Equal(2, e.IsDotInZoneOrOnBoard(9, 5));
        }
        [Fact]
        public void IsPointInZoneTest6()
        {
            var e = new CheckZoneTask();
            Assert.Equal(2, e.IsDotInZoneOrOnBoard(10, 3));
        }
        [Fact]
        public void IsPointInZoneTest7()
        {
            var e = new CheckZoneTask();
            Assert.Equal(1, e.IsDotInZoneOrOnBoard(2.5, 2.5));
        }
        [Fact]
        public void IsPointInZoneTest8()
        {
            var e = new CheckZoneTask();
            Assert.Equal(0, e.IsDotInZoneOrOnBoard(-2.5, -2.5));
        }
    }
}