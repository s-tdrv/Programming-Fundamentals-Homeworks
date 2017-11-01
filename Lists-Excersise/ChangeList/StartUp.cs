using System;
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
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            var commandArgs = command
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            while (command != "Odd" && command != "Even")
            {
                if (commandArgs[0] == "Delete")
                {
                    int number = (int.Parse(commandArgs[1]));
                    numbers.RemoveAll(item => item == number);
                }
                else if (commandArgs[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (command == "Even")
                {
                    if (numbers[i] % 2 ==0)
                    {
                        Console.WriteLine(string.Join(" ", numbers[i]));
                    }
                }
                else if (command == "Even")
                {
                    if (numbers[i] % 2 != 0)
                    {
                        Console.WriteLine(string.Join(" ", numbers[i]));
                    }
                }
            }
            
        }
    }
}
