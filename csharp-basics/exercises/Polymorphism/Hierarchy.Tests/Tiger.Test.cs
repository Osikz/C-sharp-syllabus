using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class TigerTests
    {
        private Tiger _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Tiger("Tom", "Tiger", 153.45D, 0, "Wild Africa");
        }

        [Test]
        public void MakeSound_TigerInstance_ShouldMakeCorrectSound()
        {
            //Arrange
            var expected = "Rawwwwwr!";

            //Assert
            Assert.AreEqual(_target.MakeSound(), expected);
        }

        [Test]
        public void Eat_50Meat_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Meat(50);
            var expected = 50;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void Eat_50Vegetable_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Vegetable(50);
            var expected = 0;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void AnimalName_TigerInstance_ShouldBeTom()
        {
            //Arrange
            var expected = "Tom";

            //Assert
            Assert.AreEqual(_target.AnimalName, expected);
        }

        [Test]
        public void AnimalType_TigerInstance_ShouldBeTiger()
        {
            //Arrange
            var expected = "Tiger";

            //Assert
            Assert.AreEqual(_target.AnimalType, expected);
        }

        [Test]
        public void AnimalWeight_TigerInstance_ShouldBe153_45D()
        {
            //Arrange
            var expected = 153.45D;

            //Assert
            Assert.AreEqual(_target.AnimalWeight, expected);
        }

        [Test]
        public void FoodEaten_TigerInstance_ShouldBeZero()
        {
            //Arrange
            var expected = 0;

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void LivingRegion_TigerInstance_ShouldBeWildAfrica()
        {
            //Arrange
            var expected = "Wild Africa";

            //Assert
            Assert.AreEqual(_target.LivingRegion, expected);
        }

        [Test]
        public void OverriddenToString_TigerInstance_ShouldReturnCorrectString()
        {
            //Arrange
            var animalType = "Tiger";
            var animalName = "Robert";
            var animalWeight = 123.12D;
            var foodEaten = 0;
            var livingRegion = "Wild West";
            var expected = $"{animalType} [{animalName}, {animalWeight:F1}, {livingRegion}, {foodEaten}]";

            //Act
            _target = new Tiger(animalName, animalType, animalWeight, foodEaten, livingRegion);
            
            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}