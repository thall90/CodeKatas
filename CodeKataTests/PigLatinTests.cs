using CodeKataTester;
using Xunit;

namespace CodeKataTests
{
    public class PigLatinTests
    {
        [Fact]
        public void Test1()
        {
            // Assemble
            const string stringToConvert = "My name is Ron Swanson";

            // Apply
            var result = stringToConvert.Convert();

            const string expectedResult = "yMay amenay siay onRay wansonSay";
            
            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}