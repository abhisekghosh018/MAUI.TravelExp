
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Pages;

namespace TravelExp.ViewModels;

public partial class SettingViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(Initial))]
    private string _name = "Abhisek Ghosh";

    public string Initial => Name[0].ToString().ToUpper();

    [RelayCommand]
    private async Task GoToExpenseCategoryAsync()
    {
        await Shell.Current.GoToAsync(nameof(ExpenseCategoryPage));
    }
}
