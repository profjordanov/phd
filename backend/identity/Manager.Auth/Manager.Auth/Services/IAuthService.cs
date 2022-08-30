using Manager.Auth.Models;
using Optional;

namespace Manager.Auth.Services;

public interface IAuthService
{
    Task<Option<JwtModel, ErrorModel>> Login(LoginUserModel model);

    Task<Option<UserModel, ErrorModel>> Register(RegisterUserModel model);
}