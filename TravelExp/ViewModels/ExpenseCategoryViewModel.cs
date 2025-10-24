using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TravelExp.Models;

namespace TravelExp.ViewModels
{
    public partial class ExpenseCategoryViewModel : ObservableObject
    {
        public ObservableCollection<ExpenseCategoryModel> ExpenseCategories { get; set; } = [];


        public ExpenseCategoryViewModel()
        {
            ExpenseCategoryModel[] tempCategoryModel = [
                new (1, "Tickets"),
                new(2,"Hotels"),
                new(3, "Food"),
                new (4, "Shopping"),
                new(5,"Fuel"),
                new(6, "Other")
                ];
            foreach (var item in tempCategoryModel)
            {
                ExpenseCategories.Add(item);
            }
        }
        [RelayCommand]
        private async Task AddCategory()
        {
            var newCategoryName = await Shell.Current.DisplayPromptAsync("Expense category name", "Enter category expense  name", "Add");
            if (!string.IsNullOrEmpty(newCategoryName))
            {
                var newCategory = new ExpenseCategoryModel(ExpenseCategories.Count + 1, newCategoryName);
                ExpenseCategories.Add(newCategory);
                return;
            }
            await Toast.Make("Invalid expense category name").Show();
        }
    }
}
