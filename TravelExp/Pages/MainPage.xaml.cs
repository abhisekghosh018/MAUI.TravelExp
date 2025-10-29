
using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class MainPage : ContentPage
{
    private readonly HomeViewModel _homeViewModel;
    public MainPage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
        _homeViewModel = homeViewModel;
    }

    override protected async void OnAppearing()
    {
        base.OnAppearing();
        await _homeViewModel.fetchTripsAsync();
    }
}