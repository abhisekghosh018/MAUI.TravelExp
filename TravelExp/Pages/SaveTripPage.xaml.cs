using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class SaveTripPage : ContentPage
{
    public SaveTripPage(SaveTripViewModel saveTripViewModel)
    {
        InitializeComponent();
        BindingContext = saveTripViewModel;
    }
}