using System;
using Xunit;
using linkedList.classes;
using linkedList;

namespace linkedListTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(99)]
        [InlineData(true)]
        [InlineData("georgia")]
        public void AddsNodeToBeginning(object testValue)
        {
            Node node1 = new Node("bird");
            Node node2 = new Node(false);
            Node node3 = new Node(testValue);
            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.Add(node3);

            Assert.Equal(testValue, testList.Head.Value);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(true)]
        [InlineData("georgia")]
        public void AddsNodeToEnd(object testValue)
        {
            Node node1 = new Node("bird");
            Node node2 = new Node(false);
            Node node3 = new Node(testValue);
            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.Append(node3);

            while (testList.Current.Next != null)
            {
                testList.Current = testList.Current.Next;
            }

            Assert.Equal(testValue, testList.Current.Value);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(true)]
        [InlineData("georgia")]
        public void AddsNodeBeforeTarget(object testValue)
        {
            Node node1 = new Node("bird");
            Node node2 = new Node(false);
            Node node3 = new Node(testValue);
            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.AddBefore(node3, node2);

            Assert.Equal(testValue, testList.Head.Value);
        }

        [Theory]
        [InlineData(99)]
        [InlineData(true)]
        [InlineData("georgia")]
        public void AddsNodeAfterTarget(object testValue)
        {
            Node node1 = new Node("bird");
            Node node2 = new Node(false);
            Node node3 = new Node(testValue);
            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.AddAfter(node3, node2);

            Assert.Equal(testValue, testList.Head.Next.Value);
        }
    }
}
