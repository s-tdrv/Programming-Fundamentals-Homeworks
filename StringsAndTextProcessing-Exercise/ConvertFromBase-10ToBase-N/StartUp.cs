namespace ConvertFromBase_10ToBase_N
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToList();                ;
            int n = (int)input[0];
            BigInteger number = input[1];
            BigInteger remainder;
            string result = null;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;

                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }

            
        }
    }
}
