namespace TravelExp.Models
{
    public record TripDetailModel(int Id, string Image, string Title, string Location,
        string CategoryName, string Status, DateTime StartDate, DateTime EndDate)
    {
        public string DisplayDateRange => $"{StartDate:dd-MMM-yy} / {EndDate:dd-MMM-yy}";
    }
}
