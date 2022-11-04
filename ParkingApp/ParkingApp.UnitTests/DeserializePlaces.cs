using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingApp.Services;
using System.Configuration;

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
            result.Should().NotBeNull();
            //var actualType = result.GetType();
            //var expectedType = typeof(ParkingPlace[]);
            //Assert.AreEqual(expectedType, actualType);
        }

        [TestMethod]
        public void Get_path_directory_success_result()
        {
            var service = new SerializationService();
            var path = service.GetCacheFilePath();

            path.Should().BeEquivalentTo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ParkingApp", "place.json"));
        }

        [TestMethod]
        public void Deserialize_places_count_and_not_empty()
        {
            var service = new SerializationService();



            var res = service.DeserializeState();
            res.Should().NotBeEmpty().And.HaveCount(10);
        }

        [TestMethod]
        public void Deserialize_places_details_satisfy()
        {
            var service = new SerializationService();
            var res = service.DeserializeState();
            res.Should().OnlyHaveUniqueItems(x => x.PlaceNumber);
        }


        [TestMethod]
        public void CacheIsRecreated_WhenDoesntExist()
        {
            string tmpPath = Path.Combine(Path.GetTempPath(), "test.json");
            var service = new SerializationService(tmpPath);
            string cacheFile = service.GetCacheFilePath();
            if (File.Exists(cacheFile))
            {
                File.Delete(cacheFile);
            }
            var res = service.DeserializeState();
            res.Should().BeEquivalentTo(ParkingBookModel.DefaultInstance);
        }

        [TestMethod]
        public void CacheIsRecreated_WhenInvalid()
        {
            string tmpPath = Path.Combine(Path.GetTempPath(), "test.json");
            var service = new SerializationService();
            string cacheFile = service.GetCacheFilePath();
            File.WriteAllText(cacheFile, "bla");

            var res = service.DeserializeState();
            res.Should().BeEquivalentTo(ParkingBookModel.DefaultInstance);
        }

    }
}
