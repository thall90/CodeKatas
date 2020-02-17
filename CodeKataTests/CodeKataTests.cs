using CodeKataTester.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class CodeKataTests
    {
        [Fact]
        public void Should_Return_Correct_Number_Of_Trailing_Zeroes()
        {
            const int numberToCalculate = 25;

            var result = numberToCalculate.TrailingZeroes();

            const int expectedResult = 6;
            
            result.Should().Be(expectedResult);
        }
    }
}