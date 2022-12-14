using Newtonsoft.Json;
using ParkingApp.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace ParkingApp
{
    internal class ParkingBook
    {
        private readonly FileService _fileService;
        public static Dictionary<int, ParkingPlace> dictionary;
        private List<Car> cars;
        private int carSpace = 0;
        public Dictionary<int, ParkingPlace> Dictionary
        {
            get
            {
                return dictionary;
            }
        }
        public ParkingBook()
        {
            dictionary = new Dictionary<int, ParkingPlace>();
            cars = new List<Car>(carSpace);
            _fileService = new FileService();
            
        }

        public void FirstInitDictionary()
        {
            dictionary.Add(1, new ParkingPlace { IsOccupied = false, NumberPlace = 11 });
            dictionary.Add(2, new ParkingPlace { IsOccupied = false, NumberPlace = 12 });
            dictionary.Add(3, new ParkingPlace { IsOccupied = false, NumberPlace = 13 });
            dictionary.Add(4, new ParkingPlace { IsOccupied = false, NumberPlace = 14 });
            dictionary.Add(5, new ParkingPlace { IsOccupied = false, NumberPlace = 15 });
            dictionary.Add(6, new ParkingPlace { IsOccupied = false, NumberPlace = 16 });
            dictionary.Add(7, new ParkingPlace { IsOccupied = false, NumberPlace = 17 });
            dictionary.Add(8, new ParkingPlace { IsOccupied = false, NumberPlace = 18 });
            dictionary.Add(9, new ParkingPlace { IsOccupied = false, NumberPlace = 19 });
            dictionary.Add(10, new ParkingPlace { IsOccupied = false, NumberPlace = 20 });
        }

        public void ShowDict()
        {
            foreach (KeyValuePair<int,ParkingPlace> item in dictionary)
            {               
                if (item.Value.NumberCar != null)
                {
                    Console.WriteLine($"Key = {item.Key}, Value = {item.Value.IsOccupied}, {item.Value.NumberPlace} {item.Value.NumberCar.NumberOfCar}");
                }
                else
                {
                    Console.WriteLine($"Key = {item.Key}, Value = {item.Value.IsOccupied}, {item.Value.NumberPlace}");
                }
            }           
            //_fileService.SerializeState(dictionary);
            //var res = _fileService.DeserializeState();
           // Console.WriteLine("Deserialize:");
            //foreach (KeyValuePair<int, ParkingPlace> item in res)
            //{
            //    Console.WriteLine(item.Value.NumberPlace);
            //}         

        }      

        public void SaveState()
        {            
            _fileService.SerializeState(Dictionary);
        }

        public Dictionary<int,ParkingPlace> GetDataState()
        {
            var res = _fileService.DeserializeState();
            foreach (KeyValuePair<int, ParkingPlace> item in res)
            {
                Console.WriteLine(item.Value.NumberPlace);
            }
            return res;
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
            carSpace++;
            dictionary[1] = new ParkingPlace {NumberPlace = 11, IsOccupied = true, NumberCar = car };
        }       


    }
}
