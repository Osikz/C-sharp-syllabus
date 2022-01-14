using NUnit.Framework;

namespace Exercise5.Tests
{
    public class Tests
    {
        [Test]
        public void DisplayDate_DayMonthYear_ShouldDisplayCorrectDateCorrectly()
        {
            //Arrange
            var day = 13;
            var month = 1;
            var year = 2022;

            //Act
            var target = new Date(day, month, year);

            //Assert
            Assert.AreEqual(target.DisplayDate(), $"{day}/{month}/{year}");
        }
    }
}