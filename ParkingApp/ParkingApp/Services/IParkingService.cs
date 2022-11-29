using System.Runtime.CompilerServices;

namespace ParkingApp.Services
{
    public interface IParkingService
    {
       public void SaveState();
        // ParkingService InitParkingPlaces();
        public ParkingBookModel GetPlaces();
    }
}
