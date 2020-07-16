using BST.Class;
using System;
using static BST.Class.BinarySearchTree;

namespace BST
{
    public class Program
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 7);
            bst.Insert(bst.Root, 4);
            bst.Insert(bst.Root, 3);
            bst.Insert(bst.Root, 6);

            bool result = Program.SumContains(bst.Root, 12);


            //BT.PreOrder(bst.Root);
            //Console.WriteLine();
            //BT.InOrder(bst.Root);
            //Console.WriteLine();
            //BT.PostOrder(bst.Root);
            //Console.WriteLine();
            BT.BreathFirst(bst.Root);

            Console.WriteLine(result);
        }

        public static bool SumContains(Node node, int sv) => HelperMethod(node, false, 0, sv);
        public static bool HelperMethod(Node node, bool result, int sumVal, int sv)
        {

            if (node == null)
                return false;

            sumVal += node.Value;

            if (node.Left == null && node.Right == null && sv == sumVal)
                return true;


            else
            {
                if (result)
                    return result;

                if(node.Left != null)
                    result = HelperMethod(node.Left, result, sumVal, sv);

                if(node.Right != null)
                    result = HelperMethod(node.Right, result, sumVal, sv);

                return result;
            }
        }
    }
}
