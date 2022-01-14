using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class MouseTests
    {
        private Mouse _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Mouse("Ratata", "Mouse", 0.2D, 0, "Basement");
        }

        [Test]
        public void MakeSound_MouseInstance_ShouldMakeCorrectSound()
        {
            //Arrange
            var expected = "Piiipiipipi..";

            //Assert
            Assert.AreEqual(_target.MakeSound(), expected);
        }

        [Test]
        public void Eat_5Vegetable_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Vegetable(5);
            var expected = 5;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void Eat_5Meat_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Meat(5);
            var expected = 0;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void AnimalName_MouseInstance_ShouldBeRatata()
        {
            //Arrange
            var expected = "Ratata";

            //Assert
            Assert.AreEqual(_target.AnimalName, expected);
        }

        [Test]
        public void AnimalType_MouseInstance_ShouldBeMouse()
        {
            //Arrange
            var expected = "Mouse";

            //Assert
            Assert.AreEqual(_target.AnimalType, expected);
        }

        [Test]
        public void AnimalWeight_MouseInstance_ShouldBe0_2D()
        {
            //Arrange
            var expected = 0.2D;

            //Assert
            Assert.AreEqual(_target.AnimalWeight, expected);
        }

        [Test]
        public void FoodEaten_MouseInstance_ShouldBeZero()
        {
            //Arrange
            var expected = 0;

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void LivingRegion_MouseInstance_ShouldBeBasement()
        {
            //Arrange
            var expected = "Basement";

            //Assert
            Assert.AreEqual(_target.LivingRegion, expected);
        }

        [Test]
        public void OverriddenToString_MouseInstance_ShouldReturnCorrectString()
        {
            //Arrange
            var animalType = "Mouse";
            var animalName = "Jerry";
            var animalWeight = 0.1D;
            var foodEaten = 0;
            var livingRegion = "Home";
            var expected = $"{animalType} [{animalName}, {animalWeight:F1}, {livingRegion}, {foodEaten}]";

            //Act
            _target = new Mouse(animalName, animalType, animalWeight, foodEaten, livingRegion);
            
            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}