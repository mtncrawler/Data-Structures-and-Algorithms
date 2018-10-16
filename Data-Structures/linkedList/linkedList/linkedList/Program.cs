using System;
using System.Collections.Generic;
using linkedList.classes;

namespace linkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(7);
            Node node2 = new Node(4);
            Node node3 = new Node(13);

            LinkedList myAwesomeList = new LinkedList(node1);

            myAwesomeList.Add(node2);
            

            myAwesomeList.AddAfter(node3, node2);

            myAwesomeList.Print();

            
            
        }
    }
}
