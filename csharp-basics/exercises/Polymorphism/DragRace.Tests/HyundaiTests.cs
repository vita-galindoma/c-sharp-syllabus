using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Tests
{
    [TestClass]
    public class HyundaiTests
    {
        private Hyundai _target;

        [TestMethod]
        public void SpeedUp_Input1_Expected1()
        {
            //Arrange
            _target = new Hyundai("Hyundai");
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
            _target = new Hyundai("Hyundai");
            var resultExpected = 0;
            _target.SpeedUp();
            _target.SlowDown();

            //Act
            var resultActual = _target.ShowCurrentSpeed();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void GetName_InputHyundai_ExpectedHyundai()
        {
            //Arrange
            _target = new Hyundai("Hyundai");
            var resultExpected = "Hyundai";

            //Act
            var resultActual = _target.GetName();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod]
        public void StartEngine_ExpectedStringWithSound()
        {
            //Arrange
            _target = new Hyundai("Hyundai");
            var resultExpected = "Rrrrrrr.....";

            //Act
            var resultActual = _target.StartEngine();

            //Assert
            Assert.AreEqual(resultExpected, resultActual);
        }
    }
}
