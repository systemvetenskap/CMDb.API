using System.Text.RegularExpressions;

namespace CMDbAPI
{
    public static class RegexExtensions
    {
        /// <summary>
        /// Check if string matches the imdb movie id pattern
        /// </summary>
        /// <param name="input">string to check</param>
        /// <returns>true if id is valid</returns>
        public static bool IsValidImdbId(this string input)
        {
            return Regex.IsMatch(input, @"^[tt]{2}\d{6}");
        }
    }
}
