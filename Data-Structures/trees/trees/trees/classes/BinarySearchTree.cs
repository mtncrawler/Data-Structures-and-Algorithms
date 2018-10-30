using System;
using System.Collections.Generic;
using System.Text;

namespace trees.classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree (Node value)
        {
            Root = value;
        }

        /// <summary>
        /// add a node to a binary search tree
        /// </summary>
        /// <param name="add">node to be added</param>
        public void Add(Node add)
        {
            Node current = Root;
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

        /// <summary>
        /// search tree to find a node
        /// </summary>
        /// <param name="findMe">Node being searched for</param>
        /// <returns>Node that matches input in tree</returns>
        public Node Search(Node findMe)
        {
            Node current = Root;

            while (current != null)
            {
                if (findMe.Value == current.Value)
                {
                    return current;
                }
                else if (findMe.Value < current.Value)
                {
                    current = current.LeftChild;
                }
                else if (findMe.Value > current.Value)
                {
                    current = current.RightChild;
                }
            }

            return null;
        }
    }
}
