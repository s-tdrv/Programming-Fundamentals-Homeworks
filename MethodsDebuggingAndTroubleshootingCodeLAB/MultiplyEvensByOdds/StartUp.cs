
namespace MultiplyEvensByOdds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }
    }
}
