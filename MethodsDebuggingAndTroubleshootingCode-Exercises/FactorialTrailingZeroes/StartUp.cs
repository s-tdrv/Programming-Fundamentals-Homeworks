namespace FactorialTrailingZeroes
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeros(n));                    
        }

        private static int TrailingZeros(int n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            int counter = 0;
            while (factorial > 0)
            {                
                BigInteger lastDigit = factorial % 10;
                factorial = factorial / 10;

                if (lastDigit == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                } 
            }
            return counter;
            
            
        }
    }
}
