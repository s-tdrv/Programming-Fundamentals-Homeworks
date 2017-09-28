using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lines = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < lines; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient.ToLower() == "cheese")
                {
                    calories += 500;
                }
                else if (ingredient.ToLower() == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient.ToLower() == "salami")
                {
                    calories += 600;
                }
                else if (ingredient.ToLower() == "pepper")
                {
                    calories += 50;
                }
                
            }
            Console.WriteLine($"Total calories: {calories}");
            
        }
    }
}
