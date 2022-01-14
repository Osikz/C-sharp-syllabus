using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class VegetableTests
    {
        private Food _target;

        [Test]
        public void Vegetable_NewVegetable10_ShouldAddQuantity()
        {
            //Arrange
            var expected = 10;

            //Act
            _target = new Vegetable(10);

            //Assert
            Assert.AreEqual(_target.Quantity, expected);
        }

        [Test]
        public void OverriddenToString_Vegetable_ShouldReturnVegetable()
        {
            //Arrange
            var expected = "Vegetable";

            //Act
            _target = new Vegetable(15);

            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}