﻿using System;
using System.IO;
using System.Linq;

namespace FixEmails
{
    public class StartUp
    {
        public static void Main()
        {
            var lines = File.ReadAllLines("input.txt");
            var numbers = Directory.GetFiles(".")
                .Where(f => f.StartsWith(".\\output"))
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                .Where(f => f != null)
                .Select(f => f.Replace(".txt", ""))
                .Select(int.Parse);

            int nextNumber = 0;
            if (numbers.Any())
            {
                nextNumber = numbers.Max() + 1;
            }

            var outputFileName = "output_" + nextNumber + ".txt";
                
            for (int i = 0; i < lines.Length; i+= 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                var output = $"{name} -> {email}" + Environment.NewLine;
                File.AppendAllText(outputFileName, output);
            }
           
        }
    }
}
