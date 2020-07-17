using BubbleSort;
using System;
using Xunit;

namespace TEST
{
    public class UnitTest1
    {
        [Fact]
        public void BubbleSorting()
        {
            int[] arr = { 5, 3, 2, 1, 6, 10 };
            Program.BubbleSort(arr);

            Assert.Equal(10, arr[arr.Length - 1]);
        }

        [Fact]
        public void MergeSorting()
        {
            int[] arr = { 5, 3, 2, 1, 6, 10 };
            MergeSort.Program.MergeSort(arr);

            Assert.Equal(1, arr[0]);
        }
    }
}
