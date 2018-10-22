using System;
using Xunit;
using linkedListPalindrome;
using linkedList.classes;

namespace linkedListPalindromeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test for a true palindrome
        /// </summary>
        [Fact]
        public void TruePalindrome()
        {
            Node node1 = new Node(2);
            Node node2 = new Node(4);
            Node node3 = new Node(4);
            Node node4 = new Node(2);

            LinkedList input = new LinkedList(node1);
            input.Add(node2);
            input.Add(node3);
            input.Add(node4);

            Assert.True(Program.ValidatePalindrome(input));
        }

        /// <summary>
        /// test for a false palindrome
        /// </summary>
        [Fact]
        public void FalsePalindrome()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            LinkedList input = new LinkedList(node1);
            input.Add(node2);
            input.Add(node3);
            input.Add(node4);

            Assert.False(Program.ValidatePalindrome(input));
        }

        /// <summary>
        /// test false for one node linked list
        /// </summary>
        [Fact]
        public void OneNodeLinkedList()
        {
            LinkedList input = new LinkedList(new Node(1));
            
            Assert.False(Program.ValidatePalindrome(input));
        }
    }
}
