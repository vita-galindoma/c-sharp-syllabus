using System;
using Exercise_6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6_.Tests
{
    [TestClass]
    public class ArrayExtensionsTests
    {

        [TestMethod]
        public void Length_InputArrLength10_10Expected()
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
        public void LastItem_InputMinus7_Minus7Expected()
        {
            //Arrange
            int[] intArr = {1, 5, 47, 48, 58, 12, 14, 10, 1, 15};
            var expectedLastItem = -7;

            // Act
            int[] copiedArray = ArrayExtensions.CopyArray(intArr);
            var lastItem = 0;
            foreach (var i in copiedArray)
            {
                lastItem = copiedArray[^1];
            }
            
            // Assert
            Assert.AreEqual(expectedLastItem, lastItem);
        }

        [TestMethod]
        public void AllItemsInRange1to100_True_TrueExpected()
        {
            //Arrange
            int[] newArray = ArrayExtensions.CreateRandomArray(10);

            // Act
            bool InRange(int min, int max, int[] arr)
            {
                foreach (var x in arr)
                {
                    if (x >= min && x <= max) 
                        return true;
                }
                return false;
            }

            // Assert
            Assert.AreEqual(true, InRange(1, 100, newArray));
        }
    }
}
