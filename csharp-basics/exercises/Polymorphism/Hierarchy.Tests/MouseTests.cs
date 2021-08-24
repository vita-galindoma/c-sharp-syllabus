using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class MouseTests
    {
        private Mouse _target;
        [TestMethod]
        public void MakeSound()
        {
            //Arrange
            _target = new Mouse("Mousy", "mouse", 12.12, 0, "Africa");
            var resultExpected = "pii pii pii";

            //Act
            var resultActual = _target.MakeSound();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void ReturnInfo_InputMouseEaten_ExpectedStringAfterEating()
        {
            //Arrange
            _target = new Mouse("Mousy", "Mouse", 12.12, 0, "Africa");
            var resultExpected = "Mouse [Mousy, 12.12, 5], Africa"; 

            //Act
            var food = new Vegetable("Vegetable", 5);
            _target.Eat(food);
            var resultActual = _target.ReturnInfo();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void Eat_InvalidFood_ExpectedExceptionMessage()
        {
            //Arrange
            _target = new Mouse("Mousy", "Mouse", 12.12, 0, "Africa");
            var resultExpected = "Mouse are not eating that type of food!"; 

            //Act
            var food = new Meat("Meat", 5);
            var resultActual = _target.Eat(food);

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
