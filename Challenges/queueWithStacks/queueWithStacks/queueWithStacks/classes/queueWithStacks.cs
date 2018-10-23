using stackAndQueue.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace queueWithStacks.classes
{
    public class QueueWithStacks
    {
        public Stack stack1 = new Stack(null);
        public Stack stack2 = new Stack(null);

        public QueueWithStacks(Node node)
        {
            stack1 = new Stack(node);
            stack2 = new Stack(node);
        }

        /// <summary>
        /// add node to the front of queue
        /// </summary>
        /// <param name="node"></param>
        public void Enqueue(Node node)
        {
            stack1.Push(node);
        }

        /// <summary>
        /// remove node from the front of queue
        /// </summary>
        /// <returns>node that is removed</returns>
        public Node Dequeue()
        {
            if (stack2.Pop() == null )
            {
                while (stack1.Pop() == null)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            Node temp = stack2.Pop();

            while (stack2.Pop() == null)
            {
                stack1.Push(stack2.Pop());
            }

            return temp;
        }
    }
}
