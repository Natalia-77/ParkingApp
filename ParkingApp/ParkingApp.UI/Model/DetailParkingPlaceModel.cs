namespace ParkingApp.UI.Model
{
    public partial class DetailParkingPlaceModel
    {
        public int PlaceNumber { get; init; }
        public bool IsOccupied { get; init; }
        public CarModel OccupiedBy { get; init; }
    }
}
