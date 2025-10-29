using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TravelExp.Apis;
using TravelExp.Enums;
using TravelExp.Models;

namespace TravelExp.ViewModels;

public partial class SaveTripViewModel : BaseViewModel
{
    private readonly ITripsApi _tripsApi;

    public SaveTripViewModel(ITripsApi TripsApi)
    {
        _tripsApi = TripsApi;
        FetchCategoryAsync();
    }

    [ObservableProperty]
    private CategoryModel[] _categories = [];
    public async Task FetchCategoryAsync()
    {
        await MakeApiCall(async () =>
        {
            var categoriesFromApi = await _tripsApi.GetCategoriesAsync();
            Categories = categoriesFromApi.Select(c => new CategoryModel
            {
                Name = c.Name,
                Id = c.Id,
                Image = c.Image,
                IsSelected = false
            }).ToArray();
        });
    }

    public string[] Status { get; set; } =
    [
        nameof(TripStatus.Planned),
        nameof(TripStatus.Ongoing),
        nameof(TripStatus.Completed),
        nameof(TripStatus.Cancelled),
    ];

    public SaveTripModel Model { get; set; } = new();

    [RelayCommand]
    private void SetSelectedCategory(CategoryModel category)
    {
        if (category.IsSelected)
            return;
        var existingSelectedCategory = Categories.FirstOrDefault(c => c.IsSelected);

        if (existingSelectedCategory != null)
            existingSelectedCategory.IsSelected = false;

        category.IsSelected = true;
        Model.CategoryId = category.Id;

        // Force UI to refresh (MAUI bug workaround)
        // To solve the issue where the UI does not update the selection state of categories,
        var temp = Categories;
        Categories = null;
        Categories = temp;
    }
}

