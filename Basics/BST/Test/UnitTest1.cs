using BST.Class;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddNodeToTree()
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Insert(bst.Root, 5);

            Assert.Equal(5, bst.Root.Value);
        }

        [Fact]
        public void CanAddToLeft()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 4);


            Assert.Equal(4, bst.Root.Left.Value);

        }

        [Fact]
        public void CanAddToRight()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 6);

            Assert.Equal(6, bst.Root.Right.Value);
        }

        [Fact]
        public void TreeContainsValue()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(bst.Root, 5);
            bst.Insert(bst.Root, 7);
            bst.Insert(bst.Root, 4);

            bst.Insert(bst.Root, 6);

            Assert.True(bst.Contains(bst.Root, 6));
        }
    }
}
