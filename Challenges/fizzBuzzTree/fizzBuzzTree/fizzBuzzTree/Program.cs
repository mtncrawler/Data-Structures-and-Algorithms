using trees.classes;
using System;
using System.Collections.Generic;

namespace fizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FizzBuzz Binary Tree!");

            Node n1 = new Node(30);
            Node n2 = new Node(11);
            Node n3 = new Node(9);
            Node n4 = new Node(4);
            Node n5 = new Node(10);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n1.LeftChild.LeftChild = n4;
            n1.LeftChild.LeftChild.LeftChild = n5;

            FizzBuzzTree(n1);
        }

        /// <summary>
        /// traverses binary tree to writeLine fizz, buzz, or fizzbuzz for node values divisible by 3, 5, or 15 respectively 
        /// </summary>
        /// <param name="node">root node of BT</param>
        public static void FizzBuzzTree(Node node)
        {
            if (node.LeftChild != null)
            {
                FizzBuzzTree(node.LeftChild);
            }
            
            if (node.Value % 15 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (node.Value % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (node.Value % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            if (node.RightChild != null)
            {
                FizzBuzzTree(node.RightChild);
            }
        }
        
    }
}
