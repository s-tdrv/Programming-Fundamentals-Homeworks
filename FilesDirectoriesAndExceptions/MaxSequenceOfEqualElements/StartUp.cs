using System;
using System.IO;
using System.Linq;


namespace MaxSequenceOfEqualElements
{
    public class StartUp
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int number = 0;
            int maxCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        number = numbers[i];
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            var output = "";
            if (maxCount == 1)
            {
                output = $"{numbers[0]} ";
                File.AppendAllText("output.txt", output);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    output = $"{number} ";
                    File.AppendAllText("output.txt", output);
                }
            }

        }
    }
}
