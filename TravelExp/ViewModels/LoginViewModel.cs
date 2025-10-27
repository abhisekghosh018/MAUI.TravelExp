using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Apis;
using TravelExp.DTOs;
using TravelExp.Pages;
using TravelExp.Services;

namespace TravelExp.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {

        private readonly IAuthApi _authApi;
        private readonly AuthService _authService;

        public LoginViewModel(IAuthApi authApi, AuthService AuthService)
        {
            _authApi = authApi;
            _authService = AuthService;
        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private async Task NavigateToRegisterAsync() =>
         await Shell.Current.GoToAsync(nameof(RegistrationPage));


        [RelayCommand]
        private async Task LoginAsync()
        {

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await ErrorAlertAsync("All fields are mandatory.");
                return;
            }
            var login = new LoginDto
            {
                Email = Email,
                Password = Password,
            };

            await MakeApiCall(async () =>
            {
                var result = await _authApi.LoginAsync(login);

                if (!result.IsSuccess)
                {
                    await ErrorAlertAsync(result.Error);
                    return;
                }

                var jwtToken = result.Data;
                _authService.SetToken(jwtToken);

                await ToastAsync("Login Successful");
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            });

        }
    }
}
