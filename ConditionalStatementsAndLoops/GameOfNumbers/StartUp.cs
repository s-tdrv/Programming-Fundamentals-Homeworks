
namespace GameOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            int num1 = 0;
            int num2 = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        num1 = i;
                        num2 = j;
                        
                    }
                    
                }
            }
            if (num1 + num2 == magic)
            {
                Console.WriteLine($"Number found! {num1} + {num2} = {magic}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
           
           
            
        }
    }
}
