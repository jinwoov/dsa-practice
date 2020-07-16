using Problems;
using System;
using Xunit;

namespace TEST
{
    public class UnitTest1
    {
        [Fact]
        public void FibonacciNumberWorks()
        {
            int result = Program.FibonacciNum(5);

            Assert.Equal(5, result);

        }
    }
}
