using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;
            
            
            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;

                if (nights > 7)
                {
                    priceStudio = priceStudio * 0.95;
                }
            }

            if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;

                if (nights > 14)
                {
                    priceDouble = priceDouble * 0.90;
                }
            }

            if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;

                if (nights > 14)
                {
                    priceSuite = priceSuite * 0.85;
                }
            }
            double sumStudio = priceStudio * nights;
            double sumDouble = priceDouble * nights;
            double sumSuite = priceSuite * nights;

            if (month == "September" && nights > 7)
            {
                sumStudio = sumStudio - priceStudio;
            }
            if (month == "October" && nights > 7)
            {
                sumStudio = sumStudio - priceStudio;
            }

            Console.WriteLine($"Studio: {sumStudio:f2} lv.");
            Console.WriteLine($"Double: {sumDouble:f2} lv.");
            Console.WriteLine($"Suite: {sumSuite:f2} lv.");
            


        }
    }
}
