using Manager.Auth.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Manager.Auth.Persistence;

public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<User> UserRoles { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DbSet{TEntity}"/> of roles.
    /// </summary>
    public virtual DbSet<Role> Roles { get; set; }

    public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
    {
        return base.Add(entity);
    }

    public override void AddRange(IEnumerable<object> entities)
    {
        base.AddRange(entities);
    }

    public override EntityEntry<TEntity> Attach<TEntity>(TEntity entity)
    {
        return base.Attach(entity);
    }

    public override TEntity? Find<TEntity>(params object?[]? keyValues) where TEntity : class
    {
        return ((DbContext)this).Find<TEntity>(keyValues);
    }

    public override EntityEntry<TEntity> Update<TEntity>(TEntity entity)
    {
        return base.Update(entity);
    }

}