using CommunityToolkit.Mvvm.ComponentModel;
using ParkingApp.UI.Model;

namespace ParkingApp.UI.ViewModel
{
    [QueryProperty("Place", "Places")]
    public partial class ParkingPlaceDetailViewModel:BaseViewModel
    {
        [ObservableProperty]       
        ParkingPlaceModel place;
    }
}
