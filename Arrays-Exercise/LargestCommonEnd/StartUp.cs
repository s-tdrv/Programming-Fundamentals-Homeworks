using System;

namespace LargestCommonEnd
{
    public class StartUp
    {
        public static void Main()
        {
            string[] firstArr = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int leftCount = FindMaxCommonItems(firstArr, secondArr);
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            int rightCount = FindMaxCommonItems(firstArr, secondArr);

            Console.WriteLine($"{Math.Max(leftCount, rightCount)}");

        }

        private static int FindMaxCommonItems(string[] firstArr, string[] secondArr)
        {
            int length = Math.Min(firstArr.Length, secondArr.Length);
            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        } 
    }
}
