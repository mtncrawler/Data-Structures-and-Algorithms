using mergeLists;
using linkedList.classes;
using System;
using Xunit;

namespace mergeListsTest
{
    public class UnitTest1
    {

        [Fact]
        public void LL1IsLonger()
        {
            LinkedList one = new LinkedList(new Node(3));
            one.Add(new Node(2));
            one.Add(new Node(1));

            LinkedList two = new LinkedList(new Node(4));

            LinkedList expected = new LinkedList(new Node(3));
            expected.Add(new Node(2));
            expected.Add(new Node(4));
            expected.Add(new Node(1));

            LinkedList actual = Program.MergeLists(one, two);

            Assert.True(expected == actual);
        }
    }
}
