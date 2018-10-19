using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue.classes
{
    class Stack
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
            Node temp = Top.Next;
            Top = Top.Next;
        }
    }
}
