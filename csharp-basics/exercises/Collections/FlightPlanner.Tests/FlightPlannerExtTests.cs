using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class FlightPlannerExtTests
    {
        private readonly string[] _inputText =
        {
            "LA -> NY", "LA -> CA", "NY -> IL", "CA -> GA", "CA -> IL", "GA -> NY", "GA -> KS", "IL -> CA", "KS -> NY"
        };

        [TestMethod]
        public void GetListOfCities_HashsetExpected()
        {
            //Arrange
            var inputTextUniqueCitiesCount = 6;

            //Act
            var resultActual = FlightPlannerExt.GetListOfCities(_inputText);

            //Assert
            Assert.AreEqual(inputTextUniqueCitiesCount, resultActual.Count);
        }

        [TestMethod]
        public void GetListOfRoutes_TheSameValuesforTheKeyForBothDictionariesExpected()
        {
            //Arrange
            var routes = new Dictionary<string, string>()
            {
                {"LA", "NY, CA"},
                {"NY", "IL"},
                {"CA", "GA, IL"},
                {"GA", "NY, KS"},
                {"IL", "CA"},
                {"KS", "NY"}
            };
           
            //Act
            var resultActual = FlightPlannerExt.GetListOfRoutes(_inputText);

            //Assert
            Assert.AreEqual(routes["LA"], resultActual["LA"]);
            Assert.AreEqual(routes["CA"], resultActual["CA"]);
            Assert.AreEqual(routes["KS"], resultActual["KS"]);
        }
    }
}
