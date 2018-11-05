using System;
using System.Collections.Generic;
using trees.classes;

namespace findMaxInBinaryTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the maximum value in a Binary Tree!");

            Node n1 = new Node(69);
            Node n2 = new Node(23);
            Node n3 = new Node(98);
            Node n4 = new Node(0);
            Node n5 = new Node(-335);

            n4.LeftChild = n2;
            n4.RightChild = n1;
            n4.RightChild.RightChild = n5;
            n4.LeftChild.LeftChild = n3;

            BinaryTree bt = new BinaryTree(n4);

            Console.WriteLine(FindMaxValue(bt));
        }

        public static int FindMaxValue(BinaryTree bt)
        {
            List<int> output = new List<int>();
            List<int> values = bt.InOrder(bt.Root, output);
            int temp = bt.Root.Value;

            foreach (var item in values)
            {
                if (item > temp)
                {
                    temp = item;
                }
            }
            return temp;

        }
    }
}
