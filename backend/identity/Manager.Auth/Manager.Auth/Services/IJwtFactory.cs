using System.Security.Claims;

namespace Manager.Auth.Services;

public interface IJwtFactory
{
    string GenerateEncodedToken(string userId, string email, IEnumerable<Claim> additionalClaims);
}