using CodeKatas.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class StringToAlphabetPositionTests
    {
        [Theory]
        [InlineData("The sunset sets at twelve o' clock.", "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11")]
        [InlineData("The narwhal bacons at midnight.", "20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20")]
        public void Should_Correctly_Convert_String_To_Alphabet_Positions(
            string input,
            string expectedResult)
        {
            var result = StringToAlphabetPosition.AlphabetPosition(input);

            result.Should().Be(expectedResult);
        }
    }
}