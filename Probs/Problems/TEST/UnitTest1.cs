using Problems;
using RemoveDuplicate;
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

        [Fact]
        public void FourSumOfArrays()
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            int[] d = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = i;
                b[i] = i + 1;
                c[i] = i + 2;
                d[i] = i + 3;
            }

            int result = FourSum.FourSum.FourSums(a, b, c, d);

            Assert.Equal(540, result);
        }

        [Fact]
        public void RemoveDuplicate()
        {
            int[] r = { 1, 1, 4, 5, 6, 9 };
            int t = ReDu.RemoveDup(r);

            Assert.Equal(5, t);
        }
    }
}
