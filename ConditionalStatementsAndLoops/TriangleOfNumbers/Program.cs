﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int col = 1; col <= n; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
           

        }
    }
}
