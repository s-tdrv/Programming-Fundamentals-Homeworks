
namespace DrawAFilledSquare
{
    using System;

    public class StartUp
    {
        static void PrintHeaderRow(int n)
        {
            string line = new string('-', 2 * n);
            Console.WriteLine(line);
        }

        static void PrintMidRows(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMidRows(n);
            }
            PrintHeaderRow(n);

        }
    }
}
