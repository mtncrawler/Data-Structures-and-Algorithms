using System;
using Xunit;
using stackAndQueue.classes;

namespace stackAndQueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void PushNodeToStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);
            
            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Peek());
        }

        [Fact]
        public void PopNodeFromStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Pop());
        }

        [Fact]
        public void PeekANodeFromStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Peek());
        }

        [Fact]
        public void AddNodeToQueue()
        {

        }
    }
}
