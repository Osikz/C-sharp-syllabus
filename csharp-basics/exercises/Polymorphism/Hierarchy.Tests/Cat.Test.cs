using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class CatTests
    {
        private Cat _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Cat("Gray", "Cat", 3.6D, 0, "Home", "Siamese");
        }

        [Test]
        public void MakeSound_CatInstance_ShouldMakeCorrectSound()
        {
            //Arrange
            var expected = "Meooooow!";

            //Assert
            Assert.AreEqual(_target.MakeSound(), expected);
        }

        [Test]
        public void Eat_5Meat_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Meat(5);
            var expected = 5;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
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
        public void AnimalName_CatInstance_ShouldBeGray()
        {
            //Arrange
            var expected = "Gray";

            //Assert
            Assert.AreEqual(_target.AnimalName, expected);
        }

        [Test]
        public void AnimalType_CatInstance_ShouldBeCat()
        {
            //Arrange
            var expected = "Cat";

            //Assert
            Assert.AreEqual(_target.AnimalType, expected);
        }

        [Test]
        public void AnimalWeight_CatInstance_ShouldBe3_6D()
        {
            //Arrange
            var expected = 3.6D;

            //Assert
            Assert.AreEqual(_target.AnimalWeight, expected);
        }

        [Test]
        public void FoodEaten_CatInstance_ShouldBeZero()
        {
            //Arrange
            var expected = 0;

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void LivingRegion_CatInstance_ShouldBeHome()
        {
            //Arrange
            var expected = "Home";

            //Assert
            Assert.AreEqual(_target.LivingRegion, expected);
        }

        [Test]
        public void Breed_CatInstance_ShouldBeSiamese()
        {
            //Arrange
            var expected = "Siamese";

            //Assert
            Assert.AreEqual(_target.Breed, expected);
        }

        [Test]
        public void OverriddenToString_CatInstance_ShouldReturnCorrectString()
        {
            //Arrange
            var animalType = "Cat";
            var animalName = "Muris";
            var animalWeight = 1.4D;
            var foodEaten = 0;
            var livingRegion = "Home";
            var breed = "Siamese";
            var expected = $"{animalType} [{animalName}, {breed}, {animalWeight:F1}, {livingRegion}, {foodEaten}]";

            //Act
            _target = new Cat(animalName, animalType, animalWeight, foodEaten, livingRegion, breed);
            
            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}