using Newtonsoft.Json;

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

        public ParkingBookModel InitParking()
        {
            _parkingPlace[0] = new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1111 AB") };
            _parkingPlace[1] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 };
            _parkingPlace[2] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 };
            _parkingPlace[3] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 };
            _parkingPlace[4] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 };
            _parkingPlace[5] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 };
            _parkingPlace[6] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 };
            _parkingPlace[7] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 };
            _parkingPlace[8] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 };
            _parkingPlace[9] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 };            

            return new ParkingBookModel(_parkingPlace);
        }

       public ParkingPlace[] Default{ get; } = (new[]
        {
            new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1112de AB") },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 },
            new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 }

        });

        //ниже закомментирован проперти.В таком виде выдает Overflow...Выще написала по-другому-так все ок.

        //public ParkingBookModel Default { get; } = new ParkingBookModel(new[]
        //{
        //    new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1112 AB") },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 },
        //    new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 }
        //});

        public void Show()
        {
            foreach (var item in _parkingPlace)
            {
                if (item.OccupiedBy != null)
                {
                    Console.WriteLine($"{item.PlaceNumber}--> {item.OccupiedBy.NumberOfCar}");
                }
                else
                {
                    Console.WriteLine($"{item.PlaceNumber}--> {item.IsOccupied}");
                }
            }
        }

    }
}
