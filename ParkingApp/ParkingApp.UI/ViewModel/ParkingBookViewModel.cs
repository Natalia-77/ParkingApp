using CommunityToolkit.Mvvm.Input;
using ParkingApp.UI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp.UI.ViewModel
{
    public partial class ParkingBookViewModel :BaseViewModel
    {
        public ObservableCollection<ParkingDictionaryModel> Parkings { get; } = new();
        ParkingBook _parkingBook;
        public ParkingBookViewModel(ParkingBook parkingSevice)
        {
            _parkingBook = parkingSevice;
        }

        [RelayCommand]
        async Task GetPlacesAsync()
        {
            var places = _parkingBook.GetDataState();
            //Parkings.Add
        }
    }
}
