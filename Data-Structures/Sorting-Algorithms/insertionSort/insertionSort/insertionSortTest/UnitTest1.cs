using System;
using Xunit;
using insertionSort;

namespace insertionSortTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] {0,9,5,1})]
        public void ValidSort(int[] input)
        {
            int[] expected = { 0, 1, 5, 9 };

            Assert.Equal(expected, Program.InsertionSort(input));
        }
    }
}
