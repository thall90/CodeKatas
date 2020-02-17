using CodeKataTester;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class ZeroMoverTests
    {
        [Fact]
        public void Should_Move_All_Zeroes_To_End_Of_Collection()
        {
            var testArray = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

            var result = testArray.MoveZeroes();

            var expectedResult = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}