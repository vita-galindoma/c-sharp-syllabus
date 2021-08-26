using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Only positive value accepted.");
            }
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
            {
                throw new ArgumentException("Only positive values accepted.");
            }
            return (double)length * (double)width;
        }

        public static double AreaOfTriangle(decimal ground, decimal h)
        {
            if (ground < 0 || h < 0)
            {
                throw new ArgumentException("Only positive values accepted.");
            }
            return (double)ground * (double)h * 0.5;
        }
    }
}
