using System;
using Xunit;
using uniqueCharacters;


namespace uniqueCharactersTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("AAAAaaaa7")]
        [InlineData("Ilovei")]
        [InlineData("4zero4")]
        public void NoUniqueness(string input)
        {
            Assert.False(Program.UniqueCharacters(input));
        }

        [Theory]
        [InlineData("iSaWtHeDog")]
        [InlineData("qWeRtYuIoPl")]
        [InlineData("123456789")]
        public void ValidUniqueness(string input)
        {
            Assert.True(Program.UniqueCharacters(input));
        }
    }
}
