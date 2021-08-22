using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class ProductTests
    {
        private Product _target;


        [TestMethod]
        public void PrintProduct_InputNewValidProd_ProductInfoExpected()
        {
            //Arrange
            _target = new Product("iPhone 10",800.99,1);

            //Act
            var result = _target.PrintProduct();
            var expected = "iPhone 10, price 800.99, amount 1";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountChanges_Input5_5Expected()
        {
            //Arrange
            _target = new Product("iPhone 10", 800.99, 1);

            //Act
            var result = _target.AmountChanges(5);
            var expected = 5;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountChanges_InputNegative5_ExceptionExpected()
        {
            //Arrange
            _target = new Product("iPhone 10", 800.99, 1);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.AmountChanges(-5));
        }

        [TestMethod]
        public void PriceChanges_Input700_700Expected()
        {
            //Arrange
            _target = new Product("iPhone 10", 800.99, 1);

            //Act
            var result = _target.PriceChanges(700);
            var expected = 700;

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PriceChanges_InputNegative700_ExceptionExpected()
        {
            //Arrange
            _target = new Product("iPhone 10", 800.99, 1);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.PriceChanges(-700));
        }

        [TestMethod]
        public void NewProduct_InputNegativeAmount_ExceptionExpected()
        {
            //Assert
            Assert.ThrowsException<ArgumentException>(() => new Product("Apple Watch Series 6", -5, -2));
        }
    }
}
