using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            FibonacciNum(5);
        }
        public static int FibonacciNum(int n)
        {
            int[] dp = new int[n + 1];

            return FibHelper(n, dp);
        }

        private static int FibHelper(int n, int[] dp)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (dp[n] > 0)
                return dp[n];

            dp[n] = FibHelper(n - 1, dp) + FibHelper(n - 2, dp);

            return dp[n];

        }
    }
}
