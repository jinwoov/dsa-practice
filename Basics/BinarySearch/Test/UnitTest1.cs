using BinarySearch;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanSearchValue()
        {
            int[] arr = { 1, 2, 4, 5, 7, 8 ,10,11,12,108};

            Assert.Equal(arr.Length - 1, Program.BinarySearch(arr, 108));

        }

        [Fact]
        public void DontHaveValue()
        {
            int[] arr = { 1, 2, 4, 5, 7, 8, 10, 11, 12, 108 };
            Assert.Equal(-1, Program.BinarySearch(arr, 114));


        }

        [Fact]
        public void CanSortArray()
        {
            int[] arr = { 5, 2, 4, 6, 8, 1, 3, 5, 6 };

            Program.BubbleSort(arr);

            Assert.Equal(8, arr[arr.Length - 1]);
        }

        [Fact]
        public void CanFindValueWithinUnsortedArr()
        {
            int[] arr = { 5, 2, 4, 6, 8, 1, 3, 5, 6,7 };

            Program.BubbleSort(arr);

            Assert.Equal(7, arr[Program.BinarySearch(arr, 7)]);

        }
    }
}
