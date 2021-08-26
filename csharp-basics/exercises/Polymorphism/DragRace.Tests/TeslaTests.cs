using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class TeslaTests
    {
        private Tesla _target;

        [TestMethod]
        public void SpeedUp_Input1_Expected1()
        {
            //Arrange
            _target = new Tesla("Tesla");
            var resultExpected = 1;
            _target.SpeedUp();
            
            //Act
            var resultActual = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void SlowDown_Input1_Expected0()
        {
            //Arrange
            _target = new Tesla("Tesla");
            var resultExpected = 0;
            _target.SpeedUp();
            _target.SlowDown();

            //Act
            var resultActual = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void GetName_InputTesla_ExpectedTesla()
        {
            //Arrange
            _target = new Tesla("Tesla");
            var resultExpected = "Tesla";

            //Act
            var resultActual = _target.GetName();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void StartEngine_ExpectedStringWithSound()
        {
            //Arrange
            _target = new Tesla("Tesla");
            var resultExpected = "-- silence ---";

            //Act
            var resultActual = _target.StartEngine();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
