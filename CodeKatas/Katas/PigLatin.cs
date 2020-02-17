using System.Linq;

namespace CodeKataTester
{
    public static class PigLatin
    {
        public static string Convert(this string str)
        {
            return string.Join(" ", str.Split().Select(x => $"{x.Substring(1)}{x.First()}ay"));
        }
    }
}