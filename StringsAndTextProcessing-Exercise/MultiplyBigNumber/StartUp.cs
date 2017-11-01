using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    public class StartUp
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("0");
                return;
            }
            first = first.TrimStart('0');
            int reminder = 0;
            int number = 0;
            int sum = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = (first[i] - 48) * num + reminder;
                number = sum % 10;
                sb.Append(number % 10);
                reminder = sum / 10;
            }
            if (reminder > 0)
                sb.Append(reminder);
            string result = new string(sb.ToString().Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
