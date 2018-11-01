using System;
using System.Collections.Generic;
using trees.classes;

namespace breadthFirstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Breadth First Traversal!");

            Node n1 = new Node(54);
            Node n2 = new Node(99);
            Node n3 = new Node(200);
            Node n4 = new Node(3);
            Node n5 = new Node(143);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n1.LeftChild.LeftChild = n4;
            n1.RightChild.RightChild = n5;

            BreadthFirst(n1);

        }

        public static void BreadthFirst(Node root)
        {
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);

            while (breadth.Count != 0)
            {
                Node front = breadth.Dequeue();
                Console.WriteLine(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
        }
    }
}
