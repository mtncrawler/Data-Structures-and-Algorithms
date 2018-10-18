using System;
using System.Collections.Generic;
using linkedList.classes;

namespace mergeLists
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(1);
            Node node2 = new Node(3);
            Node node3 = new Node(2);
            Node node4 = new Node(5);
            Node node5 = new Node(9);
            Node node6 = new Node(4);

            LinkedList one = new LinkedList(node3);
            one.Add(node2);
            one.Add(node1);
            one.Print();

            LinkedList two = new LinkedList(node6);
            two.Add(node5);
            two.Add(node4);
            two.Print();
            MergeLists(one, two).Print();

        }

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

                if (p1 == null || p2 == null)
                {
                    one.Current.Next = two.Current;
                    return one;
                }

                one.Current.Next = two.Current;
                one.Current = p1;

                two.Current.Next = p1;
                two.Current = p2;
            }

            return one;
        }
    }
}
