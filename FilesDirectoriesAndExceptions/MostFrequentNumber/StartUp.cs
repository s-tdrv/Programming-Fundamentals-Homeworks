using System;
using System.IO;
using System.Linq;


namespace MostFrequentNumber
{
    public class StartUp
    {
        public static void Main()
        {
            int[] array = File.ReadAllText("input.txt")
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

            int[] count = new int[65536];

            foreach (int num in array)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxValue)
                {
                    var output = $"{array[i]}";
                    File.AppendAllText("output.txt", output);
                    return;
                }
            }



        }
    }
}
