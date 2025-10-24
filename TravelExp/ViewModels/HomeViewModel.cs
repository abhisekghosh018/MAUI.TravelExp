
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TravelExp.Models;
using TravelExp.Pages;

namespace TravelExp.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    public ObservableCollection<TripModel> Trips { get; set; } = [];

    [RelayCommand]
    private void AddTripTemp()
    {
        Trips.Add(new TripModel(1, "logo.jpg", "Sunny Beach", "California"));
        Trips.Add(new TripModel(2, "logo.jpg", "Dreamy Beach", "Newzeland"));
        Trips.Add(new TripModel(3, "logo.jpg", "Zoho Beach", "Mumbai"));
        Trips.Add(new TripModel(4, "logo.jpg", "Himalaya", "Nepal"));
    }

    [RelayCommand]

    private async Task GoToTripDetailsPageAsync(int tripId)
    {
        await Shell.Current.GoToAsync(nameof(TripDetailsPage));
    }

}
