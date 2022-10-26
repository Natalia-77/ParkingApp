namespace ParkingApp.UI.Model
{
    public partial class ParkingPlaceModel
    {
        public int NumberPlace { get; init; }
        public bool IsOccupied { get; init; }
        public CarModel? NumberCar { get; init; }
    }    
}
