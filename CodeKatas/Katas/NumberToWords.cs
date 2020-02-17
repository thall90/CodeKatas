using System;

namespace CodeKataTester.Katas
{
    public static class NumberToWords
    {
        public static string Convert(this int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + Convert(Math.Abs(number));

            var words = "";

            if ((number / 1000000) > 0)
            {
                words += Convert(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += Convert(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += Convert(number / 100) + " hundred ";
                number %= 100;
            }

            if (number <= 0)
            {
                return words;
            }
            
            if (words != "")
                words += "and ";

            var unitsMap = new[]
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen"
            };
            var tensMap = new[]
            {
                "zero",
                "ten",
                "twenty",
                "thirty",
                "forty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }

            return words;
        }
    }
}