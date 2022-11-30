using CommunityToolkit.Mvvm.Input;
using ParkingApp.Services;
using ParkingApp.UI.Model;
using ParkingApp.UI;
using System.Collections.ObjectModel;
using ParkingApp.UI.View;

namespace ParkingApp.UI.ViewModel
{
    public partial class ParkingBookViewModel : BaseViewModel
    {
        public ObservableCollection<ParkingPlaceModel> Parkings { get; } = new();
        IParkingService _parkingBookService;
        public ParkingBookViewModel(IParkingService parkingBookSevice)
        {
            Title = "Parking Book";
            _parkingBookService = parkingBookSevice;
        }

        [RelayCommand]
        public Task GetPlaces()
        {
            try
            {
                var places = _parkingBookService.GetPlaces();                            
                foreach (var item in places.ParkingPlaces)
                {
                    var obj = new ParkingPlaceModel()
                    {
                        PlaceNumber = item.PlaceNumber,
                        IsOccupied = item.IsOccupied,
                        OccupiedBy = new CarModel(item.OccupiedBy?.NumberOfCar) ?? null

                    };
                    Parkings.Add(obj);
                }

            }
            catch (Exception ex)
            {
                Shell.Current.DisplayAlert("Error get data places!", ex.Message, "OK");
            }

            return Task.CompletedTask;
        }

        [RelayCommand]
        public Task GetInfo(ParkingPlaceModel model)
        {
            Shell.Current.DisplayAlert("Current place number", model.PlaceNumber.ToString(), "OK");
            return Task.CompletedTask;
        }

        [RelayCommand]
        public async Task GetPlaceDetails(ParkingPlaceModel parkingPlace)
        {
            if (parkingPlace is null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Place={parkingPlace.PlaceNumber}"); 
              // new Dictionary<string, object> { { "Place", parkingPlace } });
            
        }
    }
}
