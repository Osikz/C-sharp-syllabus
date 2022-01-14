using NUnit.Framework;

namespace Exercise_1.Tests
{
    public class Tests
    {
        [Test]
        public void CheckNumber_OneOfProvidedNumbersIs15_ExpectedTrue()
        {
            //Arrange
            int numOne = 15;
            int numTwo = 3;

            //Assert
            Assert.IsTrue(Methods.CheckNumber(numOne, numTwo));
        }

        [Test]
        public void CheckNumber_SumOfProvidedNumbersIs15_ExpectedTrue()
        {
            //Arrange
            int numOne = 12;
            int numTwo = 3;

            //Assert
            Assert.IsTrue(Methods.CheckNumber(numOne, numTwo));
        }

        [Test]
        public void CheckNumber_DifferenceOfProvidedNumbersIs15_ExpectedTrue()
        {
            //Arrange
            int numOne = 7;
            int numTwo = 22;

            //Assert
            Assert.IsTrue(Methods.CheckNumber(numOne, numTwo));
        }

        [Test]
        public void CheckNumber_NoneOfProvidedNumbersIs15_ExpectedFalse()
        {
            //Arrange
            int numOne = 7;
            int numTwo = 1;

            //Assert
            Assert.IsFalse(Methods.CheckNumber(numOne, numTwo));
        }

        [Test]
        public void CheckNumber_SumOrDifferenceIsNot15_ExpectedFalse()
        {
            //Arrange
            int numOne = 7;
            int numTwo = 1;

            //Assert
            Assert.IsFalse(Methods.CheckNumber(numOne, numTwo));
        }
    }
}