﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary <string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] parameters = input.Split('|');
                string city = parameters[0];
                string country = parameters[1];
                long population = long.Parse(parameters[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);
                }
                else
                {
                    if (!countries[country].ContainsKey(city))
                    {
                        countries[country].Add(city, population);
                    }

                }
                input = Console.ReadLine();

            }
            //countries = countries.OrderBy(n => n.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value); - същото като foreach-a отдолу

            foreach (var country in countries.OrderByDescending(n => n.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                foreach (var city in country.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }

        }


    }
}

   
