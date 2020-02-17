using System.Dynamic;
using CodeKataTester;
using CodeKataTester.Katas;
using Xunit;

namespace CodeKataTests
{
    public class NumberToWordsTests
    {
        [Fact]
        public void Test1()
        {
            // Assemble
            const int intToConvert = 55;

            // Apply
            var result = intToConvert.Convert();

            const string expectedResult = "fifty-five";
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}