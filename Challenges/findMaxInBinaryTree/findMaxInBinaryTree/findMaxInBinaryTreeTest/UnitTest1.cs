using System;
using trees.classes;
using Xunit;
using findMaxInBinaryTree;

namespace findMaxInBinaryTreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestsForHighestValue()
        {
            Node n1 = new Node(10000);
            Node n2 = new Node(-576);
            Node n3 = new Node(98);
            Node n4 = new Node(69);
            Node n5 = new Node(-335);

            n4.LeftChild = n2;
            n4.RightChild = n1;
            n4.RightChild.RightChild = n5;
            n4.LeftChild.LeftChild = n3;

            BinaryTree bt = new BinaryTree(n4);

            Assert.Equal(n1.Value, Program.FindMaxValue(bt));
        }

        [Fact]
        public void TestForOneNodeTree()
        {
            Node n1 = new Node(69);
            
            BinaryTree bt = new BinaryTree(n1);

            Assert.Equal(n1.Value, Program.FindMaxValue(bt));
        }

        [Fact]
        public void TestForAllNegativeInts()
        {
            Node n1 = new Node(-654);
            Node n2 = new Node(-98);
            Node n3 = new Node(-56);

            n1.LeftChild = n2;
            n1.LeftChild.LeftChild = n3;

            BinaryTree bt = new BinaryTree(n1);

            Assert.Equal(n3.Value, Program.FindMaxValue(bt));
        }

    }
}
