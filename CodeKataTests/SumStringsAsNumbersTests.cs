using CodeKataTester;
using Xunit;

namespace CodeKataTests
{
    public class SumStringsAsNumbersTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("579", SumStringsAsNumbers.SumStrings("123", "456"));
            Assert.Equal("20", SumStringsAsNumbers.SumStrings("15", "5"));
            Assert.Equal("2500000", SumStringsAsNumbers.SumStrings("1500000", "1000000"));
        }
    }
}