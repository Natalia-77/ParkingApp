namespace ParkingApp.UI.Model
{
    public class CarModel
    {
        public CarModel(string numberOfCar)
        {
            NumberOfCar = numberOfCar;
        }

        public string NumberOfCar { get; init; }
    }
}
