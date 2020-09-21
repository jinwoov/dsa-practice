using stackNQ.Class;
using System;

namespace stackNQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(5);
            Console.WriteLine(s.Pop());

            Console.WriteLine(s.IsEmpty());
        }
    }
}
