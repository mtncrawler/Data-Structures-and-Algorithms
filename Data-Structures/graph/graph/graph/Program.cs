using System;
using System.Collections.Generic;

namespace graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Graphs!");

            Graph g1 = new Graph(6, new Tuple<LinkedListNode<object>, int> (new LinkedListNode<object> ("dog"), 5));

            Console.WriteLine("The size of your graph is: ");
            Console.WriteLine(g1.Size());

            Console.WriteLine("Return all Nodes: ");
            foreach (var item in g1.GetNodes())
            {
                Console.WriteLine($"{item.Item1.Value}, Weight = {item.Item2}");
            }


        }
    }
}
