using ParkingApp.Services;
namespace ParkingApp
{
    public class ParkingBookService
    {
        //private readonly ISerializationService _fileService;
        private readonly ParkingBookModel _parkingBook = new ParkingBookModel();
        private readonly ISerializationService service;

        public ParkingBookService(ISerializationService service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public ParkingBookService(ISerializationService service, ParkingBookModel model) : this(service) 
        {
            _parkingBook = model;
        }

        public void SaveState()
        {
            service.SerializeState(_parkingBook);
        }

        public static ParkingBookService GetDataState(ISerializationService service)
        {
            if (service is null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            ParkingBookModel book = service.DeserializeState();
            return new ParkingBookService(service, book);
        }

        public void Show()
        {
            _parkingBook.Show();
        }

        //public void AddCar(Car car)
        //{
        //    cars.Add(car);
        //    carSpace++;
        //    dictionary[1] = new ParkingPlace {NumberPlace = 11, IsOccupied = true, NumberCar = car };
        //}       


    }
}
