using Microsoft.VisualStudio.TestTools.UnitTesting;
using GravityCalculator;
using System;

namespace GravityCalculatorTests
{
    [TestClass]
    public class GravityCalculatorExtensionTests
    {
        private GravityCalculatorExtension _target;

        [TestMethod]
        public void CalculateFinalPosition_12FallingTime_Minus706dot32Expected()
        {
            //Arrange
            _target = new GravityCalculatorExtension(-9.81, 0, 12,0);

            //Act
            var result = _target.CalculateFinalPosition();
            var expected = -706.32;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFinalPosition_NegativeValuesGiven_ExceptionExpected()
        {
            //Act
            Assert.ThrowsException<ArgumentException>(() => new GravityCalculatorExtension(-9.81, -5, -5, 0));
        }
    }
}
