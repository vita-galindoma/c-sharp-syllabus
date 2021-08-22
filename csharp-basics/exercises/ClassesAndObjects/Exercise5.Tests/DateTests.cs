using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5.Tests
{
    [TestClass]
    public class DateTests
    {
        private Date _target;

        [TestMethod]
        public void DisplayDate_Input_25Day_8Month__2015Year_2582015Expected()
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
        public void DisplayDate_Input_31Day_9Month_1990Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(31, 9, 1990));
        }

        [TestMethod]
        public void DisplayDate_Input_12Day_14Month_2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(12, 14, 2015));
        }

        [TestMethod]
        public void DisplayDate_Input_Neg12Day_8Month_2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(-12, 8, 2015));
        }

        [TestMethod]
        public void DisplayDate_Input_45Day_5Month_2015Year_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Date(45, 5, 2015));
        }
    }
}
