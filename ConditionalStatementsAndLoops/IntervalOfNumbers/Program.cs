using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int startNumber = Math.Min(number1, number2);
            int lastNumber = Math.Max(number1, number2);

            for (int i = startNumber; i <= lastNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
