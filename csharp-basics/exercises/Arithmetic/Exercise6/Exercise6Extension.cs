using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Exercise6Extension
    {
        private int _minBorder;
        private int _maxBorder;
        private int _lineLength;

        public Exercise6Extension(int minBorder, int maxBorder, int lineLength)
        {
            _minBorder = minBorder;
            _maxBorder = maxBorder;
            _lineLength = lineLength;
        }
        public string CozaLozaWoza()
        {
            var text = "";
            for (_minBorder = 1; _minBorder <= _maxBorder; _minBorder++)
            {
                if ((_minBorder - 1) % _lineLength == 0 && _minBorder != 1)
                    text += "\n";
                if (_minBorder % 15 == 0)
                    text += "CozaLoza ";
                else if (_minBorder % 21 == 0)
                    text += "CozaWoza ";
                else if (_minBorder % 35 == 0)
                    text += "LozaWoza ";
                else if (_minBorder % 3 == 0)
                    text += "Coza ";
                else if (_minBorder % 5 == 0)
                    text += "Loza ";
                else if (_minBorder % 7 == 0)
                    text += "Woza ";
                else
                    text += $"{_minBorder} ";
            }
            return text;
        }
    }
}
