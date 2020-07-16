using System;
using System.Collections.Generic;

namespace FourSum
{
    public class FourSum
    {
        static void Main(string[] args)
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

            int result = FourSums(a, b, c, d);
        }

        public static int FourSums(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int result = 0;

            foreach (var a in A)
            {
                foreach (var b in B)
                {
                    int key = a + b;
                    dictionary[key] = dictionary.GetValueOrDefault(key, 0) + 1;
                }
            }

            foreach(var c in C)
            {
                foreach(var d in D)
                {
                    int key = c + d;
                    if (dictionary.ContainsKey(key))
                        result += dictionary[key];
                }
            }

            return result;
        }
    }
}
