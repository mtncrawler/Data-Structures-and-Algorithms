using mergeLists;
using linkedList.classes;
using System;
using Xunit;

namespace mergeListsTest
{
    public class UnitTest1
    {
        /// <summary>
        /// LL1 is longer than LL2
        /// </summary>
        [Fact]
        public void LL1IsLonger()
        {
            LinkedList one = new LinkedList(new Node(3));
            one.Add(new Node(2));
            one.Add(new Node(1));

            LinkedList two = new LinkedList(new Node(4));

            Assert.Equal("1 --> 4 --> 2 --> 3 --> null", Program.Print(Program.MergeLists(one, two)));
        }

        /// <summary>
        /// LL2 is longer than LL1
        /// </summary>
        [Fact]
        public void LL2IsLonger()
        {
            LinkedList two = new LinkedList(new Node(3));
            two.Add(new Node(2));
            two.Add(new Node(1));

            LinkedList one = new LinkedList(new Node(4));
            
            Assert.Equal("4 --> 1 --> 2 --> 3 --> null", Program.Print(Program.MergeLists(one, two)));
        }

        /// <summary>
        /// two LL merge
        /// </summary>
        [Fact]
        public void LLMerged()
        {
            LinkedList one = new LinkedList(new Node(3));
            one.Add(new Node(2));

            LinkedList two = new LinkedList(new Node(4));
            two.Add(new Node(1));

            Assert.Equal("2 --> 1 --> 3 --> 4 --> null", Program.Print(Program.MergeLists(one, two)));
        }
    }
}
