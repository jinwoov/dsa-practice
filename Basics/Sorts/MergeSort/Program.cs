using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 2, 5, 4, 20, 22, 40 };
            MergeSort(a);
            foreach (var n in a)
            {
                Console.Write($"{n}, ");
            }
        }

        public static void MergeSort(int[] arr) => Sort(arr, new int[arr.Length] ,0, arr.Length - 1);

        private static void Sort(int[] arr, int[] aux, int low, int high)
        {
            if (high <= low)
                return;
            int mid = (high + low) / 2;
            Sort(arr, aux, low, mid);
            Sort(arr, aux, mid + 1, high);
            Merge(arr, aux, low, mid, high);
        }

        private static void Merge(int[] a, int[] aux, int low, int mid, int high)
        {
            if (a[mid] <= a[mid + 1])
                return;

            int j = low;
            int k = mid + 1;

            Array.Copy(a, low, aux, low, high - low + 1);

            for (int i = low; i <= high; i++)
            {
                if(j > mid)
                {
                    a[i] = aux[k++];
                }
                else if(k > high)
                {
                    a[i] = aux[j++];
                }
                else if(aux[k] < aux[j])
                {
                    a[i] = aux[k++];
                }
                else
                {
                    a[i] = aux[j++];
                }
            }

        }
    }
}
