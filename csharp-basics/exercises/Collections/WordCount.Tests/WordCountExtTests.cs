using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountExtTests
    {
        private string inputText =
            "I sing of an old land\n" +
            "where the gods have taken shelter underground,\n" +
            "where the human idols eat human sacrifice,\n" +
            "where hatred runs the business of philanthropy.";

        [TestMethod]
        public void CalculateLineCount_Input4Lines_4Expected()
        {
            //Arrange
            int expectedLineCount = 4;

            //Act
            var result = WordCountExt.CalculateLineCount(inputText);

            //Assert
            Assert.AreEqual(expectedLineCount, result);
        }

        [TestMethod]
        public void CalculateWordCount_Input27Words_27Expected()
        {
            //Arrange
            int expectedWordCount = 27;

            //Act
            var result = WordCountExt.CalculateWordCount(inputText);

            //Assert
            Assert.AreEqual(expectedWordCount, result);
        }

        [TestMethod]
        public void CalculateCharCount_Input159Char_159Expected()
        {
            //Arrange
            int expectedCharCount = 159;

            //Act
            var result = WordCountExt.CalculateCharCount(inputText);

            //Assert
            Assert.AreEqual(expectedCharCount, result);
        }
    }
}
