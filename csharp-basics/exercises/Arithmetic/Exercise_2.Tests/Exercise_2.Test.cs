using NUnit.Framework;

namespace Exercise_2.Tests
{
    public class Tests
    {
        [Test]
        public void CheckIfOdd_NumberIsOdd_ExpectedFalse()
        {
            //Arrange
            int number = 5;

            //Assert
            Assert.IsFalse(Methods.CheckIfOdd(number));
        }

        [Test]
        public void CheckIfOdd_NumberIsEven_ExpectedTrue()
        {
            //Arrange
            int number = 4;

            //Assert
            Assert.IsTrue(Methods.CheckIfOdd(number));
        }
    }
}