using NUnit.Framework;

namespace GravityCalculator.Tests
{
    public class Tests
    {
        [Test]
        public void FinalPositionCalculator_GravityFallingTimeInitPosInitVelocity_Expected490_5()
        {
            //Arrange
            double gravity = -9.81;
            double fallingTime = 10.0;
            double initPos = 0.0;
            double initVelocity = 0.0;

            //Assert
            Assert.AreEqual(Methods.FinalPositionCalculator(gravity, initVelocity, initPos, fallingTime), -490.5);
        }
    }
}