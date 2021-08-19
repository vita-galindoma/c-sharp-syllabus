using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class GravityCalculatorExtension
    {
        private readonly double _gravity = -9.81;
        private double _initialVelocity;
        private double _fallingTime;
        private double _initialPosition;

        public GravityCalculatorExtension(double gravity, double initialVelocity, double fallingTime, double initialPosition)
        {
            if (initialVelocity < 0 || fallingTime < 0 || initialPosition < 0)
            {
                throw new ArgumentException("Velocity, falling time and initial position should be positive");
            }
            _gravity = gravity;
            _initialVelocity = initialVelocity;
            _fallingTime = fallingTime;
            _initialPosition = initialPosition;
        }

        public double CalculateFinalPosition()
        {
            return 0.5 * _gravity * Math.Pow(_fallingTime, 2) + (_initialVelocity * _fallingTime) + _initialPosition;
        }
    }
}
