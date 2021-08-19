using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise1.Tests
{
    [TestClass]
    public class Exercise1ExtensionTests
    {
        [DataTestMethod]
        [DataRow(15, 3, true)]
        [DataRow(9, 15, true)]
        [DataRow(9, 6, true)]
        [DataRow(18, -3, true)]
        [DataRow(18, 9, false)]

        public void IsFifteen_Input2Int_boolExpected(int x, int y, bool z)
        {
            //Act
            var result = Exercise1Extension.IsFifteen(x, y);
            //Assert
            Assert.AreEqual(z, result);
        }
    }
}
