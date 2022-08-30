using Manager.Auth.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Manager.Auth.Persistence;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
{
    
}