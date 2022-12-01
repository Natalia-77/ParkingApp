using ParkingApp.UI.ViewModel;
using System.Diagnostics.Metrics;
using System.Net.Mime;

namespace ParkingApp.UI
{
    public partial class MainPage : ContentPage
    {    
        public MainPage(ParkingBookViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Btn.Text = "Ok";

        }

    }
}