using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().ToLower()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, long> junkMaterials = new SortedDictionary<string, long>();
            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            long quantity = 0;
            string material = "".ToLower();
            bool isObtained = false;
            while (isObtained == false)
            {
                for (int i = 1; i <= input.Length; i += 2)
                {
                    material = input[i];
                    quantity = long.Parse(input[i - 1]);

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                        {
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        junkMaterials.Add(material, 0);
                        junkMaterials[material] += quantity;
                    }

                }

                input = Console.ReadLine().ToLower()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }

            if (keyMaterials["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                keyMaterials["shards"] -= 250;
               
            }
            else if (keyMaterials["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                keyMaterials["fragments"] -= 250;
               
            }
            else if (keyMaterials["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                keyMaterials["motes"] -= 250;
                
            }


            foreach (var item in keyMaterials.OrderByDescending(pair => pair.Value).ThenBy(pair => pair.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var junk in junkMaterials)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }

        }
    }
}
