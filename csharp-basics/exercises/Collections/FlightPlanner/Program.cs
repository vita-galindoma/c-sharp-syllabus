using System;
using System.Collections.Generic;
using System.IO;


namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<string> roundTripFlight = new List<string>();
            var routes = GetListOfRoutes(readText);

            Console.WriteLine("All possible cities:");
            foreach (var city in GetListOfCities(readText))
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();
            Console.WriteLine("Select a city from which to start your round-trip flight: ");
            string flightTo = Console.ReadLine();
            string flightFrom = flightTo;
            do
            {
                roundTripFlight.Add(flightTo);
                Console.WriteLine();
                Console.WriteLine("Select the next destination:");
                Console.WriteLine(routes[flightTo]);
                Console.WriteLine();
                Console.WriteLine("Select the next destination:");
                flightTo = Console.ReadLine();
            }
            while (flightFrom != flightTo);
            Console.WriteLine();
            Console.WriteLine($"Your round-trip route: {String.Join(" -> ", roundTripFlight)} -> back to {flightFrom}");

            Console.ReadKey();
        }

        static HashSet<string> GetListOfCities(string[] txt)
        {
            var cities = new HashSet<string>();
            foreach (var city in txt)
            {
                var citiesFromTxt = city.Split('-');
                cities.Add(citiesFromTxt[0].Trim());
            }
            return cities;
        }

        static Dictionary<string, string> GetListOfRoutes(string[] txt)
        {
            var routes = new Dictionary<string, string>();
            foreach (var route in txt)
            {
                var citiesFromTxt = route.Split('-');
                var cityToAdd = citiesFromTxt[0].Trim();

                var destinationsFromTxt = route.Split('>');
                var destinationToAdd = destinationsFromTxt[1].Trim();
                
                if (routes.ContainsKey(cityToAdd))
                {
                    routes[cityToAdd] += $", {destinationToAdd}";
                }
                else
                {
                    routes.Add(cityToAdd, destinationToAdd);
                }
            }
            return routes;
        }
    }
}
