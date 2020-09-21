using System;
using System.Collections.Generic;
using System.Text;

namespace stackNQ.Class
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }

        public void Enqueue(T val)
        {
            Node<T> node = new Node<T>(val);
            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
            }
        }

    }
}
