﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int number = 0;
            int maxCount = 1;

            for (int i = 0; i < numbers.Count - 1; i++)  //защото отдолу ползваме i + 1
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (count > maxCount)
                    {
                        number = numbers[i];
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            if (maxCount == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
            
        }
    }
}
