namespace CodeKatas.Katas
{
    public class PascalCaseToSnakeCase
    {
        private const char underscore = '_';
        
        public static string ToUnderscore(int str) => str.ToString();

        public static string ToUnderscore(string str)
        {
            var snakeCaseString = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) && i != 0)
                {
                    snakeCaseString += underscore;
                }
                
                snakeCaseString += str[i];
            }

            return snakeCaseString.ToLowerInvariant();
        }
    }
}