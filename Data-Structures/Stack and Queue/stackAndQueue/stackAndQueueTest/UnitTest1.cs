using System;
using Xunit;
using stackAndQueue.classes;

namespace stackAndQueueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test a node is added to stack
        /// </summary>
        [Fact]
        public void PushNodeToStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);
            
            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Peek());
        }

        /// <summary>
        /// test to remove from stack
        /// </summary>
        [Fact]
        public void PopNodeFromStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Pop());
        }

        /// <summary>
        /// test to view the top node of stack
        /// </summary>
        [Fact]
        public void PeekANodeFromStack()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Stack myStack = new Stack(node1);
            myStack.Push(node2);

            Assert.Equal(node2, myStack.Peek());
        }

        /// <summary>
        /// test a node is added to a queue
        /// </summary>
        [Fact]
        public void AddNodeToQueue()
        {
            Node node1 = new Node("banana");
            Queue myQueue = new Queue(node1);

            Assert.Equal(node1, myQueue.Peek());
        }

        /// <summary>
        /// teste a node is removed from a queue
        /// </summary>
        [Fact]
        public void RemoveNodeFromQueue()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);

            Assert.Equal(node1, myQueue.Dequeue());
        }

        /// <summary>
        /// test to view the front node from a queue
        /// </summary>
        [Fact]
        public void PeekANodeFromQueue()
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(20);

            Queue myQueue = new Queue(node1);
            myQueue.Enqueue(node2);

            Assert.Equal(node1, myQueue.Peek());
        }
    }
}
