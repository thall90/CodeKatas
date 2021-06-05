using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas.Katas
{
    public static class CodeKatas
    {
        public static bool IsIsogram(this string str)
        {
            var letterSet = new HashSet<char>();

            if (str.Equals(string.Empty))
            {
                return true;
            }

            foreach (var character in str.ToLowerInvariant())
            {
                if (letterSet.Contains(character) || !char.IsLetter(character))
                {
                    return false;
                }

                letterSet.Add(character);
            }

            return true;
        }
       
        public static int TrailingZeroes(this int n)
        {
            var zeroCount = 0;

            for (var i = 5; (n / i) > 0; i *= 5)
            {
                zeroCount += (n / i);
            }

            return zeroCount;
        }

        public static bool IsPalindrome(this int x)
        {
            var inputAsString = x.ToString();
            var reversedStringInput = string.Empty;

            for (var i = inputAsString.Length - 1; i >= 0; i--)
            {
                reversedStringInput += inputAsString[i];
            }

            return inputAsString.Equals(reversedStringInput);
        }

        public static int[] RunningSum(int[] nums)
        {
            var count = nums.Length - 1;
            var total = 0;
            var result = new int[nums.Length];

            for (var i = 0; i <= count; i++)
            {
                var currentNum = nums[i];
                
                result[i] = currentNum + total;
                
                total += currentNum;
            }

            return result;
        }

        public static string RemoveVowels(this string s)
        {
            var result = string.Empty;

            foreach (var character in s)
            {
                if (vowels.Contains(character))
                {
                    continue;
                }

                result += character;
            }

            return result;
        }
        
        private static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
        
        public static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var word1Chars = word1.SelectMany(x => x).OrderBy(x => x).ToArray();
            var word2Chars = word2.SelectMany(x => x).OrderBy(x => x).ToArray();

            if (word1Chars.Length != word2Chars.Length)
            {
                return false;
            }

            return true;
        }

        public static int ToInt(this string s)
        {
            var result = 0;
            var arrayEnd = s.Length - 1;
            
            for (var i = 0; i <= arrayEnd; i++)
            {
                var last = i == 0 ? 1000 : numeralLookup[s[i - 1]];
                var current = numeralLookup[s[i]];
                var next = i == arrayEnd ? 1 : numeralLookup[s[i + 1]];
                
                if (NextCanSubtractCurrent(current, next))
                {
                    continue;
                }

                if (CanSubtractLast(last, current))
                {
                    result += current - last;
                    continue;
                }
                
                result += current;
            }

            return result;
        }

        private static bool NextCanSubtractCurrent(int current, int next)
        {
            return (next / current == 5) || (next / current == 10);
        }
        
        private static bool CanSubtractLast(int last, int current)
        {
            return (current / last == 5) || (current / last == 10);
        }

        private static IDictionary<char, int> numeralLookup => 
            new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };
    }
}