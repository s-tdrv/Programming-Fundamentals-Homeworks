using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers2
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            long result = Console.ReadLine()
                .Split()
                .Select(a => int.Parse(new string(a.Reverse().ToArray())))
                .Sum();

            Console.WriteLine(result);
        }
    }
}
