namespace PrimeChecker
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Prime(n));
        }
        private static bool Prime(double n)
        {
            bool isPrime = true;
            if (n <= 1)
            {
                isPrime = false;
            }
            for (double i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}
