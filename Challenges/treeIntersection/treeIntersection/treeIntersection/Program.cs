using hashTables.Classes;
using System;
using System.Collections.Generic;
using trees.classes;

namespace treeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tree Intersection!");
            Console.WriteLine();

            trees.classes.Node n1 = new trees.classes.Node(99);
            trees.classes.Node n2 = new trees.classes.Node(12);
            trees.classes.Node n3 = new trees.classes.Node(-100);
            trees.classes.Node n4 = new trees.classes.Node(36);

            trees.classes.Node n5 = new trees.classes.Node(101);
            trees.classes.Node n6 = new trees.classes.Node(12);
            trees.classes.Node n7 = new trees.classes.Node(99);
            trees.classes.Node n8 = new trees.classes.Node(36);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n2.LeftChild = n4;

            n5.LeftChild = n6;
            n6.RightChild = n7;
            n6.LeftChild = n8;

            BinaryTree bt1 = new BinaryTree(n1);
            BinaryTree bt2 = new BinaryTree(n5);

            Console.WriteLine("The trees share these values: ");

            foreach (var item in TreeIntersection(bt1, bt2))
            {
                Console.WriteLine(item);
            }
        }

        public static List<int> TreeIntersection(BinaryTree bt1, BinaryTree bt2)
        {
            HashTable ht = new HashTable();
            ht.Table = new hashTables.Classes.Node[1024];
            ht.Size = 1024;

            List<int> output = new List<int>();
            List<int> binaryTreeValues = new List<int>();

            foreach (var item in bt1.InOrder(bt1.Root, binaryTreeValues))
            {
                ht.Add(item.ToString(), item);
            }

            binaryTreeValues.Clear();

            foreach (var item in bt2.InOrder(bt2.Root, binaryTreeValues))
            {
                if (ht.Contains(item.ToString()))
                {
                    output.Add(item);
                }
            }
            return output;
        }
    }
}
