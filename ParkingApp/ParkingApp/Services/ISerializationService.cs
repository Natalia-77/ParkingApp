namespace ParkingApp.Services
{
    public interface ISerializationService
    {
        void SerializeState(ParkingBookModel book);
        ParkingBookModel DeserializeState();
        string GetCacheFilePath();
    }
}
