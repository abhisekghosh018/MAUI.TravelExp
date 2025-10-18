using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginVM)
	{
		InitializeComponent();
		BindingContext = loginVM;
	}
}