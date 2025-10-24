using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class SaveExpensePage : ContentPage
{
    public SaveExpensePage(SaveExpenseViewModel saveExpenseViewModel)
    {
        InitializeComponent();
        BindingContext = saveExpenseViewModel;
    }
}