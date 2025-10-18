using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }
}