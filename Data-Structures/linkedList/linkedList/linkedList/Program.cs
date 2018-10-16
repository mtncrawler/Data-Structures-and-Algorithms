using System;
using System.Collections.Generic;
using linkedList.classes;

namespace linkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Node node1 = new Node(7);
            //Node node2 = new Node(4);
            //Node node3 = new Node(13);
            //Node node4 = new Node(100);
            //Node node5 = new Node(300);
            //Node node6 = new Node(25);

            //LinkedList myAwesomeList = new LinkedList(node1);

            //myAwesomeList.Add(node2);
            //myAwesomeList.Add(node3);
            //myAwesomeList.Add(node4);


            //myAwesomeList.AddAfter(node6, node3);

            //myAwesomeList.Print();

            Node node1 = new Node("bird");
            Node node2 = new Node(false);
            Node node3 = new Node(99999);
            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.AddAfter(node3, node2);
            testList.Print();

        }
    }
}
