using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (firstInput == secondInput)
            {
                Console.WriteLine(firstInput);
                Console.WriteLine(secondInput);
                return;
            }

            for (int i = 0; i < Math.Min(firstInput.Length, secondInput.Length); i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    continue;
                }
                if (firstInput[i] < secondInput[i])
                {
                    Console.WriteLine(firstInput);
                    Console.WriteLine(secondInput);
                    return;
                }
                else
                {
                    Console.WriteLine(secondInput);
                    Console.WriteLine(firstInput);
                    return;
                }
        }
    }
}
