using System;
using System.Linq;


namespace ReverseAnArrayOfStrings
{
    public class StartUp
    {
        public static void Main()
        {
            string[] nums = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Array.Reverse(nums);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
