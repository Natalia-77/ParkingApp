using CommunityToolkit.Mvvm.ComponentModel;
using ParkingApp.UI.ViewModel;

namespace ParkingApp.UI.Model
{
    public partial class ParkingDictionaryModel : BaseViewModel
    {
        [ObservableProperty]
        public Dictionary<int, ParkingPlaceModel> dataParking;
        public ParkingDictionaryModel()
        {
            dataParking = new Dictionary<int, ParkingPlaceModel>();
        }
    }
}
