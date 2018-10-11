using System;
using Xunit;
using binarySearch;

namespace binarySearchTest
{
    public class UnitTest1
    {
        //tests to check for correct answers with given sorted arrays
        [Fact]
        public void BinarySearchReturnsCorrect()
        {
            int[] input = { 10, 50, 100, 335, 400, 589 };
            int target = 400;
            Assert.Equal(4, Program.BinarySearch(input, target));
        }

        [Fact]
        public void BinarySearchReturnsCorrect3()
        {
            int[] input = { -1023, -123, 7};
            int target = -1023;
            Assert.Equal(0, Program.BinarySearch(input, target));
        }

        //test for a target that does not exist in the array
        [Fact]
        public void BinarySearchReturnCorrect2()
        {
            int[] input = { -999, -105, 25, 27, 978};
            int target = -106;
            Assert.Equal(-1, Program.BinarySearch(input, target));
        }

        
    }
}
