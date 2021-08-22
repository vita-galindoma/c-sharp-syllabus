using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    public class FlightPlannerExt
    {
        public static HashSet<string> GetListOfCities(string[] txt)
        {
            var cities = new HashSet<string>();
            foreach (var city in txt)
            {
                var citiesFromTxt = city.Split('-');
                cities.Add(citiesFromTxt[0].Trim());
            }
            return cities;
        }

        public static Dictionary<string, string> GetListOfRoutes(string[] txt)
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
