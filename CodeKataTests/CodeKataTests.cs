using CodeKatas.Katas;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace CodeKataTests
{
    public class CodeKataTests
    {
        private readonly ITestOutputHelper outputHelper;

        public CodeKataTests(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }
        
        [Theory]
        [InlineData("", true)]
        [InlineData("Dermatoglyphics", true)]
        [InlineData("aba", false)]
        [InlineData("moOse", false)]
        [InlineData("isogram", true)]
        [InlineData("isIsogram", false)]
        [InlineData("moose", false)]
        [InlineData("thumbscrewjapingly", true)]
        public void Should_Correctly_Identify_Whether_String_Is_Isogram(
            string input,
            bool expectedResult)
        {
            var result = input.IsIsogram();

            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Should_Return_Correct_Number_Of_Trailing_Zeroes()
        {
            const int numberToCalculate = 25;

            var result = numberToCalculate.TrailingZeroes();

            const int expectedResult = 6;
            
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(-101, false)]
        public void Should_Correctly_Identify_Whether_Number_Is_Palindrome(
            int input,
            bool expectedResult)
        {
            var result = input.IsPalindrome();

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Should_Correctly_Convert_Roman_Input_To_Int(
            string input,
            int expectedResult)
        {
            var result = input.ToInt();

            result.Should().Be(expectedResult);
        }
        
        [Theory]
        [InlineData("leetcodeisacommunityforcoders", "ltcdscmmntyfrcdrs")]
        [InlineData("aeiou", "")]
        public void Should_Correctly_Remove_Vowels_From_String(
            string input,
            string expectedResult)
        {
            var result = input.RemoveVowels();

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new [] { 1, 2, 3, 4 }, new [] { 1, 3, 6, 10 })]
        [InlineData(new [] { 1, 1, 1, 1, 1 }, new [] { 1, 2, 3, 4, 5 })]
        [InlineData(new [] { 3, 1, 2, 10, 1 }, new [] { 3, 4, 6, 16, 17 })]
        public void Should_Correctly_Calculate_Running_Sum(
            int[] input,
            int[] expectedResult)
        {
            var result = CodeKatas.Katas.CodeKatas.RunningSum(input);

            result.Should().BeEquivalentTo(expectedResult, x => x.WithStrictOrdering());
        }

        [Theory]
        [InlineData(new[] {"ab", "c"}, new[] {"a", "bc"}, true)]
        [InlineData(new[] {"a", "cb"}, new[] {"ab", "c"}, false)]
        [InlineData(new[] {"abc", "d", "defg"}, new[] {"abcddefg"}, true)]
        public void Should_Correctly_Determine_Equivalence(
            string[] word1,
            string[] word2,
            bool expectedResult)
        {
            var result = CodeKatas.Katas.CodeKatas.ArrayStringsAreEqual(word1, word2);

            result.Should().Be(expectedResult);
        }
    }
}