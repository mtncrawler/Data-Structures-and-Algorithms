using System;
using Xunit;
using linkedList.classes;
using findKthValue;

namespace findKthValueTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test for edge cases and correct node value returned
        /// </summary>
        /// <param name="k"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(-2, "Exception: Please enter a non-negative number.")]
        [InlineData(3, "friyah")]
        [InlineData(8, "Exception: Invalid k value.")]
        public void FindKthValueWorks(int k, object expected)
        {
            Node node1 = new Node("banana");
            Node node2 = new Node(79);
            Node node3 = new Node(true);
            Node node4 = new Node("friyah");
            Node node5 = new Node(300);

            LinkedList testList = new LinkedList(node1);
            testList.Add(node2);
            testList.Add(node3);
            testList.Add(node4);
            testList.Add(node5);

            Assert.Equal(expected, Program.FindKthValue(testList, k));
        }
    }
}
