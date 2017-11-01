using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var numbersString = Console.ReadLine();
            var numbers = Regex.Matches(numbersString, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
