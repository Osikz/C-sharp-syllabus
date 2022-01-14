using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FlightPlanner.Tests
{
    public class Tests
    {
        private string[] _cityList = File.ReadAllLines("../../../../FlightPlanner/flights.txt");

        private List<string> _availableCities = new List<string>()
        {
            "San Jose", "New York", "Anchorage",
            "Honolulu", "Denver", "San Francisco"
        };

        private List<string> _availableFlights = new List<string>()
        {
            "San Jose -> San Francisco", "San Jose -> Anchorage"
        };

        [Test]
        public void AvaialbleCities_CityArray_ShouldReturnListOfAvailableCities()
        {
            //Arrange, Act
            var cities = Methods.AvailableCities(_cityList);

            //Assert
            Assert.AreEqual(cities, _availableCities);
        }

        [Test]
        public void AvaialbleFlights_CityArrayAndStartDestinationSanJose_ShouldReturnListOfAvailableFlightsFromSanJose()
        {
            //Arrange, Act
            var startDestination = "San Jose";
            var flights = Methods.AvailableFlights(_cityList, startDestination);

            //Assert
            Assert.AreEqual(flights, _availableFlights);
        }
    }
}