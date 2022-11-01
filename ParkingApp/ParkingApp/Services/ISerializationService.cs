namespace ParkingApp.Services
{
    public interface ISerializationService
    {
        void SerializeState(ParkingPlace[] places );
        ParkingPlace[] DeserializeState();
        string GetPathDirectory();
    }
}
