using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.classes
{
    class LinkedList
    {
        /// <summary>
        /// Always points to the first node in the LL
        /// </summary>
        public Node Head
        {
            get; set;
        }

        /// <summary>
        /// Node that is used to traverse through the LL
        /// </summary>
        public Node Current
        {
            get; set;
        }

        /// <summary>
        /// LL requires a node at time of creation to be the HEAD
        /// </summary>
        /// <param name="node"></param>
        public LinkedList(Node node)
        {
            Head = node;
            Current = node;
        }

        /// <summary>
        /// add a node at the beginning
        /// </summary>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Traverse list in order to print
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> null");
            Current = Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void Append(Node newNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = newNode;
            Current = Head;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newNode"></param>
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
            }

            Current = Head;
        }
    }
}
