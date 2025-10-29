using System.Globalization;
using TravelExp.Pages;
using TravelExp.Services;

namespace TravelExp
{
    public partial class App : Application
    {
        private readonly AuthService _authService;
        public App(AuthService authService)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-IN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-IN");
            _authService = authService;
            _authService.LoadToken();

            MainPage = new AppShell();

            Dispatcher.Dispatch(async () =>
            {
                if (_authService.HasValidToken)
                    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                else
                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            });
        }


    }
}