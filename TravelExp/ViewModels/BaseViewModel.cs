using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TravelExp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool _IsBusy;

        protected async Task MakeApiCall(Func<Task> apiCall)
        {
            try
            {
                IsBusy = true;
                await apiCall.Invoke();
            }
            catch (Exception ex)
            {
                await ErrorAlertAsync(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected async Task ErrorAlertAsync(string message) =>
            await Shell.Current.DisplayAlert("Error", message, "Ok");

        protected async Task ToastAsync(string message) =>
            await Toast.Make(message).Show();

    }
}
