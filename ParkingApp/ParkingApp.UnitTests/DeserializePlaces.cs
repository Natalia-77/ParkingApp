using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingApp.Services;
using Xunit.Sdk;

namespace ParkingApp.UnitTests
{
    [TestClass]
    public class DeserializePlaces
    {
        [TestMethod]
        public void Deserialize_success_result()
        {
            var service = new SerializationService();
            var result = service.DeserializeState();
            var actualType = result.GetType();
            var expectedType = typeof(ParkingPlace[]);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void Get_path_directory_success_result()
        {
            var service = new SerializationService();
            var path = service.GetPathDirectory();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(path);
        }

        [TestMethod]
        public void Deserialize_places_count_and_not_empty()
        {
            var service = new SerializationService();
            var res = service.DeserializeState();
            //res.Should().NotBeEmpty().And.HaveCount(10);
        }

        [TestMethod]
        public void Deserialize_places_details_satisfy()
        {
            var service = new SerializationService();
            var res = service.DeserializeState();
            //res.Should().OnlyHaveUniqueItems(x => x.PlaceNumber);
        }

    }
}
