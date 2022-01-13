using NUnit.Framework;

namespace DragRace.Tests
{
    public class BmwTest
    {
        private Bmw _target;

        [SetUp]
        public void Setup()
        {
            _target = new Bmw();
        }

        [Test]
        public void SpeedUp_CurrentSpeed_ShouldIncreaseSpeed()
        {
            //Arrange
            var expected = 12;

            //Assert
            Assert.AreEqual(_target.SpeedUp(), expected);
        }

        [Test]
        public void SlowDown_CurrentSpeed_ShouldDecreaseSpeed()
        {
            //Arrange
            var expected = 4;
            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(_target.SlowDown(), expected);
        }

        [Test]
        public void ShowCurrentSpeed_CurrentSpeed_ShouldEqual10()
        {
            //Arrange
            var expected = "12";

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(_target.ShowCurrentSpeed(), expected);
        }

        [Test]
        public void StartEngine_CarAudiObject_ShouldReturnCorrectString()
        {
            //Arrange
            var expected = "Rrrrrrr.....";

            //Assert
            Assert.AreEqual(_target.StartEngine(), expected);
        }

        [Test]
        public void UseNitrousOxideEngine_CurrentSpeed_ShouldIncreaseSpeedALot()
        {
            //Arrange
            var expected = 50;

            //Assert
            Assert.AreEqual(_target.UseNitrousOxideEngine(), expected);
        }
    }
}