using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace BST.Class
{
    public class BinarySearchTree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int val)
            {
                Value = val;
                Left = null; 
                Right = null;
            }
        }

        public Node Root { get; set; }

        public Node Insert(Node node, int value)
        {
            if(Root == null)
            {
                node = new Node(value);
                Root = node;
                return node;
            }

            else
            {
                if(node == null)
                {
                    node = new Node(value);
                    return node;
                }

                if (value <= node.Value)
                    node.Left = Insert(node.Left, value);

                if (value > node.Value)
                    node.Right = Insert(node.Right, value);
            }
            return node;
        }

        public bool Contains(Node node, int searchValue)
        {
            if (node == null)
                return false;

            else
            {
                if (node.Value == searchValue)
                    return true;

                if (node.Value < searchValue)
                    return Contains(node.Right, searchValue);
                else
                    return Contains(node.Left, searchValue);
            }
        }
    }
}
