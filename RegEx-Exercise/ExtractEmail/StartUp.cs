namespace ExtractEmail
{
    using System;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"(\s[a-zA-Z0-9][\w.-]*\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match emailMatch in matches)
            {
                string email = emailMatch.ToString();
                Console.WriteLine(emailMatch);
            }
        }
    }
}
