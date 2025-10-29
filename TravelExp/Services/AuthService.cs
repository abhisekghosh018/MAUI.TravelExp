namespace TravelExp.Services;

public class AuthService
{
    public string? JwtToken { get; private set; }

    private const string TokenKey = "auth_token";
    public void SetToken(string token)
    {
        JwtToken = token;
        Preferences.Default.Set(TokenKey, token);
    }

    public void RemoveToken()
    {
        JwtToken = null;
        Preferences.Default.Remove(TokenKey);
    }
}
