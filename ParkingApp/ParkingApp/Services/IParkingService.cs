namespace ParkingApp.Services
{
    public interface IParkingService
    {
        void SaveState();
        ParkingBookModel InitParkingPlaces();
    }
}
