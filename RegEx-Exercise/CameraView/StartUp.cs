﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    public class StartUp
    {
        public static void Main()
        {
           int[] indices = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int m = indices[0];
            int n = indices[1];

            string pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";

            Regex regex = new Regex(pattern);

            string inputLine = Console.ReadLine();

            Match match = regex.Match(inputLine);

            List<string> results = new List<string>();

            while (inputLine.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd = match.Groups[2].Value;

                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("|"));
                }

                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("<"));
                }

                results.Add(matchToAdd);

                inputLine = inputLine
                    .Substring(match.Index + 2);
                match = regex.Match(inputLine);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
