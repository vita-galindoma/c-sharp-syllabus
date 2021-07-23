using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            Car car1 = new Car(0);
            Car car2 = new Car(0);
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Car1 - Enter mileage reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Car1 - Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
                
                Console.Write("Car2 - Enter mileage reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Car2 - Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car2.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption().ToString("0.00") + " gasHog:" + car1.GasHog() + ", economyCar:" + car1.EconomyCar());
            Console.WriteLine("Car2 Kilometers per liter are " + car2.CalculateConsumption().ToString("0.00") + " gasHog:" + car2.GasHog() + ", economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}   
