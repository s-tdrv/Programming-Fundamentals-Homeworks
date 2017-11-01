namespace RoundingNumbersAwayFromZero
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }

        }
    }
}
