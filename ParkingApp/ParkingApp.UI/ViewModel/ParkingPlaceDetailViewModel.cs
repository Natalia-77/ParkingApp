using CommunityToolkit.Mvvm.ComponentModel;
using ParkingApp.UI.Model;

namespace ParkingApp.UI.ViewModel
{
    [QueryProperty("Place", "Place")]
    public partial class ParkingPlaceDetailViewModel:BaseViewModel
    {
       [ObservableProperty]
       int place;
        //public ParkingPlaceDetailViewModel(ParkingPlaceModel parkingPlaceModel)
        //{
        //    Title = "Detail";
        //    place = parkingPlaceModel;
        //}

    }
}
