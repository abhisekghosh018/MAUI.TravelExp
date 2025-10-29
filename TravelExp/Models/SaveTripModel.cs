using CommunityToolkit.Mvvm.ComponentModel;

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
        private DateTime _startDate;

        [ObservableProperty]
        private DateTime _endDate;

        [ObservableProperty]
        private string _status;

    }
}
