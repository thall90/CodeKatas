using System.Linq;

namespace CodeKatas.Katas
{
    public static class StringToAlphabetPosition
    {
        public static string AlphabetPosition(string text) =>  
            text.Where(char.IsLetter)
                .Aggregate(string.Empty, (current, character) => current + $"{char.ToUpperInvariant(character) - 64} ")
                .TrimEnd();
    }
}