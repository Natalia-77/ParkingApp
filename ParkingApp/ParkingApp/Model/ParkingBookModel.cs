using Newtonsoft.Json;
using ParkingApp.Model;
using ParkingApp.Services;

namespace ParkingApp
{
    public class ParkingBookModel
    {
        [JsonProperty]
        private readonly ParkingPlace[] _parkingPlace = new ParkingPlace[10];

        public ParkingBookModel()
        {
        }

        public ParkingBookModel(ParkingPlace[] places)
        {
            _parkingPlace = places;
        }

        public static ParkingBookModel InitParking()
        {
            ParkingBookModel parkingBookModel = new();

            parkingBookModel._parkingPlace[0] = new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1234 AB") };
            parkingBookModel._parkingPlace[1] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 };
            parkingBookModel._parkingPlace[2] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 };
            parkingBookModel._parkingPlace[3] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 };
            parkingBookModel._parkingPlace[4] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 };
            parkingBookModel._parkingPlace[5] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 };
            parkingBookModel._parkingPlace[6] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 };
            parkingBookModel._parkingPlace[7] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 };
            parkingBookModel._parkingPlace[8] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 };
            parkingBookModel._parkingPlace[9] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 };

            parkingBookModel.IsDefault = true;

            return parkingBookModel;
        }

        public bool IsDefault { get; private set; }

        public static ParkingBookModel DefaultInstance { get; } = new ParkingBookModel(new[] 
        {
            new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1234 AB") }, 
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 }
            //parkingBookModel._parkingPlace[2] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 };
            //parkingBookModel._parkingPlace[3] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 };
            //parkingBookModel._parkingPlace[4] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 };
            //parkingBookModel._parkingPlace[5] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 };
            //parkingBookModel._parkingPlace[6] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 };
            //parkingBookModel._parkingPlace[7] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 };
            //parkingBookModel._parkingPlace[8] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 };
            //parkingBookModel._parkingPlace[9] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 };
        });

        public void ShowDict()
        {
            foreach (var item in _parkingPlace)
            {
                if (item.OccupiedBy != null)
                {
                    Console.WriteLine($"{item.PlaceNumber}-->{item.OccupiedBy.NumberOfCar}");
                }
                else
                {
                    Console.WriteLine($"Key = {item.PlaceNumber}-->{item.IsOccupied}");
                }
            }
        }

        public void Show()
        {
            foreach (var item in _parkingPlace)
            {
                if (item.OccupiedBy != null)
                {
                    Console.WriteLine($"{item.PlaceNumber}-->{item.OccupiedBy.NumberOfCar}");
                }
                else
                {
                    Console.WriteLine($"Key = {item.PlaceNumber}-->{item.IsOccupied}");
                }
            }
        }

        //public void AddCar(Car car)
        //{
        //    cars.Add(car);
        //    carSpace++;
        //    dictionary[1] = new ParkingPlace {NumberPlace = 11, IsOccupied = true, NumberCar = car };
        //}       


    }
}
