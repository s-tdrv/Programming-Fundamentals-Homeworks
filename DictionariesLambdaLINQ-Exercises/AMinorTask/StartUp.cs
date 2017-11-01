using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string input2 = Console.ReadLine();

            var collectedResources = new Dictionary<string, long>();


            while (input != "stop")
            {

                var inputIndex = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var inputIndex2 = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var resource = inputIndex[0];
                long quantity = long.Parse(inputIndex2[0]);

                if (!collectedResources.ContainsKey(resource))
                {
                    collectedResources.Add(resource, quantity);
                }
                else
                {
                    collectedResources[resource] += quantity;
                }


                input = Console.ReadLine().ToLower();
                input2 = Console.ReadLine();
                
            }
            if (input == "stop")
            {
                foreach (var name in collectedResources)
                {
                    Console.WriteLine($"{name.Key} -> {name.Value}");
                }
            }

        }
    }
}
