using ParkingApp.UI.ViewModel;

namespace ParkingApp.UI
{
    public partial class MainPage : ContentPage
    {       

        public MainPage(ParkingBookViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }       
    }
}