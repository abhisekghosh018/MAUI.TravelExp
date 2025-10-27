using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Apis;
using TravelExp.DTOs;

namespace TravelExp.ViewModels;

public partial class RegistrationViewModel : BaseViewModel
{
    private readonly IAuthApi _authApi;
    public RegistrationViewModel(IAuthApi authApi)
    {
        _authApi = authApi;
    }


    [ObservableProperty]
    private string _name;

    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _password;


    [RelayCommand]
    private async Task NavigateBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    private async Task RegisterAsync()
    {
        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
        {
            await ErrorAlertAsync("All fields are mandatory");
            return;
        }

        var registerDto = new RegisterDto()
        {
            Email = Email,
            Name = Name,
            Password = Password
        };
        await MakeApiCall(async () =>
        {
            var result = await _authApi.RegisterAsync(registerDto);

            if (!result.IsSuccess)
            {
                await ErrorAlertAsync(result.Error);
                return;
            }
            await ToastAsync("User registered successfylly.");
            await NavigateBackAsync();
        });
    }
}
