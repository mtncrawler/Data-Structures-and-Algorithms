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

            //bt.PreOrder(n1, output);


            //List<int> output1 = new List<int>();
            //List<int> test2 = bt.InOrder(n1, output1);


            //foreach (var item in test2)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (var item in bt.PostOrder(n1, output))
            {
                Console.WriteLine(item);
            }
            
        }

        public void Print(List<int> output)
        {
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
