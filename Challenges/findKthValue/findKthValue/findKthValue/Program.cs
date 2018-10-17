using linkedList.classes;
using System;

namespace findKthValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node("banana");
            Node node2 = new Node(79);
            Node node3 = new Node(true);
            Node node4 = new Node("friyah");
            Node node5 = new Node(300);

            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.Add(node3);
            testList.Add(node4);
            testList.Add(node5);

            testList.Print();




        }
    }
}
