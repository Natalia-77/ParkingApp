namespace ParkingApp.Services
{    
    internal class ParkingService:IParkingService
    {
        private readonly ParkingBookModel _parkingBook = new ParkingBookModel() ;  
        public ParkingBookModel ParkingBook { get; }
        private readonly ISerializationService _service;

        public ParkingService(ISerializationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));            
            
        }

        public ParkingService(ParkingBookModel parkingBook, ISerializationService service):this(service)
        {
            ParkingBook = parkingBook;
            
        }       

        public void SaveState()
        {
            _service.SerializeState(_parkingBook);
        }  
               
        public ParkingBookModel GetPlaces()
        {
            var model = _service.DeserializeState();
            var res = new ParkingService(model, _service);
            return new ParkingBookModel(res.ParkingBook.ParkingPlaces);
        }
    }
}
