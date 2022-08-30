using Manager.Auth.Entities;
using Manager.Auth.Models;
using Microsoft.AspNetCore.Identity;
using Optional;

namespace Manager.Auth.Services;

public class AuthService :  IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly IJwtFactory _jwtFactory;

    public AuthService(UserManager<User> userManager, IJwtFactory jwtFactory)
    {
        _userManager = userManager;
        _jwtFactory = jwtFactory;
    }

    public Task<Option<JwtModel, ErrorModel>> Login(LoginUserModel model)
    {
        throw new NotImplementedException();
    }

    public Task<Option<UserModel, ErrorModel>> Register(RegisterUserModel model)
    {
        throw new NotImplementedException();
    }
}