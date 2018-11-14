using System;
using Xunit;
using treeIntersection;
using trees.classes;
using System.Collections.Generic;

namespace treeIntersectionTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test for no matching values in both binary trees
        /// </summary>
        [Fact]
        public void NoMatchingValues()
        {
            trees.classes.Node n1 = new trees.classes.Node(99);
            trees.classes.Node n2 = new trees.classes.Node(12);
            trees.classes.Node n3 = new trees.classes.Node(-100);
            trees.classes.Node n4 = new trees.classes.Node(36);

            trees.classes.Node n5 = new trees.classes.Node(1298);
            trees.classes.Node n6 = new trees.classes.Node(-98);
            trees.classes.Node n7 = new trees.classes.Node(2);
            trees.classes.Node n8 = new trees.classes.Node(95);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n2.LeftChild = n4;

            n5.LeftChild = n6;
            n6.RightChild = n7;
            n6.LeftChild = n8;

            BinaryTree bt1 = new BinaryTree(n1);
            BinaryTree bt2 = new BinaryTree(n5);
            
            Assert.Empty(Program.TreeIntersection(bt1, bt2));
        }

        /// <summary>
        /// test correct matching values are returned
        /// </summary>
        [Fact]
        public void MatchingValues()
        {
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

            List<int> expected = new List<int>() { 36, 12, 99 };

            Assert.Equal(expected, Program.TreeIntersection(bt1, bt2));
        }

        /// <summary>
        /// test for no matches with a single node tree
        /// </summary>
        [Fact]
        public void NoMatchesWithOneNodeTree()
        {
            trees.classes.Node n1 = new trees.classes.Node(99);
            trees.classes.Node n2 = new trees.classes.Node(12);
            trees.classes.Node n3 = new trees.classes.Node(-100);
            trees.classes.Node n4 = new trees.classes.Node(36);
            trees.classes.Node n5 = new trees.classes.Node(101);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n2.LeftChild = n4;

            BinaryTree bt1 = new BinaryTree(n1);
            BinaryTree bt2 = new BinaryTree(n5);

            Assert.Empty(Program.TreeIntersection(bt1, bt2));
        }
    }
}
