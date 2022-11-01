using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingApp.Services;
namespace ParkingApp.UnitTests
{
    [TestClass]
    public class SerializePlaces
    {      
        [TestMethod]
        public void Serialize_empty_places()
        {
            SerializationService service = new SerializationService();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException<NullReferenceException>(() => service.SerializeState(null));
        }        
    }
}