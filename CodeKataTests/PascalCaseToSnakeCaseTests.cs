using CodeKatas.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class PascalCaseToSnakeCaseTests
    {
        [Theory]
        [InlineData("TestController", "test_controller")]
        [InlineData("ThisIsBeautifulDay", "this_is_beautiful_day")]
        [InlineData("Am7Days", "am7_days")]
        [InlineData("My3CodeIs4TimesBetter", "my3_code_is4_times_better")]
        [InlineData("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool", "arbitrarily_sending_different_types_to_functions_makes_katas_cool")]
        public void Should_Correctly_Convert_String_From_Pascal_Case_To_Snake_Case(
            string input,
            string expectedResult)
        {
            var result = PascalCaseToSnakeCase.ToUnderscore(input);

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData(1, "1")]
        [InlineData(123, "123")]
        [InlineData(9595959, "9595959")]
        public void Should_Correctly_Convert_Int_To_Snake_Case_String(
            int input,
            string expectedResult)
        {
            var result = PascalCaseToSnakeCase.ToUnderscore(input);

            result.Should().Be(expectedResult);
        }
    }
}