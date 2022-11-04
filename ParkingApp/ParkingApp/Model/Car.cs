namespace ParkingApp.Model
{
    public class Car
    {
        public string NumberOfCar { get; init; }
        public Car(string number)
        {
            NumberOfCar = number;
        }
    }
}
