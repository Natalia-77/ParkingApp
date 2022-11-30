using ParkingApp.UI.ViewModel;

namespace ParkingApp.UI.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(ParkingPlaceDetailViewModel detailViewModel)
	{
		InitializeComponent();
		BindingContext = detailViewModel;
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}