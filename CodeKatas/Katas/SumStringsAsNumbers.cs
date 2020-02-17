using System;
using System.Numerics;

namespace CodeKataTester
{
    public static class SumStringsAsNumbers
    {
        public static string SumStrings(string a, string b)
        {
            var couldConvertA = BigInteger.TryParse(a, out var longA);
            var couldConvertB = BigInteger.TryParse(b, out var longB);

            Console.WriteLine($"a is {a} and b is {b}");
            
            return couldConvertA || couldConvertB ? (longA + longB).ToString() : "0";
        }
    }
}