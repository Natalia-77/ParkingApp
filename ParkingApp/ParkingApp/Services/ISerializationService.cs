namespace ParkingApp.Services
{
    public interface ISerializationService
    {
        void SerializeState(ParkingBookModel parkingBook);
        ParkingBookModel DeserializeState();
        string GetPathDirectory();
    }
}
