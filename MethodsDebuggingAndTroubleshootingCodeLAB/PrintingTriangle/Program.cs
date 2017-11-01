using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            
        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line < n; line++)
            {
                PrintLine(1, line);
            }
            PrintLine(1, n);

            for (int i = n-1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
    }
}
