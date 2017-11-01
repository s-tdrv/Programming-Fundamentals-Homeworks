namespace KeyReplacer
{
    using System;
    using System.Text.RegularExpressions;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var start = @"^[a-zA-Z]+[<|\\]";
            var end = @"[<|\\][a-zA-Z]+$";

            var firstKey = Regex.Match(input, start);
            var secondKey = Regex.Match(input, end);

            var firstK = firstKey.Value.TrimEnd('<', '|', '\\');
            var secondK = secondKey.Value.TrimStart('<', '|', '\\');

            var pattern = $"{firstK}(.*?){secondK}";

            var text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].Value);
            }

            Console.WriteLine(sb.Length > 1 ? sb.ToString() : "Empty result");

            
        }
    }
}
