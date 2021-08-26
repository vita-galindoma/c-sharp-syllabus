using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Exercise1
{
    public class Exercise1Extension
    {
        public static bool IsFifteen(int x, int y)
        {
            return x == 15 || y == 15 || x + y == 15 || Math.Abs(x + y) == 15;
        }
    }
}
