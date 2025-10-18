using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Pages;

namespace TravelExp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private async Task NavigateToRegisterAsync()
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(RegistrationPage));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [RelayCommand]
        private async Task LoginAsync()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
