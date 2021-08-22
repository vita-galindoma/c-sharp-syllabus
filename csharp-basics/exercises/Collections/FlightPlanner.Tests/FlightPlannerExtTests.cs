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
            HashSet<string> resultCities = new HashSet<string>() { "LA", "NY", "CA", "GA", "IL", "KS"};
            var textResultCities = "";
            foreach (var i in resultCities)
                textResultCities += $"{i} ";

            //Act
            var resultActual = FlightPlannerExt.GetListOfCities(_inputText);
            var textResultActual = "";
            foreach (var i in resultActual) 
                textResultActual += $"{i} ";

            //Assert
            Assert.AreEqual(textResultCities, textResultActual);
        }

        [TestMethod]
        public void GetListOfRoutes_DictionaryExpected()
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
            var textResultRoutes = "";
            foreach (var kvp in routes)
                textResultRoutes += $"[{kvp.Key}, {kvp.Value}]";
            
            //Act
            var resultActual = FlightPlannerExt.GetListOfRoutes(_inputText);
            var textResultActual = "";
            foreach (var i in resultActual)
                textResultActual += $"{i}";

            //Assert
            Assert.AreEqual(textResultRoutes, textResultActual);
        }
    }
}
