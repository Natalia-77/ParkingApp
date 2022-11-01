using ParkingApp.Services;
using ParkingApp.UI.ViewModel;

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
            builder.Services.AddSingleton<ParkingBook>();
            builder.Services.AddScoped<ISerializationService, SerializationService>();
            builder.Services.AddSingleton<ParkingBookViewModel>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}