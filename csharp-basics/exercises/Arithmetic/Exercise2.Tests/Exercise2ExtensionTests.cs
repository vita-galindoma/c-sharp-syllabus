using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise2.Tests
{
    [TestClass]

    public class Exercise2ExtensionTests

    {
        private Exercise2Extension _target;

        [TestMethod]

        public void CheckOdd_Input16_TrueExpected()
        {
            //Arrange
            _target = new Exercise2Extension(16);

            //Act
            var result = _target.CheckOdd();

            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]

        public void CheckOdd_Input17_FalseExpected()
        {
            //Arrange
            _target = new Exercise2Extension(17);

            //Act
            var result = _target.CheckOdd();

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
