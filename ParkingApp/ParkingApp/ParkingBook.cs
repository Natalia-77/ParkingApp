using ParkingApp.Services;
namespace ParkingApp
{
    public class ParkingBook
    {
        private readonly SerializationService _fileService;
        private readonly ParkingPlace[] parkingPlace = new ParkingPlace[10];      
        public ParkingBook()
        {            
            _fileService = new SerializationService();            
        }

        public void InitDictionary()
        {
            parkingPlace[0] = new ParkingPlace() { IsOccupied = true, PlaceNumber = 11, OccupiedBy = new Car("1234 AB") };
            parkingPlace[1] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 12 };
            parkingPlace[2] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 13 };
            parkingPlace[3] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 14 };
            parkingPlace[4] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 15 };
            parkingPlace[5] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 16 };
            parkingPlace[6] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 17 };
            parkingPlace[7] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 18 };
            parkingPlace[8] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 19 };
            parkingPlace[9] = new ParkingPlace() { IsOccupied = false, PlaceNumber = 20 };
        }

        public void ShowDict()
        {
            foreach (var item in parkingPlace)
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

        public void SaveState()
        {            
            _fileService.SerializeState(parkingPlace);
        }

        public ParkingPlace[]  GetDataState()
        {
            return _fileService.DeserializeState();          
        }

        public void Show()
        {
            var des = GetDataState();
            foreach (var item in des)
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
