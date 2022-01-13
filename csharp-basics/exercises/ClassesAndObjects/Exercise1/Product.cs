using System;

namespace Exercise1
{
    public class Product
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

        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public int Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public string PrintProduct()
        {
            return $"{_name} - Price: {_price}EUR - Amount: {_amount}";
        }

        public double ChangeAmount(int newAmount)
        {
            return _amount = newAmount;
        }

        public double ChangePrice(double newPrice)
        {
            return _price = newPrice;
        }
    }
}
