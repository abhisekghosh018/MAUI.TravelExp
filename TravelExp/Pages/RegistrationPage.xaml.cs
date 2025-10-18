using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage(RegistrationViewModel registrationVM)
	{
		InitializeComponent();
		BindingContext = registrationVM;
	}
}