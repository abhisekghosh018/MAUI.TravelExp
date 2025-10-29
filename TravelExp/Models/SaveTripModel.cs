using CommunityToolkit.Mvvm.ComponentModel;
using TravelExp.DTOs;

namespace TravelExp.Models
{
    public partial class SaveTripModel : ObservableObject
    {
        [ObservableProperty]
        private int _id;

        [ObservableProperty]
        private int _categoryId;

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private string _location;

        [ObservableProperty]
        private DateTime _startDate = DateTime.Now;

        [ObservableProperty]
        private DateTime _endDate = DateTime.Now.AddDays(1);

        [ObservableProperty]
        private string _status;

        public (bool IsValid, string? Error) Validate()
        {
            string? error = null;
            if (CategoryId == 0)
                error = "Category is required.";

            else if (string.IsNullOrWhiteSpace(Title)
                || string.IsNullOrWhiteSpace(Title)
                || string.IsNullOrWhiteSpace(Title)
                || StartDate == default
                || EndDate == default)
                error = "All fields are required.";

            else if (EndDate < StartDate)
                error = "End date cannot be less than start date";

            return (error == null, error);
        }


        public SaveTripDto ToDto() =>
            new SaveTripDto
            {
                CategoryId = CategoryId,
                EndDate = EndDate,
                StartDate = StartDate,
                Location = Location,
                Title = Title,
                Status = Status,
            };

    }

}
