using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise8.Tests
{
    [TestClass]
    public class Exercise8ExtensionTests
    {
        private Exercise8Extension _target;

        [TestMethod]
        public void WageCalculator_inputInvalidBasePay_ErrorMessageExpected()
        {
            //Arrange
            _target = new Exercise8Extension(7.2, 39);
            var expected = "Error! The base pay $7.2 is less than the minimum wage ($8.00 an hour).";

            //Act
            var result = _target.WageCalculator();

             //Assert
             Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WageCalculator_inputValid_SalaryCalculatedWithBonusExpected()
        {
            //Arrange
            _target = new Exercise8Extension(8.2, 47);
            var expected = "Total salary is $414.1.";

            //Act
            var result = _target.WageCalculator();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WageCalculator_inputInvalidHoursWorked_ErrorMessageExpected()
        {
            //Arrange
            _target = new Exercise8Extension(9, 79);
            var expected = "Error! Employee has worked 79 hours, only 60 hours per week allowed.";

            //Act
            var result = _target.WageCalculator();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WageCalculator_inputValid_SalaryCalculatedExpected()
        {
            //Arrange
            _target = new Exercise8Extension(9, 40);
            var expected = "Total salary is $360.";

            //Act
            var result = _target.WageCalculator();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void WageCalculator_NegativeValuesGiven_ExceptionExpected()
        {
            //Act
            Assert.ThrowsException<ArgumentException>(() => new Exercise8Extension(-9.81, -5));
        }
    }
}
