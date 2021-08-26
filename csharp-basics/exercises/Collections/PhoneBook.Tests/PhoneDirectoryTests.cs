using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        PhoneDirectory target = new PhoneDirectory();
        
        [TestMethod]
        public void AddNumber_ValidName_ExpectedNumberAdded()
        {
            //Arrange
            //PhoneDirectory target = new PhoneDirectory();
            var userName = "Gustav";
            var userNum = "26467708";
            var expectedResult = "name: Gustav, number: 26467708.";
            //Act
            target.AddNumber(userName, userNum);
            
            //Assert
            Assert.AreEqual(expectedResult, target.FindByName(userName));
        }

        [TestMethod]
        public void AddNumber_InvalidName_ExpectedException()
        {
            //Arrange
            target = new PhoneDirectory();
            target.AddNumber("Gustav", "26467708");
            var userName = "Gustav";
            var userNum = "26467708";
            var expectedResult = "An entry with name Gustav already exists.";

            //Act 
            var actualResult = target.AddNumber(userName, userNum);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FindByName_InputJohn_ExpectedNameAndNum()
        {
            //Arrange
            target = new PhoneDirectory();
            target.AddNumber("John", "26467702");

            var expectedResult = "name: John, number: 26467702.";

            //Act 
            var actualResult = target.FindByName("John");

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [DataTestMethod]
        [DataRow("John", "name: John, number: 26467705.")]
        [DataRow("Eric", "Eric is not found.")]
        public void FindByName_InputName_ExpectedNameAddedAndNotFound(string name, string result)
        {
            //Arrange
            target = new PhoneDirectory();
            target.AddNumber("John", "26467705");

            //Act 
            var actualResult = target.FindByName(name); ;

            //Assert
            Assert.AreEqual(result, actualResult);
        }

        [DataTestMethod]
        [DataRow("26467705", "This 26467705 belongs to Gustav.")]
        [DataRow("26467702", "Number 26467702 is not found.")]
        public void FindByNumber_InputValidAndInvalidNums_ExpectedFullContactAndNotFoundMessage(string num, string result)
        {
            //Arrange
            target = new PhoneDirectory();
            target.AddNumber("Gustav", "26467705");
            
            //Act 
            var actualResult = target.FindByNumber(num);

            //Assert
            Assert.AreEqual(result, actualResult);
        }

        [TestMethod]
        public void ReturnAllPhoneBook_Input1Item_Expected1ItemPhoneBook()
        {
            //Arrange
            target = new PhoneDirectory();
            target.AddNumber("John", "26467702");

            var expectedResult = "Name: John, Number: 26467702\n";

            //Act 
            var actualResult = target.ReturnAllPhoneBook();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
