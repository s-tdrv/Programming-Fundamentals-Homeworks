using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class StartUp
    {
        static void Main()
        {
            var records = new Dictionary<string, string>();
            string name = Console.ReadLine();


            while (name != "stop")
            {
                string email = Console.ReadLine();
                string emailEnd = email.Substring(email.Length - 2, 2);

                if (emailEnd != "us" && emailEnd != "uk")
                {
                    records.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var rec in records)
            {
                Console.WriteLine($"{rec.Key} -> {rec.Value}");
            }
        }
    }
}
