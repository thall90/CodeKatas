using System.Linq;

namespace CodeKataTester.Katas
{
    public static class CodeKatas
    {
        public static int TrailingZeroes(this int n)
        {
            var zeroCount = 0;
            for (var i = 5; (n / i) > 0; i *= 5) 
            {
                zeroCount = zeroCount + (n / i);
            }
            return zeroCount;
        }
    }
}