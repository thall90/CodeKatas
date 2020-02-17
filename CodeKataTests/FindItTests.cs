using CodeKatas.Katas;
using CodeKataTester.Katas;
using Xunit;

namespace CodeKataTests
{
    public class FindItTests
    {
        [Fact]
        public void Should_Find_The_Odd_Number_With_The_Highest_Frequency_In_The_Collection()
        {
            var sequence = new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5};

            var result = sequence.OddFrequency();
            
            const int expectedResult = 5;
            
            Assert.Equal(expectedResult, result);
        }
    }
}