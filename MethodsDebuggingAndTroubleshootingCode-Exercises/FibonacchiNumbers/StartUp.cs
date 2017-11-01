

namespace FibonacchiNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                case 1:
                    Console.WriteLine("1");
                    break;
                default:
                    Console.WriteLine(Fibonacci(n));
                    break;
            }
        }

        private static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b; b = c;
            }
            return c;
                
        }
    }
}
