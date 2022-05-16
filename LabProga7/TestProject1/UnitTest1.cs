using System;
using Xunit;
using LabProga7;

namespace TestProject1
{
    public class UnitTest1
    {
        Interval FirstObject = new Interval();
        Interval SecondObject = new Interval(10, 20);
        Interval ThirdObject = new Interval(5, 7);
        Interval FourthObject = new Interval(15, 17.5);
        Interval FifthObject;
        Interval SixthObject = new Interval(9.5, 17.5);
        [Fact]
        public void Test1()
        {
            FirstObject.Beginning = -1;
            FirstObject[1]= 1;
            Assert.Equal(2, FirstObject.GetLength());
        }

        [Fact]
        public void Test2()
        {
            FifthObject = ThirdObject + SecondObject;
            Assert.Equal(12, FifthObject.GetLength());
        }

        [Fact]
        public void Test3()
        {
            FifthObject = SecondObject - ThirdObject;
            Assert.Equal(8, FifthObject.GetLength());
        }

        [Fact]
        public void Test4()
        {
            FifthObject = SecondObject * ThirdObject;
            Assert.Equal(0, FifthObject.GetLength());
        }

        [Fact]
        public void Test5()
        {
            FifthObject = SecondObject * FourthObject;
            Assert.Equal(2.5, FifthObject.GetLength());
        }

        [Fact]
        public void Test6()
        {
            FifthObject = SecondObject * SixthObject;
            Assert.Equal(7.5, FifthObject.GetLength());
        }

        [Fact]
        public void Test7()
        {
            FirstObject++;
            ++FirstObject;
            FirstObject++;
            ++FirstObject;
            Assert.Equal(8, FirstObject.GetLength());
        }

        [Fact]
        public void Test8()
        {
            SecondObject--;
            --SecondObject;
            Assert.Equal(6, SecondObject.GetLength());
        }

        [Fact]
        public void Test9()
        {
            Assert.True(FourthObject > ThirdObject);
        }

        [Fact]
        public void Test10()
        {
            Assert.False(FourthObject < ThirdObject);
        }

        [Fact]
        public void Test11()
        {
            FourthObject.Beginning = 9;
            FourthObject.End = 11;
            Assert.True(ThirdObject==FourthObject);
        }

        [Fact]
        public void Test12()
        {
            Assert.True(ThirdObject != FourthObject);
        }

        [Fact]
        public void Test13()
        {
            Assert.False(FourthObject >= SixthObject);
        }

        [Fact]
        public void Test14()
        {
            Assert.True(FourthObject <= SixthObject);
        }

        [Fact]
        public void Test15()
        {
            bool Status;
            if (FirstObject)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            Assert.False(Status);
        }

        [Fact]
        public void Test16()
        {
            bool Status;
            if (SecondObject)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }
            Assert.True(Status);
        }

        [Fact]
        public void Test17()
        {
            Assert.Equal(2.5, (double)FourthObject);
        }

        [Fact]
        public void Test18()
        {
            FifthObject = (Interval)22.5;
            Assert.Equal(0, FifthObject[0]);
        }

        [Fact]
        public void Test19()
        {
            FifthObject = (Interval)22.5;
            Assert.Equal(22.5, FifthObject.End);
        }

        [Fact]
        public void Test20()
        {
            Assert.Equal("Beginning = 5, End = 7, Length = 2", ThirdObject.ToString());
        }
    }
}