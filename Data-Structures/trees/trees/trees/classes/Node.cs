using System;
using System.Collections.Generic;
using System.Text;

namespace trees.classes
{
    public class Node
    {
        public int Value { get; set; }

        public Node LeftChild { get; set; }

        public Node RightChild { get; set; }

        public Node (int value)
        {
            Value = value;
        }

    }
}
