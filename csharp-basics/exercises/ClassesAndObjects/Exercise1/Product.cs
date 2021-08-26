using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            if (priceAtStart < 0 || amountAtStart < 0)
            {
                throw new ArgumentException("Price and amount should be positive");
            }
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public string PrintProduct()
        {
            return $"{_name}, price {_priceAtStart:0.00}, amount {_amountAtStart}";
        }

        public int AmountChanges(int newAmount)
        {
            if (newAmount < 0)
            {
                throw new ArgumentException("Amount should be positive");
            }
            _amountAtStart = newAmount;
            return newAmount;
        }

        public double PriceChanges(double newPrice)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException("Price should be positive");
            }
            _priceAtStart = newPrice;
            return newPrice;
        }
    }
}
