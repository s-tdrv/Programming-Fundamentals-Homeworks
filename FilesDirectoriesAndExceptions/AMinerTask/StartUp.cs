using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> collectedResources = new Dictionary<string, int>();

            var resource = File.ReadAllLines("input.txt");

            for (int i = 0; i < resource.Length; i+=2)
            {
                if (resource[i] == "stop")
                {
                    break;
                }

                string resourceName = resource[i];
                int resourceQuantity = int.Parse(resource[i + 1]);
                if (!collectedResources.ContainsKey(resourceName))
                {
                    collectedResources.Add(resourceName, 0);
                }

                collectedResources[resourceName] += resourceQuantity;
            }
           

            foreach (var item in collectedResources)
            {
                var output = $"{item.Key} -> {item.Value}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }
    }
}
