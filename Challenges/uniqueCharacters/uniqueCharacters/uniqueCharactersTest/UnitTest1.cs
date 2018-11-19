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
    }
}
