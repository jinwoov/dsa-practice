using BST.Class;
using System;

namespace BST
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 4);
            bst.Insert(bst.Root, 3);
            bst.Insert(bst.Root, 7);
            bst.Insert(bst.Root, 10);


            BT.PreOrder(bst.Root);
            Console.WriteLine();
            BT.InOrder(bst.Root);
            Console.WriteLine();
            BT.PostOrder(bst.Root);
            Console.WriteLine();
            BT.BreathFirst(bst.Root);

        }
    }
}
