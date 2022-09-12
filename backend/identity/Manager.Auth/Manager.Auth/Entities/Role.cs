using Microsoft.AspNetCore.Identity;

namespace Manager.Auth.Entities;

public class Role : IdentityRole<Guid>
{
    public override Guid Id { get; set; }
    public override string Name { get; set; }
    public override string ConcurrencyStamp { get; set; }
    public override string NormalizedName { get; set; }
    public override string ToString()
    {
        return base.ToString();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}