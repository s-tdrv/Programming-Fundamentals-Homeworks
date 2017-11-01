using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask2
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, int> collectedResources = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!collectedResources.ContainsKey(resource))
                {
                    collectedResources.Add(resource, 0);
                }

                collectedResources[resource] += quantity;
                resource = Console.ReadLine();
            }

            foreach (var item in collectedResources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

    }
}
 