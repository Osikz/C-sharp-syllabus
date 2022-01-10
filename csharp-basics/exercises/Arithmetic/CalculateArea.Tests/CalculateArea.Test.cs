using System;
using NUnit.Framework;

namespace CalculateArea.Tests
{
    public class Tests
    {
        [Test]
        public void AreaOfCircle_Radius10_Expected12_57d()
        {
            //Arrange
            decimal radius = 2;

            //Assert
            Assert.AreEqual(Geometry.AreaOfCircle(radius), 12.57d);
        }

        [Test]
        public void AreaOfRectangle_Length2Width2_Expected4_0d()
        {
            //Arrange
            decimal length = 2;
            decimal width = 2;

            //Assert
            Assert.AreEqual(Geometry.AreaOfRectangle(length, width), 4.0d);
        }

        [Test]
        public void AreaOfTriangle_Ground5Height5_Expected12_5d()
        {
            //Arrange
            decimal ground = 5;
            decimal h = 5;

            //Assert
            Assert.AreEqual(Geometry.AreaOfTriangle(ground, h), 12.5d);
        }

        [Test]
        public void AreaOfCircle_Radius0_ThrowsInvalidOperationException()
        {
            //Arrange
            decimal radius = 0;

            //Assert
            Assert.Throws<InvalidOperationException>(() => Geometry.AreaOfCircle(radius));
        }

        [Test]
        public void AreaOfRectangle_Length0Width5_ThrowsInvalidOperationException()
        {
            //Arrange
            decimal length = 0;
            decimal width = 5;

            //Assert
            Assert.Throws<InvalidOperationException>(() => Geometry.AreaOfRectangle(length, width));
        }

        [Test]
        public void AreaOfTriangle_Ground0Height5_ThrowsInvalidOperationException()
        {
            //Arrange
            decimal ground = 0;
            decimal h = 5;

            //Assert
            Assert.Throws<InvalidOperationException>(() => Geometry.AreaOfTriangle(ground, h));
        }
    }
}