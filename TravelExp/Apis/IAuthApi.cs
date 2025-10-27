using Refit;
using TravelExp.DTOs;

namespace TravelExp.Apis
{
    public interface IAuthApi
    {

        [Post("/api/auth/register")]
        Task<CustomApiResponse> RegisterAsync(RegisterDto dto);

        [Post("/api/auth/login")]
        Task<DTOs.CustomApiResponse<string>> LoginAsync(LoginDto dto);
    }
}
