
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TravelExp.Models;

namespace TravelExp.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    public ObservableCollection<TripModel> Trips { get; set; } = [];

    [RelayCommand]
    private void AddTripTemp()
    {
        Trips.Add(new TripModel("logo.jpg", "Sunny Beach", "California"));
        Trips.Add(new TripModel("logo.jpg", "Dreamy Beach", "Newzeland"));
        Trips.Add(new TripModel("logo.jpg", "Zoho Beach", "Mumbai"));
        Trips.Add(new TripModel("logo.jpg", "Himalaya", "Nepal"));
    }

}
