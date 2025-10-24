using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TravelExp.Models;

namespace TravelExp.ViewModels
{
    public partial class TripDetailsViewModel : ObservableObject
    {
        public TripDetailModel TripInfo { get; set; } =
            new TripDetailModel(1, "beach.png", "A trip to the Goa beach", "Goa", "Beach", "Planned",
                DateTime.Now.AddDays(5), DateTime.Now.AddDays(12));

        public ObservableCollection<ExpenseModel> Expenses { get; set; } = [];

        [ObservableProperty]
        private decimal _totalExpenses;


        [RelayCommand]
        private void AddExpense()
        {
            Expenses.Add(new ExpenseModel(1, "Flight Tickets", "Tickets", 1500, DateTime.Today));
            Expenses.Add(new ExpenseModel(2, "Breakfast", "Food", 350, DateTime.Today));
            Expenses.Add(new ExpenseModel(2, "Bought colth", "Shopping", 350, DateTime.Today));

            TotalExpenses = Expenses.Sum(sum => sum.Amount);
        }

    }
}
