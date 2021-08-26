using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hierarchy.Tests
{
    [TestClass]
    public class CatTests
    {
        private Cat _target;
        [TestMethod]
        public void MakeSound()
        {
            //Arrange
            _target = new Cat("Bob", "Cat", 31.12, 0, "Europe", "Persian");
            var resultExpected = "meouuw";

            //Act
            var resultActual = _target.MakeSound();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void ReturnInfo_InputCatEaten_ExpectedStringAfterEating()
        {
            //Arrange
            _target = new Cat("Bob", "Cat", 31.12, 0, "Europe", "Persian");
            var resultExpected = "Cat [Bob, 31.12, 5], Europe, Persian";

            //Act
            var food = new Vegetable("Vegetable", 5);
            _target.Eat(food);
            var resultActual = _target.ReturnInfo();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void Eat_ValidFoodInput_ExpectedInfoOfAnimal()
        {
            //Arrange
            _target = new Cat("Bob", "Cat", 31.12, 0, "Europe", "Persian");
            var resultExpected = "Cat, [Bob, Persian, 31.12, Europe, 5]";

            //Act
            var food = new Meat("Meat", 5);
            var resultActual = _target.Eat(food);

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
