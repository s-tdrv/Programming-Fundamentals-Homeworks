using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();

            while (commands[0] != "Odd" && commands[0] != "Even")
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
                commands = Console.ReadLine().Split(' ').ToList();
            }
            if (commands[0] == "Even")
            {
                Console.Write(String.Join(" ", numbers.Where(x => x % 2 == 0)));
            }
            else if (commands[0] == "Odd")
            {
                Console.Write(String.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
            Console.WriteLine();
        }
    }
}
