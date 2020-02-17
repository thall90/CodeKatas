using System;
using System.Linq;

namespace CodeKataTester
{
    public static class ZeroMover
    {
        // Sample: MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
        public static int[] MoveZeroes(this int[] arr)
        {
            var paddedString = string.Join(string.Empty, arr.Where(z => z != 0).Select(p=>p.ToString()))
                                   .PadRight(arr.Length, '0');

            return Array.ConvertAll(paddedString.ToCharArray(), c => (int)char.GetNumericValue(c));
        }
    }
}