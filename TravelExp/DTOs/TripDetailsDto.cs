namespace TravelExp.DTOs;

public record TripDetailsDto(TripListDto TripInfo, ExpenseListDto[] ExpenseList);
