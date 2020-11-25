using CodeKatas.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class PigLatinTests
    {
        [Fact]
        public void Should_Convert_Given_String_To_PigLatin()
        {
            // Assemble
            const string stringToConvert = "My name is Ron Swanson";

            // Apply
            var result = stringToConvert.Convert();

            const string expectedResult = "yMay amenay siay onRay wansonSay";
            
            // Assert
            result.Should().Be(expectedResult);
        }
    }
}