using Refit;
using TravelExp.DTOs;

namespace TravelExp.Apis;

[Headers("Authorization: Bearer ")]
public interface ITripsApi
{
    [Get("/api/trip/categories")]
    Task<TripCategoryDto[]> GetCategoriesAsync();
    [Post("/api/trip/")]
    Task<CustomApiResponse> SaveTripAsync(SaveTripDto dto);
    [Get("/api/trip/")]
    Task<TripListDto[]> GetUserTripsAsync(int count = 20);

    [Get("/api/trip/{tripId}")]
    Task<TripDetailsDto> GetTripDetailsAsync(int tripId);
}
