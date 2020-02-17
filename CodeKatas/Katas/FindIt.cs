using System.Linq;

namespace CodeKataTester.Katas
{
    public static class FindIt
    {
        public static int OddFrequency(this int[] seq)
        {
            return seq.GroupBy(x => x)
                      .Select(y => y)
                      .Where(number => number.Count() % 2 != 0)
                      .Select(number => number.Key)
                      .FirstOrDefault();
        }
    }
}