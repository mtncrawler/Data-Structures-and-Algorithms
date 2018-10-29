using System;
using System.Collections.Generic;
using System.Text;

namespace trees.classes
{
    class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree (Node value)
        {
            Root = value;
        }

        public void Add(Node node, Node add)
        {
            Node current = node;
            Node previous = current;

            while (current != null)
            {
                if (add.Value < current.Value)
                {
                    previous = current;
                    current = current.LeftChild;
                }
                else if (add.Value > current.Value)
                {
                    previous = current;
                    current = current.RightChild;
                }
            }

            if (add.Value < previous.Value)
                previous.LeftChild = add;
            else
                previous.RightChild = add;
        }
    }
}
