using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumber
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
             var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
             var bombAndPower = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];
         
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = i - power; j <= power + i; j++)
                    {
                        if (j >= 0 && j <= numbers.Count - 1)
                        {
                            numbers[j] = 0;
                        }
                    }
                }
            }            
            Console.WriteLine(string.Join(" ", numbers.Sum()));
            
        }
       
    }
}
