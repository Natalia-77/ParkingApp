namespace ParkingApp.Services
{
    internal class ParkingService
    {
        private readonly ParkingBookModel _parkingBook = new ParkingBookModel() ;        
        private readonly ISerializationService _service;

        public ParkingService(ISerializationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));            
            
        }

        public ParkingService(ParkingBookModel parkingBook, ISerializationService service):this(service)
        {
            _parkingBook = parkingBook;
            
        }

        public void SaveState()
        {
            _service.SerializeState(_parkingBook);
        }

        public ParkingService GetState()
        {
            var model = _service.DeserializeState();
            return new ParkingService(model,_service);      
                                  
        }

        public void Show()
        {
            var modelResult = GetState();
            ParkingBookModel model = modelResult._parkingBook;           
            model.Show();
        }
    }
}
