using System;
using Xunit;
using task1;

namespace task1_Test
{
    public class TriangleCheckTests
    {
        [Fact]
        public void TriangleCheckTest1()
        {
            var e = new TriangleTask();
            Assert.False(e.TriangleCheck(1, 2, 3));
        }
        [Fact]
        public void TriangleCheckTest2()
        {
            var e = new TriangleTask();
            Assert.True(e.TriangleCheck(1, 1, 1));
        }
        [Fact]
        public void TriangleCheckTest3()
        {
            var e = new TriangleTask();
            Assert.False(e.TriangleCheck(1.5, 3.5, 2));
        }
        [Fact]
        public void TriangleCheckTest4()
        {
            var e = new TriangleTask();
            Assert.True(e.TriangleCheck(37.333, 37.333, 64.666));
        }
    }
}
