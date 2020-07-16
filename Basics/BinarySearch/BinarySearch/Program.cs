using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 5, 7, 8, 10, 11, 12, 108 };

            Console.WriteLine(BinarySearch(arr, 108));
        }

        public static int BinarySearch(int[] ar, int sv)
        {
            if (ar.Length == 0)
                throw new InvalidOperationException();

            int start = 0;
            int end = ar.Length - 1;
            while(start <= end)
            {
                int mid = (end + start) / 2;

                if (ar[mid] == sv)
                    return mid;

                if (ar[mid] > sv)
                    end = mid - 1;

                if (ar[mid] < sv)
                    start = mid + 1;
            }
            return -1;
        }

        public static void BubbleSort(int[] ar)
        {
            if (ar.Length == 0)
                return;

            for (int partIndex = ar.Length -1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (ar[i] > ar[i + 1])
                        Swap(ar, i, i + 1);
                }
            }
        }

        public static void Swap(int[] ar, int i, int j)
        {
            if (i >= j)
                return;

            int temp = ar[j];
            ar[j] = ar[i];
            ar[i] = temp;
        }
    }
}
