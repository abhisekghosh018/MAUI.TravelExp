
using Refit;
using TravelExp.DTOs;

namespace TravelExp.Apis;


[Headers("Authorization: Bearer ")]
public interface IProfileApi
{
    [Post("/api/user/profile/update-name")]
    Task<CustomApiResponse> UpdateNameAsync(string name);
    [Post("/api/user/profile/change-password")]
    Task<CustomApiResponse> ChangePasswordAsync(string name);
}
