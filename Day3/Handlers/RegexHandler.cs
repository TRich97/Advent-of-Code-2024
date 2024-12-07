using System.Text.RegularExpressions;

namespace Day3.Handlers
{
    public static class RegexHandler
    {
        public static List<string> GetMuls(string input)
        {
            const string pattern = @"mul\(\d+,\d+\)";
            var matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (var match in matches)
            {
                result.Add(match.ToString());
            }

            return result;
        }

        public static List<string> GetFuncs(string input)
        {
            const string pattern = @"mul\(\d+,\d+\)|do\(\)|don't\(\)";
            var matches = Regex.Matches(input, pattern);

            List<string> result = new List<string>();

            foreach (var match in matches)
            {
                result.Add(match.ToString());
            }

            return result;
        }
    }
    
}
