using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class TripDetailsPage : ContentPage
{
    public TripDetailsPage(TripDetailsViewModel tripDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = tripDetailsViewModel;
    }
}