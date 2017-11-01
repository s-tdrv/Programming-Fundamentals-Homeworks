namespace Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";

            Dictionary<string, double> citiesWithTemperature = new Dictionary<string, double>();

            Dictionary<string, string> citiesWithWeather = new Dictionary<string, string>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                if (Regex.IsMatch(inputLine, pattern))
                {
                    Match match = Regex.Match(inputLine, pattern);

                    string city = match.Groups[1].Value;
                    double averageTemp = double.Parse(match.Groups[2].Value);
                    string weather = match.Groups[3].Value;

                    citiesWithTemperature[city] = averageTemp;
                    citiesWithWeather[city] = weather;
                }

                inputLine = Console.ReadLine();
            }
            Dictionary<string, double> sortedCitiesByTemp = citiesWithTemperature
                .OrderBy(c => c.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var sortedCity in sortedCitiesByTemp)
            {
                Console.WriteLine($"{sortedCity.Key} => {sortedCity.Value} => {citiesWithWeather[sortedCity.Key]}");
            }
        }
    }
}
