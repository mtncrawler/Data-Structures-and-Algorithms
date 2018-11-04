using System;
using trees.classes;
using System.Collections.Generic;
using Xunit;

namespace breadthFirstTraversalTest
{
    public class UnitTest1
    {
        [Fact]
        public void BreadthFirstTraversal()
        {
            Node n1 = new Node(54);
            Node n2 = new Node(99);
            Node n3 = new Node(200);
            Node n4 = new Node(3);
            Node n5 = new Node(143);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n1.LeftChild.LeftChild = n4;
            n1.RightChild.RightChild = n5;
        }
    }
}
