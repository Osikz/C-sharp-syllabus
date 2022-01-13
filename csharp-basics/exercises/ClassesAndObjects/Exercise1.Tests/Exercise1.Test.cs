using System;
using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        private Product _target;

        [SetUp]
        public void Setup()
        {
            _target = new Product("Zowie", 69.99D, 5);
        }

        [Test]
        public void ChangeAmount_NewAmount_ShouldEqualNewAmount()
        {
            //Arrange, Act
            _target.ChangeAmount(10);

            //Assert
            Assert.AreEqual(_target.Amount, 10);
        }

        [Test]
        public void ChangePrice_NewPrice_ShouldEqualNewPrice()
        {
            //Arrange, Act
            _target.ChangePrice(49.99D);

            //Assert
            Assert.AreEqual(_target.Price, 49.99D);
        }

        [Test]
        public void PrintProduct_ProductInstance_ShouldPrintCorrectMessage()
        {
            //Arrange
            var name = _target.Name;
            var amount = _target.Amount;
            var price = _target.Price;

            //Assert
            Assert.AreEqual(_target.PrintProduct(), $"{name} - Price: {price}EUR - Amount: {amount}");
        }
    }
}