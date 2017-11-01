using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    public class startUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                var commandArgs = input.Split(' ');
                var ip = commandArgs[0];
                var name = commandArgs[1];
                var duration = int.Parse(commandArgs[2]);

                if (!logs.ContainsKey(name))
                {
                    logs.Add(name, new SortedDictionary<string, int>());

                    if (!logs[name].ContainsKey(ip))
                    {
                        logs[name].Add(ip, 0);
                        logs[name][ip] += duration;
                    }
                    else
                    {
                        logs[name][ip] += duration;
                    }
                    
                }
                else
                {
                    if (!logs[name].ContainsKey(ip))
                    {
                        logs[name].Add(ip, 0);
                        logs[name][ip] += duration;
                    }
                    else
                    {
                        logs[name][ip] += duration;
                    }
                }

                
            }

            foreach (var user in logs)
            {
                var totalDuration = logs[user.Key].Values.Sum();
                var ipList = user.Value.Keys.ToList();
                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ", ipList)}]");
            }
        }
    }
}
