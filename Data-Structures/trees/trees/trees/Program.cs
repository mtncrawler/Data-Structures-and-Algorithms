using System;
using System.Collections.Generic;
using trees.classes;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node n1 = new Node(90);
            Node n2 = new Node(50);
            Node n3 = new Node(60);
            Node n4 = new Node(15);

            BinaryTree bt = new BinaryTree(n1);
            bt.Root.LeftChild = n2;
            bt.Root.RightChild = n3;
            n2.LeftChild = n4;

            List<int> output = new List<int>();
            
            foreach (var item in bt.PreOrder(n1, output))
            {
                Console.WriteLine(item);
            }
            

            
        }
    }
}
