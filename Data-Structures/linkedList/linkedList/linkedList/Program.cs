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

            LinkedList myAwesomeList = new LinkedList(node1);

            myAwesomeList.Print();
        }
    }
}
