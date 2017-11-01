using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    public class StartUp
    {
        public static void Main()
        {
            String[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            String[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            String[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            String[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
                        
            var input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            for (int i = 0; i < n; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventIndex = rnd.Next(0, events.Length);
                int authorIndex = rnd.Next(0, authors.Length);
                int citiesIndex = rnd.Next(0, cities.Length);
                var output = $"{phrases[phraseIndex]} {events[eventIndex]} {authors[authorIndex]} - {cities[citiesIndex]}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }
    }
}
