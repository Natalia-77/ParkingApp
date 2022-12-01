using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using ParkingApp.Services;
using ParkingApp.UI.Model;
using ParkingApp.UI;
using ParkingApp.UI.ViewModel;
using ParkingApp.UI.View;

namespace ParkingApp.UI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<ParkingBookModel>();
            builder.Services.AddSingleton<ISerializationService,SerializationService>();
            builder.Services.AddSingleton<IParkingService,ParkingService>();
            builder.Services.AddSingleton<ParkingBookViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<ParkingPlaceDetailViewModel>();
            builder.Services.AddTransient<ParkingPlaceModel>();
            builder.Services.AddTransient<DetailsPage>();

            return builder.Build();
        }
    }
}