using CommunityToolkit.Mvvm.ComponentModel;
using TravelExp.Models;
using TravelExp.Services;

namespace TravelExp.ViewModels
{
    public partial class SaveTripViewModel : ObservableObject
    {
        public CategoryModel[] Categories { get; set; } = CategoryServices.Categories;

        public string[] Status { get; set; } =
        [
            "Planned",
            "Ongoing",
            "Completed",
            "Cancelled",
        ];
    }
}
