using System.Security.Claims;

namespace Manager.Auth.Services;

public class JwtFactory : IJwtFactory
{
    public string GenerateEncodedToken(string userId, string email, IEnumerable<Claim> additionalClaims)
    {
        throw new NotImplementedException();
    }
}