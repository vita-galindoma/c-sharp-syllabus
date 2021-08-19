using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise6.Tests
{
    [TestClass]
    public class Exercise6ExtensionTests
    {
        private Exercise6Extension _target;

        [TestMethod]

        public void CozaLozaWoza_Input22_2LinesExpected()
        {
            //Arrange
            _target = new Exercise6Extension(1, 22, 11);

            //Act
            var result = _target.CozaLozaWoza().Trim();
            var expected = "1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11 \nCoza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22";

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
