using System;
using Xunit;
using task1;

namespace task1_tests
{
    public class FunctionTests
    {
        [Fact]
        public void FunctionTest1()
        {
            var e = new Function();
            Assert.Equal(1,e.Func(1,1));
        }
        [Fact]
        public void FunctionTest2()
        {
            var e = new Function();
            Assert.Equal(0.5, e.Func(2, 1));
        }
        [Fact]
        public void FunctionTest3()
        {
            var e = new Function();
            Assert.Equal(2, e.Func(2, 2));
        }
    }
}
