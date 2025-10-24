using TravelExp.Pages;

namespace TravelExp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
            Routing.RegisterRoute(nameof(ExpenseCategoryPage), typeof(ExpenseCategoryPage));

        }
    }
}
