using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            string command = Console.ReadLine();
            var commands = command
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            while (command != "Odd" && command != "Even")
            {
                if (commands[0] == "Delete")
                {
                    int number = (int.Parse(commands[1]));
                    numbers.RemoveAll(item => item == number);
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            if (command == "Even")
            {
                Console.Write(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            else if (command == "Odd")
            {
                Console.Write(String.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
            Console.WriteLine();
        }
    }
}
