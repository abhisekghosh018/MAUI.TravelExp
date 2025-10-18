using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class TripsPage : ContentPage
{
    public TripsPage(TripViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

    }
}