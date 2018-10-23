using System;
using Xunit;
using stackAndQueue.classes;
using queueWithStacks.classes;


namespace queueWithStacksTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(500)]
        [InlineData("banana")]
        [InlineData(false)]
        public void NodesAdded(object input)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(input);

            QueueWithStacks queue = new QueueWithStacks(node1);

            queue.Enqueue(node2);
            queue.Enqueue(node3);

            Assert.Equal(input, queue.stack1.Top.Value);
        }

        [Theory]
        [InlineData(500)]
        [InlineData("banana")]
        [InlineData(false)]
        public void NodesRemoved(object input)
        {
            Node node1 = new Node(10);
            Node node2 = new Node(input);

            QueueWithStacks queue = new QueueWithStacks(node2);
            queue.Enqueue(node1);

            Assert.Equal(input, queue.Dequeue().Value);
        }
    }
}
