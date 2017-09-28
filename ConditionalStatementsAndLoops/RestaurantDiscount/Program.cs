using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0.0;

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            int packagePrice = 0;
            double discount = 0.0;


            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 0.95;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 0.90;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 0.85;
            }

            double pricePP = ((price + packagePrice) * discount) / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePP:f2}$");
        }
    }
}
