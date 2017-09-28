
namespace TestNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalSum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    
                    totalSum += 3 * (i * j);
                    counter++;
                    if (totalSum >= maxSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {totalSum}");
 
        } 
    }
}
