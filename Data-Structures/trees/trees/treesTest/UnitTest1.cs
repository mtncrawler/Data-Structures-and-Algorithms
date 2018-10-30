using System;
using Xunit;
using trees.classes;
using System.Collections.Generic;

namespace treesTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        [InlineData(-541)]
        [InlineData(0.65)]
        public void PreOrderBinaryTree(int test)
        {
            Node n1 = new Node(25);
            Node n2 = new Node(700);
            Node n3 = new Node(test);

            BinaryTree bt = new BinaryTree(n1);
            n1.LeftChild = n2;
            n1.RightChild = n3;

            List<int> expected = new List<int> { 25, 700, test };

            Assert.Equal(expected, bt.PreOrder(n1, new List<int>()));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(-541)]
        [InlineData(0.65)]
        public void InOrderBinaryTree(int test)
        {
            Node n1 = new Node(25);
            Node n2 = new Node(test);
            Node n3 = new Node(700);

            BinaryTree bt = new BinaryTree(n1);
            n1.LeftChild = n2;
            n1.RightChild = n3;

            List<int> expected = new List<int> { test, 25, 700 };

            Assert.Equal(expected, bt.InOrder(n1, new List<int>()));
        }

        [Theory]
        [InlineData(100)]
        [InlineData(-541)]
        [InlineData(0.65)]
        public void PostOrderBinaryTree(int test)
        {
            Node n1 = new Node(test);
            Node n2 = new Node(700);
            Node n3 = new Node(25);

            BinaryTree bt = new BinaryTree(n1);
            n1.LeftChild = n2;
            n1.RightChild = n3;

            List<int> expected = new List<int> { 700, 25, test };

            Assert.Equal(expected, bt.PostOrder(n1, new List<int>()));
        }

        [Fact]
        public void AddBinarySearchTree()
        {
            Node n1 = new Node(200);
            Node n2 = new Node(700);
            Node n3 = new Node(100);

            BinarySearchTree bt = new BinarySearchTree(n1);
            bt.Add(n2);
            bt.Add(n3);

            Assert.Equal(n3.Value, bt.Root.LeftChild.Value);
        }

        [Fact]
        public void AddBinarySearchTreeLargestValue()
        {
            Node n1 = new Node(200);
            Node n2 = new Node(700);
            Node n3 = new Node(900);

            BinarySearchTree bt = new BinarySearchTree(n1);
            bt.Add(n2);
            bt.Add(n3);

            Assert.Equal(n3.Value, bt.Root.RightChild.RightChild.Value);
        }

        [Fact]
        public void AddBinarySearchTreeSmallestValue()
        {
            Node n1 = new Node(200);
            Node n2 = new Node(100);
            Node n3 = new Node(25);

            BinarySearchTree bt = new BinarySearchTree(n1);
            bt.Add(n2);
            bt.Add(n3);

            Assert.Equal(n3.Value, bt.Root.LeftChild.LeftChild.Value);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(-541)]
        [InlineData(900)]
        public void SearchBinarySearchTree(int test)
        {
            Node n1 = new Node(25);
            Node n2 = new Node(700);
            Node n3 = new Node(test);

            BinarySearchTree bt = new BinarySearchTree(n1);
            bt.Add(n2);
            bt.Add(n3);

            Assert.Equal(n3, bt.Search(n3));
        }
    }
}
