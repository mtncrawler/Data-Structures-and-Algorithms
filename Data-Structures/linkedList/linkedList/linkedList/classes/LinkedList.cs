using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.classes
{
    public class LinkedList
    {
        /// <summary>
        /// Always points to the first node in the LL
        /// </summary>
        public Node Head { get; set; }
        
        /// <summary>
        /// Node that is used to traverse through the LL
        /// </summary>
        public Node Current { get; set; }
        
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
        /// Traverse list in order to print
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.Write($"{Current.Value} --> null");
            Console.WriteLine();
            Current = Head;
        }

        /// <summary>
        /// add a node at the beginning of linked list
        /// </summary>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        /// <summary>
        /// Appends a node to the end of the linked list
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
        /// add a node before a node
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
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

        /// <summary>
        /// add a node after a specific node
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="existingNode"></param>
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
            if (Head.Value == existingNode.Value)
            {
                newNode.Next = Current.Next;
                Current.Next = newNode;
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }

            Current = Head;
        }
    }
}
