

namespace PrintPartOfTheASCIITable
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            for (int i = min; i <= max; i++)
            {
                char c = (char)i;
                Console.Write($"{c} ");
                
            }
            Console.WriteLine();

        }
    }
}
