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
                foreach (var item in places)
                {                    
                        var obj = new ParkingPlaceModel()
                        {
                            PlaceNumber = item.PlaceNumber,
                            IsOccupied = item.IsOccupied,
                            OccupiedBy = new CarModel(item.OccupiedBy?.NumberOfCar)?? null

                        };                    
                    Parkings.Add(obj);
                }
            }
            catch(Exception ex)
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

        //[RelayCommand]
        //public Task  GetPlaceDetails(ParkingPlaceModel parkingPlace)
        //{

        //}
    }
}
