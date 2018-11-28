using System;
using System.Collections.Generic;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Graphs!");

            LinkedListNode<object> v1 = new LinkedListNode<object>("dog");
            LinkedListNode<object> v2 = new LinkedListNode<object>("Kite");

            Graph g1 = new Graph(6, v1, 5);

            Console.WriteLine("The size of your graph is: ");
            Console.WriteLine(g1.Size());

            g1.AddEdge(v1, v2, 2);
            Console.WriteLine("I added a Node!");

            Console.WriteLine("Return all Nodes: ");
            foreach (var item in g1.GetNodes())
            {
                Console.WriteLine($"{item.Item1.Value}, Weight = {item.Item2}");
            }

            Console.WriteLine("Get neighbor Nodes: ");
            foreach (var item in g1.GetNeighbors(v1, 5))
            {
                Console.WriteLine($"{item.Item1.Value}, Weight = {item.Item2}");
            }
        }
    }
}
