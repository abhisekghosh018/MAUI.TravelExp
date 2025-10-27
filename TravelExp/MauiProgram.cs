using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Refit;
using TravelExp.Apis;
using TravelExp.Pages;
using TravelExp.Services;
using TravelExp.ViewModels;

namespace TravelExp;

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
        builder.Services.AddTransient<SaveExpenseViewModel>().AddTransient<SaveExpensePage>();

        builder.Services.AddSingleton<AuthService>();

        ConfigureRefit(builder.Services);

        return builder.Build();
    }

    private static void ConfigureRefit(IServiceCollection services)
    {
        const string ApiBaseUrl = "https://bjv7gmvb-7252.inc1.devtunnels.ms";

        //To Add RefitClient to call APIs

        services.AddRefitClient<IAuthApi>().ConfigureHttpClient(SetHttpClient);

        services.AddRefitClient<ITripsApi>(GetRefitSettings).ConfigureHttpClient(SetHttpClient);

        services.AddRefitClient<IExpensesApi>(GetRefitSettings).ConfigureHttpClient(SetHttpClient);

        services.AddRefitClient<IProfileApi>(GetRefitSettings).ConfigureHttpClient(SetHttpClient);

        //To Add Bearer in the header for Authorization 
        static RefitSettings GetRefitSettings(IServiceProvider sp)
        {
            //Getting the jwt token from AuthService
            var authService = sp.GetRequiredService<AuthService>();

            return new RefitSettings
            {
                AuthorizationHeaderValueGetter = (_, __) => Task.FromResult(authService.JwtToken ?? "")
            };
        }
        //To Add ApiBaseUrl 
        static void SetHttpClient(HttpClient httpClient)
             => httpClient.BaseAddress = new Uri(ApiBaseUrl);

    }

}

