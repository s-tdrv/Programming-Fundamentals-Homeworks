﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (commands[0] != "Odd" && commands[0] != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);
                    nums.RemoveAll(i => i == number);
                }
                else
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    nums.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ').ToList();
            }
            if (commands[0] == "Even")
            {
                Console.Write(String.Join(" ", nums.Where(x => x % 2 == 0)));
            }
            else if (commands[0] == "Odd")
            {
                Console.Write(String.Join(" ", nums.Where(x => x % 2 != 0)));
            }
            Console.WriteLine();
        }
    }
}
