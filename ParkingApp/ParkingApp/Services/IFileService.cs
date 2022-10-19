namespace ParkingApp.Services
{
    internal interface IFileService
    {
        void SerializeState(Dictionary<int, ParkingPlace> dictionary);
        Dictionary<int, ParkingPlace> DeserializeState();
        string GetPathDirectory();
    }
}
