using System.Text.RegularExpressions;

namespace CodeKatas.Katas
{
    public static class SnakeCaseConverter
    {
        public static string ToUnderscore(int str)
        {
            return string.Join('_', Regex.Split(str.ToString(), @"(?<!^)(?=[A-Z])")).ToLower();
        }

        public static string ToUnderscore(string str) 
        {
            return string.Join('_', Regex.Split(str, @"(?<!^)(?=[A-Z])")).ToLower();
        }
    }
}