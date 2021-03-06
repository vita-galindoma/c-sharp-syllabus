using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed + ".");
            Console.WriteLine("Approximately " + (int)CalculateEnergyDrinkers(NumberedSurveyed) + " bought at least one energy drink.");
            Console.WriteLine((int)CalculatePreferCitrus(NumberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");

            Console.ReadKey();
        }

        public static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            double energyDrinkers = numberSurveyed * PurchasedEnergyDrinks;
            return energyDrinkers;
        }

        public static double CalculatePreferCitrus(int numberSurveyed)
        {
            double preferCitrus = CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks;
            return preferCitrus;
        }
    }
}
