using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Apis;
using TravelExp.DTOs;
using TravelExp.Pages;

namespace TravelExp.ViewModels;

public partial class HomeViewModel : BaseViewModel
{
    private readonly ITripsApi _trips;

    public HomeViewModel(ITripsApi trips)
    {
        _trips = trips;
    }

    [ObservableProperty]
    public TripListDto[] trips = [];

    [RelayCommand]
    private async Task AddTripAsync()
    {
        await Shell.Current.GoToAsync($"///{nameof(SaveTripPage)}");
    }

    [RelayCommand]

    private async Task GoToTripDetailsPageAsync(int tripId)
    {
        await Shell.Current.GoToAsync(nameof(TripDetailsPage));
    }


    public async Task fetchTripsAsync()
    {
        await MakeApiCall(async () =>
        {
            Trips = await _trips.GetUserTripsAsync(count: 6);
        });
    }

}
