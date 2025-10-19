using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class SettingsPage : ContentPage
{
    public SettingsPage(SettingViewModel settingViewModel)
    {
        InitializeComponent();
        BindingContext = settingViewModel;
    }
}