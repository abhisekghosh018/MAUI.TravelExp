using System.ComponentModel.DataAnnotations;

namespace TravelExp.DTOs;

public class SaveTripDto
{
    public int Id { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Category is required!")]
    public int CategoryId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    [Required]
    public string Status { get; set; }
}

