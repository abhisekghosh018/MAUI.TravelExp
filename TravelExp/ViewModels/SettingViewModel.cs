
using CommunityToolkit.Mvvm.ComponentModel;

namespace TravelExp.ViewModels;

public partial class SettingViewModel : ObservableObject
{
    [ObservableProperty, NotifyPropertyChangedFor(nameof(Initial))]
    private string _name = "Abhisek Ghosh";

    public string Initial => Name[0].ToString().ToUpper();

}
