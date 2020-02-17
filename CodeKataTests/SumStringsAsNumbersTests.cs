using System.Collections.Generic;
using CodeKataTester;
using FluentAssertions;
using Xunit;

namespace CodeKataTests
{
    public class SumStringsAsNumbersTests
    {
        [Fact]
        public void Should_Correctly_Calculate_Sums_Of_Number_String_Pairs()
        {
            var results = new List<string>
            {
                SumStringsAsNumbers.SumStrings("123", "456"),
                SumStringsAsNumbers.SumStrings("15", "5"),
                SumStringsAsNumbers.SumStrings("1500000", "1000000"),
            };

            var expectedResults = new List<string>
            {
                "579",
                "20",
                "2500000",
            };

            results.Should().BeEquivalentTo(expectedResults);
        }
    }
}