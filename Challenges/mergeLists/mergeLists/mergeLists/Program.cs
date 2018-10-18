using System;
using System.Collections.Generic;
using linkedList.classes;

namespace mergeLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's merge!");

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            LinkedList two = new LinkedList(node3);
            two.Add(node2);
            two.Add(node1);

            LinkedList one = new LinkedList(node4);

            Console.WriteLine(Print(MergeLists(one, two)));
        }

        /// <summary>
        /// zip merge two linked lists
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns>zip merged linked list</returns>
        public static LinkedList MergeLists(LinkedList one, LinkedList two)
        {
            one.Current = one.Head;
            two.Current = two.Head;
            Node p1 = one.Current;
            Node p2 = two.Current;

            while (one.Current != null || two.Current != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;

                if (p1 == null )
                {
                    one.Current.Next = two.Current;
                    return one;
                }

                if ( p2 == null )
                {
                    one.Current.Next = two.Current;
                    two.Current.Next = p1;
                    return one;
                }

                one.Current.Next = two.Current;
                one.Current = p1;

                two.Current.Next = p1;
                two.Current = p2;
            }

            return one;
        }

        /// <summary>
        /// prints linked list
        /// </summary>
        /// <param name="list"></param>
        /// <returns>string of linked list</returns>
        public static string Print(LinkedList list)
        {
            list.Current = list.Head;
            string output = "";

            while (list.Current.Next != null)
            {
                output += $"{list.Current.Value} --> ";
                list.Current = list.Current.Next;
            }

            output += $"{list.Current.Value} --> null";
            list.Current = list.Head;
            return output;
        }
    }
}
