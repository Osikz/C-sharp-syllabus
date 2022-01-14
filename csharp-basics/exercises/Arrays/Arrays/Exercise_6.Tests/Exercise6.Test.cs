using System;
using System.Linq;
using NUnit.Framework;

namespace Exercise_6.Tests
{
    public class Tests
    {
        [Test]
        public void RandomArrayNumbers_ArraysAreCopied_ExpectedTrue()
        {
            //Arrange
            int[] arrayOne = new int[10];
            int[] arrayTwo = new int[10];
            Random rnd = new Random();

            //Act
            ArrayMethods.RandomArrayNumbers(rnd, arrayOne, arrayTwo);

            //Assert
            Assert.AreEqual(arrayOne, arrayTwo);
        }

        [Test]
        public void RandomArrayNumbers_ArrayIntegerRangesFrom1To100_ExpectedTrue()
        {
            //Arrange
            int[] arrayOne = new int[10];
            int[] arrayTwo = new int[10];
            Random rnd = new Random();
            int min = 0;
            int max = 100;

            //Act
            ArrayMethods.RandomArrayNumbers(rnd, arrayOne, arrayTwo);

            //Assert
            for (int i = 0; i < arrayOne.Length; i++)
            {
                Assert.IsTrue(Enumerable.Range(min, max).Contains(arrayTwo[i]));
            }
        }

        [Test]
        public void RandomArrayNumbers_ArraysAreCorrectLength_ExpectedTrue()
        {
            //Arrange
            int[] arrayOne = new int[10];
            int[] arrayTwo = new int[10];
            Random rnd = new Random();

            //Act
            ArrayMethods.RandomArrayNumbers(rnd, arrayOne, arrayTwo);

            //Assert
            Assert.AreEqual(arrayOne.Length, 10);
            Assert.AreEqual(arrayTwo.Length, 10);
        }

        [Test]
        public void ChangeLastNumber_ArrayTwoLastDigitIsMinus7_ExpectedTrue()
        {
            //Arrange
            int[] arrayOne = new int[10];
            int[] arrayTwo = new int[10];
            Random rnd = new Random();

            //Act
            ArrayMethods.RandomArrayNumbers(rnd, arrayOne, arrayTwo);
            ArrayMethods.ChangeLastNumber(arrayTwo);

            //Assert
            Assert.AreNotEqual(arrayOne[^1], arrayTwo[^1]);
        }
    }
}