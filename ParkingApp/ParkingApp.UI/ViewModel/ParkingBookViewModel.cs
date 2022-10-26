using CommunityToolkit.Mvvm.Input;
using ParkingApp.UI.Model;
using System.Collections.ObjectModel;

namespace ParkingApp.UI.ViewModel
{
    public partial class ParkingBookViewModel : BaseViewModel
    {
        public ObservableCollection<ParkingPlaceModel> Parkings { get; } = new();        
        ParkingBook _parkingBookService;
        public ParkingBookViewModel(ParkingBook parkingBookSevice)
        {
            Title = "Parking Book";
            _parkingBookService = parkingBookSevice;
        }

        [RelayCommand]
        public Task GetPlaces()
        {
            try
            {
                var places = _parkingBookService.GetDataState();
                foreach (KeyValuePair<int, ParkingPlace> item in places)
                {
                    var obj = new ParkingPlaceModel()
                    {
                        NumberPlace = item.Value.NumberPlace,
                        IsOccupied = item.Value.IsOccupied,
                        NumberCar = new CarModel(item.Value.NumberCar.NumberOfCar)

                    };
                    Parkings.Add(obj);
                }
            }
            catch(Exception ex)
            {
                Shell.Current.DisplayAlert("Error!", ex.Message, "OK");
            }            

            return Task.CompletedTask;
        }
    }
}
