using System;
using Exercise_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6_.Tests
{
    [TestClass]
    public class ArrayExtensionsTests
    {
        [TestMethod]
        public void CopyArray_InputArrLength10_10ExpectedCopiedArrayLength()
        {
            //Arrange
            int[] intArr = {1, 5, 47, 48, 58, 12, 14, 10, 1, 15};
            var expectedLength = 10;

            // Act
            int[] copiedArray = ArrayExtensions.CopyArray(intArr);
            var arrLength = copiedArray.Length;

            // Assert
            Assert.AreEqual(expectedLength, arrLength);
        }

        [TestMethod]
        public void CopyArray_LastItemMinus7_Minus7Expected()
        {
            //Arrange
            int[] intArr = {1, 5, 47, 48, 58, 12, 14, 10, 1, 15};
            var expectedLastItem = -7;

            // Act
            int lastItem = ArrayExtensions.CopyArray(intArr)[^1];
            
            // Assert
            Assert.AreEqual(expectedLastItem, lastItem);
        }

        [TestMethod]
        public void CreateRandomArray_ArrayOf10Int_ArrayOf10IntExpected()
        {
            //Arrange
            int[] intArr = { 1, 5, 47, 48, 58, 12, 14, 10, 1, 15 };
            var expectedLength = intArr.Length;

            // Act
            int actualLength = ArrayExtensions.CreateRandomArray(10).Length;

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}