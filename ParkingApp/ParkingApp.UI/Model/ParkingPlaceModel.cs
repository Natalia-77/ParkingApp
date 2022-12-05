namespace ParkingApp.UI.Model
{
    public partial class ParkingPlaceModel
    {
        public int PlaceNumber { get; init; }
        public bool IsOccupied { get; init; }
        public CarModel OccupiedBy { get; init; }
        public Color Colores
        {
            get
            {
                return IsOccupied? Color.FromRgb(253, 174, 174): Color.FromRgb(132, 247, 114);
            }
        }
    }    
}
