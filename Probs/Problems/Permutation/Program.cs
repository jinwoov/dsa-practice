using System;
using System.Collections.Generic;
using System.Text;

namespace Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PermutationPal("tocaoca"));
        }

        static bool PermutationPal(string s)
        {
            HashSet<string> hs = new HashSet<string>();

            PermutationRecur(s, hs, "");

            foreach (var item in hs)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = item.Length- 1; i >= 0; i--)
                {
                    sb.Append(item[i]);
                }
                if (item == sb.ToString())
                    return true;
            }

            return false;
        }

        private static void PermutationRecur(string s, HashSet<string> hs, string prefix)
        {
            // strign length =0, means that prefix will be fill with permutated string
            if (s.Length == 0)
            {
                hs.Add(prefix);
                return;
            }

            for(int i =0; i < s.Length; i++)
            {
                string rem = s.Substring(0, i) + s.Substring(i + 1);
                PermutationRecur(rem, hs, prefix + s[i]);
            }

        }
    }
}
