namespace TravelExp.Models
{
    public record ExpenseModel(int Id, string Title, string ExpCategory, decimal Amount
        , DateTime SpentOn);
}
