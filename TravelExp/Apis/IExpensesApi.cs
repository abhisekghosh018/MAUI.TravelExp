using Refit;
using TravelExp.DTOs;

namespace TravelExp.Apis;

[Headers("Authorization: Bearer ")]
public interface IExpensesApi
{

    [Get("/api/trip/expenses/categories")]
    Task<ExpenseCategoryDto[]> GetExpenseCategoryAsync();

    [Post("/api/trip/expenses/savecategory")]
    Task<CustomApiResponse> SaveExpenseCategoryAsync(ExpenseCategoryDto dto);

    [Post("/api/trip/expenses/of-trip/{tripId}/save")]
    Task<CustomApiResponse> SaveExpenseAsync(ExpenseDto dto, int tripId);

    [Get("/api/trip/expenses/of-trip/{tripId}")]
    Task<ExpenseListDto[]> GetExpensesAsync(int tripId);
}
