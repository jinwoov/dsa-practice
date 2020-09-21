using System;
using System.Collections.Generic;
using System.Text;

namespace stackNQ.Class
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public void Push(T val)
        {
            var node = new Node<T>(val);
            if(Top == null)
            {
                Top = node;
            }
            else
            {
                node.Next = Top;
                Top = node;
            }
        }

        public T Pop()
        {
            if (Top == null)
                throw new Exception("There is nothing in the stack");
            else
            {
                var temp = Top;
                Top = Top.Next;
                return temp.Value;
            }
        }

        public T Peek() => Top == null ? throw new Exception("There is nothing in the stack") : Top.Value;

        public bool IsEmpty() => Top == null;
    }
}
