using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0.0;

            foreach (var item in input)
            {
                double number = double.Parse(item.Substring(1, item.Length - 2));
                char firstLetter = item.First();
                char lastLetter = item.Last();
                double tempSum = 0.0;

                if (char.IsLower(firstLetter))
                {
                    tempSum = number * (firstLetter - ('a' - 1));
                }
                else
                {
                    tempSum = number / (firstLetter - ('A' - 1));
                }

                if (char.IsLower(lastLetter))
                {
                    tempSum += lastLetter - ('a' - 1);
                }
                else
                {
                    tempSum -= lastLetter - ('A' - 1);
                }
                sum += tempSum;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
