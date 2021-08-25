using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class DateTests
    {
        private Date _target;

        [TestMethod]
        public void DisplayDate_Input25Day8Month2015Year_2582015Expected()
        {
            //Arrange
            _target = new Date(25, 8, 2015);

            //Act
            var result = _target.DisplayDate();
            var expected = "25/8/2015";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DisplayDate_Input31Day9Month1990Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(31, 9, 1990));
        }

        [TestMethod]
        public void DisplayDate_Input12Day14Month2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(12, 14, 2015));
        }

        [TestMethod]
        public void DisplayDate_InputNeg12Day8Month2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(-12, 8, 2015));
        }

        [TestMethod]
        public void DisplayDate_Input45Day5Month2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(45, 5, 2015));
        }
    }
}
