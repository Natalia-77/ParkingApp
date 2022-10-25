namespace ParkingApp.Services
{
    public interface IFileService
    {
        void SerializeState(Dictionary<int, ParkingPlace> dictionary);
        Dictionary<int, ParkingPlace> DeserializeState();
        string GetPathDirectory();
    }
}
