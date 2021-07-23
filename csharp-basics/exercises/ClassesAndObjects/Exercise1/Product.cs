using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this._name = name;
            this._priceAtStart = priceAtStart;
            this._amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{this._name}, price {this._priceAtStart: 0.00}, amount {this._amountAtStart}");
        }

        public void AmountChanges(int newAmount)
        {
            this._amountAtStart = newAmount;
        }

        public void PriceChanges(double newPrice)
        {
            this._priceAtStart = newPrice;
        }
    }
}
