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
            var routes = FlightPlannerExt.GetListOfRoutes(readText);

            Console.WriteLine("All possible cities:");
            foreach (var city in FlightPlannerExt.GetListOfCities(readText))
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
    }
}
