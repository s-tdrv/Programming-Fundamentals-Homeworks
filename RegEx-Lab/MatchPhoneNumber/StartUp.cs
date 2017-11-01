﻿using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace MatchPhoneNumber
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"( ?\+359 2 \d{3} \d{4}\b)|(\+ ?359-2-\d{3}-\d{4}\b)";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
            

        }
    }
}
