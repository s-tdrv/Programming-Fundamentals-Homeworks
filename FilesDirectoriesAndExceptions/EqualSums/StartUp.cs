using System;
using System.IO;
using System.Linq;


namespace EqualSums
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = File.ReadAllText("input.txt")
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            bool findEqualSums = false;
            var output = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    output = $"{i}";
                    File.WriteAllText("output.txt", output);
                    findEqualSums = true;
                    break;
                }
            }

            if (!findEqualSums)
            {
                output = "no";
                File.WriteAllText("output.txt", output);
            }
        }
    }
}
