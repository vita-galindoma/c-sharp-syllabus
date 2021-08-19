using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void AreaOfCircle_input5radius_78dot54Expected()
        {
            //Arrange
            var radius = 5;
            var expectedAreaCircle = 78.54;
            //Act
            var resultAreaCircle = Geometry.AreaOfCircle(radius);

            //Assert
            Assert.AreEqual(expectedAreaCircle, resultAreaCircle);
        }

        [TestMethod]
        public void AreaOfRectangle_input5length4width_20Expected()
        {
            //Arrange
            var length = 5;
            var width = 4;
            var expectedAreaRectangle = 20;
            //Act
            var resultAreaRectangle = Geometry.AreaOfRectangle(length, width);

            //Assert
            Assert.AreEqual(expectedAreaRectangle, resultAreaRectangle);
        }

        [TestMethod]
        public void AreaOfTriangle_input5ground2h_5Expected()
        {
            //Arrange
            var ground = 5;
            var h = 2;
            var expectedAreaTriangle = 5;
            //Act
            var resultAreaTriangle = Geometry.AreaOfTriangle(ground, h);

            //Assert
            Assert.AreEqual(expectedAreaTriangle, resultAreaTriangle);
        }

        [TestMethod]
        public void AreaOfCircle_NegativeValuesGiven_ExceptionExpected()
        {
            //Arrange
            var radius = -5.2;

            //Act
            Assert.ThrowsException<ArgumentException>(() => Geometry.AreaOfCircle(radius));
        }

        [TestMethod]
        public void AreaOfRectangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Arrange
            var length = -5;
            var width = -4;

            //Act
            Assert.ThrowsException<ArgumentException>(() => Geometry.AreaOfRectangle(length, width));
        }

        [TestMethod]
        public void AreaOfTriangle_NegativeValuesGiven_ExceptionExpected()
        {
            //Arrange
            var ground = -5;
            var h = -2;

            //Act
            Assert.ThrowsException<ArgumentException>(() => Geometry.AreaOfTriangle(ground, h));
        }
    }
}