using System;
using Xunit;
using multiBracketValidation;

namespace multiBracketValidationTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("()[]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void TrueBalancedBrackets(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[({((hi))}]")]
        public void FalseBalancedBrackets(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
