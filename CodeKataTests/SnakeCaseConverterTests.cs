using System;
using CodeKataTester;
using CodeKataTester.Katas;
using Xunit;

namespace CodeKataTests
{
    public class SnakeCaseConverterTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("test_controller", SnakeCaseConverter.ToUnderscore("TestController"));
            Assert.Equal("this_is_beautiful_day", SnakeCaseConverter.ToUnderscore("ThisIsBeautifulDay"));
            Assert.Equal("am7_days", SnakeCaseConverter.ToUnderscore("Am7Days"));
            Assert.Equal("my3_code_is4_times_better", SnakeCaseConverter.ToUnderscore("My3CodeIs4TimesBetter"));
            Assert.Equal("arbitrarily_sending_different_types_to_functions_makes_katas_cool", SnakeCaseConverter.ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool"));
            Assert.Equal("1", SnakeCaseConverter.ToUnderscore(1));
        }
    }
}