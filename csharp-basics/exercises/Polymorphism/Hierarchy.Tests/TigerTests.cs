using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class TIgerTests
    {
        private Tiger _target;
        [TestMethod]
        public void MakeSound()
        {
            //Arrange
            _target = new Tiger("Liam", "Tiger", 31.12, 0, "Europe");
            var resultExpected = "rrrrr";

            //Act
            var resultActual = _target.MakeSound();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void ReturnInfo_InputTigerEaten_ExpectedStringAfterEating()
        {
            //Arrange
            _target = new Tiger("Liam", "Tiger", 31.12, 0, "Europe");
            var resultExpected = "Tiger [Liam, 31.12, 5], Europe";

            //Act
            var food = new Meat("Meat", 5);
            
            _target.Eat(food);
            var resultActual = _target.ReturnInfo();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void Eat_InvalidFood_ExpectedExceptionMessage()
        {
            //Arrange
            _target = new Tiger("Liam", "Tiger", 31.12, 0, "Europe");
            var resultExpected = "Tiger are not eating that type of food!";

            //Act
            var food = new Vegetable("Vegetable", 5);
            var resultActual = _target.Eat(food);

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
