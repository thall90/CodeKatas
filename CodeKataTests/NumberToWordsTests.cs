using CodeKataTester.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class NumberToWordsTests
    {
        [Fact]
        public void Should_Convert_Given_Number_To_Words()
        {
            // Assemble
            const int intToConvert = 55;

            // Apply
            var result = intToConvert.Convert();

            const string expectedResult = "fifty-five";

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}