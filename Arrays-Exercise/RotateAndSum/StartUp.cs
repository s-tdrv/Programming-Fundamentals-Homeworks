namespace RotateAndSum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];
            for (int i = 0; i < rotations; i++)
            {
                int reminder = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                    sum[j] += numbers[j];
                }
                numbers[0] = reminder;
                sum[0] += numbers[0];

            }
            

            Console.WriteLine($"{String.Join(" ", sum)}");


        }
    }
}
