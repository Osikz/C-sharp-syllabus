using NUnit.Framework;

namespace CozaLozaWoza.Tests
{
    public class Tests
    {
        [Test]
        public void CheckForCozaLozaWoza_MultiplesOf3EqualsCoza_ExpectedTrue()
        {
            //Arrange
            int number = 3;
            
            //Assert
            Assert.AreEqual(Methods.CheckForCozaWozaLoza(number), "Coza");
        }

        [Test]
        public void CheckForCozaLozaWoza_MultiplesOf5EqualsLoza_ExpectedTrue()
        {
            //Arrange
            int number = 5;
            
            //Assert
            Assert.AreEqual(Methods.CheckForCozaWozaLoza(number), "Loza");
        }

        [Test]
        public void CheckForCozaLozaWoza_MultiplesOf7EqualsWoza_ExpectedTrue()
        {
            //Arrange
            int number = 7;
            
            //Assert
            Assert.AreEqual(Methods.CheckForCozaWozaLoza(number), "Woza");
        }

        [Test]
        public void CheckForCozaLozaWoza_MultiplesOf3And5EqualsCozaLoza_ExpectedTrue()
        {
            //Arrange
            int number = 15;
            
            //Assert
            Assert.AreEqual(Methods.CheckForCozaWozaLoza(number), "CozaLoza");
        }
    }
}