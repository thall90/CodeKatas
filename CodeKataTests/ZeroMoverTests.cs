using System;
using CodeKataTester;
using Xunit;
using Xunit.Abstractions;

namespace CodeKataTests
{
    public class ZeroMoverTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ZeroMoverTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test()
        {
            var testArray = new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1};

            var result = testArray.MoveZeroes();

            _testOutputHelper.WriteLine(result.ToString());
            
            Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, result);
        }
    }
}