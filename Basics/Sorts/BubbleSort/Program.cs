using System;

namespace BubbleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] r = { 4, 2, 5, 6, 3, 6, 7, 8 };
            BubbleSort(r);
            foreach (var n in r)
            {
                if(n == 8)
                    Console.Write($"{n}");
                else
                    Console.Write($"{n}, ");

            }
        }


        public static void BubbleSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            for (int partIndex = arr.Length- 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (arr[i] > arr[i + 1])
                        Swap(arr, i, i + 1);
                }
            }
        }

        static void Swap(int[] a, int i, int j)
        {
            if (i == j)
                return;

            int temp = a[j];
            a[j] = a[i];
            a[i] = temp;
        }
    }
}
