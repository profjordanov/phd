using Microsoft.AspNetCore.Identity;

namespace Manager.Auth.Entities;

public class User : IdentityUser<Guid>
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTimeOffset RegistrationDateUtc { get; set; }
}