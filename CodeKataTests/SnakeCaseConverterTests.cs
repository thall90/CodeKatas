using System;
using System.Collections.Generic;
using CodeKataTester;
using CodeKataTester.Katas;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class SnakeCaseConverterTests
    {
        [Fact]
        public void Should_Correctly_Convert_All_Inputs_To_Snake_Case()
        {
            var snakeCasedResults = new List<string>
            {
                SnakeCaseConverter.ToUnderscore("TestController"),
                SnakeCaseConverter.ToUnderscore("ThisIsBeautifulDay"),
                SnakeCaseConverter.ToUnderscore("Am7Days"),
                SnakeCaseConverter.ToUnderscore("My3CodeIs4TimesBetter"),
                SnakeCaseConverter.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"),
                SnakeCaseConverter.ToUnderscore(1),
            };
            
            var expectedResults = new List<string>
            {
                "test_controller",
                "this_is_beautiful_day",
                "am7_days",
                "my3_code_is4_times_better",
                "arbitrarily_sending_different_types_to_functions_makes_katas_cool",
                "1",
            };

            snakeCasedResults.Should().BeEquivalentTo(expectedResults);
        }
    }
}