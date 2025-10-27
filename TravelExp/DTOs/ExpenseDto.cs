using System.ComponentModel.DataAnnotations;

namespace TravelExp.DTOs;

public class ExpenseDto
{
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Title { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Category is required.")]
    public int CategoryId { get; set; }
    [Range(0.1, double.MaxValue, ErrorMessage = "Invalid amount.")]
    public decimal Amount { get; set; }
    public DateTime SpentOn { get; set; }

}
