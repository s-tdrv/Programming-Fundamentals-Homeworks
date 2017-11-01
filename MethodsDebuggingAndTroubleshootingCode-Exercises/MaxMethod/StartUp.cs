
namespace MaxMethod
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max1 = GetMax(a, b);
            int max2 = GetMax(max1, c);
            Console.WriteLine(max2);
             
        }
        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
