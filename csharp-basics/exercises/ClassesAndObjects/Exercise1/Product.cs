using System;

namespace Exercise1
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _amount;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name} - Price: {_price}EUR - Amount: {_amount}");
        }

        public void ChangeAmount(int newAmount)
        {
            _amount = newAmount;
        }

        public void ChangePrice(double newPrice)
        {
            _price = newPrice;
        }
    }
}
