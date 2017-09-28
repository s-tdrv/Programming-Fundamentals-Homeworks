using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string drink = "";
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.70;
                    break;

                default:
                    drink = "Tea";
                    price = 1.20;
                    break;
            }
            double totalprice = quantity * price;
            Console.WriteLine($"The {profession} has to pay {totalprice:f2}.");
        }
    }
}
