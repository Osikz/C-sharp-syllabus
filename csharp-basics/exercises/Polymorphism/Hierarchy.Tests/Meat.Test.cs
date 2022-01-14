using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class MeatTests
    {
        private Food _target;

        [Test]
        public void Meat_NewMeat10_ShouldAddQuantity()
        {
            //Arrange
            var expected = 10;

            //Act
            _target = new Meat(10);

            //Assert
            Assert.AreEqual(_target.Quantity, expected);
        }

        [Test]
        public void OverriddenToString_Meat_ShouldReturnMeat()
        {
            //Arrange
            var expected = "Meat";

            //Act
            _target = new Meat(15);

            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}