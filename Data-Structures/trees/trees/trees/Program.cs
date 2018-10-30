using System;
using System.Collections.Generic;
using trees.classes;

namespace trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Trees!");

            Node n1 = new Node(90);
            Node n2 = new Node(50);
            Node n3 = new Node(110);
            Node n4 = new Node(15);

            BinarySearchTree bst = new BinarySearchTree(n1);
            bst.Add(n2);
            bst.Add(n3);

            Console.WriteLine(bst.Search(n3).Value);

        }

    }
}
