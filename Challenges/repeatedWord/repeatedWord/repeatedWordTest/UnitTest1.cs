using System;
using Xunit;
using repeatedWord;

namespace repeatedWordTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test for no matching words in input
        /// </summary>
        [Fact]
        public void NoMatchingWords()
        {
            string input = "There are no matching words in this not so lengthy text input that is only for testing purposes.";

            Assert.Null(Program.RepeatedWord(input));
        }

        /// <summary>
        /// test that only the first repeated word is returned
        /// </summary>
        [Fact]
        public void MultipleMatchingWords()
        {
            string input = "There are lengthy matching words in this testing not so lengthy text input that is only for testing purposes.";

            Assert.Equal("lengthy", Program.RepeatedWord(input));
        }

        /// <summary>
        /// test that an integer is returned as the first repeated word
        /// </summary>
        [Fact]
        public void ReturnIntAsString()
        {
            string input = "There are no matching words 79 in this not so lengthy text 43 input that is only for 79 testing purposes.";

            Assert.Equal("79", Program.RepeatedWord(input));
        }
    }
}
