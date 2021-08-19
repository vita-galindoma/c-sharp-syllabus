
using System;
using System.CodeDom;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            var finalPosition = new GravityCalculatorExtension(gravity, initialVelocity, fallingTime, initialPosition).CalculateFinalPosition();
            
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
}
