using System;

namespace RemoveDuplicate
{
    public class ReDu
    {
        static void Main(string[] args)
        {
            int[] r = { 1, 1, 4, 5, 6, 9 };
            int t = RemoveDup(r);
            Console.WriteLine(t);
        }

        public static int RemoveDup(int[] num)
        {
            if (num.Length < 2)
                return num.Length;
            int l = 1;
            for (int i = 1; i < num.Length; i++)
            {
                if(num[i] != num[i-1])
                {
                    num[l++] = num[i];
                }
            }
            return l;
        }
    }
}
