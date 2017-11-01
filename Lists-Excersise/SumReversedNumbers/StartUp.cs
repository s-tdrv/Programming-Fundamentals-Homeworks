using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    public class StartUp
    {
        public static void Main()
        {

            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            var newNumber = 0;
            var revNum = new List<int>();
            var sum = 0;
            foreach (var item in numbers)
            {
                newNumber = ReverseInt(item);
                revNum.Add(newNumber);
                                             
            }
            for (int i = 0; i < revNum.Count; i++)
            {
                sum += revNum[i];
            }
            Console.WriteLine(sum);

        }
        static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }      
}

