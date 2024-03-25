using System.Linq;

namespace SigilAssist
{
    public class SigilBuilder
    {
        public string GetCompressedText(string inputText)
        {
            var cleanText = inputText
                .Replace(".", "")
                .Replace(",", "")
                .Replace(";", "")
                .Replace("'", "")
                .Replace("’", "")
                .Replace("-", "")
                .ToLower();
            
            var uniqueChars = cleanText.ToList().Distinct();
            
            return string.Join("", uniqueChars);
        }
    }
}