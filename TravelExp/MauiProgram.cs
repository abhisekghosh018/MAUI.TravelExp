using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TravelExp.Pages;
using TravelExp.ViewModels;

namespace TravelExp
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
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                }).UseMauiCommunityToolkit();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<LoginViewModel>().AddTransient<LoginPage>();
            builder.Services.AddTransient<RegistrationViewModel>().AddTransient<RegistrationPage>();

            builder.Services.AddSingleton<HomeViewModel>().AddSingleton<MainPage>();

            builder.Services.AddTransient<TripViewModel>().AddTransient<TripsPage>();
            builder.Services.AddTransient<SettingViewModel>().AddTransient<SettingsPage>();
            builder.Services.AddTransient<SaveTripViewModel>().AddTransient<SaveTripPage>();
            builder.Services.AddTransient<ExpenseCategoryViewModel>().AddTransient<ExpenseCategoryPage>();
            builder.Services.AddTransient<TripDetailsViewModel>().AddTransient<TripDetailsPage>();

            return builder.Build();
        }
    }
}
