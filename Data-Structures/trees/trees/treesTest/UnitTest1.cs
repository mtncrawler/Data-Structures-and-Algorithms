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
    }
}
