using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Exercise2Extension
    {
        private int _number;

        public Exercise2Extension(int number)
        {
            _number = number;
        }

        public bool CheckOdd()
        {
            return _number % 2 == 0;
        }
    }
}
