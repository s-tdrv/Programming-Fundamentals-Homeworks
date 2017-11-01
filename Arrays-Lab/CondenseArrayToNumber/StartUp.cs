namespace CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[nums.Length - 1];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];
               
            }
            //to do

        }
    }
}
