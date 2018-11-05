using System;
using trees.classes;
using Xunit;
using findMaxInBinaryTree;

namespace findMaxInBinaryTreeTest
{
    public class UnitTest1
    {
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

        [Fact]
        public void EmptyTree()
        {
           Node n1 = new Node();
           BinaryTree bt = new BinaryTree(n1);
        }
    }
}
