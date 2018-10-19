using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue.classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// view the top of the stack
        /// </summary>
        /// <returns>Top node</returns>
        public Node Peek()
        {
            return Top;
        }

        /// <summary>
        /// removes a node from the top
        /// </summary>
        /// <returns>Top node</returns>
        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        /// <summary>
        /// add new node to the top of stack
        /// </summary>
        /// <param name="node">added node</param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
