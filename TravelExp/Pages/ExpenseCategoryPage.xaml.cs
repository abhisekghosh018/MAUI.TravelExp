using TravelExp.ViewModels;

namespace TravelExp.Pages;

public partial class ExpenseCategoryPage : ContentPage
{
    public ExpenseCategoryPage(ExpenseCategoryViewModel expenseCategoryViewModel)
    {
        InitializeComponent();
        BindingContext = expenseCategoryViewModel;
    }
}