using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join( " <= ", numbers));
        }
    }
}
