using stackNQ.Class;
using System;
using Xunit;

namespace unit_test
{
    public class UnitTest1
    {
        [Fact]
        public void CanMakeNode()
        {
            Node<int> node = new Node<int>(4);
            Assert.Equal(4, node.Value);
        }

        [Fact]
        public void CanAddNextReference()
        {
            Node<int> node = new Node<int>(4);
            Node<int> node1 = new Node<int>(5);
            node.Next = node1;

            Assert.Equal(node1, node.Next);

        }

        [Fact]
        public void CanAddToStack()
        {
            Stack<int> s = new Stack<int>();
            s.Push(5);
            Assert.NotNull(s.Top);
        }

        [Fact]
        public void CanPopFromStack()
        {
            Stack<string> s = new Stack<string>();
            s.Push("Lemon");
            s.Pop();

            Assert.True(s.IsEmpty());
        }

        [Fact]
        public void ThrowExceptionWhenPoppingEmptyStack()
        {
            Stack<int> s = new Stack<int>();
            var rec = Record.Exception(() => s.Pop());
            Assert.IsType<Exception>(rec);
        }

        [Fact]
        public void CanPeekFromStack()
        {
            Stack<int> s = new Stack<int>();
            s.Push(4);
            Assert.Equal(4, s.Peek());
        }
    }
}
