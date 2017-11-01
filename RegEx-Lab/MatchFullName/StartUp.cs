using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    public class StartUp
    {
        public static void Main()
        {
            string names = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matchedNames = Regex.Matches(names, regex);
            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();  

        }
    }
}
