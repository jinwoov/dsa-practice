using System;
using System.Collections.Generic;
using System.Text;
using static BST.Class.BinarySearchTree;

namespace BST.Class
{
    public class BT
    {
        public static void PreOrder(Node node)
        {
            if (node == null)
                return;
            else
            {
                Console.Write(node.Value + " => ");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }
        }

        public static void InOrder(Node node)
        {
            if (node == null)
                return;
            else
            {
                InOrder(node.Left);
                Console.Write(node.Value + " => ");
                InOrder(node.Right);
            }
        }

        public static void PostOrder(Node node)
        {
            if (node == null)
                return;
            else
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write(node.Value + " => ");
            }
        }

        public static void BreathFirst(Node node)
        {
            if (node == null)
                return;

            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while(q.Count > 0)
            {
                Node temp = q.Dequeue();
                Console.Write(temp.Value + " => ");

                if (temp.Left != null)
                    q.Enqueue(temp.Left);
                if (temp.Right != null)
                    q.Enqueue(temp.Right);
            }
        }
    }
}
