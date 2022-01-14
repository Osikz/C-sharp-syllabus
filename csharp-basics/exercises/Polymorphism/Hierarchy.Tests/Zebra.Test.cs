using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class ZebraTests
    {
        private Zebra _target;
        
        [SetUp]
        public void Setup()
        {
            _target = new Zebra("Matthew", "Zebra", 230.48D, 0, "Africa");
        }

        [Test]
        public void MakeSound_ZebraInstance_ShouldMakeCorrectSound()
        {
            //Arrange
            var expected = "Neeeeeigh...";

            //Assert
            Assert.AreEqual(_target.MakeSound(), expected);
        }

        [Test]
        public void Eat_50Vegetable_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Vegetable(50);
            var expected = 50;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void Eat_50Meat_ShouldReturnCorrectFoodEaten()
        {
            //Arrange
            var food = new Meat(50);
            var expected = 0;

            //Act
            _target.Eat(food);

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void AnimalName_ZebraInstance_ShouldBeMatthew()
        {
            //Arrange
            var expected = "Matthew";

            //Assert
            Assert.AreEqual(_target.AnimalName, expected);
        }

        [Test]
        public void AnimalType_ZebraInstance_ShouldBeZebra()
        {
            //Arrange
            var expected = "Zebra";

            //Assert
            Assert.AreEqual(_target.AnimalType, expected);
        }

        [Test]
        public void AnimalWeight_ZebraInstance_ShouldBe230_48D()
        {
            //Arrange
            var expected = 230.48D;

            //Assert
            Assert.AreEqual(_target.AnimalWeight, expected);
        }

        [Test]
        public void FoodEaten_ZebraInstance_ShouldBeZero()
        {
            //Arrange
            var expected = 0;

            //Assert
            Assert.AreEqual(_target.FoodEaten, expected);
        }

        [Test]
        public void LivingRegion_ZebraInstance_ShouldBeAfrica()
        {
            //Arrange
            var expected = "Africa";

            //Assert
            Assert.AreEqual(_target.LivingRegion, expected);
        }

        [Test]
        public void OverriddenToString_ZebraInstance_ShouldReturnCorrectString()
        {
            //Arrange
            var animalType = "Zebra";
            var animalName = "Joshua";
            var animalWeight = 198.99D;
            var foodEaten = 0;
            var livingRegion = "South America";
            var expected = $"{animalType} [{animalName}, {animalWeight:F1}, {livingRegion}, {foodEaten}]";

            //Act
            _target = new Zebra(animalName, animalType, animalWeight, foodEaten, livingRegion);
            
            //Assert
            Assert.AreEqual(_target.ToString(), expected);
        }
    }
}