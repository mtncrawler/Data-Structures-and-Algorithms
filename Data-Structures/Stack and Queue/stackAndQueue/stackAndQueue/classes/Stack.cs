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

        public Node Peek()
        {
            return Top;
        }

        public Node Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
