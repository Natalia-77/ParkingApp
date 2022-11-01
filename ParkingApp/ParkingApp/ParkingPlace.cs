namespace ParkingApp
{
   public class ParkingPlace
    {
        public int PlaceNumber { get; init; }
        public bool IsOccupied { get; init; }
        public Car? OccupiedBy { get; init; }
    }
}
