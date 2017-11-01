using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    public class StartUp
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var commands = input.Split(' ');
                string ip = commands[0].Split('=')[1];
                string user = commands[2].Split('=')[1];
                

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                    
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }
                userLogs[user][ip]++;

                
                input = Console.ReadLine();
            }

            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");
                Console.WriteLine(string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}")) + ".");
                              
                
            }

        }
    }
}
